using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    public static class Util
    {
        public enum Effect
        {
            Roll,
            Slide,
            Center,
            Blend
        }

        private static readonly int[] dirmap = {1, 5, 4, 6, 2, 10, 8, 9};
        private static readonly int[] effmap = {0, 0x40000, 0x10, 0x80000};

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            var flags = effmap[(int) effect];
            if (ctl.Visible)
            {
                flags |= 0x10000;
                angle += 180;
            }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }

            flags |= dirmap[angle % 360 / 45];
            var ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
    }
}