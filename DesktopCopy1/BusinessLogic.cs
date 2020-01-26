using DesktopCopy1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCopy1
{
    public interface IBusinessLogic
    {
        void DirCreate();
        void Search(bool method);
        void Logger(string text);
        string DEFAULT_PATH { get; set;}
        string DIR_OUTPUT { get; set; }

        string Excel { set; get; }
        string Word { set; get; }
        string Access { set; get; }

        string TextDoc{ set; get; }
        string Image { set; get; }
    }




    public class BusinessLogic: IBusinessLogic
    {
        #region Поля/Свойства
        /*
        _Excel - поля служат для хранения информации.(переменная)
        Excel  - Свойства  для Чтение и Записи.
        */
        public string _Excel;
        public string Excel {
            set
            {
                _Excel = value;
            }
            get
            {
                return _Excel;
            }
        }
        public string _Word;
        public string Word
        {
            set
            {
                _Word = value;
            }
            get
            {
                return _Word;
            }
        }
        public string _Access;
        public string Access
        {
            set
            {
                _Access = value;
            }
            get
            {
                return _Access;
            }
        }
        public string _DEFAULT_PATH;
        public string DEFAULT_PATH
        {
            get
            {
                return _DEFAULT_PATH;
            }
            set
            {
                _DEFAULT_PATH = value;
            }
        }
        public string _DIR_OUTPUT;
        public string DIR_OUTPUT
        {
            get
            {
                return _DIR_OUTPUT;
            }
            set
            {
                _DIR_OUTPUT = value;
            }
        }

        /*От 0.0.2*/
        public string _TextDoc;
        public string TextDoc
        {
            get
            {
                return _TextDoc;
            }
            set
            {
                _TextDoc = value;
            }
        }

        public string _Image;
        public string Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
            }
        }
        #endregion

        #region Массив данных
        /*
        Строковые элементы, объединенные в одно поле (Переменную)         
        */
        private string[] word = new string[] { ".docx", ".dotx", ".doc", ".dot" };
        private string[] excel = new string[] { ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlam", ".xls", ".xlt", ".xla" };
        private string[] access = new string[] { ".accdb", ".mdb" };

        /*От 0.0.2*/
        private string[] text = new string[] { ".txt", ".log"};
        private string[] image = new string[] { ".bmp", ".tif", ".jpg", ".gif", ".png", ".ico"};
        #endregion
        public void Logger(string text )
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


        public void DirCreate()
        {
            if (!Directory.Exists(DIR_OUTPUT))
            {
                Directory.CreateDirectory(DIR_OUTPUT);
            }

            ExDir(Word);
            ExDir(Excel);
            ExDir(Access);
            /*0.0.2*/
            ExDir(TextDoc);
            ExDir(Image);

        }

        public void Search(bool MoveMethod)
        {
            var files = Directory.GetFiles(DEFAULT_PATH, "*.*", SearchOption.TopDirectoryOnly);
            DirectoryInfo target = new DirectoryInfo(DEFAULT_PATH);
            try
            {
                foreach (string t_path in files)
                {
                    
                    if (t_path.Length > 0)
                    {
                        FileInfo s = new FileInfo(t_path);

                        Console.WriteLine(s.FullName);

                        if (File.Exists(Word + @"\" + s.Name) || File.Exists(Excel + @"\" + s.Name) || File.Exists(Access + @"\" + s.Name) || File.Exists(TextDoc + @"\" + s.Name) || File.Exists(Image + @"\" + s.Name))
                        {
                            continue;
                        }

                        foreach (string w in word)
                        {
                            if (w == s.Extension)
                            {
                                if(MoveMethod == true)
                                {
                                    s.MoveTo(Path.Combine(Word.ToString(), s.Name));
                                }
                                else
                                {
                                    s.CopyTo(Path.Combine(Word.ToString(), s.Name), true);
                                   
                                }
                               
                            }
                        }
                        foreach (string e in excel)
                        {
                            if (e == s.Extension)
                            {
                                if (MoveMethod == true)
                                {
                                    s.MoveTo(Path.Combine(Excel.ToString(), s.Name));
                                }
                                else
                                {
                                    s.CopyTo(Path.Combine(Excel.ToString(), s.Name), true);

                                }

                            }
                        }
                        foreach (string a in access)
                        {
                            if (a == s.Extension)
                            {
                                if (MoveMethod == true)
                                {
                                    s.MoveTo(Path.Combine(Access.ToString(), s.Name));
                                }
                                else
                                {
                                    s.CopyTo(Path.Combine(Access.ToString(), s.Name), true);

                                }

                            }
                        }
                        // От 0.0.2
                        foreach (string t in text)
                        {
                            if (t == s.Extension)
                            {
                                if (MoveMethod == true)
                                {
                                    s.MoveTo(Path.Combine(TextDoc.ToString(), s.Name));
                                }
                                else
                                {
                                    s.CopyTo(Path.Combine(TextDoc.ToString(), s.Name), true);

                                }

                            }
                        }
                        foreach (string i in image)
                        {
                            if (i == s.Extension)
                            {
                                if (MoveMethod == true)
                                {
                                    s.MoveTo(Path.Combine(Image.ToString(), s.Name));
                                }
                                else
                                {
                                    s.CopyTo(Path.Combine(Image.ToString(), s.Name), true);

                                }

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                    Logger(e.Message);
            }
        }
    }
}
