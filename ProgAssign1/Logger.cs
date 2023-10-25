using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace ProgAssign1
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string logDirectory, string path)
        {
            this.logFilePath = Path.Combine(logDirectory, path);

        }
        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO] {message}";
            writeLog(logEntry);
        }
        private void writeLog(string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(message);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }


    }

}
