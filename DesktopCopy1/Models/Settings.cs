using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace DesktopCopy1.Models
{

    public class Data
    {
        /*
         Реализация сохранение каждого объекта
             
        */
        public static void Save<T>(T subject, string FileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Settings));
            
            using (var file = new FileStream(FileName, FileMode.Create) )
            {
                xml.Serialize(file,subject);
            }
        }

        public static  T Load<T>(string FileName)
        {

                XmlSerializer xml = new XmlSerializer(typeof(Settings));
                using (var file = new FileStream(FileName, FileMode.Open))
                {
                    return (T)xml.Deserialize(file);
                }
        }
    }
    [Serializable]
    public class Alternative
    {
        public int Code { get; set; }
        public string Title { get; set; }
    }
    [Serializable]
    public class Setting
    {
        /*
        Индувидуальная настройка каждого объекта, который имеет id и "включен" ли он. 
             
        */
        
        public string ID { get; set; }
        public bool IsChecked { get; set; }
    }
    [Serializable]
    [XmlRoot("Settings")]
    public class Settings : List<Setting>
    {
    }
}
