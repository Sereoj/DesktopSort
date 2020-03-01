using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WK.Libraries.BetterFolderBrowserNS;

namespace DesktopCopy1.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ImageDialog1 = new System.Windows.Forms.PictureBox();
            this.ImageDialog2 = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowHidetoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDialog1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.Edit1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.Edit2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.ButtonCut = new Guna.UI.WinForms.GunaButton();
            this.ImageSettings = new Guna.UI.WinForms.GunaPictureBox();
            this.LinkSite = new Guna.UI.WinForms.GunaPictureBox();
            this.FormElipseControl = new Guna.UI.WinForms.GunaElipse(this.components);
            this.DControlForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.Header = new Guna.UI.WinForms.GunaPanel();
            this.Logo = new Guna.UI.WinForms.GunaPictureBox();
            this.DControlHead = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCopy = new Guna.UI.WinForms.GunaButton();
            this.CheckOutputFiles = new Guna.UI.WinForms.GunaCheckBox();
            this.DControlLogo = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.PanelHide = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.NotificationPanel = new Guna.UI.WinForms.GunaLinePanel();
            this.NotificationLabel = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelHide.SuspendLayout();
            this.NotificationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageDialog1
            // 
            this.ImageDialog1.BackColor = System.Drawing.Color.Transparent;
            this.ImageDialog1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImageDialog1.Image = global::DesktopCopy1.Properties.Resources.folder_open;
            this.ImageDialog1.Location = new System.Drawing.Point(698, 143);
            this.ImageDialog1.Name = "ImageDialog1";
            this.ImageDialog1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ImageDialog1.Size = new System.Drawing.Size(24, 27);
            this.ImageDialog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDialog1.TabIndex = 11;
            this.ImageDialog1.TabStop = false;
            this.ImageDialog1.Click += new System.EventHandler(this.ImageDialog1_Click);
            this.ImageDialog1.MouseEnter += new System.EventHandler(this.ImageDialog1_MouseEnter);
            this.ImageDialog1.MouseLeave += new System.EventHandler(this.ImageDialog1_MouseLeave);
            // 
            // ImageDialog2
            // 
            this.ImageDialog2.BackColor = System.Drawing.Color.Transparent;
            this.ImageDialog2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImageDialog2.Image = global::DesktopCopy1.Properties.Resources.folder_open;
            this.ImageDialog2.Location = new System.Drawing.Point(698, 229);
            this.ImageDialog2.Name = "ImageDialog2";
            this.ImageDialog2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ImageDialog2.Size = new System.Drawing.Size(24, 27);
            this.ImageDialog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageDialog2.TabIndex = 12;
            this.ImageDialog2.TabStop = false;
            this.ImageDialog2.Click += new System.EventHandler(this.ImageDialog2_Click);
            this.ImageDialog2.MouseEnter += new System.EventHandler(this.ImageDialog2_MouseEnter);
            this.ImageDialog2.MouseLeave += new System.EventHandler(this.ImageDialog2_MouseLeave);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contextMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHidetoolStrip,
            this.AboutToolStrip,
            this.toolStripSeparator1,
            this.CloseToolStrip});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(171, 76);
            // 
            // ShowHidetoolStrip
            // 
            this.ShowHidetoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ShowHidetoolStrip.Image")));
            this.ShowHidetoolStrip.Name = "ShowHidetoolStrip";
            this.ShowHidetoolStrip.Size = new System.Drawing.Size(170, 22);
            this.ShowHidetoolStrip.Text = "Показать\\Скрыть";
            this.ShowHidetoolStrip.Click += new System.EventHandler(this.ShowHidetoolStrip_Click);
            // 
            // AboutToolStrip
            // 
            this.AboutToolStrip.CheckOnClick = true;
            this.AboutToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStrip.Image")));
            this.AboutToolStrip.Name = "AboutToolStrip";
            this.AboutToolStrip.Size = new System.Drawing.Size(170, 22);
            this.AboutToolStrip.Text = "О проекте";
            this.AboutToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutToolStrip.Click += new System.EventHandler(this.AboutToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // CloseToolStrip
            // 
            this.CloseToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CloseToolStrip.Image")));
            this.CloseToolStrip.Name = "CloseToolStrip";
            this.CloseToolStrip.Size = new System.Drawing.Size(170, 22);
            this.CloseToolStrip.Text = "Закрыть";
            this.CloseToolStrip.Click += new System.EventHandler(this.CloseToolStrip_Click);
            // 
            // FolderDialog1
            // 
            this.FolderDialog1.Multiselect = false;
            this.FolderDialog1.RootFolder = "C:\\";
            this.FolderDialog1.Title = "Please select a folder...";
            // 
            // Edit1
            // 
            this.Edit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Edit1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edit1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.Edit1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Edit1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Edit1.LineSize = 1;
            this.Edit1.Location = new System.Drawing.Point(41, 134);
            this.Edit1.Name = "Edit1";
            this.Edit1.PasswordChar = '\0';
            this.Edit1.Size = new System.Drawing.Size(651, 36);
            this.Edit1.TabIndex = 0;
            this.Edit1.TabStop = false;
            this.Edit1.Text = "C:\\Users\\Sergey\\Documents";
            this.Edit1.TextOffsetX = 10;
            // 
            // Edit2
            // 
            this.Edit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Edit2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Edit2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.Edit2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Edit2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.Edit2.LineSize = 1;
            this.Edit2.Location = new System.Drawing.Point(41, 220);
            this.Edit2.Name = "Edit2";
            this.Edit2.PasswordChar = '\0';
            this.Edit2.Size = new System.Drawing.Size(651, 36);
            this.Edit2.TabIndex = 1;
            this.Edit2.TabStop = false;
            this.Edit2.Text = "C:\\Users\\Egorov\\Documents";
            this.Edit2.TextOffsetX = 10;
            // 
            // ButtonCut
            // 
            this.ButtonCut.AnimationHoverSpeed = 0.07F;
            this.ButtonCut.AnimationSpeed = 0.03F;
            this.ButtonCut.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ButtonCut.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonCut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonCut.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonCut.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.ButtonCut.Image = global::DesktopCopy1.Properties.Resources.cut_out;
            this.ButtonCut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCut.Location = new System.Drawing.Point(428, 277);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ButtonCut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCut.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCut.OnHoverImage = global::DesktopCopy1.Properties.Resources.cut;
            this.ButtonCut.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCut.Radius = 10;
            this.ButtonCut.Size = new System.Drawing.Size(241, 43);
            this.ButtonCut.TabIndex = 0;
            this.ButtonCut.Text = "Переместить";
            this.ButtonCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // ImageSettings
            // 
            this.ImageSettings.BackColor = System.Drawing.Color.Transparent;
            this.ImageSettings.BaseColor = System.Drawing.Color.Transparent;
            this.ImageSettings.Image = ((System.Drawing.Image)(resources.GetObject("ImageSettings.Image")));
            this.ImageSettings.Location = new System.Drawing.Point(722, 465);
            this.ImageSettings.Name = "ImageSettings";
            this.ImageSettings.Size = new System.Drawing.Size(30, 29);
            this.ImageSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageSettings.TabIndex = 22;
            this.ImageSettings.TabStop = false;
            this.ImageSettings.Click += new System.EventHandler(this.ImageSettings_Click);
            this.ImageSettings.MouseEnter += new System.EventHandler(this.ImageSettings_MouseEnter);
            this.ImageSettings.MouseLeave += new System.EventHandler(this.ImageSettings_MouseLeave);
            // 
            // LinkSite
            // 
            this.LinkSite.BackColor = System.Drawing.Color.Transparent;
            this.LinkSite.BaseColor = System.Drawing.Color.White;
            this.LinkSite.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LinkSite.Image = ((System.Drawing.Image)(resources.GetObject("LinkSite.Image")));
            this.LinkSite.Location = new System.Drawing.Point(687, 465);
            this.LinkSite.Name = "LinkSite";
            this.LinkSite.Size = new System.Drawing.Size(29, 29);
            this.LinkSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinkSite.TabIndex = 23;
            this.LinkSite.TabStop = false;
            this.LinkSite.Click += new System.EventHandler(this.ImageHelper_Click);
            this.LinkSite.MouseEnter += new System.EventHandler(this.LinkSite_MouseEnter);
            this.LinkSite.MouseLeave += new System.EventHandler(this.LinkSite_MouseLeave);
            // 
            // FormElipseControl
            // 
            this.FormElipseControl.Radius = 1;
            this.FormElipseControl.TargetControl = this;
            // 
            // DControlForm
            // 
            this.DControlForm.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(672, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.DodgerBlue;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox1.TabIndex = 26;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.IconColor = System.Drawing.Color.White;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(717, 1);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.OrangeRed;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox2.TabIndex = 27;
            // 
            // Header
            // 
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.gunaControlBox2);
            this.Header.Controls.Add(this.gunaControlBox1);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(764, 28);
            this.Header.TabIndex = 28;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BaseColor = System.Drawing.Color.White;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(15, 7);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(112, 18);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 29;
            this.Logo.TabStop = false;
            // 
            // DControlHead
            // 
            this.DControlHead.TargetControl = this.Header;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Desktop Soft";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WindowIcon_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Укажите папку, откуда будем получать файлы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Укажите папку, куда будем отправлять файлы";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.AnimationHoverSpeed = 0.07F;
            this.ButtonCopy.AnimationSpeed = 0.03F;
            this.ButtonCopy.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCopy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ButtonCopy.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonCopy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonCopy.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonCopy.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.ButtonCopy.Image = global::DesktopCopy1.Properties.Resources.cut_out;
            this.ButtonCopy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCopy.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCopy.Location = new System.Drawing.Point(77, 277);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ButtonCopy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCopy.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCopy.OnHoverImage = global::DesktopCopy1.Properties.Resources.cut;
            this.ButtonCopy.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCopy.OnPressedDepth = 90;
            this.ButtonCopy.Radius = 10;
            this.ButtonCopy.Size = new System.Drawing.Size(241, 43);
            this.ButtonCopy.TabIndex = 0;
            this.ButtonCopy.Text = "Копировать";
            this.ButtonCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // CheckOutputFiles
            // 
            this.CheckOutputFiles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckOutputFiles.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckOutputFiles.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckOutputFiles.FillColor = System.Drawing.Color.White;
            this.CheckOutputFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckOutputFiles.Location = new System.Drawing.Point(372, 111);
            this.CheckOutputFiles.Name = "CheckOutputFiles";
            this.CheckOutputFiles.Size = new System.Drawing.Size(111, 20);
            this.CheckOutputFiles.TabIndex = 1;
            this.CheckOutputFiles.Text = "Use OutputFiles";
            this.CheckOutputFiles.CheckedChanged += new System.EventHandler(this.CheckOutputFiles_CheckedChanged);
            // 
            // DControlLogo
            // 
            this.DControlLogo.TargetControl = this.Logo;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = null;
            // 
            // PanelHide
            // 
            this.PanelHide.Controls.Add(this.label1);
            this.PanelHide.Location = new System.Drawing.Point(0, 185);
            this.PanelHide.Name = "PanelHide";
            this.PanelHide.Size = new System.Drawing.Size(764, 71);
            this.PanelHide.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "По умолчанию папки создаются там, откуда указали путь. \r\nДля того, чтобы использо" +
    "вать другой путь поставьте галочку \"Use OutputFiles\".\r\n";
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationPanel.Controls.Add(this.NotificationLabel);
            this.NotificationPanel.LineColor = System.Drawing.Color.Black;
            this.NotificationPanel.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.NotificationPanel.Location = new System.Drawing.Point(12, 465);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(657, 29);
            this.NotificationPanel.TabIndex = 32;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotificationLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.NotificationLabel.Location = new System.Drawing.Point(62, 5);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(140, 17);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Тестовое сообщение!";
            this.NotificationLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.NotificationPanel);
            this.Controls.Add(this.PanelHide);
            this.Controls.Add(this.CheckOutputFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkSite);
            this.Controls.Add(this.ImageSettings);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.ImageDialog2);
            this.Controls.Add(this.ImageDialog1);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.ButtonCut);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Sort";
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelHide.ResumeLayout(false);
            this.PanelHide.PerformLayout();
            this.NotificationPanel.ResumeLayout(false);
            this.NotificationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox ImageDialog1;
        private PictureBox ImageDialog2;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem AboutToolStrip;
        private ToolStripMenuItem CloseToolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ShowHidetoolStrip;
        private BetterFolderBrowser FolderDialog1;
        private Guna.UI.WinForms.GunaLineTextBox Edit1;
        private Guna.UI.WinForms.GunaLineTextBox Edit2;
        private Guna.UI.WinForms.GunaButton ButtonCut;
        private Guna.UI.WinForms.GunaPictureBox ImageSettings;
        private Guna.UI.WinForms.GunaPictureBox LinkSite;
        private Guna.UI.WinForms.GunaElipse FormElipseControl;
        private Guna.UI.WinForms.GunaDragControl DControlForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaPanel Header;
        private Guna.UI.WinForms.GunaDragControl DControlHead;
        private Guna.UI.WinForms.GunaPictureBox Logo;
        private NotifyIcon notifyIcon1;
        private Label label4;
        private Label label2;
        private Guna.UI.WinForms.GunaButton ButtonCopy;
        private Guna.UI.WinForms.GunaCheckBox CheckOutputFiles;
        private Guna.UI.WinForms.GunaDragControl DControlLogo;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Guna.UI.WinForms.GunaPanel PanelHide;
        private Label label1;
        private Guna.UI.WinForms.GunaLinePanel NotificationPanel;
        private Guna.UI.WinForms.GunaLabel NotificationLabel;
        private Timer timer1;
    }
}

