using DesktopCopy1.Common;
using DesktopCopy1.Models;

namespace DesktopCopy1
{
    public interface ISettingsPresenter
    {
        void Save();
    }

    //public class ChangeUsernamePresenter : BasePresener<IChangeUsernameView, User>
    internal class SettingsPresenter : BasePresener<IForm2, Settings>
    {
        public SettingsPresenter(IApplicationController controller, IForm2 view) : base(controller, view)
        {
        }

        public override void Run(Settings argument)
        {
            View.Show();
        }
    }
}