using DesktopCopy1.Common;
using DesktopCopy1.Models;
using DesktopCopy1.Views;

namespace DesktopCopy1.Presenters
{
    public class SwitcherSettingsPresenter : BasePresener<IForm2, Settings>
    {
        public Switcher _Switcher = new Switcher();

        public SwitcherSettingsPresenter(IApplicationController controller, IForm2 view, IMainForm main) : base(
            controller, view)
        {
            if (_Switcher.Control != null) View.Add(_Switcher.Control);
        }

        public override void Run(Settings argument)
        {
            View.Show();
        }
    }
}