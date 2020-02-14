using System.Windows.Forms;

namespace DesktopCopy1.Models
{
    public interface IMessageService
    {
        /// <summary>
        ///     Вывести диалоговое сообщение.
        /// </summary>
        /// <param name="text"></param>
        void Message(string text);
    }

    public class MessageService : IMessageService
    {
        /// <summary>
        ///     Обычное сообщение
        /// </summary>
        /// <param name="text"></param>
        public void Message(string text)
        {
            MessageBox.Show(text);
        }

        /// <summary>
        ///     Сообщение с заголовком
        /// </summary>
        /// <param name="text">Тестовое сообщение</param>
        /// <param name="text1">Название окна</param>
        public void Message(string text, string text1)
        {
            MessageBox.Show(text, text1);
        }

        /// <summary>
        ///     Сообщение об обновлении
        /// </summary>
        /// <param name="text">Тестовое сообщение</param>
        /// <param name="isUpdate">Параметр обновления</param>
        public void Message(string text, bool isUpdate)
        {
            if (!isUpdate) return;
            MessageBox.Show("Пожалуйста обновите программу.");
        }
    }
}