using System;
using System.Collections.Generic;
using System.IO;

namespace DesktopCopy1.Models
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

        public void Logger(string text)
        {
            var file = new StreamWriter(DEFAULT_PATH + @"\logger.txt");
            file.WriteLine(text);
            file.Close();
        }

        public void ExDir(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        public void DirCreate(List<string> NameDirs)
        {
            ExDir(DEFAULT_PATH);
            ExDir(DIR_OUTPUT);
            try
            {
                foreach (var DIR in NameDirs) ExDir(DIR);
            }
            catch (Exception e)
            {
                Logger(e.Message);
            }
        }

        public void Search(string type, string pattern, bool MoveMethod)
        {
            foreach (var t_path in Directory.GetFiles(DEFAULT_PATH, "*.*".ToLower(), SearchOption.TopDirectoryOnly))
                try
                {
                    var Ext = Path.GetExtension(t_path);
                    if (pattern.Contains(Ext.ToLower()) && Ext.Length > 0)
                    {
                        var s = new FileInfo(t_path);
                        if (File.Exists(Path.Combine(type, s.Name)))
                        {
                        }
                        else
                        {
                            if (MoveMethod)
                                s.MoveTo(Path.Combine(type, s.Name));
                            else
                                s.CopyTo(Path.Combine(type, s.Name), true);
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