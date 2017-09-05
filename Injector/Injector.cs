using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Injector
{
    public class Injector
    {
        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

        [System.Reflection.Obfuscation(Feature = "virtualization", Exclude = false)]
        public static void Main()
        {
            var proc = Process.GetProcessesByName("CS2D").FirstOrDefault();

            while(proc == null)
            {
                Console.WriteLine("Waiting for CS2D");
                Thread.Sleep(1000);
                proc = Process.GetProcessesByName("CS2D").FirstOrDefault();
            }

            Console.WriteLine("Injecting");

            var sharpo = @"T:\C#\!Projects\CS2DHookCS\CS2DHookCS\bin\Debug\CS2DHookCS.dll";
            Console.WriteLine(sharpo);

            var injectedLibPtr = proc.LoadLibrary(sharpo);
            var lib = LoadLibrary(sharpo);
            var ptr = GetProcAddress(lib, "Init");
            var diff = IntPtr.Subtract(ptr, (int)lib);

            proc.CallAsync(IntPtr.Add(injectedLibPtr, (int)diff), IntPtr.Zero);
        }
    }
}