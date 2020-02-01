
using System.Windows.Forms;

namespace DesktopCopy1
{
    public interface IMessageService
    {
        void Message(string text);

    }
    public class MessageService : IMessageService
    {
        public void Message(string text)
        {
            MessageBox.Show(text);
        }
    }
}
