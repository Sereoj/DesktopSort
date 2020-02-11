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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.label1 = new Label();
            this.Edit1 = new TextBox();
            this.Edit2 = new TextBox();
            this.label2 = new Label();
            this.ButtonCopy = new Button();
            this.label3 = new Label();
            this.LinkSite = new LinkLabel();
            this.ImageHelper = new PictureBox();
            this.panel1 = new Panel();
            this.DublicateNameForm = new Label();
            this.PanelClose = new Button();
            this.label6 = new Label();
            this.label5 = new Label();
            this.HeadText = new Label();
            this.ButtonCut = new Button();
            this.ImageDialog1 = new PictureBox();
            this.ImageDialog2 = new PictureBox();
            this.WindowIcon = new NotifyIcon(this.components);
            this.contextMenu = new ContextMenuStrip(this.components);
            this.ShowHidetoolStrip = new ToolStripMenuItem();
            this.AboutToolStrip = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.CloseToolStrip = new ToolStripMenuItem();
            this.DocLink = new LinkLabel();
            this.ImageSettings = new PictureBox();
            this.FolderDialog1 = new BetterFolderBrowser(this.components);
            ((ISupportInitialize)(this.ImageHelper)).BeginInit();
            this.panel1.SuspendLayout();
            ((ISupportInitialize)(this.ImageDialog1)).BeginInit();
            ((ISupportInitialize)(this.ImageDialog2)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((ISupportInitialize)(this.ImageSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = Color.Orange;
            this.label1.Location = new Point(12, 38);
            this.label1.Margin = new Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первичный вход";
            // 
            // Edit1
            // 
            this.Edit1.Location = new Point(8, 54);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new Size(298, 20);
            this.Edit1.TabIndex = 1;
            // 
            // Edit2
            // 
            this.Edit2.Location = new Point(8, 94);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new Size(298, 20);
            this.Edit2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = Color.Orange;
            this.label2.Location = new Point(12, 78);
            this.label2.Margin = new Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вторичный вход";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCopy.ForeColor = Color.Black;
            this.ButtonCopy.Location = new Point(8, 127);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new Size(160, 25);
            this.ButtonCopy.TabIndex = 4;
            this.ButtonCopy.Text = "Копирование";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new EventHandler(this.ButtonCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Transparent;
            this.label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = Color.Orange;
            this.label3.Location = new Point(50, 12);
            this.label3.Margin = new Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new Size(223, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Быстрая сортировка файлов по папкам.";
            // 
            // LinkSite
            // 
            this.LinkSite.ActiveLinkColor = Color.CornflowerBlue;
            this.LinkSite.AutoSize = true;
            this.LinkSite.BackColor = Color.Transparent;
            this.LinkSite.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(204)));
            this.LinkSite.LinkColor = Color.RoyalBlue;
            this.LinkSite.Location = new Point(279, 12);
            this.LinkSite.Margin = new Padding(3);
            this.LinkSite.Name = "LinkSite";
            this.LinkSite.Size = new Size(54, 13);
            this.LinkSite.TabIndex = 6;
            this.LinkSite.TabStop = true;
            this.LinkSite.Text = "2World.ru";
            this.LinkSite.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkSite_LinkClicked);
            // 
            // ImageHelper
            // 
            this.ImageHelper.BackColor = Color.Transparent;
            this.ImageHelper.Cursor = Cursors.Help;
            this.ImageHelper.Image = ((Image)(resources.GetObject("ImageHelper.Image")));
            this.ImageHelper.Location = new Point(15, 174);
            this.ImageHelper.Name = "ImageHelper";
            this.ImageHelper.Size = new Size(16, 16);
            this.ImageHelper.SizeMode = PictureBoxSizeMode.CenterImage;
            this.ImageHelper.TabIndex = 8;
            this.ImageHelper.TabStop = false;
            this.ImageHelper.Click += new EventHandler(this.ImageHelper_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.Transparent;
            this.panel1.Controls.Add(this.DublicateNameForm);
            this.panel1.Controls.Add(this.PanelClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HeadText);
            this.panel1.Location = new Point(8, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(329, 137);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // DublicateNameForm
            // 
            this.DublicateNameForm.AutoSize = true;
            this.DublicateNameForm.Location = new Point(24, 86);
            this.DublicateNameForm.Name = "DublicateNameForm";
            this.DublicateNameForm.Size = new Size(0, 13);
            this.DublicateNameForm.TabIndex = 4;
            // 
            // PanelClose
            // 
            this.PanelClose.Location = new Point(19, 103);
            this.PanelClose.Name = "PanelClose";
            this.PanelClose.Size = new Size(144, 23);
            this.PanelClose.TabIndex = 3;
            this.PanelClose.Text = "Закрыть";
            this.PanelClose.UseVisualStyleBackColor = true;
            this.PanelClose.Click += new EventHandler(this.PanelClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(113)))), ((int)(((byte)(17)))));
            this.label6.Location = new Point(174, 114);
            this.label6.Name = "label6";
            this.label6.Size = new Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "2World © 2020 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(113)))), ((int)(((byte)(17)))));
            this.label5.Location = new Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new Size(126, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "✸Сергей Алексеевич✸";
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.ForeColor = Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(127)))), ((int)(((byte)(49)))));
            this.HeadText.Location = new Point(20, 10);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new Size(221, 21);
            this.HeadText.TabIndex = 0;
            this.HeadText.Text = "Огромное  благодарность.";
            // 
            // ButtonCut
            // 
            this.ButtonCut.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCut.ForeColor = Color.Black;
            this.ButtonCut.Location = new Point(170, 127);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.Size = new Size(160, 25);
            this.ButtonCut.TabIndex = 10;
            this.ButtonCut.Text = "Вырезание";
            this.ButtonCut.UseVisualStyleBackColor = true;
            this.ButtonCut.Click += new EventHandler(this.ButtonCut_Click);
            // 
            // ImageDialog1
            // 
            this.ImageDialog1.BackColor = Color.Transparent;
            this.ImageDialog1.Cursor = Cursors.Hand;
            this.ImageDialog1.Image = ((Image)(resources.GetObject("ImageDialog1.Image")));
            this.ImageDialog1.Location = new Point(314, 54);
            this.ImageDialog1.Name = "ImageDialog1";
            this.ImageDialog1.Padding = new Padding(0, 3, 0, 0);
            this.ImageDialog1.Size = new Size(16, 19);
            this.ImageDialog1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.ImageDialog1.TabIndex = 11;
            this.ImageDialog1.TabStop = false;
            this.ImageDialog1.Click += new EventHandler(this.ImageDialog1_Click);
            this.ImageDialog1.MouseEnter += new EventHandler(this.ImageDialog1_MouseEnter);
            this.ImageDialog1.MouseLeave += new EventHandler(this.ImageDialog1_MouseLeave);
            // 
            // ImageDialog2
            // 
            this.ImageDialog2.BackColor = Color.Transparent;
            this.ImageDialog2.Cursor = Cursors.Hand;
            this.ImageDialog2.Image = ((Image)(resources.GetObject("ImageDialog2.Image")));
            this.ImageDialog2.Location = new Point(314, 94);
            this.ImageDialog2.Name = "ImageDialog2";
            this.ImageDialog2.Padding = new Padding(0, 3, 0, 0);
            this.ImageDialog2.Size = new Size(16, 19);
            this.ImageDialog2.SizeMode = PictureBoxSizeMode.AutoSize;
            this.ImageDialog2.TabIndex = 12;
            this.ImageDialog2.TabStop = false;
            this.ImageDialog2.Click += new EventHandler(this.ImageDialog2_Click);
            this.ImageDialog2.MouseEnter += new EventHandler(this.ImageDialog2_MouseEnter);
            this.ImageDialog2.MouseLeave += new EventHandler(this.ImageDialog2_MouseLeave);
            // 
            // WindowIcon
            // 
            this.WindowIcon.BalloonTipIcon = ToolTipIcon.Info;
            this.WindowIcon.BalloonTipText = "123";
            this.WindowIcon.BalloonTipTitle = "1234";
            this.WindowIcon.ContextMenuStrip = this.contextMenu;
            this.WindowIcon.Icon = ((Icon)(resources.GetObject("WindowIcon.Icon")));
            this.WindowIcon.Text = "DesktopCopy";
            this.WindowIcon.Visible = true;
            this.WindowIcon.MouseDoubleClick += new MouseEventHandler(this.WindowIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = SystemColors.ButtonFace;
            this.contextMenu.ImeMode = ImeMode.NoControl;
            this.contextMenu.Items.AddRange(new ToolStripItem[] {
            this.ShowHidetoolStrip,
            this.AboutToolStrip,
            this.toolStripSeparator1,
            this.CloseToolStrip});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new Size(171, 76);
            // 
            // ShowHidetoolStrip
            // 
            this.ShowHidetoolStrip.Image = ((Image)(resources.GetObject("ShowHidetoolStrip.Image")));
            this.ShowHidetoolStrip.Name = "ShowHidetoolStrip";
            this.ShowHidetoolStrip.Size = new Size(170, 22);
            this.ShowHidetoolStrip.Text = "Показать\\Скрыть";
            this.ShowHidetoolStrip.Click += new EventHandler(this.ShowHidetoolStrip_Click);
            // 
            // AboutToolStrip
            // 
            this.AboutToolStrip.CheckOnClick = true;
            this.AboutToolStrip.Image = ((Image)(resources.GetObject("AboutToolStrip.Image")));
            this.AboutToolStrip.Name = "AboutToolStrip";
            this.AboutToolStrip.Size = new Size(170, 22);
            this.AboutToolStrip.Text = "О проекте";
            this.AboutToolStrip.TextAlign = ContentAlignment.MiddleLeft;
            this.AboutToolStrip.Click += new EventHandler(this.AboutToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(167, 6);
            // 
            // CloseToolStrip
            // 
            this.CloseToolStrip.Image = ((Image)(resources.GetObject("CloseToolStrip.Image")));
            this.CloseToolStrip.Name = "CloseToolStrip";
            this.CloseToolStrip.Size = new Size(170, 22);
            this.CloseToolStrip.Text = "Закрыть";
            this.CloseToolStrip.Click += new EventHandler(this.CloseToolStrip_Click);
            // 
            // DocLink
            // 
            this.DocLink.ActiveLinkColor = Color.CornflowerBlue;
            this.DocLink.AutoSize = true;
            this.DocLink.BackColor = Color.Transparent;
            this.DocLink.CausesValidation = false;
            this.DocLink.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.DocLink.ForeColor = Color.RoyalBlue;
            this.DocLink.LinkColor = Color.RoyalBlue;
            this.DocLink.Location = new Point(37, 174);
            this.DocLink.Name = "DocLink";
            this.DocLink.Size = new Size(91, 17);
            this.DocLink.TabIndex = 13;
            this.DocLink.TabStop = true;
            this.DocLink.Text = "Документация";
            // 
            // ImageSettings
            // 
            this.ImageSettings.BackColor = Color.Transparent;
            this.ImageSettings.Image = ((Image)(resources.GetObject("ImageSettings.Image")));
            this.ImageSettings.Location = new Point(302, 164);
            this.ImageSettings.Name = "ImageSettings";
            this.ImageSettings.Size = new Size(32, 32);
            this.ImageSettings.SizeMode = PictureBoxSizeMode.CenterImage;
            this.ImageSettings.TabIndex = 14;
            this.ImageSettings.TabStop = false;
            this.ImageSettings.Click += new EventHandler(this.ImageSettings_Click);
            this.ImageSettings.MouseEnter += new EventHandler(this.ImageSettings_MouseEnter);
            this.ImageSettings.MouseLeave += new EventHandler(this.ImageSettings_MouseLeave);
            // 
            // FolderDialog1
            // 
            this.FolderDialog1.Multiselect = false;
            this.FolderDialog1.RootFolder = "C:\\";
            this.FolderDialog1.Title = "Please select a folder...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = ImageLayout.Center;
            this.ClientSize = new Size(344, 210);
            this.Controls.Add(this.ImageSettings);
            this.Controls.Add(this.DocLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImageHelper);
            this.Controls.Add(this.LinkSite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCut);
            this.Controls.Add(this.ImageDialog2);
            this.Controls.Add(this.ImageDialog1);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DesktopCopy[v 0.0.3]";
            ((ISupportInitialize)(this.ImageHelper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((ISupportInitialize)(this.ImageDialog1)).EndInit();
            ((ISupportInitialize)(this.ImageDialog2)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((ISupportInitialize)(this.ImageSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Edit1;
        private TextBox Edit2;
        private Label label2;
        private Button ButtonCopy;
        private Label label3;
        private LinkLabel LinkSite;
        private PictureBox ImageHelper;
        private Panel panel1;
        private Button PanelClose;
        private Label label6;
        private Label label5;
        private Label HeadText;
        private Label DublicateNameForm;
        private Button ButtonCut;
        private PictureBox ImageDialog1;
        private PictureBox ImageDialog2;
        private NotifyIcon WindowIcon;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem AboutToolStrip;
        private ToolStripMenuItem CloseToolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ShowHidetoolStrip;
        private LinkLabel DocLink;
        private PictureBox ImageSettings;
        private BetterFolderBrowser FolderDialog1;
    }
}

