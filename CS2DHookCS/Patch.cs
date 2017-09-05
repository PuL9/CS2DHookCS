using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS
{
    /// <summary>
    /// Patch class for removals etc..
    /// </summary>
    public unsafe class Patch
    {
        public IntPtr Address;
        public byte[] On { get; set; }
        public byte[] Off { get; set; }

        /// <summary>
        /// Initialize patch, find it's signature etc
        /// </summary>
        /// <param name="signature">Signature in CE format</param>
        /// <param name="length">Number of bytes to be patched</param>
        /// <param name="offset">Add offset to address</param>
        public Patch(string signature, int length, int offset = 0)
        {
            Address = Memory.FixedAobscan(signature) + offset;
            WinApi.VirtualProtect(Address, length);
            Off = Memory.ReadBytes(Address, length);
        }

        public void Enable()
        {
            Memory.WriteBytes(Address, On);
        }

        public void Disable()
        {
            Memory.WriteBytes(Address, Off);
        }

        public void Set(bool enable)
        {
            if(enable)
                Enable();
            else
                Disable();
        }
    }
}