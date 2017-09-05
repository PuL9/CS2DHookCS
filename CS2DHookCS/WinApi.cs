using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class WinApi {
    [DllImport("user32.dll")]
    public static extern short GetAsyncKeyState(Keys vKey);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetCursorPos(int x, int y);

    [DllImport("user32.dll", SetLastError = true)]
    public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    public const int MOUSEEVENTF_LEFTDOWN = 0x02;
    public const int MOUSEEVENTF_LEFTUP = 0x04;
    public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    public const int MOUSEEVENTF_RIGHTUP = 0x10;

    [DllImport("user32.dll")]
    public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

    [DllImport("kernel32.dll")]
    public static extern bool VirtualProtect(IntPtr address, uint size, uint newProtect, out uint oldProtect);

    public static void DoMouseClick()
    {
        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }

    public static void VirtualProtect(IntPtr address, int size)
    {
        uint old = 0;
        VirtualProtect(address, (uint)size, (uint)MemoryProtection.PAGE_EXECUTE_READ_WRITE, out old);
    }

    enum MemoryProtection : uint
    {
        PAGE_EXECUTE_READ_WRITE = 0x40
    }
}