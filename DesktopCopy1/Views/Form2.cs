using System;
using System.IO;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1
{
    public interface IForm2 : IView
    {
        //Все методы, свойства и события будут отправлены в Presenter
    }

    public partial class Form2 : Form, IForm2
    {
        private readonly ApplicationContext _context;
        private Settings settings = new Settings();

        public Form2(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            ShowDialog();
        }

        private void LoadFromFile(string filePath)
        {
            settings = Data.Load<Settings>(filePath);
            LoadCheckPoint();
        }

        public void UpdateList()
        {
            settings.Clear();
        }

        private void SaveToFile(string filePath)
        {
            SaveCheckPoint();
            Data.Save(settings, filePath);
        }

        public void LoadCheckPoint()
        {
            foreach (Control control in Controls)
                if (control as CheckBox != null)
                    for (var i = 0; i < settings.Count; i++)
                        if (control.Name == settings[i].ID)
                            (control as CheckBox).Checked = settings[i].IsChecked;
        }

        public void SaveCheckPoint()
        {
            UpdateList();
            foreach (Control control in Controls)
                if (control as CheckBox != null)
                {
                    if ((control as CheckBox).Checked)
                    {
                        var setting = new Setting {ID = control.Name, IsChecked = true};
                        settings.Add(setting);
                    }
                    else
                    {
                        var setting = new Setting {ID = control.Name, IsChecked = false};
                        settings.Add(setting);
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveToFile("data.xml");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("data.xml")) LoadFromFile("data.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}