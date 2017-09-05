using System;
using System.Runtime.InteropServices;
using System.Threading;

using CS2DHookCS.Engine;
using CS2DHookCS.CS2D;

using RGiesecke.DllExport;

namespace CS2DHookCS
{
    [System.Reflection.ObfuscationAttribute(Feature = "renaming", ApplyToMembers = true)]
    // Should NOT be obfuscated
    public static class Main
    {
        /// <summary>
        /// Actually never called, need for injector to see exports
        /// </summary>
        public static void DllMain(IntPtr dllInstance, int reason, IntPtr reserved) { }

        /// <summary>
        /// Pseudo entry point, must be called after injection
        /// </summary>
        [DllExport("Init", CallingConvention.Cdecl)]
        public static void Init()
        {
            var core = new Core();
            Globals.MainForm = new UI.NewForm();
            Globals.MainForm.ShowDialog();
        }
    }
}