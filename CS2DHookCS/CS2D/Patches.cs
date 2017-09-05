using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS.CS2D
{
    public static class Patches
    {
        private static IntPtr BigScopeAlphaAdr = IntPtr.Zero;
        private static IntPtr SmallScopeAlphaAdr = IntPtr.Zero;
        private static IntPtr MapAlphaAdr = IntPtr.Zero;

        public static void Init()
        {
            BigScopeAlphaAdr = Memory.FixedAobscan(Signatures.BigScopeAlpha) + 1;
            SmallScopeAlphaAdr = Memory.FixedAobscan(Signatures.SmallScopeAlpha) + 1;
            MapAlphaAdr = Memory.FixedAobscan(Signatures.MapAlpha) + 1;

            WinApi.VirtualProtect(BigScopeAlphaAdr, 4);
            WinApi.VirtualProtect(SmallScopeAlphaAdr, 4);
            WinApi.VirtualProtect(MapAlphaAdr, 4);
        }

        public static void SetScopeAlpha(float alpha)
        {
            Memory.WriteFloat(BigScopeAlphaAdr, alpha);
            Memory.WriteFloat(SmallScopeAlphaAdr, alpha);
        }

        public static void SetMapAlpha(float alpha)
        {
            Memory.WriteFloat(MapAlphaAdr, alpha);
        }

        public static Patch DontRotate = new Patch(Signatures.DontRotate, 6)
        {
            On = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }
        };

        public static Patch AntiFlash = new Patch(Signatures.Antiflash, 6)
        {
            On = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }
        };

        public static Patch AntiSmoke = new Patch(Signatures.AntiSmoke, 5, 5)
        {
            On = new byte[] { 0xE9, 0x1D, 0x1A, 0x00, 0x00, 0x90, 0x90 }
        };

        public static Patch AntiTree = new Patch(Signatures.AntiTree, 3)
        {
            On = new byte[] { 0x90, 0x90, 0x90 }
        };

        public static Patch AntiFX = new Patch(Signatures.AntiFX, 3)
        {
            On = new byte[] { 0x90, 0x90, 0x90 }
        };

        public static Patch Scopex2 = new Patch(Signatures.Scopex2, 1, 2)
        {
            On = new byte[] { 0x02 }
        };

        public static Patch HideMapBg = new Patch(Signatures.HideMapBg, 6)
        {
            On = new byte[] { 0xE9, 0x67, 0x01, 0x00, 0x00, 0x90 }
        };
    }
}