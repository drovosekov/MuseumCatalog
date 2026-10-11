using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utils
{
    public static class Extensions
    {
        public static void SaveFormPosition(this Form frm)
        {
            Reg.SetRegValueSettings(frm.Name + " Maximize", frm.WindowState == FormWindowState.Maximized);
            if (frm.WindowState == FormWindowState.Normal)
            {
                Reg.SetRegValueSettings(frm.Name + " Maximize", false);
                Reg.SetRegValueSettings(frm.Name + " Left", frm.Left);
                Reg.SetRegValueSettings(frm.Name + " Top", frm.Top);
                Reg.SetRegValueSettings(frm.Name + " Height", frm.Height);
                Reg.SetRegValueSettings(frm.Name + " Width", frm.Width);
            }
        }

        public static void LoadFormPosition(this Form frm, bool getFormSize = true)
        {
            object m = Reg.GetRegValueSettings(frm.Name + " Maximize");
            if (m is null)
                return;

            if (Convert.ToBoolean(m) == false)
            {
                Rectangle wa = Screen.PrimaryScreen.WorkingArea;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Left = Reg.GetRegValueInt(frm.Name + " Left").Constrain(0, wa.Width * 10);
                frm.Top = Reg.GetRegValueInt(frm.Name + " Top").Constrain(0, wa.Height * 10);
                if (getFormSize)
                {
                    frm.Height = Reg.GetRegValueInt(frm.Name + " Height");
                    frm.Width = Reg.GetRegValueInt(frm.Name + " Width");
                }
            }
            else
            {
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        public static int Constrain(this int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

    }
}
