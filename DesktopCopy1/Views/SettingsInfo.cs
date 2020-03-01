using System.Windows.Forms;

namespace DesktopCopy1.Views
{
    public partial class SettingsInfo : UserControl
    {
        private static SettingsInfo _instance;

        public SettingsInfo()
        {
            InitializeComponent();
        }

        public static SettingsInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsInfo();
                return _instance;
            }
        }
    }
}