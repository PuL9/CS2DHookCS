using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS
{
    public static class Playerstruct
    {
        public static int Player { get; set; }
        public static int Local { get; set; }

        public static int ID = 0x8;

        public static int Health = 0x1BC;
        public static int Armor = 0x1C4;
        public static int Money = 0x170;

        public static int Rotation = 0x1A4;

        public static int PosX = 0x19C;
        public static int PosY = 0x1A0;

        public static int Speed = 0x290;
        
        public static int Team = 0x18C;
        public static int Ping = 0x70;
    }
}
