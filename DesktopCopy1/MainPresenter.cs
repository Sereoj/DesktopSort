using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Add_ButtonCopyClick(object sender, EventArgs e)
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
                        logic.Excel = form.Editor2 + @"/Excel";
                        logic.Word = form.Editor2 + @"/Word";
                        logic.Access = form.Editor2 + @"/Access";

                        logic.TextDoc = form.Editor2 + @"/Text";
                        logic.Image = form.Editor2 + @"/Image";
                        
                        logic.DEFAULT_PATH = form.Editor1;
                        logic.DIR_OUTPUT = form.Editor2;

                        logic.DirCreate();
                        logic.Search(false);
                }

            }
            catch (Exception ex)
            {
                logic.Logger(ex.Message);
            }

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
                    logic.Excel = form.Editor2 + @"/Excel";
                    logic.Word = form.Editor2 + @"/Word";
                    logic.Access = form.Editor2 + @"/Access";

                    logic.TextDoc = form.Editor2 + @"/Text";
                    logic.Image = form.Editor2 + @"/Image";

                    logic.DEFAULT_PATH = form.Editor1;
                    logic.DIR_OUTPUT = form.Editor2;

                    logic.DirCreate();
                    logic.Search(true);
                }

            }
            catch (Exception ex)
            {
                logic.Logger(ex.Message);
            }
        }
        public void Add_ImageDialogClick(object sender , EventArgs e)
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
