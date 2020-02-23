using System;
using System.Windows.Forms;
using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{

    public class SwitcherSettingsPresenter : BasePresener<IForm2, Settings>
    {
        public Settings Settings { get; set; }
        public Switcher _Switcher = new Switcher();

        public SwitcherSettingsPresenter(IApplicationController controller,IForm2 view) : base(controller, view)
        {

            if (_Switcher.Control != null)
            {
                View.Add(_Switcher.Control);
                
            }
        }



        /// <summary>
        ///     Показать форму2.
        /// </summary>
        /// <param name="argument"></param>
        public override void Run(Settings argument)
        { 
            
            //Controller.Run<SettingsPresenterManager, Settings>(argument);
            View.Show();
        }
    }
}