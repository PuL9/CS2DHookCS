using CS2DHookCS.CS2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS2DHookCS.Engine
{
    public static class Blitzmax
    {
        public delegate void SetColorDlg(int r, int g, int b);
        public delegate void SetAlphaDlg(float alpha);
        public delegate void DrawLineDlg(float x, float y, float x2, float y2, int drawLastPixel);
        public delegate void SetLineWidthDlg(float width);
        public delegate void DrawRectDlg(float x, float y, float width, float height);
        public delegate void DrawStringDlg(IntPtr textAdr, float x, float y);
        public delegate void SetRotationDlg(float rotation);

        public static SetColorDlg SetColor;
        public static SetAlphaDlg SetAlpha;
        public static DrawLineDlg DrawLine;
        public static SetLineWidthDlg SetLineWidth;
        public static DrawRectDlg DrawRect;
        public static DrawStringDlg DrawString;
        public static SetRotationDlg SetRotation;

        /// <summary>
        /// Find BlitzMAX functions
        /// </summary>
        public static void Init()
        {
            SetColor = Memory.GetFunction<SetColorDlg>(Memory.FixedAobscan(Signatures.SetColor));
            SetAlpha = Memory.GetFunction<SetAlphaDlg>(Memory.FixedAobscan(Signatures.SetAlpha));
            DrawLine = Memory.GetFunction<DrawLineDlg>(Signatures.DrawLine);
            SetLineWidth = Memory.GetFunction<SetLineWidthDlg>(Memory.FixedAobscan(Signatures.SetLineWidth));
            DrawRect = Memory.GetFunction<DrawRectDlg>(Memory.FixedAobscan(Signatures.DrawRect));
            DrawString = Memory.GetFunction<DrawStringDlg>(Memory.FixedAobscan(Signatures.DrawString));
            SetRotation = Memory.GetFunction<SetRotationDlg>(Memory.FixedAobscan(Signatures.SetRotation));
        }

        public static void DrawBorder(int x, int y, int w, int h)
        {
            DrawLine(x, y, x + w, y, 1);
            DrawLine(x, y, x, y + h, 1);

            DrawLine(x, y + h, x + w, y + h, 1);
            DrawLine(x + w, y, x + w, y + h, 1);
        }

        public static void DrawText(string text, int x, int y)
        {
            DrawString(text.ToBlitzmaxString(), x, y);
        }

        public static IntPtr ToBlitzmaxString(this string str)
        {
            var buffer = new List<byte>();
            buffer.AddRange(Enumerable.Range(0, 8).Select(x => (byte)0));
            buffer.AddRange(BitConverter.GetBytes(str.Length));
            buffer.AddRange(Encoding.Unicode.GetBytes(str));

            var bytes = buffer.ToArray();

            unsafe
            {
                fixed (byte* ptr = bytes)
                {
                    return (IntPtr)ptr;
                }
            }
        }
    }
}