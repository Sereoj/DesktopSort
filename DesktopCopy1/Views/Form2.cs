using System;
using System.Drawing;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1.Views
{
    /// <summary>
    ///     Интерфейс, случит для "Открытия" определенных "объектов".
    /// </summary>
    public interface IForm2 : IView
    {
        void Add(Control control);
    }

    public partial class Form2 : Form, IForm2
    {
        public Form2(ApplicationContext context)
        {
            Context = context;
            InitializeComponent();

            Header.BackColor = Color.FromArgb(24, 0, 0, 0);
        }


        protected override CreateParams CreateParams
        {
            get
            {
                var param = base.CreateParams;
                param.ClassStyle |= 0x00020000;
                return param;
            }
        }

        /// <summary>
        ///     Свойства, только получает
        /// </summary>
        public ApplicationContext Context { get; }

        public Switcher Switcher { get; set; } = new Switcher();

        /// <summary>
        ///     Отвественен за появление формы
        /// </summary>
        public new void Show()
        {
            ShowDialog();
        }

        public void Add(Control control)
        {
            if (!Pages.Controls.Contains(control))
            {
                Pages.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
            }
            else
            {
                control.BringToFront();
            }
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Switcher.Control = SettingsBasic.Instance;
            Add(Switcher.Control);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Switcher.Control = SettingsInfo.Instance;
            Add(Switcher.Control);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Switcher.Control = SettingsAdvanced.Instance;
            Add(Switcher.Control);
        }
    }
}