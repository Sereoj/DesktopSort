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
            this.WindowIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowHidetoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDialog1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.Edit1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.Edit2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.ButtonCopy = new Guna.UI.WinForms.GunaButton();
            this.ButtonCut = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.label3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox4 = new Guna.UI.WinForms.GunaPictureBox();
            this.ImageSettings = new Guna.UI.WinForms.GunaPictureBox();
            this.LinkSite = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageDialog1
            // 
            this.ImageDialog1.BackColor = System.Drawing.Color.Transparent;
            this.ImageDialog1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDialog1.Image = ((System.Drawing.Image)(resources.GetObject("ImageDialog1.Image")));
            this.ImageDialog1.Location = new System.Drawing.Point(716, 143);
            this.ImageDialog1.Name = "ImageDialog1";
            this.ImageDialog1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ImageDialog1.Size = new System.Drawing.Size(24, 27);
            this.ImageDialog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageDialog1.TabIndex = 11;
            this.ImageDialog1.TabStop = false;
            this.ImageDialog1.Click += new System.EventHandler(this.ImageDialog1_Click);
            this.ImageDialog1.MouseEnter += new System.EventHandler(this.ImageDialog1_MouseEnter);
            this.ImageDialog1.MouseLeave += new System.EventHandler(this.ImageDialog1_MouseLeave);
            // 
            // ImageDialog2
            // 
            this.ImageDialog2.BackColor = System.Drawing.Color.Transparent;
            this.ImageDialog2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDialog2.Image = ((System.Drawing.Image)(resources.GetObject("ImageDialog2.Image")));
            this.ImageDialog2.Location = new System.Drawing.Point(716, 194);
            this.ImageDialog2.Name = "ImageDialog2";
            this.ImageDialog2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ImageDialog2.Size = new System.Drawing.Size(24, 27);
            this.ImageDialog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageDialog2.TabIndex = 12;
            this.ImageDialog2.TabStop = false;
            this.ImageDialog2.Click += new System.EventHandler(this.ImageDialog2_Click);
            this.ImageDialog2.MouseEnter += new System.EventHandler(this.ImageDialog2_MouseEnter);
            this.ImageDialog2.MouseLeave += new System.EventHandler(this.ImageDialog2_MouseLeave);
            // 
            // WindowIcon
            // 
            this.WindowIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.WindowIcon.BalloonTipText = "123";
            this.WindowIcon.BalloonTipTitle = "1234";
            this.WindowIcon.ContextMenuStrip = this.contextMenu;
            this.WindowIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("WindowIcon.Icon")));
            this.WindowIcon.Text = "DesktopCopy";
            this.WindowIcon.Visible = true;
            this.WindowIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WindowIcon_MouseDoubleClick);
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
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(80, 506);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
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
            this.Edit1.Location = new System.Drawing.Point(80, 134);
            this.Edit1.Name = "Edit1";
            this.Edit1.PasswordChar = '\0';
            this.Edit1.Size = new System.Drawing.Size(630, 36);
            this.Edit1.TabIndex = 15;
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
            this.Edit2.Location = new System.Drawing.Point(80, 185);
            this.Edit2.Name = "Edit2";
            this.Edit2.PasswordChar = '\0';
            this.Edit2.Size = new System.Drawing.Size(630, 36);
            this.Edit2.TabIndex = 16;
            this.Edit2.Text = "C:\\Users\\Egorov\\Documents";
            this.Edit2.TextOffsetX = 10;
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
            this.ButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCopy.Image")));
            this.ButtonCopy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCopy.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCopy.Location = new System.Drawing.Point(110, 257);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ButtonCopy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCopy.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCopy.OnHoverImage = null;
            this.ButtonCopy.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCopy.Radius = 10;
            this.ButtonCopy.Size = new System.Drawing.Size(241, 43);
            this.ButtonCopy.TabIndex = 17;
            this.ButtonCopy.Text = "Копирование";
            this.ButtonCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
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
            this.ButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCut.Image")));
            this.ButtonCut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCut.Location = new System.Drawing.Point(429, 257);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ButtonCut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCut.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCut.OnHoverImage = null;
            this.ButtonCut.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCut.Radius = 10;
            this.ButtonCut.Size = new System.Drawing.Size(241, 43);
            this.ButtonCut.TabIndex = 18;
            this.ButtonCut.Text = "Вырезание";
            this.ButtonCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaButton3);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox3);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(110, 436);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(625, 63);
            this.gunaElipsePanel1.TabIndex = 20;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(507, 17);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 10;
            this.gunaButton3.Size = new System.Drawing.Size(100, 30);
            this.gunaButton3.TabIndex = 2;
            this.gunaButton3.Text = "Обновить";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(42, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Доступно новое обновление, пожалуйста обновите  ";
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox3.Image")));
            this.gunaPictureBox3.Location = new System.Drawing.Point(10, 22);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(20, 20);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox3.TabIndex = 0;
            this.gunaPictureBox3.TabStop = false;
            // 
            // gunaPictureBox4
            // 
            this.gunaPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox4.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox4.Image")));
            this.gunaPictureBox4.Location = new System.Drawing.Point(676, 9);
            this.gunaPictureBox4.Name = "gunaPictureBox4";
            this.gunaPictureBox4.Size = new System.Drawing.Size(83, 37);
            this.gunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox4.TabIndex = 21;
            this.gunaPictureBox4.TabStop = false;
            // 
            // ImageSettings
            // 
            this.ImageSettings.BackColor = System.Drawing.Color.Transparent;
            this.ImageSettings.BaseColor = System.Drawing.Color.White;
            this.ImageSettings.Image = ((System.Drawing.Image)(resources.GetObject("ImageSettings.Image")));
            this.ImageSettings.Location = new System.Drawing.Point(720, 12);
            this.ImageSettings.Name = "ImageSettings";
            this.ImageSettings.Size = new System.Drawing.Size(29, 29);
            this.ImageSettings.TabIndex = 22;
            this.ImageSettings.TabStop = false;
            this.ImageSettings.Click += new System.EventHandler(this.ImageSettings_Click);
            // 
            // LinkSite
            // 
            this.LinkSite.BackColor = System.Drawing.Color.Transparent;
            this.LinkSite.BaseColor = System.Drawing.Color.White;
            this.LinkSite.Image = ((System.Drawing.Image)(resources.GetObject("LinkSite.Image")));
            this.LinkSite.Location = new System.Drawing.Point(687, 13);
            this.LinkSite.Name = "LinkSite";
            this.LinkSite.Size = new System.Drawing.Size(30, 30);
            this.LinkSite.TabIndex = 23;
            this.LinkSite.TabStop = false;
            this.LinkSite.Click += new System.EventHandler(this.ImageHelper_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Image = ((System.Drawing.Image)(resources.GetObject("gunaLabel1.Image")));
            this.gunaLabel1.Location = new System.Drawing.Point(19, 474);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "0.0.0.6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.LinkSite);
            this.Controls.Add(this.ImageSettings);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.ImageDialog2);
            this.Controls.Add(this.ImageDialog1);
            this.Controls.Add(this.gunaPictureBox4);
            this.Controls.Add(this.ButtonCut);
            this.Controls.Add(this.ButtonCopy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DesktopCopy[v 0.0.3]";
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox ImageDialog1;
        private PictureBox ImageDialog2;
        private NotifyIcon WindowIcon;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem AboutToolStrip;
        private ToolStripMenuItem CloseToolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ShowHidetoolStrip;
        private BetterFolderBrowser FolderDialog1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox Edit1;
        private Guna.UI.WinForms.GunaLineTextBox Edit2;
        private Guna.UI.WinForms.GunaButton ButtonCopy;
        private Guna.UI.WinForms.GunaButton ButtonCut;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox4;
        private Guna.UI.WinForms.GunaPictureBox ImageSettings;
        private Guna.UI.WinForms.GunaPictureBox LinkSite;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

