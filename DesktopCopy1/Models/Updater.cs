using System.Threading;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace DesktopCopy1.Models
{
    public class Updater
    {
        public Updater()
        {
            AutoUpdater.AppTitle = "Desktop Sort Updater";
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;

            AutoUpdater.Start("https://getfile.dokpub.com/yandex/get/https://yadi.sk/d/PBkFm38Nbc-WTw");
        }

        private void AutoUpdater_ApplicationExitEvent()
        {
            Thread.Sleep(5000);
            Application.Exit();
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            new MessageService().Context = args.CurrentVersion.ToString();
        }
    }
}