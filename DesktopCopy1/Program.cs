using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCopy1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            Form2 FormSettings = new Form2();
            BusinessLogic manager = new BusinessLogic();
            MainPresenter presenter = new MainPresenter(form, FormSettings, manager);
            Application.Run(form);
        }
    }
}
