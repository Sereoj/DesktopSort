using System;
using System.Collections.Generic;
using System.IO;

namespace DesktopCopy1.Models
{
    public interface IBusinessLogic
    {
        /// <summary>
        ///     От кого
        /// </summary>
        string DEFAULT_PATH { get; set; }

        /// <summary>
        ///     К кому
        /// </summary>
        string DIR_OUTPUT { get; set; }

        /// <summary>
        ///     Создание папок
        /// </summary>
        /// <param name="nameDirs">Принимает список</param>
        void DirCreate(List<string> nameDirs);

        /// <summary>
        ///     Проверка на сущ.-ние папки, нет - то создать.
        /// </summary>
        /// <param name="path"></param>
        void ExDir(string path);

        /// <summary>
        ///     Главная функция, поиска и переноса файлов
        /// </summary>
        /// <param name="type">Путь к папки используется как тип</param>
        /// <param name="pattern">Расширения файлов</param>
        /// <param name="moveMethod">Перенос файлов - true, копирование - false</param>
        void Search(string type, string pattern, bool moveMethod);

    }

    public class BusinessLogic : IBusinessLogic
    {

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
                new Logger(e.Message);
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
                    new Logger(e.Message);
                }
        }

        #region Поля/Свойства

        public string DEFAULT_PATH { get; set; }
        public string DIR_OUTPUT { get; set; }

        #endregion
    }
}