using System;
using System.IO;
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
        private readonly ISettingsBasic _form2;
        private readonly IBusinessLogic _logic;
        private readonly IForm2 _sForm2;
        public MainPresenter(IApplicationController controller, IBusinessLogic service, IMainForm view, ISettingsBasic form2, IForm2 sForm2) : base(controller, view)
        {
            _form2 = form2;
            _logic = service;
            _sForm2 = sForm2;
            form2.LoadFromFile("data.xml");
            View.ButtonClick += Add_ButtonCopyClick;
            View.ButtonCutClick += Add_ButtonCutClick;
            View.ImageDialogClick += Add_ImageDialogClick;
            View.ImageDialogClick1 += Add_ImageDialogClick1;
            View.LinkSiteClick += Add_LinkSiteClick;
            View.ImageSettingsClick += Add_ImageSettingsClick;
            View.ImageHelperClick += View_ImageHelperClick;

        }

        private void View_ImageHelperClick(object sender, EventArgs e)
        {
            _sForm2.Add(SettingsAdvanced.Instance);
            _sForm2.Show();
        }

        private void ControllerMessage(string message, string type, string icon = "")
        {
            if (type != null)
            {

            }
        }


        private void ControllerButtons(bool isMove)
        {
            try
            {
                _logic.DEFAULT_PATH = View.Editor1;
                _logic.DIR_OUTPUT = View.Editor2;
                _form2.LoadFromFile("data.xml");
                for (var x = 0; x < _form2.GetSettings().Setting.Count; x++)
                    if (_form2.GetSettings().Setting[x].IsChecked)
                    {
                        _logic.ExDir(Path.Combine(View.Editor2 + "\\", _form2.GetSettings().Setting[x].Catalog));
                        _logic.Search(Path.Combine(View.Editor2 + "\\", _form2.GetSettings().Setting[x].Catalog),
                            _form2.GetSettings().Setting[x].Extension, isMove);
                    }
            }
            catch (Exception exception)
            {
                new MessageService().Message(exception.Message, "Error");
                new Logger(exception.Message);
            }
        }


        public void Add_ButtonCopyClick(object sender, EventArgs e)
        {
            ControllerButtons(false);
        }


        public void Add_ButtonCutClick(object sender, EventArgs e)
        {
            ControllerButtons(true);
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
            var settings = _form2.GetSettings();
            Controller.Run<SwitcherSettingsPresenter, Settings>(settings);
        }
    }
}