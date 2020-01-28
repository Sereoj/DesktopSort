using System;
using System.Collections.Generic;

namespace DesktopCopy1
{
    public class MainPresenter
    {

        private readonly IBusinessLogic logic;
        private readonly IMainForm form;


        public MainPresenter(IMainForm form, IBusinessLogic logic)
        {
            this.form = form;
            this.logic = logic;


            form.ButtonClick += new EventHandler(Add_ButtonCopyClick);
            form.ButtonCutClick += new EventHandler(Add_ButtonCutClick);
            form.ImageDialogClick += new EventHandler(Add_ImageDialogClick);
            form.ImageDialogClick1 += new EventHandler(Add_ImageDialogClick1);
            form.LinkSiteClick += new EventHandler(Add_LinkSiteClick);
        }

        protected void MainSettinger(bool[] setting, bool isCut)
        {
            //System.IO.SearchOption search = System.IO.SearchOption.AllDirectories;
            //logic.Excel = form.Editor2 + @"/Excel";
            //logic.Word = form.Editor2 + @"/Word";
            //logic.Access = form.Editor2 + @"/Access";
            //logic.TextDoc = form.Editor2 + @"/Text";
            //logic.Image = form.Editor2 + @"/Image";

            //logic.DEFAULT_PATH = form.Editor1;
            //logic.DIR_OUTPUT = form.Editor2;

            //string[] word = new string[] { ".docx", ".dotx", ".doc", ".dot" };
            //string[] excel = new string[] { ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlam", ".xls", ".xlt", ".xla" };
            //string[] access = new string[] { ".accdb", ".mdb" };

            ///*От 0.0.2*/
            //string[] text = new string[] { ".txt", ".log" };
            //string[] image = new string[] { ".bmp", ".tif", ".jpg", ".gif", ".png", ".ico" };
            //if (setting[0])
            //{
            //    logic.test_Search(System.IO.SearchOption.TopDirectoryOnly, logic.Word, word, isCut);
            //}
            //if (setting[1])
            //{
            //    logic.test_Search(System.IO.SearchOption.TopDirectoryOnly, logic.Excel, excel, isCut);
            //}
            //if (setting[2])
            //{
            //    logic.test_Search(System.IO.SearchOption.TopDirectoryOnly, logic.Access, access, isCut);
            //}
            //if (setting[3])
            //{
            //    logic.test_Search(System.IO.SearchOption.TopDirectoryOnly, logic.TextDoc, text, isCut);
            //}
            //if (setting[4])
            //{
            //    logic.test_Search(System.IO.SearchOption.TopDirectoryOnly, logic.Image, image, isCut);
            //}


        }
        public void Add_ButtonCopyClick(object sender, EventArgs e)
        {
            List<string> Dir = new List<string>();
            Dir.Add(form.Editor2 + @"/Access");
            Dir.Add(form.Editor2 + @"/Word");
            Dir.Add(form.Editor2 + @"/Excel");
            Dir.Add(form.Editor2 + @"/Image");
            Dir.Add(form.Editor2 + @"/Text");

            List<string> Ext = new List<string>();
            Dir.Add(".accdb,*.mdb");
            Dir.Add("*.docx,*.dotx,*.doc,*.dot");
            Dir.Add("*.xlsx,*.xlsm,*.xltx,*.xltm,*.xlam,*.xls,*.xlt,*.xla");
            Dir.Add(".bmp,*.tif,*.jpg,*.gif,*.png,*.ico");
            Dir.Add(".txt,*.log");


            logic.DEFAULT_PATH = form.Editor1;
            logic.DIR_OUTPUT = form.Editor2;

            logic.DirCreate(Dir);
            
            for(int x = 0; x < 3; x++)
            {
                logic.Search(Dir[x] , Ext[x], false);
            }
            
            //logic.test_Search(Dir[0], "*.txt,*.doc,*.jpg", false);

        }

        public void Add_ButtonCutClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(form.Editor1) || string.IsNullOrEmpty(form.Editor2) || form.Editor1.Length < 1 || form.Editor2.Length < 1)
                {
                    //logic.DEFAULT_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    //logic.DIR_OUTPUT = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    //logic.Excel = form.Editor2 + @"/Excel";
                    //logic.Word = form.Editor2 + @"/Word";
                    //logic.Access = form.Editor2 + @"/Access";

                    //logic.TextDoc = form.Editor2 + @"/Text";
                    //logic.Image = form.Editor2 + @"/Image";

                    //logic.DEFAULT_PATH = form.Editor1;
                    //logic.DIR_OUTPUT = form.Editor2;

                    //logic.DirCreate();
                    //logic.Search(true);
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
