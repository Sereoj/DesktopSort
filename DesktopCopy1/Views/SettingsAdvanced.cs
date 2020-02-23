using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCopy1.Views
{
    public partial class SettingsAdvanced : UserControl
    {
        private static SettingsAdvanced _instance;

        public static SettingsAdvanced Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsAdvanced();
                return _instance;
  
            }
        }

        public SettingsAdvanced()
        {
            InitializeComponent();
        }
    }
}
