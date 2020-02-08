using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    public class Version
    {
        public string GetVersion()
        {
            return Application.ProductVersion;
        }
    }
}