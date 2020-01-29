using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCopy1
{


    public interface IMainForm
    {
        /*
        Это интерфейс, Возможность Отправлять/Получать События и т.д              
        */
        event EventHandler ButtonClick;
        event EventHandler ButtonCutClick;
        event EventHandler ImageHelperClick;
        event EventHandler ImageDialogClick;
        event EventHandler ImageDialogClick1;
        event EventHandler LinkSiteClick;
        string Editor1 { get; }
        string Editor2 { get; }
        string Label { get; set; }
    }

    public partial class MainForm : Form, IMainForm
    {
        const string НАВЕДЕНИЕ = "#2D3276"; // 000C1C
        const string ВНЕ = "#000C1C"; // 2D3276
        public Form2 Form2;


        #region Editors && events
        #region Editors
        public string Editor1
        {
            get
            {
                return Edit1.Text;
            }
        }

        public string Editor2
        {
            get
            {
                return Edit2.Text;
            }
        }

        public string Label
        {
            get
            {
                return label3.Text;
            }
            set
            {
                label3.Text = value;
            }
        }
        #endregion
        #region Events
        public event EventHandler ButtonClick;
        public event EventHandler ButtonCutClick;
        public event EventHandler ImageHelperClick;
        public event EventHandler ImageDialogClick;
        public event EventHandler ImageDialogClick1;

        public event EventHandler LinkSiteClick;
        #endregion
        #endregion

        public void ReadmeText()
        {
            string file = Application.StartupPath + @"\Readme";
            if (!File.Exists(file))
            {

                File.AppendAllText(file, "Для того, чтобы здесь был текст - придумайте его.");
                File.SetAttributes(file, FileAttributes.ReadOnly);
            }
        }
        public void Starter()
        {
            string[] commands = Environment.GetCommandLineArgs();


            if (commands.Length > 1)
            {
                string args1 = commands[1].Substring(1);
                string args2 = commands[2].Substring(1);
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



        public MainForm()
        {
            InitializeComponent();
            Starter();

            DublicateNameForm.Text = this.Text;
        }
        #region Buttons
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null) ButtonClick(this, EventArgs.Empty);
        }

        private void ButtonCut_Click(object sender, EventArgs e)
        {
            if (ButtonCutClick != null) ButtonCutClick(this, EventArgs.Empty);
        }
        #endregion

        #region Panels
        private void PanelClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        #endregion

        #region Links
        private void LinkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Ой..\nКажется сайт - {LinkSite.Text} временно недоступен!\nПопробуйте повторить позже.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (LinkSiteClick != null) LinkSiteClick(this, EventArgs.Empty);
        }
        #endregion

        #region Images

        private void ImageDialog1_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit1.Text = FolderDialog1.SelectedPath;
                if (ImageDialogClick != null) ImageDialogClick(this, EventArgs.Empty);
            }
        }

        private void ImageDialog2_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit2.Text = FolderDialog1.SelectedPath;
                if (ImageDialogClick1 != null) ImageDialogClick1(this, EventArgs.Empty);
            }
        }

        private void ImageHelper_Click(object sender, EventArgs e)
        {

            if (panel1.Visible)
            {
                panel1.Location = new Point(362, 34);
                panel1.Visible = false;
            }
            else
            {
                panel1.Location = new Point(8, 34);
                panel1.Visible = true;
            }
            if (ImageHelperClick != null) ImageHelperClick(this, EventArgs.Empty);
        }

        private void ImageSettings_Click(object sender, EventArgs e)
        {
            Form2 = new Form2();
            Form2.Show();
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
        #endregion

        #region Custom ToolStrip
        private void WindowIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Activate();

        }

        private void AboutToolStrip_Click(object sender, EventArgs e)
        {
            HeadText.Text = "О проекте";
            label5.Text = "Для того, чтобы здесь был текст - придумайте его.";

            if (panel1.Visible)
            {
                panel1.Location = new Point(362, 34);
                panel1.Visible = false;
            }
            else
            {
                panel1.Location = new Point(8, 34);
                panel1.Visible = true;

            }
        }

        private void CloseToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowHidetoolStrip_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        #endregion

    }
}
