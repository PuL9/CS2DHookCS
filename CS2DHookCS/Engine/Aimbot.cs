using CS2DHookCS.CS2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CS2DHookCS.Engine
{
    public static class Aimbot
    {
        public static float Precision = 0.2f;
        public static int ScanRange = 11;
        public static int HitscanType = 0;

        /// <summary>
        /// Perfect hitscan :D
        /// </summary>
        /// <param name="playerBase"></param>
        /// <param name="posx"></param>
        /// <param name="posy"></param>
        /// <param name="range"></param>
        /// <returns>Hitscan result</returns>
        public static HitscanResult Hitscan(IntPtr playerBase, float posx, float posy, int range = 300000)
        {
            int x = (int)posx;
            int y = (int)posy;

            if(GameFuncs.Hitscan(playerBase, x, y, Precision, range))
            {
                return HitscanResult.Center;
            }

            if(Globals.MainForm.CheckBoxMultiHitscan.Checked)
            {
                if(HitscanType == 0)
                {
                    if(GameFuncs.Hitscan(playerBase, x, y - ScanRange, Precision, range))
                    {
                        return HitscanResult.Top;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x, y + ScanRange, Precision, range))
                    {
                        return HitscanResult.Bottom;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x - ScanRange, y, Precision, range))
                    {
                        return HitscanResult.Left;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x + ScanRange, y, Precision, range))
                    {
                        return HitscanResult.Right;
                    }
                }
                else if(HitscanType == 1)
                {
                    if(GameFuncs.Hitscan(playerBase, x - ScanRange, y - ScanRange, Precision, range))
                    {
                        return HitscanResult.TopLeft;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x + ScanRange, y - ScanRange, Precision, range))
                    {
                        return HitscanResult.TopRight;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x - ScanRange, y + ScanRange, Precision, range))
                    {
                        return HitscanResult.BottomLeft;
                    }
                    else if(GameFuncs.Hitscan(playerBase, x + ScanRange, y + ScanRange, Precision, range))
                    {
                        return HitscanResult.BottomRight;
                    }
                }
            }

            return HitscanResult.None;
        }

        /// <summary>
        /// Add hitscan position to coordinates
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static PointF GetHitscanPoint(HitscanResult result)
        {
            switch(result)
            {
                case HitscanResult.Center:
                    return new PointF(0, 0);
                case HitscanResult.Top:
                    return new PointF(0, 0 - ScanRange);
                case HitscanResult.Bottom:
                    return new PointF(0, 0 + ScanRange);
                case HitscanResult.Left:
                    return new PointF(0 - ScanRange, 0);
                case HitscanResult.Right:
                    return new PointF(0 + ScanRange, 0);
                case HitscanResult.TopLeft:
                    return new PointF(0 - ScanRange, 0 - ScanRange);
                case HitscanResult.TopRight:
                    return new PointF(0 + ScanRange, 0 - ScanRange);
                case HitscanResult.BottomLeft:
                    return new PointF(0 - ScanRange, 0 + ScanRange);
                case HitscanResult.BottomRight:
                    return new PointF(0 + ScanRange, 0 + ScanRange);
            }

            return new PointF(0, 0);
        }

        /// <summary>
        /// Find and hitscan closest player
        /// </summary>
        /// <returns>Closest player and it's hitscan result</returns>
        public static Player GetClosestPlayer()
        {
            float maxDistance = float.MaxValue;
            int closestId = -1;

            for(int i = 0; i < Globals.Players.Length; i++)
            {
                if(Globals.Players[i] != null && Globals.Players[i].Health > 0)
                {
                    if(Globals.Players[i].Hitscan != HitscanResult.None)
                    {
                        if(Globals.Players[i].Distance < maxDistance)
                        {
                            maxDistance = Globals.Players[i].Distance;
                            closestId = i;
                        }
                    }
                }
            }

            if(closestId == -1)
                return null;

            return Globals.Players[closestId];
        }

        /// <summary>
        /// Returns angle of relative position
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static float PointToAngle(PointF p)
        {
            double angle = Math.Atan(p.Y / p.X);

            if(p.X < 0)
                angle += Math.PI / 2;
            else
                angle -= Math.PI / 2;

            float angleF = (float)(angle / Math.PI * 180D);
            return angleF;
        }

        /// <summary>
        /// Get position of player relative to another player
        /// </summary>
        /// <param name="p1">Player</param>
        /// <param name="p2">Relative player</param>
        /// <returns>Coordinates of player2 relative to player1</returns>
        public static PointF RelativePoint(Player p1, Player p2)
        {
            float dx = p1.PosX - p2.PosX;
            float dy = p1.PosY - p2.PosY;
            return new PointF(dx, dy);
        }

        /// <summary>
        /// Get position of player relative to another player
        /// </summary>
        /// <param name="p1">Player</param>
        /// <param name="p2">Relative player</param>
        /// <returns>Coordinates of player2 relative to player1</returns>
        public static PointF RelativePoint(Player p1, PointF p2)
        {
            float dx = p1.PosX - p2.X;
            float dy = p1.PosY - p2.Y;
            return new PointF(dx, dy);
        }

        /// <summary>
        /// Get position on screen of relative point
        /// </summary>
        /// <param name="relativePos">Relative Point</param>
        /// <returns></returns>
        public static PointF ScreenPoint(PointF relativePos)
        {
            float sx = Globals.ScreenWidth / 2 - relativePos.X;
            float sy = Globals.ScreenHeight / 2 - relativePos.Y;
            return new PointF(sx, sy);
        }
    }

    public enum HitscanResult
    {
        None,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Top,
        Bottom,
        Left,
        Right,
        Center
    }
}