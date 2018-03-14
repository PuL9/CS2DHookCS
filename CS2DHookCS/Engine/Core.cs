using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using CS2DHookCS.CS2D;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace CS2DHookCS.Engine
{
    public class Core
    {
        delegate void GameLoopDlg();
        GameLoopDlg GameLoop;
        Hook GameLoopHook;

        Process CurrentProcess;

        /// <summary>
        /// Called after dll has been injected
        /// </summary>
        public Core()
        {
            DebugHelper.ShowConsoleWindow();
            CurrentProcess = Process.GetCurrentProcess();

            Globals.Players = new Player[33];

            GameFuncs.Init();
            Blitzmax.Init();
            Patches.Init();

            Patches.AntiCE.Enable();

            ReadSignatures();
            InitHooks();
        }

        /// <summary>
        /// Called every game frame (while playing)
        /// </summary>
        void OnUpdate()
        {
            ReadPlayers();

            if (Globals.LocalPlayer.IsPlaying)
            {
                DoAimbot();
                Esp();
                Speedhack();
                //Visuals();
                //Spinbot();
            }
        }

        void DoAimbot()
        {
            var player = Aimbot.GetClosestPlayer();
            if (player != null && player.Distance <= 300 * 3) // TODO: FIX
            {
                var relativePoint = Aimbot.RelativePoint(Globals.LocalPlayer, player);
                var hitscanPos = Aimbot.GetHitscanPoint(player.Hitscan);
                relativePoint.X -= hitscanPos.X;
                relativePoint.Y -= hitscanPos.Y;

                if (Globals.MainForm.CheckBoxAutoShoot.Checked || (WinApi.GetAsyncKeyState(System.Windows.Forms.Keys.Space) & 0x8000) != 0)
                {
                    var enemyAngle = Aimbot.PointToAngle(relativePoint);
                    GameFuncs.OnRecoilShoot(Globals.LocalPlayer.Base, enemyAngle, 1, 0);
                }
            }
        }

        void Esp()
        {
            Blitzmax.SetRotation(0);
            Blitzmax.SetAlpha(1);
            Blitzmax.SetLineWidth(1);

            for (int i = 0; i <= 32; i++)
            {
                Blitzmax.SetColor(255, 255, 255);
                var player = Globals.Players[i];

                if (player != null && player.Health > 0 && (player.Team != Globals.LocalPlayer.Team || Globals.MainForm.CheckboxEspTeam.Checked))
                {
                    var relativePoint = Aimbot.RelativePoint(Globals.LocalPlayer, player);
                    var screenPos = Aimbot.ScreenPoint(relativePoint);

                    if (Globals.MainForm.CheckboxEspHealthColor.Checked)
                    {
                        if (player.Health >= 70)
                        {
                            Blitzmax.SetColor(0, 255, 0);
                        }
                        else if (player.Health >= 50)
                        {
                            Blitzmax.SetColor(255, 255, 0);
                        }
                        else if (player.Health >= 20)
                        {
                            Blitzmax.SetColor(255, 200, 0);
                        }
                        else
                        {
                            Blitzmax.SetColor(255, 0, 0);
                        }
                    }

                    if (Globals.MainForm.CheckboxEspLines.Checked)
                    {
                        if (player.Hitscan != HitscanResult.None)
                            Blitzmax.SetLineWidth(3);
                        Blitzmax.DrawLine(Globals.ScreenWidth / 2, Globals.ScreenHeight / 2, screenPos.X, screenPos.Y, 1);
                        Blitzmax.SetLineWidth(1);
                    }
                    if (Globals.MainForm.CheckboxEspBoxes.Checked)
                    {
                        Blitzmax.DrawBorder((int)screenPos.X - 16, (int)screenPos.Y - 16, 32, 32);
                    }
                }
            }
        }

        void Speedhack()
        {
            if ((WinApi.GetAsyncKeyState(System.Windows.Forms.Keys.LControlKey) & 0x8000) != 0)
            {
                Globals.LocalPlayer.Speed = Globals.Speedhack;
            }
            else
            {
                Globals.LocalPlayer.Speed = 0;
            }
        }

        void Spinbot()
        {
            if (Globals.MainForm.CheckBoxSpinbot.Checked)
            {
                Globals.LocalPlayer.Rotation += (Globals.Spinbot / 100f);
                if (Globals.LocalPlayer.Rotation > 360)
                {
                    Globals.LocalPlayer.Rotation = 0;
                }
            }
        }

        /// <summary>
        /// Read all players
        /// </summary>
        void ReadPlayers()
        {
            Globals.LocalPlayer = new Player(Memory.ReadPointer(Globals.LocalPlayerPointer));

            for (int i = 0; i <= 32; i++)
            {
                var playerBase = GameFuncs.GetPlayer(i);

                if (playerBase == IntPtr.Zero)
                {
                    Globals.Players[i] = null;
                    continue;
                }

                var player = new Player(playerBase);

                if (player.ID != Globals.LocalPlayer.ID && player.Team != Team.S && player.Health > 0)
                {
                    if (player.Team != Globals.LocalPlayer.Team || Globals.MainForm.CheckBoxAimbotTeam.Checked)
                    {
                        player.Distance = Helper.CalcRange(Globals.LocalPlayer.PosX, Globals.LocalPlayer.PosY, player.PosX, player.PosY);
                        if (player.Distance <= 300 * 3) // TODO: READ WEAPON DISTANCE
                            player.Hitscan = Aimbot.Hitscan(Globals.LocalPlayer.Base, player.PosX, player.PosY);
                        else
                            player.Hitscan = HitscanResult.None;
                    }
                    Globals.Players[i] = player;
                }
                else
                {
                    Globals.Players[i] = null;
                }
            }
        }

        void Visuals()
        {
            Memory.WriteByte(Globals.MapBgColorPointer + 0x18, Globals.MapBgColor.R);
            Memory.WriteByte(Globals.MapBgColorPointer + 0x19, Globals.MapBgColor.G);
            Memory.WriteByte(Globals.MapBgColorPointer + 0x1A, Globals.MapBgColor.B);
        }

        /// <summary>
        /// Read all signatures
        /// </summary>
        void ReadSignatures()
        {
            var localPlayer = Memory.FixedAobscan(Signatures.LocalPlayer);
            var mapBg = Memory.FixedAobscan(Signatures.MapBgColor);

            WinApi.VirtualProtect(mapBg, 6);

            Globals.LocalPlayerPointer = Memory.ReadPointer(IntPtr.Add(localPlayer, 1));
            Globals.MapBgColorPointer = Memory.ReadPointer(Memory.ReadPointer(IntPtr.Add(mapBg, 1)));
        }

        #region Hook game loop
        void InitHooks()
        {
            IntPtr gameLoopAdr = Memory.FixedAobscan(Signatures.Gameloop);
            GameLoop = Memory.GetFunction<GameLoopDlg>(gameLoopAdr);
            GameLoopHook = new Hook(gameLoopAdr, (GameLoopDlg)GameLoopHooked);
            GameLoopHook.SetJump();
        }

        void GameLoopHooked()
        {
            OnUpdate();

            GameLoopHook.UnsetJump();
            GameLoop();
            GameLoopHook.SetJump();
        }
        #endregion
    }
}