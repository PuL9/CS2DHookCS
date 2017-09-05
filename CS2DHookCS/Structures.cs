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

        public static int Health = 0x164;
        public static int Armor = 0x16C;
        public static int Money = 0x170;

        public static int Rotation = 0x14C;

        public static int PosX = 0x144;
        public static int PosY = 0x148;

        public static int Speed = 0x218;
        public static int Recoil = 0x1F8;
        
        public static int Team = 0x134;
    }
}
