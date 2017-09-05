using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using CS2DHookCS.Engine;

namespace CS2DHookCS.CS2D
{
    public unsafe class Player
    {
        public IntPtr Base { get; private set; }

        public int ID { get { return *(int*)(Base + Playerstruct.ID); } }

        public int Health { get { return *(int*)(Base + Playerstruct.Health); } }
        public int Armor { get { return *(int*)(Base + Playerstruct.Armor); } }
        public int Money { get { return *(int*)(Base + Playerstruct.Money); } }

        public float Rotation
        {
            get { return *(float*)(Base + Playerstruct.Rotation); }
            set { *(float*)(Base + Playerstruct.Rotation) = value; }
        }

        public float PosX { get { return *(float*)(Base + Playerstruct.PosX); } }
        public float PosY { get { return *(float*)(Base + Playerstruct.PosY); } }

        public int Speed
        {
            get { return *(int*)(Base + Playerstruct.Speed); }
            set { *(int*)(Base + Playerstruct.Speed) = value; }
        }

        public float Recoil
        {
            get { return *(float*)(Base + Playerstruct.Recoil); }
            set { *(float*)(Base + Playerstruct.Recoil) = value; }
        }

        public Team Team { get { return (Team)(*(int*)(Base + Playerstruct.Team)); } }

        public HitscanResult Hitscan { get; set; }
        public float Distance { get; set; }

        public Player(IntPtr playerBase)
        {
            this.Base = playerBase;
        }
    }

    public enum Team : int
    {
        S = 0,
        T = 1,
        CT = 2
    }
}