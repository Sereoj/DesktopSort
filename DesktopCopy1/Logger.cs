using System.IO;

namespace DesktopCopy1
{
    public interface ILogger
    {
        bool IsLogger { get; set; }
        void Print(string text);
    }

    internal class Logger : ILogger
    {
        protected string DefaultPath = "logger.txt";

        public Logger(string message)
        {
            Print(message);
        }

        public bool IsLogger { get; set; }

        public void Print(string text)
        {
            if (!IsLogger) return;
            var file = new StreamWriter(DefaultPath);
            file.WriteLine(text);
            file.Close();
        }
    }
}