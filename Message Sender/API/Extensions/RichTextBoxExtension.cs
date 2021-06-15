using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MessageSender
{
    static class RichTextBoxExtension
    {
        private const int WM_SETREDRAW = 0x0b;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        public static void SuspendDrawing(this RichTextBox richTextBox)
        {
            SendMessage(richTextBox.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
        }

        public static void ResumeDrawing(this RichTextBox richTextBox)
        {
            SendMessage(richTextBox.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            richTextBox.Invalidate();
        }

        public static void SetZoomFactor(this RichTextBox richTextBox, float zoomFactor)
        {
            richTextBox.ZoomFactor = 1.0f;
            richTextBox.ZoomFactor = zoomFactor;
        }
    }
}
