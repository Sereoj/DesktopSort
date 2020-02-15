using System.ComponentModel;
using System.Windows.Forms;

namespace DesktopCopy1.Views
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CheckWord = new System.Windows.Forms.CheckBox();
            this.CheckExcel = new System.Windows.Forms.CheckBox();
            this.CheckAccess = new System.Windows.Forms.CheckBox();
            this.CheckProject = new System.Windows.Forms.CheckBox();
            this.CheckImage = new System.Windows.Forms.CheckBox();
            this.CheckTextDoc = new System.Windows.Forms.CheckBox();
            this.CheckArchive = new System.Windows.Forms.CheckBox();
            this.CheckPDF = new System.Windows.Forms.CheckBox();
            this.CheckMedia = new System.Windows.Forms.CheckBox();
            this.CheckOtherDir = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TextDirectory = new System.Windows.Forms.TextBox();
            this.TextFormats = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDefault = new System.Windows.Forms.Button();
            this.BtnChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckWord
            // 
            this.CheckWord.AutoSize = true;
            this.CheckWord.BackColor = System.Drawing.Color.Transparent;
            this.CheckWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckWord.ForeColor = System.Drawing.Color.Orange;
            this.CheckWord.Location = new System.Drawing.Point(15, 38);
            this.CheckWord.Name = "CheckWord";
            this.CheckWord.Size = new System.Drawing.Size(99, 19);
            this.CheckWord.TabIndex = 0;
            this.CheckWord.Text = "Microsoft Word";
            this.CheckWord.UseVisualStyleBackColor = false;
            this.CheckWord.CheckedChanged += new System.EventHandler(this.CheckWord_CheckedChanged);
            // 
            // CheckExcel
            // 
            this.CheckExcel.AutoSize = true;
            this.CheckExcel.BackColor = System.Drawing.Color.Transparent;
            this.CheckExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckExcel.ForeColor = System.Drawing.Color.Orange;
            this.CheckExcel.Location = new System.Drawing.Point(15, 65);
            this.CheckExcel.Name = "CheckExcel";
            this.CheckExcel.Size = new System.Drawing.Size(99, 19);
            this.CheckExcel.TabIndex = 1;
            this.CheckExcel.Text = "Microsoft Excel";
            this.CheckExcel.UseVisualStyleBackColor = false;
            this.CheckExcel.CheckedChanged += new System.EventHandler(this.CheckExcel_CheckedChanged);
            // 
            // CheckAccess
            // 
            this.CheckAccess.AutoSize = true;
            this.CheckAccess.BackColor = System.Drawing.Color.Transparent;
            this.CheckAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckAccess.ForeColor = System.Drawing.Color.Orange;
            this.CheckAccess.Location = new System.Drawing.Point(15, 91);
            this.CheckAccess.Name = "CheckAccess";
            this.CheckAccess.Size = new System.Drawing.Size(107, 19);
            this.CheckAccess.TabIndex = 2;
            this.CheckAccess.Text = "Microsoft Access";
            this.CheckAccess.UseVisualStyleBackColor = false;
            this.CheckAccess.CheckedChanged += new System.EventHandler(this.CheckAccess_CheckedChanged);
            // 
            // CheckProject
            // 
            this.CheckProject.AutoSize = true;
            this.CheckProject.BackColor = System.Drawing.Color.Transparent;
            this.CheckProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckProject.ForeColor = System.Drawing.Color.Orange;
            this.CheckProject.Location = new System.Drawing.Point(136, 38);
            this.CheckProject.Name = "CheckProject";
            this.CheckProject.Size = new System.Drawing.Size(109, 19);
            this.CheckProject.TabIndex = 3;
            this.CheckProject.Text = "Microsoft Project";
            this.CheckProject.UseVisualStyleBackColor = false;
            this.CheckProject.CheckedChanged += new System.EventHandler(this.CheckProject_CheckedChanged);
            // 
            // CheckImage
            // 
            this.CheckImage.AutoSize = true;
            this.CheckImage.BackColor = System.Drawing.Color.Transparent;
            this.CheckImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckImage.ForeColor = System.Drawing.Color.Orange;
            this.CheckImage.Location = new System.Drawing.Point(136, 65);
            this.CheckImage.Name = "CheckImage";
            this.CheckImage.Size = new System.Drawing.Size(82, 19);
            this.CheckImage.TabIndex = 4;
            this.CheckImage.Text = "Image Files";
            this.CheckImage.UseVisualStyleBackColor = false;
            this.CheckImage.CheckedChanged += new System.EventHandler(this.CheckImage_CheckedChanged);
            // 
            // CheckTextDoc
            // 
            this.CheckTextDoc.AutoSize = true;
            this.CheckTextDoc.BackColor = System.Drawing.Color.Transparent;
            this.CheckTextDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckTextDoc.ForeColor = System.Drawing.Color.Orange;
            this.CheckTextDoc.Location = new System.Drawing.Point(136, 91);
            this.CheckTextDoc.Name = "CheckTextDoc";
            this.CheckTextDoc.Size = new System.Drawing.Size(103, 19);
            this.CheckTextDoc.TabIndex = 5;
            this.CheckTextDoc.Text = "Text Documents";
            this.CheckTextDoc.UseVisualStyleBackColor = false;
            this.CheckTextDoc.CheckedChanged += new System.EventHandler(this.CheckTextDoc_CheckedChanged);
            // 
            // CheckArchive
            // 
            this.CheckArchive.AutoSize = true;
            this.CheckArchive.BackColor = System.Drawing.Color.Transparent;
            this.CheckArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckArchive.Enabled = false;
            this.CheckArchive.ForeColor = System.Drawing.Color.Orange;
            this.CheckArchive.Location = new System.Drawing.Point(269, 38);
            this.CheckArchive.Name = "CheckArchive";
            this.CheckArchive.Size = new System.Drawing.Size(64, 19);
            this.CheckArchive.TabIndex = 6;
            this.CheckArchive.Text = "Архивы";
            this.CheckArchive.UseVisualStyleBackColor = false;
            this.CheckArchive.CheckedChanged += new System.EventHandler(this.CheckArchive_CheckedChanged);
            // 
            // CheckPDF
            // 
            this.CheckPDF.AutoSize = true;
            this.CheckPDF.BackColor = System.Drawing.Color.Transparent;
            this.CheckPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPDF.ForeColor = System.Drawing.Color.Orange;
            this.CheckPDF.Location = new System.Drawing.Point(15, 118);
            this.CheckPDF.Name = "CheckPDF";
            this.CheckPDF.Size = new System.Drawing.Size(94, 19);
            this.CheckPDF.TabIndex = 7;
            this.CheckPDF.Text = "Microsoft PDF";
            this.CheckPDF.UseVisualStyleBackColor = false;
            this.CheckPDF.Visible = false;
            this.CheckPDF.CheckedChanged += new System.EventHandler(this.CheckPDF_CheckedChanged);
            // 
            // CheckMedia
            // 
            this.CheckMedia.AutoSize = true;
            this.CheckMedia.BackColor = System.Drawing.Color.Transparent;
            this.CheckMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckMedia.Enabled = false;
            this.CheckMedia.ForeColor = System.Drawing.Color.Orange;
            this.CheckMedia.Location = new System.Drawing.Point(269, 65);
            this.CheckMedia.Name = "CheckMedia";
            this.CheckMedia.Size = new System.Drawing.Size(111, 19);
            this.CheckMedia.TabIndex = 8;
            this.CheckMedia.Text = "MP3, MP4 файлы";
            this.CheckMedia.UseVisualStyleBackColor = false;
            this.CheckMedia.CheckedChanged += new System.EventHandler(this.CheckMedia_CheckedChanged);
            // 
            // CheckOtherDir
            // 
            this.CheckOtherDir.AutoSize = true;
            this.CheckOtherDir.BackColor = System.Drawing.Color.Transparent;
            this.CheckOtherDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOtherDir.Enabled = false;
            this.CheckOtherDir.ForeColor = System.Drawing.Color.Orange;
            this.CheckOtherDir.Location = new System.Drawing.Point(269, 91);
            this.CheckOtherDir.Name = "CheckOtherDir";
            this.CheckOtherDir.Size = new System.Drawing.Size(111, 19);
            this.CheckOtherDir.TabIndex = 9;
            this.CheckOtherDir.Text = "Отдельные папки";
            this.CheckOtherDir.UseVisualStyleBackColor = false;
            this.CheckOtherDir.CheckedChanged += new System.EventHandler(this.CheckOtherDir_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Форматы";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(266, 321);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(109, 32);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextDirectory
            // 
            this.TextDirectory.Location = new System.Drawing.Point(5, 230);
            this.TextDirectory.Name = "TextDirectory";
            this.TextDirectory.Size = new System.Drawing.Size(271, 20);
            this.TextDirectory.TabIndex = 14;
            // 
            // TextFormats
            // 
            this.TextFormats.Location = new System.Drawing.Point(5, 256);
            this.TextFormats.Name = "TextFormats";
            this.TextFormats.Size = new System.Drawing.Size(271, 20);
            this.TextFormats.TabIndex = 14;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(5, 321);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(146, 32);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Проверить обновление";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.Location = new System.Drawing.Point(5, 282);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.Size = new System.Drawing.Size(146, 32);
            this.BtnDefault.TabIndex = 13;
            this.BtnDefault.Text = "По умолчанию";
            this.BtnDefault.UseVisualStyleBackColor = true;
            this.BtnDefault.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnChanger
            // 
            this.BtnChanger.Location = new System.Drawing.Point(282, 230);
            this.BtnChanger.Name = "BtnChanger";
            this.BtnChanger.Size = new System.Drawing.Size(93, 46);
            this.BtnChanger.TabIndex = 15;
            this.BtnChanger.Text = "Изменить";
            this.BtnChanger.UseVisualStyleBackColor = true;
            this.BtnChanger.Click += new System.EventHandler(this.BtnChanger_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 367);
            this.Controls.Add(this.BtnChanger);
            this.Controls.Add(this.TextFormats);
            this.Controls.Add(this.TextDirectory);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckOtherDir);
            this.Controls.Add(this.CheckMedia);
            this.Controls.Add(this.CheckPDF);
            this.Controls.Add(this.CheckArchive);
            this.Controls.Add(this.CheckTextDoc);
            this.Controls.Add(this.CheckImage);
            this.Controls.Add(this.CheckProject);
            this.Controls.Add(this.CheckAccess);
            this.Controls.Add(this.CheckExcel);
            this.Controls.Add(this.CheckWord);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "Настройки программы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox CheckWord;
        private CheckBox CheckExcel;
        private CheckBox CheckAccess;
        private CheckBox CheckProject;
        private CheckBox CheckImage;
        private CheckBox CheckTextDoc;
        private CheckBox CheckArchive;
        private CheckBox CheckPDF;
        private CheckBox CheckMedia;
        private CheckBox CheckOtherDir;
        private Label label2;
        private Button BtnSave;
        private TextBox TextDirectory;
        private TextBox TextFormats;
        private Button BtnUpdate;
        private Button BtnDefault;
        private Button BtnChanger;
    }
}