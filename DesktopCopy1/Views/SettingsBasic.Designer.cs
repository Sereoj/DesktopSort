using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace DesktopCopy1.Views
{
    partial class SettingsBasic
    {
        /// <summary>
        ///     Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///     Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        ///     Требуемый метод для поддержки конструктора — не изменяйте
        ///     содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Template6 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckWord = new Guna.UI.WinForms.GunaCheckBox();
            this.Template5 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckImage = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckMedia = new Guna.UI.WinForms.GunaCheckBox();
            this.Template4 = new Guna.UI.WinForms.GunaCheckBox();
            this.Template7 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckProject = new Guna.UI.WinForms.GunaCheckBox();
            this.Template3 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckAccess = new Guna.UI.WinForms.GunaCheckBox();
            this.Template1 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckExcel = new Guna.UI.WinForms.GunaCheckBox();
            this.Template2 = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckPDF = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckTextDoc = new Guna.UI.WinForms.GunaCheckBox();
            this.CheckArchive = new Guna.UI.WinForms.GunaCheckBox();
            this.BtnSave = new Guna.UI.WinForms.GunaButton();
            this.BtnDefault = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextFormats = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextDirectory = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // Template6
            // 
            this.Template6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template6.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template6.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template6.FillColor = System.Drawing.Color.White;
            this.Template6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template6.Location = new System.Drawing.Point(451, 95);
            this.Template6.Name = "Template6";
            this.Template6.Size = new System.Drawing.Size(78, 20);
            this.Template6.TabIndex = 55;
            this.Template6.Text = "Шаблон6";
            this.Template6.CheckedChanged += new System.EventHandler(this.Template6_CheckedChanged);
            // 
            // CheckWord
            // 
            this.CheckWord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckWord.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckWord.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckWord.FillColor = System.Drawing.Color.White;
            this.CheckWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckWord.Location = new System.Drawing.Point(32, 43);
            this.CheckWord.Name = "CheckWord";
            this.CheckWord.Size = new System.Drawing.Size(106, 20);
            this.CheckWord.TabIndex = 58;
            this.CheckWord.Text = "Microsoft Word";
            this.CheckWord.CheckedChanged += new System.EventHandler(this.CheckWord_CheckedChanged);
            // 
            // Template5
            // 
            this.Template5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template5.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template5.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template5.FillColor = System.Drawing.Color.White;
            this.Template5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template5.Location = new System.Drawing.Point(451, 68);
            this.Template5.Name = "Template5";
            this.Template5.Size = new System.Drawing.Size(78, 20);
            this.Template5.TabIndex = 53;
            this.Template5.Text = "Шаблон5";
            this.Template5.CheckedChanged += new System.EventHandler(this.Template5_CheckedChanged);
            // 
            // CheckImage
            // 
            this.CheckImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckImage.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckImage.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckImage.FillColor = System.Drawing.Color.White;
            this.CheckImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckImage.Location = new System.Drawing.Point(160, 42);
            this.CheckImage.Name = "CheckImage";
            this.CheckImage.Size = new System.Drawing.Size(88, 20);
            this.CheckImage.TabIndex = 57;
            this.CheckImage.Text = "Image Files";
            this.CheckImage.CheckedChanged += new System.EventHandler(this.CheckImage_CheckedChanged);
            // 
            // CheckMedia
            // 
            this.CheckMedia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckMedia.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckMedia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckMedia.FillColor = System.Drawing.Color.White;
            this.CheckMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckMedia.Location = new System.Drawing.Point(312, 42);
            this.CheckMedia.Name = "CheckMedia";
            this.CheckMedia.Size = new System.Drawing.Size(104, 20);
            this.CheckMedia.TabIndex = 51;
            this.CheckMedia.Text = "Медиа Файлы";
            this.CheckMedia.CheckedChanged += new System.EventHandler(this.CheckMedia_CheckedChanged);
            // 
            // Template4
            // 
            this.Template4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template4.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template4.FillColor = System.Drawing.Color.White;
            this.Template4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template4.Location = new System.Drawing.Point(451, 42);
            this.Template4.Name = "Template4";
            this.Template4.Size = new System.Drawing.Size(78, 20);
            this.Template4.TabIndex = 52;
            this.Template4.Text = "Шаблон4";
            this.Template4.CheckedChanged += new System.EventHandler(this.Template4_CheckedChanged);
            // 
            // Template7
            // 
            this.Template7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template7.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template7.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template7.FillColor = System.Drawing.Color.White;
            this.Template7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template7.Location = new System.Drawing.Point(451, 121);
            this.Template7.Name = "Template7";
            this.Template7.Size = new System.Drawing.Size(78, 20);
            this.Template7.TabIndex = 54;
            this.Template7.Text = "Шаблон7";
            this.Template7.CheckedChanged += new System.EventHandler(this.Template7_CheckedChanged);
            // 
            // CheckProject
            // 
            this.CheckProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckProject.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckProject.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckProject.FillColor = System.Drawing.Color.White;
            this.CheckProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckProject.Location = new System.Drawing.Point(32, 121);
            this.CheckProject.Name = "CheckProject";
            this.CheckProject.Size = new System.Drawing.Size(114, 20);
            this.CheckProject.TabIndex = 64;
            this.CheckProject.Text = "Microsoft Project";
            this.CheckProject.CheckedChanged += new System.EventHandler(this.CheckProject_CheckedChanged);
            // 
            // Template3
            // 
            this.Template3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template3.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template3.FillColor = System.Drawing.Color.White;
            this.Template3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template3.Location = new System.Drawing.Point(312, 121);
            this.Template3.Name = "Template3";
            this.Template3.Size = new System.Drawing.Size(78, 20);
            this.Template3.TabIndex = 56;
            this.Template3.Text = "Шаблон3";
            this.Template3.CheckedChanged += new System.EventHandler(this.Template3_CheckedChanged);
            // 
            // CheckAccess
            // 
            this.CheckAccess.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckAccess.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckAccess.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckAccess.FillColor = System.Drawing.Color.White;
            this.CheckAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckAccess.Location = new System.Drawing.Point(32, 95);
            this.CheckAccess.Name = "CheckAccess";
            this.CheckAccess.Size = new System.Drawing.Size(115, 20);
            this.CheckAccess.TabIndex = 63;
            this.CheckAccess.Text = "Microsoft Access";
            this.CheckAccess.CheckedChanged += new System.EventHandler(this.CheckAccess_CheckedChanged);
            // 
            // Template1
            // 
            this.Template1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template1.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template1.FillColor = System.Drawing.Color.White;
            this.Template1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template1.Location = new System.Drawing.Point(312, 69);
            this.Template1.Name = "Template1";
            this.Template1.Size = new System.Drawing.Size(78, 20);
            this.Template1.TabIndex = 50;
            this.Template1.Text = "Шаблон1";
            this.Template1.CheckedChanged += new System.EventHandler(this.Template1_CheckedChanged);
            // 
            // CheckExcel
            // 
            this.CheckExcel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckExcel.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckExcel.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckExcel.FillColor = System.Drawing.Color.White;
            this.CheckExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckExcel.Location = new System.Drawing.Point(32, 69);
            this.CheckExcel.Name = "CheckExcel";
            this.CheckExcel.Size = new System.Drawing.Size(106, 20);
            this.CheckExcel.TabIndex = 62;
            this.CheckExcel.Text = "Microsoft Excel";
            this.CheckExcel.CheckedChanged += new System.EventHandler(this.CheckExcel_CheckedChanged);
            // 
            // Template2
            // 
            this.Template2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.Template2.CheckedOffColor = System.Drawing.Color.Gray;
            this.Template2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.Template2.FillColor = System.Drawing.Color.White;
            this.Template2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.Template2.Location = new System.Drawing.Point(312, 95);
            this.Template2.Name = "Template2";
            this.Template2.Size = new System.Drawing.Size(78, 20);
            this.Template2.TabIndex = 65;
            this.Template2.Text = "Шаблон2";
            this.Template2.CheckedChanged += new System.EventHandler(this.Template2_CheckedChanged);
            // 
            // CheckPDF
            // 
            this.CheckPDF.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckPDF.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckPDF.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckPDF.FillColor = System.Drawing.Color.White;
            this.CheckPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckPDF.Location = new System.Drawing.Point(160, 121);
            this.CheckPDF.Name = "CheckPDF";
            this.CheckPDF.Size = new System.Drawing.Size(133, 20);
            this.CheckPDF.TabIndex = 61;
            this.CheckPDF.Text = "Электронные книги";
            this.CheckPDF.CheckedChanged += new System.EventHandler(this.CheckPDF_CheckedChanged);
            // 
            // CheckTextDoc
            // 
            this.CheckTextDoc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckTextDoc.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckTextDoc.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckTextDoc.FillColor = System.Drawing.Color.White;
            this.CheckTextDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckTextDoc.Location = new System.Drawing.Point(160, 69);
            this.CheckTextDoc.Name = "CheckTextDoc";
            this.CheckTextDoc.Size = new System.Drawing.Size(112, 20);
            this.CheckTextDoc.TabIndex = 59;
            this.CheckTextDoc.Text = "Text Documents";
            this.CheckTextDoc.CheckedChanged += new System.EventHandler(this.CheckTextDoc_CheckedChanged);
            // 
            // CheckArchive
            // 
            this.CheckArchive.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.CheckArchive.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckArchive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.CheckArchive.FillColor = System.Drawing.Color.White;
            this.CheckArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.CheckArchive.Location = new System.Drawing.Point(160, 95);
            this.CheckArchive.Name = "CheckArchive";
            this.CheckArchive.Size = new System.Drawing.Size(70, 20);
            this.CheckArchive.TabIndex = 60;
            this.CheckArchive.Text = "Архивы";
            this.CheckArchive.CheckedChanged += new System.EventHandler(this.CheckArchive_CheckedChanged);
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
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.BtnSave.Image = null;
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSave.Location = new System.Drawing.Point(392, 318);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.BtnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSave.OnHoverImage = null;
            this.BtnSave.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSave.Radius = 10;
            this.BtnSave.Size = new System.Drawing.Size(160, 36);
            this.BtnSave.TabIndex = 48;
            this.BtnSave.Text = "Применить";
            this.BtnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSave.Click += new System.EventHandler(this.Saver_Click);
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
            this.BtnDefault.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.BtnDefault.Image = null;
            this.BtnDefault.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDefault.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnDefault.Location = new System.Drawing.Point(392, 276);
            this.BtnDefault.Name = "BtnDefault";
            this.BtnDefault.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(61)))));
            this.BtnDefault.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnDefault.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnDefault.OnHoverImage = null;
            this.BtnDefault.OnPressedColor = System.Drawing.Color.Black;
            this.BtnDefault.Radius = 10;
            this.BtnDefault.Size = new System.Drawing.Size(160, 36);
            this.BtnDefault.TabIndex = 49;
            this.BtnDefault.Text = "Сбросить";
            this.BtnDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDefault.Click += new System.EventHandler(this.Default_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel3.Location = new System.Drawing.Point(29, 266);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(357, 58);
            this.gunaLabel3.TabIndex = 47;
            this.gunaLabel3.Text = "Расширение файлов, требуется вводить так: *.exe\r\nПри использовании нескольких рас" +
    "ширений,\r\nиспользуется следующее: *.exe,*.dll\r\n\r\n";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 145);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(365, 25);
            this.gunaLabel2.TabIndex = 46;
            this.gunaLabel2.Text = "Изменение [Папка/Расширение файлов]\r\n";
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
            this.TextFormats.Location = new System.Drawing.Point(32, 217);
            this.TextFormats.Name = "TextFormats";
            this.TextFormats.PasswordChar = '\0';
            this.TextFormats.Size = new System.Drawing.Size(354, 36);
            this.TextFormats.TabIndex = 44;
            this.TextFormats.Text = "Введите расширение файлов";
            this.TextFormats.TextOffsetX = 10;
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
            this.TextDirectory.Location = new System.Drawing.Point(32, 175);
            this.TextDirectory.Name = "TextDirectory";
            this.TextDirectory.PasswordChar = '\0';
            this.TextDirectory.Size = new System.Drawing.Size(354, 36);
            this.TextDirectory.TabIndex = 45;
            this.TextDirectory.Text = "Введите название папки";
            this.TextDirectory.TextOffsetX = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(231)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(307, 25);
            this.gunaLabel1.TabIndex = 43;
            this.gunaLabel1.Text = "Выберите необходимые форматы.\r\n";
            // 
            // SettingsBasic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Template6);
            this.Controls.Add(this.CheckWord);
            this.Controls.Add(this.Template5);
            this.Controls.Add(this.CheckImage);
            this.Controls.Add(this.CheckMedia);
            this.Controls.Add(this.Template4);
            this.Controls.Add(this.Template7);
            this.Controls.Add(this.CheckProject);
            this.Controls.Add(this.Template3);
            this.Controls.Add(this.CheckAccess);
            this.Controls.Add(this.Template1);
            this.Controls.Add(this.CheckExcel);
            this.Controls.Add(this.Template2);
            this.Controls.Add(this.CheckPDF);
            this.Controls.Add(this.CheckTextDoc);
            this.Controls.Add(this.CheckArchive);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDefault);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.TextFormats);
            this.Controls.Add(this.TextDirectory);
            this.Controls.Add(this.gunaLabel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(578, 369);
            this.Name = "SettingsBasic";
            this.Size = new System.Drawing.Size(578, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GunaCheckBox Template6;
        private GunaCheckBox CheckWord;
        private GunaCheckBox Template5;
        private GunaCheckBox CheckImage;
        private GunaCheckBox CheckMedia;
        private GunaCheckBox Template4;
        private GunaCheckBox Template7;
        private GunaCheckBox CheckProject;
        private GunaCheckBox Template3;
        private GunaCheckBox CheckAccess;
        private GunaCheckBox Template1;
        private GunaCheckBox CheckExcel;
        private GunaCheckBox Template2;
        private GunaCheckBox CheckPDF;
        private GunaCheckBox CheckTextDoc;
        private GunaCheckBox CheckArchive;
        private GunaButton BtnSave;
        private GunaButton BtnDefault;
        private GunaLabel gunaLabel3;
        private GunaLabel gunaLabel2;
        private GunaLineTextBox TextFormats;
        private GunaLineTextBox TextDirectory;
        private GunaLabel gunaLabel1;
    }
}