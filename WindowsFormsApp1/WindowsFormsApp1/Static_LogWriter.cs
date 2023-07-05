using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Static_LogWriter
    {
        private string m_exePath = string.Empty;

        public Static_LogWriter(string logMessage)
        {
            LogWrite(logMessage);
        }
        public Static_LogWriter(int x, int y)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            File.WriteAllText(m_exePath + "\\" + "log.txt", String.Empty);
        }
        public void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
            {
                Log(logMessage, w);
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            var dt = DateTime.Now;
            txtWriter.WriteLine(dt.ToString("yyyy/MM/dd") + " " + dt.ToString("HH:mm:ss") + " " + logMessage);
        }
    }
}
