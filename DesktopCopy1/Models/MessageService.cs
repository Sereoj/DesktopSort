using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    public interface IMessageService
    {
        /// <summary>
        /// Вывести диалоговое сообщение.
        /// </summary>
        /// <param name="text"></param>
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