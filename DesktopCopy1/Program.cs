using System;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Presenters;
using DesktopCopy1.Views;

namespace DesktopCopy1
{
    internal static class Program
    {

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<IMainForm, MainForm>()
                .RegisterView<IForm2, Form2>()
                .RegisterView<ISettingsBasic, SettingsBasic>()
                .RegisterService<IMessageService, MessageService>()
                .RegisterService<IBusinessLogic, BusinessLogic>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainPresenter>();
        }
    }
}