using System;
using System.Collections.Generic;
using System.IO;

namespace DesktopCopy1
{
    public interface IBusinessLogic
    {
        void DirCreate(List<string> NameDirs);
        void Search(string type, string pattern, bool MoveMethod);
        void Logger(string text);
        string DEFAULT_PATH { get; set; }
        string DIR_OUTPUT { get; set; }
    }




    public class BusinessLogic : IBusinessLogic
    {
        #region Поля/Свойства
        public string _DEFAULT_PATH;
        public string DEFAULT_PATH
        {
            get => _DEFAULT_PATH;
            set => _DEFAULT_PATH = value;
        }
        public string _DIR_OUTPUT;
        public string DIR_OUTPUT
        {
            get => _DIR_OUTPUT;
            set => _DIR_OUTPUT = value;
        }
        #endregion

        #region Массив данных
        /*
        Строковые элементы, объединенные в одно поле (Переменную)         
        */
        private readonly string[] word = new string[] { ".docx", ".dotx", ".doc", ".dot" };
        private readonly string[] excel = new string[] { ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlam", ".xls", ".xlt", ".xla" };
        private readonly string[] access = new string[] { ".accdb", ".mdb" };

        /*От 0.0.2*/
        private readonly string[] text = new string[] { ".txt", ".log" };
        private readonly string[] image = new string[] { ".bmp", ".tif", ".jpg", ".gif", ".png", ".ico" };
        #endregion
        public void Logger(string text)
        {
            StreamWriter file = new StreamWriter(DEFAULT_PATH + @"\logger.txt");
            file.WriteLine(text);
            file.Close();
        }

        public void ExDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        public void DirCreate(List<string> NameDirs)
        {
            if (!Directory.Exists(DIR_OUTPUT))
            {
                Directory.CreateDirectory(DIR_OUTPUT);
            }
            try
            {
                foreach (string DIR in NameDirs)
                {
                    ExDir(DIR);
                }
            }
            catch (Exception e)
            {
                Logger(e.Message);
            }


        }

        public void Search(string type, string pattern, bool MoveMethod)
        {
            foreach (string t_path in Directory.GetFiles(DEFAULT_PATH, "*.*", SearchOption.TopDirectoryOnly))
            {
                try
                {
                    var Ext = Path.GetExtension(t_path);
                    if (pattern.Contains(Ext) && Ext.Length > 0)
                    {
                        

                        FileInfo s = new FileInfo(t_path);
                        if (File.Exists(Path.Combine(type.ToString(), s.Name)))
                        {
                            continue;
                        }
                        else
                        {
                            if (MoveMethod)
                            {
                                s.MoveTo(Path.Combine(type.ToString(), s.Name));
                            }
                            else
                            {
                                s.CopyTo(Path.Combine(type.ToString(), s.Name), true);

                            }
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Logger(e.Message);
                }
            }

        }


    }
}
