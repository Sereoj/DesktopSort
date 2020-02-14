namespace DesktopCopy1
{
    public interface ILogger
    {
        void Print();
    }

    internal class Logger : ILogger
    {
        /// <summary>
        ///     Вывод сообщения
        /// </summary>
        public void Print()
        {
        }
    }
}