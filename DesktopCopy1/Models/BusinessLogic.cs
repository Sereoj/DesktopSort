using System;
using System.Collections.Generic;
using System.IO;

namespace DesktopCopy1.Models
{
    public interface IBusinessLogic
    {
        void DirCreate(List<string> nameDirs);
        void ExDir(string path);
        void Search(string type, string pattern, bool moveMethod);
        void Logger(string text);
        string DEFAULT_PATH { get; set; }
        string DIR_OUTPUT { get; set; }
    }

    public class BusinessLogic : IBusinessLogic
    {
        #region Поля/Свойства

        public string DEFAULT_PATH { get; set; }
        public string DIR_OUTPUT { get; set; }

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

        public void DirCreate(List<string> nameDirs)
        {
            ExDir(DEFAULT_PATH);
            ExDir(DIR_OUTPUT);
            try
            {
                foreach (var dir in nameDirs) ExDir(dir);
            }
            catch (Exception e)
            {
                Logger(e.Message);
            }
        }

        public void Search(string type, string pattern, bool moveMethod)
        {
            foreach (var tPath in Directory.GetFiles(DEFAULT_PATH, "*.*".ToLower(), SearchOption.TopDirectoryOnly))
                try
                {
                    var ext = Path.GetExtension(tPath);
                    if (ext != null && pattern.Contains(ext.ToLower()) && ext.Length > 0)
                    {
                        var s = new FileInfo(tPath);
                        if (File.Exists(Path.Combine(type, s.Name)))
                        {
                        }
                        else
                        {
                            if (moveMethod) s.MoveTo(Path.Combine(type, s.Name));
                            else s.CopyTo(Path.Combine(type, s.Name), true);
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