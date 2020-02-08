using System;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1
{
    internal static class Program
    {
        public static readonly ApplicationContext Context = new ApplicationContext();

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<IMainForm, MainForm>()
                .RegisterView<IForm2, Form2>()
                .RegisterService<IMessageService, MessageService>()
                .RegisterService<IBusinessLogic, BusinessLogic>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainPresenter>();
            //Application.Run(new MainForm(Context));
        }
    }
}