using System;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{
    public class SettingsPresenterManager2
    {
        private readonly ISettingsAdvanced _view;

        public SettingsPresenterManager2(ISettingsAdvanced view)
        {
            _view = view;
            view.Logger += View_Logger;
            view.Background += View_Background;
            view.RunAsUpdate += View_RunAsUpdate;
        }

        public Settings Settings { get; set; }

        private void View_RunAsUpdate(object sender, EventArgs e)
        {
            Settings.Update = !Settings.Update;
        }

        private void View_Logger(object sender, EventArgs e)
        {
            Settings.Logger = !Settings.Logger;
        }

        private void View_Background(object sender, EventArgs e)
        {
            Settings.Background = !Settings.Background;
        }

        public void Init()
        {
            _view.Show();
        }
    }
}