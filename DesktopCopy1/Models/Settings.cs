using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DesktopCopy1.Models
{
    public class Alternative
    {
    }

    [Serializable]
    public class Setting
    {
        /*
        Индувидуальная настройка каждого объекта, который имеет id и "включен" ли он. 
             
        */
        public string ID { get; set; }
        public bool IsChecked { get; set; }


        public string Catalog { get; set; }
        public string Extension { get; set; }
    }


    [Serializable]
    [XmlRoot("Settings")]
    public class Settings
    {
        [NonSerialized] public string FileName;

        /// <summary>
        ///     Основные настройки
        /// </summary>
        public List<Setting> Setting { get; set; }

        /// <summary>
        ///     Альтернативные настройки скрытые от пользователя.
        /// </summary>
        public List<Alternative> Alternative { get; set; }

        /// <summary>
        ///     Проверять на обновления
        /// </summary>
        public bool Update { get; set; }

        /// <summary>
        ///     Вести ли логи.
        /// </summary>
        public bool Logger { get; set; }

        public static void Default()
        {
            var Settings = new Settings
            {
                FileName = "data.xml",
                Setting = new List<Setting>(),
                Alternative = new List<Alternative>(),
                Logger = false,
                Update = false
            };

            Settings.Setting.Add(new Setting
                {ID = "CheckWord", IsChecked = true, Catalog = "Word", Extension = "*.docx,*.dotx,*.doc,*.dot"});
            Settings.Setting.Add(new Setting
            {
                ID = "CheckExcel", IsChecked = true, Catalog = "Excel",
                Extension = "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla"
            });
            Settings.Setting.Add(new Setting
                {ID = "CheckAccess", IsChecked = true, Catalog = "Access", Extension = "*.accdb,*.mdb"});
            Settings.Setting.Add(new Setting
            {
                ID = "CheckImage", IsChecked = true, Catalog = "Image",
                Extension = "*.bmp,*.tif,*.jpg,*.gif,*.png,*.ico"
            });
            Settings.Setting.Add(new Setting
                {ID = "CheckTextDoc", IsChecked = true, Catalog = "Text", Extension = "*.txt,*.log"});
            Settings.Setting.Add(new Setting
                {ID = "CheckProject", IsChecked = false, Catalog = "Project", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "CheckArchive", IsChecked = false, Catalog = "Archive", Extension = ""});
            Settings.Setting.Add(new Setting {ID = "CheckPDF", IsChecked = false, Catalog = "PDF", Extension = ""});
            Settings.Setting.Add(new Setting {ID = "CheckMedia", IsChecked = false, Catalog = "Media", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template1", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template2", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template3", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template4", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template5", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template6", IsChecked = false, Catalog = "Other", Extension = ""});
            Settings.Setting.Add(new Setting
                {ID = "Template7", IsChecked = false, Catalog = "Other", Extension = ""});
            Save(Settings, "data.xml");
        }

        public static void Save<T>(T subject, string FileName)
        {
            var xml = new XmlSerializer(typeof(Settings));
            using (var file = new FileStream(FileName, FileMode.Create))
            {
                xml.Serialize(file, subject);
            }
        }

        public static T Load<T>(string FileName)
        {
            if (!File.Exists("data.xml")) Default();
            var xml = new XmlSerializer(typeof(Settings));
            using (var file = new FileStream(FileName, FileMode.Open))
            {
                return (T) xml.Deserialize(file);
            }
        }
    }
}