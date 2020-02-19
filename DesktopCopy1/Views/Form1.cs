using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using Version = DesktopCopy1.Models.Version;

namespace DesktopCopy1.Views
{
    public interface IMainForm : IView
    {
        string Editor1 { get; }
        string Editor2 { get; }

        string Label { get; set; }

        /*
        Это интерфейс, Возможность Отправлять/Получать События и т.д              
        */
        event EventHandler ButtonClick;
        event EventHandler ButtonCutClick;
        event EventHandler ImageHelperClick;
        event EventHandler ImageDialogClick;
        event EventHandler ImageDialogClick1;
        event EventHandler LinkSiteClick;

        event EventHandler ImageSettingsClick;
    }

    public partial class MainForm : Form, IMainForm
    {
        private const string НАВЕДЕНИЕ = "#494954"; // 000C1C
        private const string ВНЕ = "#444446"; // 2D3276

        private readonly ApplicationContext _context;


        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            Starter();

            Text = $"Desktop Sort";
            gunaPanel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            Header.BackColor = Color.FromArgb(24, 0, 0, 0);
            
            //DublicateNameForm.Text = Text;
        }



        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams param = base.CreateParams;
        //        param.ClassStyle |= 0x00020000;
        //        return param;
        //    }
        //}

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public void ReadmeText()
        {
            var file = Application.StartupPath + @"\Readme";
            if (!File.Exists(file))
            {
                File.AppendAllText(file, "Для того, чтобы здесь был текст - придумайте его.");
                File.SetAttributes(file, FileAttributes.ReadOnly);
            }
        }

        public void Starter()
        {
            var commands = Environment.GetCommandLineArgs();


            if (commands.Length > 1)
            {
                var args1 = commands[1].Substring(1);
                var args2 = commands[2].Substring(1);
                if (Directory.Exists(args1) && Directory.Exists(args2))
                {
                    Edit1.Text = args1;
                    Edit2.Text = args2;
                }
                else
                {
                    Label = "Неверные пути";
                    Edit1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    Edit2.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
            }
            else
            {
                ReadmeText();
                Edit1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Edit2.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }

        #region Panels

        private void PanelClose_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        #endregion

        #region Links

        private void LinkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Ой..\nКажется сайт -  временно недоступен!\nПопробуйте повторить позже.",
                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (LinkSiteClick != null) LinkSiteClick(this, EventArgs.Empty);
        }

        #endregion


        #region Editors && events

        #region Editors

        public string Editor1 => Edit1.Text;

        public string Editor2 => Edit2.Text;

        public string Label
        {
            get => label3.Text;
            set => label3.Text = value;
        }

        #endregion

        #region Events

        public event EventHandler ButtonClick;
        public event EventHandler ButtonCutClick;
        public event EventHandler ImageHelperClick;
        public event EventHandler ImageDialogClick;
        public event EventHandler ImageDialogClick1;

        public event EventHandler LinkSiteClick;
        public event EventHandler ImageSettingsClick;

        #endregion

        #endregion


        #region Buttons

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {

            ButtonCutClick?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("ЕУеы");
            new MessageService().Message("TESTs");
        }

        #endregion

        #region Images

        private void ImageDialog1_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit1.Text = FolderDialog1.SelectedPath;
                ImageDialogClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ImageDialog2_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit2.Text = FolderDialog1.SelectedPath;
                ImageDialogClick1?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ImageHelper_Click(object sender, EventArgs e)
        {
            //if (panel1.Visible)
            //{
            //    panel1.Location = new Point(362, 34);
            //    panel1.Visible = false;
            //}
            //else
            //{
            //    panel1.Location = new Point(8, 34);
            //    panel1.Visible = true;
            //}

            ImageHelperClick?.Invoke(this, EventArgs.Empty);
        }

        private void ImageSettings_Click(object sender, EventArgs e)
        {
            ImageSettingsClick?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Effect Images

        private void ImageDialog1_MouseEnter(object sender, EventArgs e)
        {
            ImageDialog1.BackColor = ColorTranslator.FromHtml(НАВЕДЕНИЕ);
        }

        private void ImageDialog1_MouseLeave(object sender, EventArgs e)
        {
            ImageDialog1.BackColor = ColorTranslator.FromHtml(ВНЕ);
        }

        private void ImageDialog2_MouseEnter(object sender, EventArgs e)
        {
            ImageDialog2.BackColor = ColorTranslator.FromHtml(НАВЕДЕНИЕ);
        }

        private void ImageDialog2_MouseLeave(object sender, EventArgs e)
        {
            ImageDialog2.BackColor = ColorTranslator.FromHtml(ВНЕ);
        }

        private void ImageSettings_MouseEnter(object sender, EventArgs e)
        {
            ImageSettings.BackColor = ColorTranslator.FromHtml(НАВЕДЕНИЕ);
        }

        private void ImageSettings_MouseLeave(object sender, EventArgs e)
        {
            ImageSettings.BackColor = ColorTranslator.FromHtml(ВНЕ);
        }

        #endregion

        #region Custom ToolStrip

        private void WindowIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            Activate();
        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            //HeadText.Text = "О проекте";
            //label5.Text = "Для того, чтобы здесь был текст - придумайте его.";

            //if (panel1.Visible)
            //{
            //    panel1.Location = new Point(362, 34);
            //    panel1.Visible = false;
            //}
            //else
            //{
            //    panel1.Location = new Point(8, 34);
            //    panel1.Visible = true;
            //}
        }

        private void CloseToolStrip_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Application.Exit();
        }

        private void ShowHidetoolStrip_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                Activate();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }



        #endregion

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }
    }
}