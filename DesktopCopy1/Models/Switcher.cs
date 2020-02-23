using DesktopCopy1.Views;
using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    public class Switcher
    {
        public Control Control { get; set; }  = SettingsBasic.Instance;
        public Control LastControl { get; set; } 
    }
}
