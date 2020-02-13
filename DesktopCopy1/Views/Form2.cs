using System;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1.Views
{
    /// <summary>
    ///     Интерфейс, случит для "Открытия" определенных "объектов".
    /// </summary>
    public interface IForm2 : IView
    {
        /// <summary>
        ///     Все что здесь, будет отображатся, когда подлючаем ЕГО.
        /// </summary>
        Settings Settings { get; set; }

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

        void LoadFromFile(string filePath);
        void SaveToFile(string filePath);
        void LoadCheckPoint();

        string TextDirectory1 { get; set; }
        string TextFormats1 { get; set; }
    }

    public partial class Form2 : Form, IForm2
    {
        /// <summary>
        ///     Свойства, только получает
        /// </summary>
        public ApplicationContext Context { get; }

        /// <summary>
        ///     Свойство в виде экземпляра: Получает,Устанавливает
        /// </summary>
        public Settings Settings { get; set; }

        #region Events

        /// <summary>
        ///     События для контролов
        /// </summary>
        public event EventHandler ButtonSave;

        public event EventHandler ButtonUpdate;
        public event EventHandler ButtonDefault;

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

        /// <summary>
        ///     Конструктор класса
        /// </summary>
        /// <param name="context"></param>
        public Form2(ApplicationContext context)
        {
            Context = context;
            InitializeComponent();
        }

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

        #region Functions

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
        ///     Очистка Листа
        /// </summary>
        public void GetDefault()
        {
            //Settings.CreateInstance();
            new MessageService().Message(Settings.Setting.Count.ToString());
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
                if (control as CheckBox != null)
                    for (var i = 0; i < Settings.Setting.Count; i++)
                        if (control.Name == Settings.Setting[i].ID)
                            (control as CheckBox).Checked = Settings.Setting[i].IsChecked;
        }

        /// <summary>
        ///     Сохранение котролов
        /// </summary>
        public void SaveCheckPoint()
        {
            // UpdateList();
            foreach (Control control in Controls)
                if (control as CheckBox != null)
                {
                    if ((control as CheckBox).Checked)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonSave?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonDefault?.Invoke(this, EventArgs.Empty);
        }
    }
}