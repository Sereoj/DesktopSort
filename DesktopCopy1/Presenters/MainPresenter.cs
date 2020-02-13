using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{
    public class MainPresenter : BasePresener<IMainForm>
    {
        /// <summary>
        /// Переменная глобальная
        /// </summary>
        public readonly IForm2 _Form2;
        private readonly IBusinessLogic _logic;

        public MainPresenter(IApplicationController controller, IBusinessLogic service, IMainForm view, IForm2 form2) : base(
            controller, view)
        {
            _Form2 = form2;
            _logic = service;
            //_form2 = form2;
            View.ButtonClick += Add_ButtonCopyClick;
            View.ButtonCutClick += Add_ButtonCutClick;
            View.ImageDialogClick += Add_ImageDialogClick;
            View.ImageDialogClick1 += Add_ImageDialogClick1;
            View.LinkSiteClick += Add_LinkSiteClick;
            View.ImageSettingsClick += Add_ImageSettingsClick;

        }
        public void Add_ButtonCopyClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(View.Editor1) || string.IsNullOrEmpty(View.Editor2) || View.Editor1.Length < 1 ||
                View.Editor2.Length < 1)
            {
            }
            else
            {

                new MessageService().Message("Извините!Данная функция временно отключена.Пожалуйста подождите обновление");
                //_logic.DEFAULT_PATH = View.Editor1;
                //_logic.DIR_OUTPUT = View.Editor2;

                //for (int x = 0; x <  _Form2.Settings.Setting.Count; x++)
                //{
                //    _logic.ExDir(View.Editor2 + _Form2.Settings.Setting[x].Catalog);
                //    _logic.Search(View.Editor2 + _Form2.Settings.Setting[x].Catalog, _Form2.Settings.Setting[x].Extension, false);
                //}
                   
            }

        }




        public void Add_ButtonCutClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(View.Editor1) || string.IsNullOrEmpty(View.Editor2) ||
                    View.Editor1.Length < 1 || View.Editor2.Length < 1)
                {
                }
                else
                {
                    var dir = new List<string>
                    {
                        View.Editor2 + @"/Access", View.Editor2 + @"/Word", View.Editor2 + @"/Excel",
                        View.Editor2 + @"/Project",
                        View.Editor2 + @"/Image",
                        View.Editor2 + @"/Text"
                    };

                    _logic.DEFAULT_PATH = View.Editor1;
                    _logic.DIR_OUTPUT = View.Editor2;

                    _logic.DirCreate(dir);
                    _logic.Search(dir[0], ".accdb,*.mdb", true);
                    _logic.Search(dir[1], "*.docx,*.dotx,*.doc,*.dot", true);
                    _logic.Search(dir[2], "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla", true);
                    _logic.Search(dir[2], "*.mpp", false);
                    _logic.Search(dir[3], ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico", true);
                    _logic.Search(dir[4], ".txt,*.log", true);
                }
            }
            catch (Exception ex)
            {
                _logic.Logger(ex.Message);
            }
        }

        public void Add_ImageDialogClick(object sender, EventArgs e)
        {
        
            View.Label = "Поле1 успешно заполнено";
        }

        public void Add_ImageDialogClick1(object sender, EventArgs e)
        {
            View.Label = "Поле2 успешно заполнено";
        }

        public void Add_LinkSiteClick(object sender, EventArgs e)
        {
            View.Label = "Здесь какое-то сообщение";
        }

        public void Add_ImageSettingsClick(object sender, EventArgs e)
        {
            var user = new Settings(); 
            //Console.WriteLine(user.Count.ToString());
            Controller.Run<SettingsPresenter, Settings>(user);
        }


    }
}