using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace DesktopCopy1.Models
{
    public class Data
    {
        public string FileName { get; set; } 

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
            var xml = new XmlSerializer(typeof(Settings));
            using (var file = new FileStream(FileName, FileMode.Open))
            {
                return (T) xml.Deserialize(file);
            }
        }

        public static void Clean(Settings settings)
        {
            settings?.Clear();
        }

        public void GetDefault(Settings settings)
        {

                Clean(settings);
                
                settings.Add(new Setting() {ID = "CheckWord", IsChecked = false, Catalog = "Word", Extension = "*.docx,*.dotx,*.doc,*.dot"});
                settings.Add(new Setting() {ID = "CheckExcel", IsChecked = false, Catalog = "Excel", Extension = "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla"});
                settings.Add(new Setting() {ID = "CheckAccess", IsChecked = false, Catalog = "Access", Extension = "*.accdb,*.mdb"});
                settings.Add(new Setting() {ID = "CheckImage", IsChecked = false, Catalog = "Image",Extension = "*.bmp,*.tif,*.jpg,*.gif,*.png,*.ico"});
                settings.Add(new Setting() {ID = "CheckTextDoc", IsChecked = false, Catalog = "Text", Extension = ".txt,*.log"});
                settings.Add(new Setting() {ID = "CheckProject", IsChecked = false, Catalog = "Project", Extension = ""});
                settings.Add(new Setting() {ID = "CheckArchive", IsChecked = false, Catalog = "Archive", Extension = ""});
                settings.Add(new Setting() {ID = "CheckPDF", IsChecked = false, Catalog = "PDF", Extension = ""});
                settings.Add(new Setting() {ID = "CheckMedia", IsChecked = false, Catalog = "Media", Extension = ""});
                settings.Add(new Setting() {ID = "CheckOtherDir", IsChecked = false, Catalog = "Other", Extension = ""});
                Save(settings,"data.xml");
        }

    }

    public class Alternative : List<Setting>
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
    public class Settings : List<Setting>
    {
    }
}