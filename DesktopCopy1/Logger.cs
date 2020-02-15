using System.IO;

namespace DesktopCopy1
{
    public interface ILogger
    {
       void Print(string text);
    }

    internal class Logger : ILogger
    {
        public string DEFAULT_PATH = "logger.txt";

        public Logger(string Message)
        {
            Print(Message);
        }
        public void Print(string text)
        {
            var file = new StreamWriter(DEFAULT_PATH);
            file.WriteLine(text);
            file.Close();
        }



    }
}