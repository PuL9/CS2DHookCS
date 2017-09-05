using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS.Engine
{
    public static class GameFuncs
    {
        public delegate bool HitscanDlg(IntPtr playerBase, int x, int y, float precision, int range);
        public delegate IntPtr GetPlayerDlg(int id);
        public delegate void OnRecoilShootDlg(IntPtr playerBase, float rotation, int a4, int a5);

        public static HitscanDlg Hitscan;
        public static GetPlayerDlg GetPlayer;
        public static OnRecoilShootDlg OnRecoilShoot;

        /// <summary>
        /// Find game functions
        /// </summary>
        public static void Init()
        {
            Hitscan = Memory.GetFunction<HitscanDlg>(Signatures.Hitscan);
            GetPlayer = Memory.GetFunction<GetPlayerDlg>(Signatures.GetPlayer);
            OnRecoilShoot = Memory.GetFunction<OnRecoilShootDlg>(Signatures.ShootRecoil);
        }
    }
}