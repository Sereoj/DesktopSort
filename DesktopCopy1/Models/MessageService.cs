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
        public const string FILE_NOT_FOUND = "Файл не найден";
        public const string UPDATE_TEXT = "Доступно обновление";
        public const string UPDATE_TEXT1 = "Обновлений не обнаружено";
        public const string ERROR_TEXT = "Неизвестная ошибка";
        public const string WELLCOME_TEXT = "Добро пожаловать";
        public const string SUCCESS = "Успешно";
        public const string PARAMS_FALSE = "Не заданы параметры";


        public string Context { get; set; }


        /// <summary>
        ///     Обычное сообщение
        /// </summary>
        /// <param name="text"></param>
        public void Message(string text)
        {
            Message1("1", "2");
            MessageBox.Show(text);
        }

        /// <summary>
        ///     Сообщение с заголовком
        /// </summary>
        /// <param name="text">Тестовое сообщение</param>
        /// <param name="text1">Название окна</param>
        private void Message1(string text, string text1)
        {
            MessageBox.Show(text, text1);
        }
    }
}