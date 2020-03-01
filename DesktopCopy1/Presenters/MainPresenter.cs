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

        private readonly Settings settings;

        public MainPresenter(IApplicationController controller, IBusinessLogic service, IMainForm view,
            ISettingsBasic form2, IForm2 sForm2) : base(controller, view)
        {
            _form2 = form2;
            _logic = service;
            _sForm2 = sForm2;
            form2.LoadFromFile("data.xml");
            View.ButtonClick += Add_ButtonCopyClick;
            View.ButtonCutClick += Add_ButtonCutClick;
            View.ImageSettingsClick += Add_ImageSettingsClick;
            View.ImageHelperClick += View_ImageHelperClick;

            settings = _form2.GetSettings();
        }

        private void View_ImageHelperClick(object sender, EventArgs e)
        {
            _sForm2.Add(SettingsInfo.Instance);
            _sForm2.Show();
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
                View.OnNotification(MessageService.SUCCESS);    
            }
            catch (Exception exception)
            {
                View.OnNotification(MessageService.ERROR_TEXT);  
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

        public void Add_ImageSettingsClick(object sender, EventArgs e)
        {
            Controller.Run<SwitcherSettingsPresenter, Settings>(settings);
        }
    }
}