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
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FormElipseControl = new Guna.UI.WinForms.GunaElipse(this.components);
            this.DControlForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.Header = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.DControlHead = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageDialog1
            // 
            this.ImageDialog1.BackColor = System.Drawing.Color.Transparent;
            this.ImageDialog1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDialog1.Image = ((System.Drawing.Image)(resources.GetObject("ImageDialog1.Image")));
            this.ImageDialog1.Location = new System.Drawing.Point(698, 143);
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
            this.ImageDialog2.Location = new System.Drawing.Point(698, 194);
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
            this.Edit2.Location = new System.Drawing.Point(41, 185);
            this.Edit2.Name = "Edit2";
            this.Edit2.PasswordChar = '\0';
            this.Edit2.Size = new System.Drawing.Size(651, 36);
            this.Edit2.TabIndex = 16;
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
            this.ButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCut.Image")));
            this.ButtonCut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonCut.Location = new System.Drawing.Point(41, 272);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.ButtonCut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ButtonCut.OnHoverForeColor = System.Drawing.Color.White;
            this.ButtonCut.OnHoverImage = null;
            this.ButtonCut.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonCut.Radius = 10;
            this.ButtonCut.Size = new System.Drawing.Size(241, 43);
            this.ButtonCut.TabIndex = 18;
            this.ButtonCut.Text = "Переместить";
            this.ButtonCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // ImageSettings
            // 
            this.ImageSettings.BackColor = System.Drawing.Color.Transparent;
            this.ImageSettings.BaseColor = System.Drawing.Color.White;
            this.ImageSettings.Image = ((System.Drawing.Image)(resources.GetObject("ImageSettings.Image")));
            this.ImageSettings.Location = new System.Drawing.Point(720, 423);
            this.ImageSettings.Name = "ImageSettings";
            this.ImageSettings.Size = new System.Drawing.Size(30, 29);
            this.ImageSettings.TabIndex = 22;
            this.ImageSettings.TabStop = false;
            this.ImageSettings.Click += new System.EventHandler(this.ImageSettings_Click);
            // 
            // LinkSite
            // 
            this.LinkSite.BackColor = System.Drawing.Color.Transparent;
            this.LinkSite.BaseColor = System.Drawing.Color.White;
            this.LinkSite.Image = ((System.Drawing.Image)(resources.GetObject("LinkSite.Image")));
            this.LinkSite.Location = new System.Drawing.Point(596, 3);
            this.LinkSite.Name = "LinkSite";
            this.LinkSite.Size = new System.Drawing.Size(29, 29);
            this.LinkSite.TabIndex = 23;
            this.LinkSite.TabStop = false;
            this.LinkSite.Click += new System.EventHandler(this.ImageHelper_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(717, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "label1";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.LinkSite);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Location = new System.Drawing.Point(0, 458);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(765, 48);
            this.gunaPanel1.TabIndex = 25;
            this.gunaPanel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.Header.Controls.Add(this.gunaPictureBox1);
            this.Header.Controls.Add(this.gunaControlBox2);
            this.Header.Controls.Add(this.gunaControlBox1);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(764, 28);
            this.Header.TabIndex = 28;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(15, 7);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(112, 18);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 29;
            this.gunaPictureBox1.TabStop = false;
            // 
            // DControlHead
            // 
            this.DControlHead.TargetControl = this.Header;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WindowIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.ImageSettings);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.ImageDialog2);
            this.Controls.Add(this.ImageDialog1);
            this.Controls.Add(this.ButtonCut);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DesktopCopy[v 0.0.3]";
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkSite)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
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
        private Label label3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Label label1;
        private Guna.UI.WinForms.GunaElipse FormElipseControl;
        private Guna.UI.WinForms.GunaDragControl DControlForm;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaPanel Header;
        private Guna.UI.WinForms.GunaDragControl DControlHead;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private NotifyIcon notifyIcon1;
    }
}

