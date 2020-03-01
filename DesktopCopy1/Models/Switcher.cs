using System.Windows.Forms;
using DesktopCopy1.Views;

namespace DesktopCopy1.Models
{
    public class Switcher
    {
        public Control Control { get; set; } = SettingsBasic.Instance;
        public ApplicationContext MainForm { get; set; }
        public ApplicationContext Form2 { get; set; }
    }
}