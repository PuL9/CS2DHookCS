using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS2DHookCS.UI;
using System.Drawing;

namespace CS2DHookCS.CS2D
{
    public static class Globals
    {
        public static NewForm MainForm { get; set; }

        public static int ScreenWidth = 850;
        public static int ScreenHeight = 480;

        public static IntPtr LocalPlayerPointer { get; set; }
        public static IntPtr MapBgColorPointer { get; set; }
        public static Color MapBgColor { get; set; }

        public static Player LocalPlayer { get; set; }
        public static Player[] Players { get; set; }

        public static int Speedhack = 100;
        public static int Spinbot = 0;
    }
}
