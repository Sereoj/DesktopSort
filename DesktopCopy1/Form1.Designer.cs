namespace DesktopCopy1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkSite = new System.Windows.Forms.LinkLabel();
            this.ImageHelper = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DublicateNameForm = new System.Windows.Forms.Label();
            this.PanelClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeadText = new System.Windows.Forms.Label();
            this.ButtonCut = new System.Windows.Forms.Button();
            this.ImageDialog1 = new System.Windows.Forms.PictureBox();
            this.ImageDialog2 = new System.Windows.Forms.PictureBox();
            this.FolderDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.WindowIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowHidetoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHelper)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(127)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первичный вход";
            // 
            // Edit1
            // 
            this.Edit1.Location = new System.Drawing.Point(8, 54);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(298, 20);
            this.Edit1.TabIndex = 1;
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(8, 94);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(298, 20);
            this.Edit2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(127)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вторичный вход";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCopy.Location = new System.Drawing.Point(8, 127);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(152, 25);
            this.ButtonCopy.TabIndex = 4;
            this.ButtonCopy.Text = "Копирование";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(127)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Быстрая сортировка файлов по папкам.";
            // 
            // LinkSite
            // 
            this.LinkSite.AutoSize = true;
            this.LinkSite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkSite.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(95)))), ((int)(((byte)(171)))));
            this.LinkSite.Location = new System.Drawing.Point(279, 12);
            this.LinkSite.Margin = new System.Windows.Forms.Padding(3);
            this.LinkSite.Name = "LinkSite";
            this.LinkSite.Size = new System.Drawing.Size(54, 13);
            this.LinkSite.TabIndex = 6;
            this.LinkSite.TabStop = true;
            this.LinkSite.Text = "2World.ru";
            this.LinkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSite_LinkClicked);
            // 
            // ImageHelper
            // 
            this.ImageHelper.Image = ((System.Drawing.Image)(resources.GetObject("ImageHelper.Image")));
            this.ImageHelper.Location = new System.Drawing.Point(316, 174);
            this.ImageHelper.Name = "ImageHelper";
            this.ImageHelper.Size = new System.Drawing.Size(16, 16);
            this.ImageHelper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageHelper.TabIndex = 8;
            this.ImageHelper.TabStop = false;
            this.ImageHelper.Click += new System.EventHandler(this.ImageHelper_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DublicateNameForm);
            this.panel1.Controls.Add(this.PanelClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.HeadText);
            this.panel1.Location = new System.Drawing.Point(362, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 137);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // DublicateNameForm
            // 
            this.DublicateNameForm.AutoSize = true;
            this.DublicateNameForm.Location = new System.Drawing.Point(24, 86);
            this.DublicateNameForm.Name = "DublicateNameForm";
            this.DublicateNameForm.Size = new System.Drawing.Size(0, 13);
            this.DublicateNameForm.TabIndex = 4;
            // 
            // PanelClose
            // 
            this.PanelClose.Location = new System.Drawing.Point(19, 103);
            this.PanelClose.Name = "PanelClose";
            this.PanelClose.Size = new System.Drawing.Size(144, 23);
            this.PanelClose.TabIndex = 3;
            this.PanelClose.Text = "Закрыть";
            this.PanelClose.UseVisualStyleBackColor = true;
            this.PanelClose.Click += new System.EventHandler(this.PanelClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(113)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(174, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "2World © 2020 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(113)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(21, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "✸Сергей Алексеевич✸";
            // 
            // HeadText
            // 
            this.HeadText.AutoSize = true;
            this.HeadText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(127)))), ((int)(((byte)(49)))));
            this.HeadText.Location = new System.Drawing.Point(20, 10);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(221, 21);
            this.HeadText.TabIndex = 0;
            this.HeadText.Text = "Огромное  благодарность.";
            // 
            // ButtonCut
            // 
            this.ButtonCut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCut.Location = new System.Drawing.Point(162, 127);
            this.ButtonCut.Name = "ButtonCut";
            this.ButtonCut.Size = new System.Drawing.Size(170, 25);
            this.ButtonCut.TabIndex = 10;
            this.ButtonCut.Text = "Вырезание";
            this.ButtonCut.UseVisualStyleBackColor = true;
            this.ButtonCut.Click += new System.EventHandler(this.ButtonCut_Click);
            // 
            // ImageDialog1
            // 
            this.ImageDialog1.Image = ((System.Drawing.Image)(resources.GetObject("ImageDialog1.Image")));
            this.ImageDialog1.Location = new System.Drawing.Point(316, 54);
            this.ImageDialog1.Name = "ImageDialog1";
            this.ImageDialog1.Size = new System.Drawing.Size(16, 16);
            this.ImageDialog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageDialog1.TabIndex = 11;
            this.ImageDialog1.TabStop = false;
            this.ImageDialog1.Click += new System.EventHandler(this.ImageDialog1_Click);
            this.ImageDialog1.MouseEnter += new System.EventHandler(this.ImageDialog1_MouseEnter);
            this.ImageDialog1.MouseLeave += new System.EventHandler(this.ImageDialog1_MouseLeave);
            // 
            // ImageDialog2
            // 
            this.ImageDialog2.Image = ((System.Drawing.Image)(resources.GetObject("ImageDialog2.Image")));
            this.ImageDialog2.Location = new System.Drawing.Point(316, 94);
            this.ImageDialog2.Name = "ImageDialog2";
            this.ImageDialog2.Size = new System.Drawing.Size(16, 16);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(342, 200);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DesktopCopy[v 0.0.2]";
            ((System.ComponentModel.ISupportInitialize)(this.ImageHelper)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDialog2)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LinkSite;
        private System.Windows.Forms.PictureBox ImageHelper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PanelClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Label DublicateNameForm;
        private System.Windows.Forms.Button ButtonCut;
        private System.Windows.Forms.PictureBox ImageDialog1;
        private System.Windows.Forms.PictureBox ImageDialog2;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog1;
        private System.Windows.Forms.NotifyIcon WindowIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ShowHidetoolStrip;
    }
}

