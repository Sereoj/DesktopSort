using System.IO;

namespace DesktopCopy1
{
    public interface ILogger
    {
       void Print(string text);
       bool IsLogger { get; set; }
    }

    internal class Logger : ILogger
    {
        protected string DefaultPath = "logger.txt";
        public bool IsLogger { get; set; }

        public Logger(string message)
        {
            Print(message);
            
        }
        public void Print(string text)
        {
            if (!IsLogger) return;
            var file = new StreamWriter(DefaultPath);
            file.WriteLine(text);
            file.Close();
        }



    }
}