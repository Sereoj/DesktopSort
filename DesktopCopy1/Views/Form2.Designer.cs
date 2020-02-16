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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.CheckWord = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.CheckExcel = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckAccess = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckProject = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckImage = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckTextDoc = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckArchive = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckPDF = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckMedia = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckOtherDir = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox11 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox12 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox13 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox14 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox15 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaCheckBox16 = new Guna.UI.WinForms.GunaCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextDirectory = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextFormats = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.BtnChanger = new Guna.UI.WinForms.GunaButton();
            this.BtnDefault = new Guna.UI.WinForms.GunaButton();
            this.BtnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.CheckProject);
            this.gunaPanel1.Controls.Add(this.CheckAccess);
            this.gunaPanel1.Controls.Add(this.CheckExcel);
            this.gunaPanel1.Controls.Add(this.CheckPDF);
            this.gunaPanel1.Controls.Add(this.CheckArchive);
            this.gunaPanel1.Controls.Add(this.CheckTextDoc);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox11);
            this.gunaPanel1.Controls.Add(this.CheckOtherDir);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox12);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox15);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox16);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox14);
            this.gunaPanel1.Controls.Add(this.gunaCheckBox13);
            this.gunaPanel1.Controls.Add(this.CheckMedia);
            this.gunaPanel1.Controls.Add(this.CheckImage);
            this.gunaPanel1.Controls.Add(this.CheckWord);
            this.gunaPanel1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaPanel1.Location = new System.Drawing.Point(136, 105);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(572, 152);
            this.gunaPanel1.TabIndex = 16;
            // 
            // CheckWord
            // 
            this.CheckWord.BaseColor = System.Drawing.Color.White;
            this.CheckWord.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckWord.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckWord.FillColor = System.Drawing.Color.White;
            this.CheckWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckWord.Location = new System.Drawing.Point(15, 36);
            this.CheckWord.Name = "CheckWord";
            this.CheckWord.Size = new System.Drawing.Size(120, 21);
            this.CheckWord.TabIndex = 0;
            this.CheckWord.Text = "Microsoft Word";
            this.CheckWord.CheckedChanged += new System.EventHandler(this.CheckWord_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel1.Location = new System.Drawing.Point(10, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(307, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Выберите необходимые форматы.\r\n";
            // 
            // CheckExcel
            // 
            this.CheckExcel.BaseColor = System.Drawing.Color.White;
            this.CheckExcel.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckExcel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckExcel.FillColor = System.Drawing.Color.White;
            this.CheckExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckExcel.Location = new System.Drawing.Point(15, 63);
            this.CheckExcel.Name = "CheckExcel";
            this.CheckExcel.Size = new System.Drawing.Size(117, 21);
            this.CheckExcel.TabIndex = 0;
            this.CheckExcel.Text = "Microsoft Excel";
            this.CheckExcel.CheckedChanged += new System.EventHandler(this.CheckExcel_CheckedChanged);
            // 
            // CheckAccess
            // 
            this.CheckAccess.BaseColor = System.Drawing.Color.White;
            this.CheckAccess.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckAccess.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckAccess.FillColor = System.Drawing.Color.White;
            this.CheckAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckAccess.Location = new System.Drawing.Point(15, 89);
            this.CheckAccess.Name = "CheckAccess";
            this.CheckAccess.Size = new System.Drawing.Size(127, 21);
            this.CheckAccess.TabIndex = 0;
            this.CheckAccess.Text = "Microsoft Access";
            this.CheckAccess.CheckedChanged += new System.EventHandler(this.CheckAccess_CheckedChanged);
            // 
            // CheckProject
            // 
            this.CheckProject.BaseColor = System.Drawing.Color.White;
            this.CheckProject.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckProject.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckProject.FillColor = System.Drawing.Color.White;
            this.CheckProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckProject.Location = new System.Drawing.Point(15, 115);
            this.CheckProject.Name = "CheckProject";
            this.CheckProject.Size = new System.Drawing.Size(128, 21);
            this.CheckProject.TabIndex = 0;
            this.CheckProject.Text = "Microsoft Project";
            this.CheckProject.CheckedChanged += new System.EventHandler(this.CheckProject_CheckedChanged);
            // 
            // CheckImage
            // 
            this.CheckImage.BaseColor = System.Drawing.Color.White;
            this.CheckImage.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckImage.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckImage.FillColor = System.Drawing.Color.White;
            this.CheckImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckImage.Location = new System.Drawing.Point(141, 36);
            this.CheckImage.Name = "CheckImage";
            this.CheckImage.Size = new System.Drawing.Size(95, 21);
            this.CheckImage.TabIndex = 0;
            this.CheckImage.Text = "Image Files";
            this.CheckImage.CheckedChanged += new System.EventHandler(this.CheckImage_CheckedChanged);
            // 
            // CheckTextDoc
            // 
            this.CheckTextDoc.BaseColor = System.Drawing.Color.White;
            this.CheckTextDoc.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckTextDoc.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckTextDoc.FillColor = System.Drawing.Color.White;
            this.CheckTextDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckTextDoc.Location = new System.Drawing.Point(141, 63);
            this.CheckTextDoc.Name = "CheckTextDoc";
            this.CheckTextDoc.Size = new System.Drawing.Size(124, 21);
            this.CheckTextDoc.TabIndex = 0;
            this.CheckTextDoc.Text = "Text Documents";
            this.CheckTextDoc.CheckedChanged += new System.EventHandler(this.CheckTextDoc_CheckedChanged);
            // 
            // CheckArchive
            // 
            this.CheckArchive.BaseColor = System.Drawing.Color.White;
            this.CheckArchive.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckArchive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckArchive.FillColor = System.Drawing.Color.White;
            this.CheckArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckArchive.Location = new System.Drawing.Point(141, 89);
            this.CheckArchive.Name = "CheckArchive";
            this.CheckArchive.Size = new System.Drawing.Size(76, 21);
            this.CheckArchive.TabIndex = 0;
            this.CheckArchive.Text = "Архивы";
            this.CheckArchive.CheckedChanged += new System.EventHandler(this.CheckArchive_CheckedChanged);
            // 
            // CheckPDF
            // 
            this.CheckPDF.BaseColor = System.Drawing.Color.White;
            this.CheckPDF.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckPDF.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckPDF.FillColor = System.Drawing.Color.White;
            this.CheckPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckPDF.Location = new System.Drawing.Point(141, 115);
            this.CheckPDF.Name = "CheckPDF";
            this.CheckPDF.Size = new System.Drawing.Size(148, 21);
            this.CheckPDF.TabIndex = 0;
            this.CheckPDF.Text = "Электронные книги";
            this.CheckPDF.CheckedChanged += new System.EventHandler(this.CheckPDF_CheckedChanged);
            // 
            // CheckMedia
            // 
            this.CheckMedia.BaseColor = System.Drawing.Color.White;
            this.CheckMedia.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckMedia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckMedia.FillColor = System.Drawing.Color.White;
            this.CheckMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckMedia.Location = new System.Drawing.Point(295, 36);
            this.CheckMedia.Name = "CheckMedia";
            this.CheckMedia.Size = new System.Drawing.Size(114, 21);
            this.CheckMedia.TabIndex = 0;
            this.CheckMedia.Text = "Медиа Файлы";
            this.CheckMedia.CheckedChanged += new System.EventHandler(this.CheckMedia_CheckedChanged);
            // 
            // CheckOtherDir
            // 
            this.CheckOtherDir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckOtherDir.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.CheckOtherDir.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckOtherDir.Enabled = false;
            this.CheckOtherDir.FillColor = System.Drawing.Color.White;
            this.CheckOtherDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckOtherDir.Location = new System.Drawing.Point(295, 63);
            this.CheckOtherDir.Name = "CheckOtherDir";
            this.CheckOtherDir.Size = new System.Drawing.Size(84, 21);
            this.CheckOtherDir.TabIndex = 0;
            this.CheckOtherDir.Text = "Шаблон1";
            // 
            // gunaCheckBox11
            // 
            this.gunaCheckBox11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox11.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox11.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox11.Enabled = false;
            this.gunaCheckBox11.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox11.Location = new System.Drawing.Point(295, 89);
            this.gunaCheckBox11.Name = "gunaCheckBox11";
            this.gunaCheckBox11.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox11.TabIndex = 0;
            this.gunaCheckBox11.Text = "Шаблон2";
            // 
            // gunaCheckBox12
            // 
            this.gunaCheckBox12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox12.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox12.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox12.Enabled = false;
            this.gunaCheckBox12.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox12.Location = new System.Drawing.Point(295, 115);
            this.gunaCheckBox12.Name = "gunaCheckBox12";
            this.gunaCheckBox12.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox12.TabIndex = 0;
            this.gunaCheckBox12.Text = "Шаблон3";
            // 
            // gunaCheckBox13
            // 
            this.gunaCheckBox13.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox13.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox13.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox13.Enabled = false;
            this.gunaCheckBox13.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox13.Location = new System.Drawing.Point(434, 36);
            this.gunaCheckBox13.Name = "gunaCheckBox13";
            this.gunaCheckBox13.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox13.TabIndex = 0;
            this.gunaCheckBox13.Text = "Шаблон4";
            // 
            // gunaCheckBox14
            // 
            this.gunaCheckBox14.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox14.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox14.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox14.Enabled = false;
            this.gunaCheckBox14.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox14.Location = new System.Drawing.Point(434, 63);
            this.gunaCheckBox14.Name = "gunaCheckBox14";
            this.gunaCheckBox14.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox14.TabIndex = 0;
            this.gunaCheckBox14.Text = "Шаблон5";
            // 
            // gunaCheckBox15
            // 
            this.gunaCheckBox15.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox15.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox15.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox15.Enabled = false;
            this.gunaCheckBox15.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox15.Location = new System.Drawing.Point(434, 89);
            this.gunaCheckBox15.Name = "gunaCheckBox15";
            this.gunaCheckBox15.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox15.TabIndex = 0;
            this.gunaCheckBox15.Text = "Шаблон7";
            // 
            // gunaCheckBox16
            // 
            this.gunaCheckBox16.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.gunaCheckBox16.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.gunaCheckBox16.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.gunaCheckBox16.Enabled = false;
            this.gunaCheckBox16.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaCheckBox16.Location = new System.Drawing.Point(434, 115);
            this.gunaCheckBox16.Name = "gunaCheckBox16";
            this.gunaCheckBox16.Size = new System.Drawing.Size(86, 21);
            this.gunaCheckBox16.TabIndex = 0;
            this.gunaCheckBox16.Text = "Шаблон8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.TextFormats);
            this.panel1.Controls.Add(this.TextDirectory);
            this.panel1.Location = new System.Drawing.Point(136, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 183);
            this.panel1.TabIndex = 17;
            // 
            // TextDirectory
            // 
            this.TextDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.TextDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextDirectory.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.TextDirectory.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.TextDirectory.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.TextDirectory.LineSize = 1;
            this.TextDirectory.Location = new System.Drawing.Point(15, 31);
            this.TextDirectory.Name = "TextDirectory";
            this.TextDirectory.PasswordChar = '\0';
            this.TextDirectory.Size = new System.Drawing.Size(354, 36);
            this.TextDirectory.TabIndex = 16;
            this.TextDirectory.Text = "C:\\Users\\Sergey\\Documents";
            this.TextDirectory.TextOffsetX = 10;
            this.TextDirectory.TextChanged += new System.EventHandler(this.TextDirectory_TextChanged);
            // 
            // TextFormats
            // 
            this.TextFormats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.TextFormats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextFormats.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(210)))), ((int)(((byte)(214)))));
            this.TextFormats.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextFormats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.TextFormats.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.TextFormats.LineSize = 1;
            this.TextFormats.Location = new System.Drawing.Point(15, 73);
            this.TextFormats.Name = "TextFormats";
            this.TextFormats.PasswordChar = '\0';
            this.TextFormats.Size = new System.Drawing.Size(354, 36);
            this.TextFormats.TabIndex = 16;
            this.TextFormats.Text = "C:\\Users\\Sergey\\Documents";
            this.TextFormats.TextOffsetX = 10;
            this.TextFormats.TextChanged += new System.EventHandler(this.TextDirectory_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel2.Location = new System.Drawing.Point(10, 3);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(365, 25);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Изменение [Папка/Расширение файлов]\r\n";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel3.Location = new System.Drawing.Point(12, 115);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(357, 58);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Расширение файлов, требуется вводить так: *.exe\r\nПри использовании нескольких рас" +
    "ширений,\r\nиспользуется следующее: *.exe,*.dll\r\n\r\n";
            // 
            // BtnChanger
            // 
            this.BtnChanger.AnimationHoverSpeed = 0.07F;
            this.BtnChanger.AnimationSpeed = 0.03F;
            this.BtnChanger.BackColor = System.Drawing.Color.Transparent;
            this.BtnChanger.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BtnChanger.BorderColor = System.Drawing.Color.Transparent;
            this.BtnChanger.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnChanger.Enabled = false;
            this.BtnChanger.FocusedColor = System.Drawing.Color.Empty;
            this.BtnChanger.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.BtnChanger.Image = null;
            this.BtnChanger.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnChanger.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnChanger.Location = new System.Drawing.Point(547, 377);
            this.BtnChanger.Name = "BtnChanger";
            this.BtnChanger.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.BtnChanger.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnChanger.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnChanger.OnHoverImage = null;
            this.BtnChanger.OnPressedColor = System.Drawing.Color.Black;
            this.BtnChanger.Radius = 10;
            this.BtnChanger.Size = new System.Drawing.Size(161, 36);
            this.BtnChanger.TabIndex = 18;
            this.BtnChanger.Text = "Изменить";
            this.BtnChanger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnChanger.Click += new System.EventHandler(this.BtnChanger_Click);
            // 
            // BtnDefault
            // 
            this.BtnDefault.AnimationHoverSpeed = 0.07F;
            this.BtnDefault.AnimationSpeed = 0.03F;
            this.BtnDefault.BackColor = System.Drawing.Color.Transparent;
            this.BtnDefault.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BtnDefault.BorderColor = System.Drawing.Color.Transparent;
            this.BtnDefault.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDefault.FocusedColor = System.Drawing.Color.Empty;
            this.BtnDefault.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.BtnDefault.Image = null;
            this.BtnDefault.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDefault.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDefault.Location = new System.Drawing.Point(547, 285);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.BtnDefault.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDefault.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDefault.OnHoverImage = null;
            this.BtnDefault.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDefault.Radius = 10;
            this.BtnDefault.Size = new System.Drawing.Size(161, 36);
            this.BtnDefault.TabIndex = 19;
            this.BtnDefault.Text = "По умолчанию";
            this.BtnDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDefault.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AnimationHoverSpeed = 0.07F;
            this.BtnSave.AnimationSpeed = 0.03F;
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BtnSave.BorderColor = System.Drawing.Color.Transparent;
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSave.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.BtnSave.Image = null;
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSave.Location = new System.Drawing.Point(547, 419);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Radius = 10;
            this.BtnSave.Size = new System.Drawing.Size(161, 36);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 506);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.BtnChanger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "Настройки программы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCheckBox CheckProject;
        private Guna.UI.WinForms.GunaCheckBox CheckAccess;
        private Guna.UI.WinForms.GunaCheckBox CheckExcel;
        private Guna.UI.WinForms.GunaCheckBox CheckPDF;
        private Guna.UI.WinForms.GunaCheckBox CheckArchive;
        private Guna.UI.WinForms.GunaCheckBox CheckTextDoc;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox11;
        private Guna.UI.WinForms.GunaCheckBox CheckOtherDir;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox12;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox15;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox16;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox14;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox13;
        private Guna.UI.WinForms.GunaCheckBox CheckMedia;
        private Guna.UI.WinForms.GunaCheckBox CheckImage;
        private Guna.UI.WinForms.GunaCheckBox CheckWord;
        private Panel panel1;
        private Guna.UI.WinForms.GunaLineTextBox TextFormats;
        private Guna.UI.WinForms.GunaLineTextBox TextDirectory;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton BtnChanger;
        private Guna.UI.WinForms.GunaButton BtnDefault;
        private Guna.UI.WinForms.GunaButton BtnSave;
    }
}