using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Presenters;
using Guna.UI.WinForms;

namespace DesktopCopy1.Views
{
    public interface ISettingsBasic : IView
    {
        string TextDirectory1 { get; set; }
        string TextFormats1 { get; set; }

        event EventHandler CheckBWord;

        event EventHandler CheckBExcel;
        event EventHandler CheckBAccess;
        event EventHandler CheckBProject;
        event EventHandler CheckBTextDoc;
        event EventHandler CheckBImages;
        event EventHandler CheckBPDF;
        event EventHandler CheckBMedia;
        event EventHandler CheckBArchive;

        event EventHandler TemplateB1;
        event EventHandler TemplateB2;
        event EventHandler TemplateB3;
        event EventHandler TemplateB4;
        event EventHandler TemplateB5;
        event EventHandler TemplateB6;
        event EventHandler TemplateB7;

        event EventHandler ButtonSave;
        event EventHandler ButtonDefault;
        event EventHandler ButtonChanger;

        void LoadFromFile(string filePath);
        void SaveToFile(string filePath);
        void LoadCheckPoint();


        Settings GetSettings();
    }


    public partial  class SettingsBasic : UserControl, ISettingsBasic
    {
        private static SettingsBasic _instance;

        public Settings Settings { get; set; }
        public static SettingsBasic Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsBasic();
                return _instance;
  
            }
        }

        public SettingsBasic()
        {
            InitializeComponent();
            var presenter = new SettingsPresenterManager(this);
            presenter.Init();
        }

       public string TextDirectory1
        {
            get => TextDirectory.Text;
            set => TextDirectory.Text = value;
        }

        /// <summary>
        ///     Свойство управления контрола TextBoxFormats
        /// </summary>
        public string TextFormats1
        {
            get => TextFormats.Text;
            set => TextFormats.Text = value;
        }

        #region Buttons

        private void Saver_Click(object sender, EventArgs e)
        {
            ButtonChanger?.Invoke(this,EventArgs.Empty);
            ButtonSave?.Invoke(this, EventArgs.Empty);
        }


        private void Default_Click(object sender, EventArgs e)
        {
            ButtonDefault?.Invoke(this, EventArgs.Empty);
        }



        #endregion

        #region Events

        /// <summary>
        ///     События для контролов
        /// </summary>
        public event EventHandler ButtonSave;

        public event EventHandler ButtonUpdate;
        public event EventHandler ButtonDefault;
        public event EventHandler ButtonChanger;

        //CheckBox
        public event EventHandler CheckBWord;
        public event EventHandler CheckBExcel;
        public event EventHandler CheckBAccess;
        public event EventHandler CheckBProject;
        public event EventHandler CheckBTextDoc;
        public event EventHandler CheckBImages;
        public event EventHandler CheckBPDF;
        public event EventHandler CheckBMedia;
        public event EventHandler CheckBArchive;
        public event EventHandler TemplateB1;
        public event EventHandler TemplateB2;
        public event EventHandler TemplateB3;
        public event EventHandler TemplateB4;
        public event EventHandler TemplateB5;
        public event EventHandler TemplateB6;
        public event EventHandler TemplateB7;
        #endregion

        #region Functions

        public Settings GetSettings()
        {
            return Settings;
        }

        /// <summary>
        ///     Загрузка из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        public void LoadFromFile(string filePath)
        {
            Settings = Settings.Load<Settings>(filePath);
            LoadCheckPoint();
        }

        /// <summary>
        ///     Сохранение  в файл
        /// </summary>
        /// <param name="filePath"></param>
        public void SaveToFile(string filePath)
        {
            SaveCheckPoint();
            Settings.Save(Settings, filePath);
        }

        /// <summary>
        ///     Загрузка контролов
        /// </summary>
        public void LoadCheckPoint()
        {
            foreach (Control control in Controls)
                if (control as Guna.UI.WinForms.GunaCheckBox != null)
                    for (var i = 0; i < Settings.Setting.Count; i++)
                        if (control.Name == Settings.Setting[i].ID)
                            (control as Guna.UI.WinForms.GunaCheckBox).Checked = Settings.Setting[i].IsChecked;
        }

        /// <summary>
        ///     Сохранение котролов
        /// </summary>
        public void SaveCheckPoint()
        {
            // UpdateList();
            foreach (Control control in Controls)
                if (control as Guna.UI.WinForms.GunaCheckBox != null)
                {
                    // ReSharper disable once PossibleNullReferenceException
                    if ((control as Guna.UI.WinForms.GunaCheckBox).Checked)
                    {
                        var setting = Settings.Setting.Find(X => X.ID == control.Name);
                        if (setting != null) setting.IsChecked = true;
                    }
                    else
                    {
                        var setting = Settings.Setting.Find(X => X.ID == control.Name);
                        if (setting != null) setting.IsChecked = false;
                    }
                }
        }



        #endregion

        #region CheckBoxS

        private void CheckWord_CheckedChanged(object sender, EventArgs e)
        {
            CheckBWord?.Invoke(this, EventArgs.Empty);
        }

        private void CheckMedia_CheckedChanged(object sender, EventArgs e)
        {
            CheckBMedia?.Invoke(this, EventArgs.Empty);
        }

        private void CheckPDF_CheckedChanged(object sender, EventArgs e)
        {
            CheckBPDF?.Invoke(this, EventArgs.Empty);
        }

        private void CheckArchive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBArchive?.Invoke(this, EventArgs.Empty);
        }

        private void CheckTextDoc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBTextDoc?.Invoke(this, EventArgs.Empty);
        }

        private void CheckImage_CheckedChanged(object sender, EventArgs e)
        {
            CheckBImages?.Invoke(this, EventArgs.Empty);
        }

        private void CheckProject_CheckedChanged(object sender, EventArgs e)
        {
            CheckBProject?.Invoke(this, EventArgs.Empty);
        }

        private void CheckAccess_CheckedChanged(object sender, EventArgs e)
        {
            CheckBAccess?.Invoke(this, EventArgs.Empty);
        }

        private void CheckExcel_CheckedChanged(object sender, EventArgs e)
        {
            CheckBExcel?.Invoke(this, EventArgs.Empty);
        }

        private void Template4_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB4?.Invoke(this, EventArgs.Empty);
        }

        private void Template2_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB2?.Invoke(this, EventArgs.Empty);
        }

        private void Template3_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB3?.Invoke(this, EventArgs.Empty);
        }

        private void Template1_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB1?.Invoke(this, EventArgs.Empty);
        }

        private void Template5_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB5?.Invoke(this, EventArgs.Empty);
        }

        private void Template6_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB6?.Invoke(this, EventArgs.Empty);
        }

        private void Template7_CheckedChanged(object sender, EventArgs e)
        {
            TemplateB7?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
        }




        #endregion
    }
}