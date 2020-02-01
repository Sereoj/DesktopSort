using DesktopCopy1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCopy1
{
    public interface ISettingsPresenter
    {
        void Save(); 
    }

    //public class ChangeUsernamePresenter : BasePresener<IChangeUsernameView, User>
    class SettingsPresenter : BasePresener<IForm2, Settings>
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
