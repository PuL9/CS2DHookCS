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

        public int Health { get { return *(int*)(*(int*)(Base + Playerstruct.Health) + 0x8) + 5; } }
        public int Armor { get { return *(int*)(*(int*)(Base + Playerstruct.Armor) + 0x8) + 5; } }
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
            get { return *(int*)(*(int*)(Base + Playerstruct.Speed) + 0x8) + 5; }
            set { *(int*)(*(int*)(Base + Playerstruct.Speed) + 0x8) = value - 5; }
        }

        public Team Team { get { return (Team)(*(int*)(Base + Playerstruct.Team)); } }
        public int Ping { get { return (*(int*)(Base + Playerstruct.Ping)); } }

        public HitscanResult Hitscan { get; set; }
        public float Distance { get; set; }

        public bool IsPlaying { get { return Team != Team.S && Health > 0; } }

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