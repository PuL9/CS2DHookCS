using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS
{
    public static class Signatures
    {
        public static string Gameloop = "55 89 E5 83 EC 0C 53 A1 ? ? ? ? 89 45 F4"; // i dont know but it happens after everything was updated and drawn, somewhere near radar
        public static string LocalPlayer = "A1 ? ? ? ? 8B 80 ? ? ? ? 89 85 ? ? ? ? DB 85 ? ? ? ? D8 35";

        // -- Game functions
        public static string Hitscan = "55 89 E5 83 EC 1C 53 56 57 8B 45 08 D9 80 ?? ?? ?? ?? 8B 45 10 89 45 E4 DB 45 E4 DE E9 83 EC 08";
        public static string GetPlayer = "55 89 E5 53 56 57 8B 7D 08 8B 35 ?? ?? ?? ?? 89 F0 50 8B ?? FF 90 ?? ?? ?? ?? 83 C4 04 89 C3 EB 27 89 D8 68 ?? ?? ?? ?? 50 8B ?? FF 50 34 83 C4 04 50 E8 ?? ?? ?? ?? 83 C4 08 3D ?? ?? ?? ?? 74 07 39 78 08 75 02 EB 17 89 D8 50 8B ?? FF 50 30 83 C4 04 83 F8 ?? 75 C9 B8 ?? ?? ?? ?? EB ?? 5F 5E 5B 89 EC 5D C3";
        public static string ShootRecoil = "55 89 E5 83 EC 68 53 56 57 8B 7D 10";

        // -- Removals
        public static string Antiflash = "D8 05 ? ? ? ? D9 1D ? ? ? ? D9 05 ? ? ? ? D9 E8 D9 C9 DA E9 DF E0 9E 0F 96 C0 0F B6 C0 83 F8 00 75 08 D9 E8 D9 1D ? ? ? ? 6A 01 68";
        public static string AntiSmoke = "E9 ? ? ? ? 6A 03 E8 ? ? ? ? 83 C4 04 68 ? ? ? ? E8";
        public static string AntiTree = "8B 40 18 83 F8 00 74 3B";
        public static string AntiFX = "8B 40 18 83 F8 00 74 20";
        public static string Scopex2 = "83 C0 01 89 42 1C 8B 45 FC 8B 80 ? ? ? ? 83 78 1C 02";
        public static string BigScopeAlpha = "68 ? ? ? ? E8 ? ? ? ? 83 C4 04 6A 00 6A 00 6A 00 E8 ? ? ? ? 83 C4 0C 89 F0 83 E8 64";
        public static string SmallScopeAlpha = "68 ? ? ? ? E8 ? ? ? ? 83 C4 04 6A 00 6A 00 6A 00 E8 ? ? ? ? 83 C4 0C 89 F0 83 E8 32";
        public static string MapAlpha = "68 ? ? ? ? E8 ? ? ? ? 83 C4 04 68 ? ? ? ? 68 ? ? ? ? 68 ? ? ? ? E8 ? ? ? ? 83 C4 0C 83 7D 10 00 7F 05 E8 ? ? ? ? A1 ? ? ? ? 99 83 E2 1F 01 D0 C1 F8 05 89 C7 A1 ? ? ? ? 99 83 E2 1F 01 D0 C1 F8 05 89 45 C8";
        public static string DontRotate = "D9 9B ? ? ? ? A1 ? ? ? ? D9 40 4C";
        public static string HideMapBg = "6A 02 E8 ? ? ? ? 83 C4 04 83 3D ? ? ? ? ? 0F 85";
        public static string MapBgColor = "A1 ? ? ? ? 0F B6 40 1A 89 C0 50 A1 ? ? ? ? 0F B6 40 19 89 C0 50 A1 ? ? ? ? 0F B6 40 18 89 C0 50 E8 ? ? ? ? 83 C4 0C E8 ? ? ? ? B8";

        // -- BlitzMAX
        public static string Cls = "55 89 E5 A1 ? ? ? ? 50 8B 00 FF 50 64";
        public static string SetColor = "55 89 E5 53 8B 4D 08 8B 55 0C 8B 45 10 8B 1D ? ? ? ? 89 4B 08";
        public static string SetAlpha = "55 89 E5 D9 45 08 A1 ? ? ? ? D9 50 14";
        public static string DrawLine = "55 89 E5 53 8B 5D 18";
        public static string SetLineWidth = "55 89 E5 D9 45 08 A1 ? ? ? ? D9 50 24";
        public static string DrawRect = "55 89 E5 D9 45 08 D9 45 0C D9 45 10 D9 45 14 A1 ? ? ? ? 8B 15 ? ? ? ? D9 CA D8 42 58 83 EC 04 D9 1C 24 8B 15 ? ? ? ? D9 CA D8 42 54 83 EC 04 D9 1C 24 8B 15 ? ? ? ? D9 42 60 DE C1 83 EC 04 D9 1C 24 8B 15 ? ? ? ? D9 42 5C DE C1 83 EC 04 D9 1C 24 8B 15 ? ? ? ? FF 72 60 8B 15 ? ? ? ? FF 72 5C 50 8B 00 FF 50 70";
        public static string DrawString = "55 89 E5 8B 55 08 D9 45 0C D9 45 10 A1";
        public static string DrawStringGame = "55 89 E5 83 EC 18 53 8B 5D 08 D9 45 0C"; // use this
        public static string SetRotation = "55 89 E5 D9 45 08 A1 ? ? ? ? D9 58 28";
    }
}