using System;
using System.Collections.Generic;
using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1
{
    public class MainPresenter : BasePresener<IMainForm>
    {
        private readonly IBusinessLogic logic;


        public MainPresenter(IApplicationController controller, IBusinessLogic service, IMainForm _View) : base(
            controller, _View)
        {
            logic = service;
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
                var dir = new List<string>
                {
                    View.Editor2 + @"/Access",
                    View.Editor2 + @"/Word",
                    View.Editor2 + @"/Excel",
                    View.Editor2 + @"/Project",
                    View.Editor2 + @"/Image",
                    View.Editor2 + @"/Text"
                };

                logic.DEFAULT_PATH = View.Editor1;
                logic.DIR_OUTPUT = View.Editor2;

                logic.DirCreate(dir);
                logic.Search(dir[0], ".accdb,*.mdb", false);
                logic.Search(dir[1], "*.docx,*.dotx,*.doc,*.dot", false);
                logic.Search(dir[2], "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla", false);
                logic.Search(dir[3], "*.mpp", false);
                logic.Search(dir[4], ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico", false);
                logic.Search(dir[5], ".txt,*.log", false);
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
                    var Dir = new List<string>
                    {
                        View.Editor2 + @"/Access", View.Editor2 + @"/Word", View.Editor2 + @"/Excel",
                        View.Editor2 + @"/Project",
                        View.Editor2 + @"/Image",
                        View.Editor2 + @"/Text"
                    };

                    logic.DEFAULT_PATH = View.Editor1;
                    logic.DIR_OUTPUT = View.Editor2;

                    logic.DirCreate(Dir);
                    logic.Search(Dir[0], ".accdb,*.mdb", true);
                    logic.Search(Dir[1], "*.docx,*.dotx,*.doc,*.dot", true);
                    logic.Search(Dir[2], "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla", true);
                    logic.Search(Dir[2], "*.mpp", false);
                    logic.Search(Dir[3], ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico", true);
                    logic.Search(Dir[4], ".txt,*.log", true);
                }
            }
            catch (Exception ex)
            {
                logic.Logger(ex.Message);
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