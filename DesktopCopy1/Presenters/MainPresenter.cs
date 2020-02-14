using System;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{
    public class MainPresenter : BasePresener<IMainForm>
    {
        /// <summary>
        ///     Переменная глобальная
        /// </summary>
        public readonly IForm2 _Form2;

        private readonly IBusinessLogic _logic;

        public MainPresenter(IApplicationController controller, IBusinessLogic service, IMainForm view,
            IForm2 form2) : base(
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

            _Form2.LoadFromFile("data.xml");
        }

        private void ControllerButtons(bool isMove)
        {
            try
            {
                _logic.DEFAULT_PATH = View.Editor1;
                _logic.DIR_OUTPUT = View.Editor2;
                _Form2.LoadFromFile("data.xml");
                for (var x = 0; x < _Form2.GetSettings().Setting.Count; x++)
                    if (_Form2.GetSettings().Setting[x].IsChecked)
                    {
                        _logic.ExDir(View.Editor2 + _Form2.GetSettings().Setting[x].Catalog);
                        _logic.Search(View.Editor2 + _Form2.GetSettings().Setting[x].Catalog,
                            _Form2.GetSettings().Setting[x].Extension, isMove);
                    }
            }
            catch (Exception exception)
            {
                new MessageService().Message(exception.Message, "Error");
                _logic.Logger(exception.Message);
            }
        }


        public void Add_ButtonCopyClick(object sender, EventArgs e)
        {
            ControllerButtons(false);
        }


        public void Add_ButtonCutClick(object sender, EventArgs e)
        {
            ControllerButtons(false);
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