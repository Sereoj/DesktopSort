using System;
using System.Drawing;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using Guna.UI;

namespace DesktopCopy1.Views
{
    /// <summary>
    ///     Интерфейс, случит для "Открытия" определенных "объектов".
    /// </summary>
    public interface IForm2 : IView
    {
        string TextDirectory1 { get; set; }
        string TextFormats1 { get; set; }

        /// <summary>
        ///     Все что здесь, будет отображатся, когда подлючаем ЕГО.
        /// </summary>
        event EventHandler CheckBWord;

        event EventHandler CheckBExcel;
        event EventHandler CheckBAccess;
        event EventHandler CheckBProject;
        event EventHandler CheckBTextDoc;
        event EventHandler CheckBImages;
        event EventHandler CheckBOtherDir;
        event EventHandler CheckBPDF;
        event EventHandler CheckBMedia;
        event EventHandler CheckBArchive;

        event EventHandler ButtonSave;
        event EventHandler ButtonUpdate;
        event EventHandler ButtonDefault;
        event EventHandler ButtonChanger;

        void LoadFromFile(string filePath);
        void SaveToFile(string filePath);
        void LoadCheckPoint();

        Settings GetSettings();
    }

    public partial class Form2 : Form, IForm2
    {
        /// <summary>
        ///     Конструктор класса
        /// </summary>
        /// <param name="context"></param>
        public Form2(ApplicationContext context)
        {
            Context = context;
            InitializeComponent();
            Header.BackColor = Color.FromArgb(24, 0, 0, 0);

        }

        /// <summary>
        ///     Свойства, только получает
        /// </summary>
        public ApplicationContext Context { get; }

        /// <summary>
        ///     Свойство в виде экземпляра: Получает,Устанавливает
        /// </summary>
        public Settings Settings { get; set; }

        /// <summary>
        ///     Отвественен за появление формы
        /// </summary>
        public new void Show()
        {
            ShowDialog();
        }

        /// <summary>
        ///     Свойство управления контрола TextBoxDir
        /// </summary>
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

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonChanger?.Invoke(this,EventArgs.Empty);
            ButtonSave?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
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
        public event EventHandler CheckBOtherDir;
        public event EventHandler CheckBPDF;
        public event EventHandler CheckBMedia;
        public event EventHandler CheckBArchive;

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
            foreach (Control control in MainBlog.Controls)
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
            foreach (Control control in MainBlog.Controls)
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

        public void ShowPanel(string panel)
        {
            switch (panel)
            {
                case "main":
                    break;
                case "addition":
                    break;
                case "about":
                    break;;
                    default:
                        break;
                        
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

        private void CheckOtherDir_CheckedChanged(object sender, EventArgs e)
        {
            CheckBOtherDir?.Invoke(this, EventArgs.Empty);
        }



        #endregion

        private void TextDirectory_TextChanged(object sender, EventArgs e)
        {
            //BtnChanger.Enabled = true;
        }

    }
}