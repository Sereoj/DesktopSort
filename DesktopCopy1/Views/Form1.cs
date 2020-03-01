using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Properties;
using Version = DesktopCopy1.Models.Version;

namespace DesktopCopy1.Views
{
    public interface IMainForm : IView
    {
        string Editor1 { get; }
        string Editor2 { get; }

        void OnNotification(string text);

        /*
        Это интерфейс, Возможность Отправлять/Получать События и т.д              
        */
        event EventHandler ButtonClick;
        event EventHandler ButtonCutClick;
        event EventHandler ImageHelperClick;
        event EventHandler ImageSettingsClick;
    }

    public partial class MainForm : Form, IMainForm
    {


        public MainForm()
        {
            InitializeComponent();
            Starter();

            NotificationPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            Header.BackColor = Color.FromArgb(24, 0, 0, 0);
            OnNotification($"{MessageService.WELLCOME_TEXT}! Версия программы {new Version().GetVersion(true)}");
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


        public new void Show()
        {
            Application.Run(this);
        }

        public void OnNotification(string text)
        {
            NotificationLabel.Text = text;
            Util.Animate(NotificationPanel, Util.Effect.Slide, 150, 180);
            timer1.Enabled = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        public void Starter()
        {
            var commands = Environment.GetCommandLineArgs();
            timer1.Enabled = true;

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
                    Edit1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    Edit2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
            }
            else
            {
                Edit1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Edit2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }




        private void CheckOutputFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckOutputFiles.Checked)
                PanelHide.Visible = false;
            else
                PanelHide.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NotificationLabel.Text = "";
            Util.Animate(NotificationPanel, Util.Effect.Slide, 150, 180);
            timer1.Enabled = false;
        }


        #region Editors && events

        #region Editors

        public string Editor1 => Edit1.Text;

        public string Editor2 => Edit2.Text;

        #endregion

        #region Events

        public event EventHandler ButtonClick;
        public event EventHandler ButtonCutClick;
        public event EventHandler ImageHelperClick;
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
        }

        #endregion

        #region Images

        private void ImageDialog1_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit1.Text = FolderDialog1.SelectedPath;
            }
        }

        private void ImageDialog2_Click(object sender, EventArgs e)
        {
            if (FolderDialog1.ShowDialog() == DialogResult.OK)
            {
                Edit2.Text = FolderDialog1.SelectedPath;
            }
        }

        private void ImageHelper_Click(object sender, EventArgs e)
        {
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
            ImageDialog1.Image = Resources.folder_close;
        }

        private void ImageDialog1_MouseLeave(object sender, EventArgs e)
        {
            ImageDialog1.Image = Resources.folder_open;
        }

        private void ImageDialog2_MouseEnter(object sender, EventArgs e)
        {
            ImageDialog2.Image = Resources.folder_close;
        }

        private void ImageDialog2_MouseLeave(object sender, EventArgs e)
        {
            ImageDialog2.Image = Resources.folder_open;
        }

        private void ImageSettings_MouseLeave(object sender, EventArgs e)
        {
            ImageSettings.Image = Resources.settings;
        }

        private void ImageSettings_MouseEnter(object sender, EventArgs e)
        {
            ImageSettings.Image = Resources.settings1;
        }

        private void LinkSite_MouseEnter(object sender, EventArgs e)
        {
            LinkSite.Image = Resources.info_clear;
        }

        private void LinkSite_MouseLeave(object sender, EventArgs e)
        {
            LinkSite.Image = Resources.info1_clear;
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
            ImageHelperClick?.Invoke(this, EventArgs.Empty);
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
    }
}