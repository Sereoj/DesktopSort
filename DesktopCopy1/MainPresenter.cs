using System;
using System.Collections.Generic;

namespace DesktopCopy1
{
    public interface IMainPresenter
    {
        void Run();
    }

    public class MainPresenter
    {

        private readonly IBusinessLogic logic;
        private readonly IMainForm form;
        private readonly IForm2 form2;


        public MainPresenter(IMainForm form, IForm2 form2,  IBusinessLogic logic)
        {
            this.form = form;
            this.form2 = form2;
            this.logic = logic;

            form.ButtonClick += new EventHandler(Add_ButtonCopyClick);
            form.ButtonCutClick += new EventHandler(Add_ButtonCutClick);
            form.ImageDialogClick += new EventHandler(Add_ImageDialogClick);
            form.ImageDialogClick1 += new EventHandler(Add_ImageDialogClick1);
            form.LinkSiteClick += new EventHandler(Add_LinkSiteClick);
        }


        public void Add_ButtonCopyClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(form.Editor1) || string.IsNullOrEmpty(form.Editor2))
            {
                //logic.DEFAULT_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //logic.DIR_OUTPUT = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            else
            {
                List<string> Dir = new List<string>();
                Dir.Add(form.Editor2 + @"/Access");
                Dir.Add(form.Editor2 + @"/Word");
                Dir.Add(form.Editor2 + @"/Excel");
                Dir.Add(form.Editor2 + @"/Project");
                Dir.Add(form.Editor2 + @"/Image");
                Dir.Add(form.Editor2 + @"/Text");


                //List<string> Ext = new List<string>();
                //Dir.Add(".accdb,*.mdb");
                //Dir.Add("*.docx,*.dotx,*.doc,*.dot");
                //Dir.Add("*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla");
                //Dir.Add(".bmp,*.tif,*.jpg,*.gif,*.png,*.ico");
                //Dir.Add(".txt,*.log");


                logic.DEFAULT_PATH = form.Editor1;
                logic.DIR_OUTPUT = form.Editor2;

                logic.DirCreate(Dir);
                logic.Search(Dir[0], ".accdb,*.mdb", false);
                logic.Search(Dir[1], "*.docx,*.dotx,*.doc,*.dot", false);
                logic.Search(Dir[2], "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla", false);
                logic.Search(Dir[2], "*.mpp", false);
                logic.Search(Dir[3], ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico", false);
                logic.Search(Dir[4], ".txt,*.log", false);
            }




        }


        public void Add_ButtonCutClick(object sender, EventArgs e)
        {
            //int x = -1;
            try
            {
                if (string.IsNullOrEmpty(form.Editor1) || string.IsNullOrEmpty(form.Editor2))
                {
                    //logic.DEFAULT_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    //logic.DIR_OUTPUT = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    List<string> Dir = new List<string>();
                    Dir.Add(form.Editor2 + @"/Access");
                    Dir.Add(form.Editor2 + @"/Word");
                    Dir.Add(form.Editor2 + @"/Excel");
                    Dir.Add(form.Editor2 + @"/Project");
                    Dir.Add(form.Editor2 + @"/Image");
                    Dir.Add(form.Editor2 + @"/Text");


                    //List<string> Ext = new List<string>();
                    //Dir.Add(".accdb,*.mdb");
                    //Dir.Add("*.docx,*.dotx,*.doc,*.dot");
                    //Dir.Add("*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla");
                    //Dir.Add(".bmp,*.tif,*.jpg,*.gif,*.png,*.ico");
                    //Dir.Add(".txt,*.log");


                    logic.DEFAULT_PATH = form.Editor1;
                    logic.DIR_OUTPUT = form.Editor2;

                    logic.DirCreate(Dir);

                    //string[] ext = new string[6] {".accdb,*.mdb",
                    //    "*.docx,*.dotx,*.doc,*.dot",
                    //    "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla",
                    //    "*.mpp",
                    //    ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico",
                    //    ".txt,*.log"

                    //};
                    
                    //foreach (string files in Dir)
                    //{
                    //    x++;
                    //    Console.WriteLine(files + "-" + ext[x]);
                    //    logic.Search(files, ext[x], true);
                        
                    //}
                    //x = -1;
                    logic.Search(Dir[0], ".accdb,*.mdb", true);
                    logic.Search(Dir[1], "*.docx,*.dotx,*.doc,*.dot", true);
                    logic.Search(Dir[2], "*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla", true);
                    logic.Search(Dir[3], "*.mpp", false);
                    logic.Search(Dir[4], ".bmp,*.tif,*.jpg,*.gif,*.png,*.ico", true);
                    logic.Search(Dir[5], ".txt,*.log", true);
                }

            }
            catch (Exception ex)
            {
                logic.Logger(ex.Message);
            }
        }
        public void Add_ImageDialogClick(object sender, EventArgs e)
        {
            form.Label = "Поле1 успешно заполнено";
        }
        public void Add_ImageDialogClick1(object sender, EventArgs e)
        {
            form.Label = "Поле2 успешно заполнено";
        }
        public void Add_LinkSiteClick(object sender, EventArgs e)
        {
            form.Label = "Здесь какое-то сообщение";
        }
    }
}
