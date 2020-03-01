using System;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Presenters;

namespace DesktopCopy1.Views
{
    public interface ISettingsAdvanced : IView
    {
        Settings Settings { get; set; }
        event EventHandler Logger;
        event EventHandler RunAsUpdate;
        event EventHandler Background;
    }


    public partial class SettingsAdvanced : UserControl, ISettingsAdvanced
    {
        private static SettingsAdvanced _instance;

        public SettingsAdvanced()
        {
            InitializeComponent();
            var presenter = new SettingsPresenterManager2(this);
            presenter.Init();
        }

        public static SettingsAdvanced Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsAdvanced();
                return _instance;
            }
        }

        public event EventHandler Logger;
        public event EventHandler RunAsUpdate;
        public event EventHandler Background;

        public Settings Settings { get; set; }

        public void Close()
        {
            throw new NotImplementedException();
        }

        private void ImageBackground(bool image)
        {
        }
    }
}