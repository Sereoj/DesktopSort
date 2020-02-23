using DesktopCopy1.Common;
using DesktopCopy1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopCopy1.Models;

namespace DesktopCopy1.Presenters
{
    public class SettingsPresenterManager
    {
        public Settings Settings { get; set; }

        public string tmpCatalog { get; private set; }
        public string tmpFormat { get; private set; }

        private ISettingsBasic _view;
        public SettingsPresenterManager(ISettingsBasic view)
        {
            _view = view;

            view.LoadFromFile("data.xml");

            // Запись в переменную
            if (view.GetSettings() != null) Settings = view.GetSettings();

            view.ButtonSave += viewOnButtonSave;
            view.ButtonDefault += view_ButtonDefault;
            view.ButtonChanger += View_ButtonChanger;

            view.CheckBAccess += view_CheckBAccess;
            view.CheckBArchive += view_CheckBArchive;
            view.CheckBExcel += view_CheckBExcel;
            view.CheckBImages += view_CheckBImages;
            view.CheckBMedia += view_CheckBMedia;
            view.CheckBPDF += view_CheckBPDF;
            view.CheckBProject += view_CheckBProject;
            view.CheckBTextDoc += view_CheckBTextDoc;
            view.CheckBWord += view_CheckBWord;

            view.TemplateB1 += view_TemplateB1;
            view.TemplateB2 += View_TemplateB2;
            view.TemplateB3 += View_TemplateB3;
            view.TemplateB4 += View_TemplateB4;
            view.TemplateB5 += View_TemplateB5;
            view.TemplateB6 += View_TemplateB6;
            view.TemplateB7 += View_TemplateB7;
        }

             private void View_ButtonChanger(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x != null && x.Catalog == tmpCatalog);
            if (s != null)
            {
                s.Catalog = _view.TextDirectory1;
                s.Extension = _view.TextFormats1;
            }

            _view.SaveToFile("data.xml");
        }

        /// <summary>
        ///     Кнопка восстановить, 2-ая форма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void view_ButtonDefault(object sender, EventArgs e)
        {
            Settings.Default();
            _view.LoadFromFile("data.xml");
            _view.LoadCheckPoint();
        }

        private void view_CheckBWord(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(item => item.ID == "CheckWord");
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBTextDoc(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckTextDoc"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBProject(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckProject"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBPDF(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckPDF"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_TemplateB1(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template1"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBMedia(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckMedia"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBImages(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckImage"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBExcel(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckExcel"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBArchive(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckArchive"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBAccess(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("CheckAccess"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB7(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template7"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB6(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template6"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB5(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template5"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB4(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template4"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB3(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template3"));
            SetText(s.Catalog, s.Extension);
        }

        private void View_TemplateB2(object sender, EventArgs e)
        {
            var s = Settings.Setting.Find(x => x.ID.Contains("Template2"));
            SetText(s.Catalog, s.Extension);
        }

        private void viewOnButtonSave(object sender, EventArgs e)
        {
            _view.SaveToFile("data.xml");
        }

        /// <summary>
        ///     Передать значения.
        /// </summary>
        /// <param name="text">TextDirectory</param>
        /// <param name="text2">TextFormat</param>
        public void SetText(string text, string text2)
        {
            _view.TextDirectory1 = text;
            _view.TextFormats1 = text2;

            tmpCatalog = text;
            tmpFormat = text2;
        }

        public void Init()
        {
            _view.Show();
            
        }


    }
}
