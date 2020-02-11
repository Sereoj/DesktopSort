using System;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{
    public interface ISettingsPresenter
    {
        void Save();
    }

    //public class ChangeUsernamePresenter : BasePresener<IChangeUsernameview, User>
    internal class SettingsPresenter : BasePresener<IForm2, Settings>
    {
        public Settings Settings;

        public SettingsPresenter(IApplicationController controller, IForm2 view) : base(controller, view)
        {
           
           
            view.LoadFromFile("data.xml");

            if (view.Settings != null) Settings = view.Settings;

            view.ButtonSave += viewOnButtonSave;
            view.ButtonUpdate += view_ButtonUpdate;
            view.ButtonDefault += view_ButtonDefault;

            view.CheckBAccess += view_CheckBAccess;
            view.CheckBArchive += view_CheckBArchive;
            view.CheckBExcel += view_CheckBExcel;
            view.CheckBImages += view_CheckBImages;
            view.CheckBMedia += view_CheckBMedia;
            view.CheckBOtherDir += view_CheckBOtherDir;
            view.CheckBPDF += view_CheckBPDF;
            view.CheckBProject += view_CheckBProject;
            view.CheckBTextDoc += view_CheckBTextDoc;
            view.CheckBWord += view_CheckBWord;


        }

        private void view_ButtonDefault(object sender, EventArgs e)
        {
            new Data().GetDefault(Settings);
        }

        private void view_CheckBWord(object sender, EventArgs e)
        {
            var s =  Settings.Find(item => item.ID=="CheckWord"); 
            SetText(s.Catalog, s.Extension);
            
        }

        private void view_CheckBTextDoc(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckTextDoc"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBProject(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckProject"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBPDF(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckPDF"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBOtherDir(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckOtherDir"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBMedia(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckMedia"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBImages(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckImage"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBExcel(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckExcel"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBArchive(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckArchive"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_CheckBAccess(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID.Contains("CheckAccess"));
            SetText(s.Catalog, s.Extension);
        }

        private void view_ButtonUpdate(object sender, EventArgs e)
        {
            var s =  Settings.Find(x => x.ID == "CheckAccess");
            new MessageService().Message(s.IsChecked.ToString());
        }

        private void viewOnButtonSave(object sender, EventArgs e)
        {
            View.SaveToFile("data.xml");
        }

        public void SetText(string text, string text2)
        {
            View.TextDirectory1 = text;
            View.TextFormats1 = text2;
        }

        public override void Run(Settings argument)
        {
            View.Show();
        }
    }
}