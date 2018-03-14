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
            Console.WriteLine("1. Don't put hack files in cs2d folder");
            Console.WriteLine("2. Open Injector");
            Console.WriteLine("3. Open CS2D");
            Console.WriteLine("-- PuL9");
            Console.WriteLine();

            var proc = Process.GetProcessesByName("CS2D").FirstOrDefault();

            Console.WriteLine("Waiting for CS2D");
            while (proc == null)
            {
                Thread.Sleep(10);
                proc = Process.GetProcessesByName("CS2D").FirstOrDefault();
            }

            Console.WriteLine("Injecting");

            var sharpo = @"C:\Users\Admin\Desktop\PuL9\C#\Projects\CS2DHookCS\CS2DHookCS\bin\Debug\CS2DHookCS.dll";
            Console.WriteLine(sharpo);

            var injectedLibPtr = proc.LoadLibrary(sharpo);
            var lib = LoadLibrary(sharpo);
            var ptr = GetProcAddress(lib, "Init");
            var diff = IntPtr.Subtract(ptr, (int)lib);

            proc.CallAsync(IntPtr.Add(injectedLibPtr, (int)diff), IntPtr.Zero);
        }
    }
}