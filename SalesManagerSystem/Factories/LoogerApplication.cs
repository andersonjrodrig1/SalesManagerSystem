using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Factories
{
    public class LoogerApplication : IDisposable
    {
        private static string DIRECTORY = @"C:\temp";

        public static void LoogerInformation(string klass, string method, string information)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------------------------------------------------------------------------");
            stringBuilder.AppendLine("Type Logger: Information");
            stringBuilder.AppendLine(string.Format("Class: {0}", klass));
            stringBuilder.AppendLine(string.Format("Method: {0}", method));
            stringBuilder.AppendLine(string.Format("Error: {0}", information));
            stringBuilder.AppendLine("------------------------------------------------------------------------");

            RegisterLooger(stringBuilder.ToString());
        }

        public static void LoogerWarnning(string klass, string method, Exception warning)
        {
            string warningString = warning.ToString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------------------------------------------------------------------------");
            stringBuilder.AppendLine("Type Logger: Warning");
            stringBuilder.AppendLine(string.Format("Class: {0}", klass));
            stringBuilder.AppendLine(string.Format("Method: {0}", method));
            stringBuilder.AppendLine(string.Format("Error: {0}", warningString));
            stringBuilder.AppendLine("------------------------------------------------------------------------");

            RegisterLooger(stringBuilder.ToString());
        }

        public static void LoogerError(string klass, string method, Exception error)
        {
            string errorString = error.ToString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------------------------------------------------------------------------");
            stringBuilder.AppendLine("Type Logger: Error");
            stringBuilder.AppendLine(string.Format("Class: {0}", klass));
            stringBuilder.AppendLine(string.Format("Method: {0}", method));
            stringBuilder.AppendLine(string.Format("Error: {0}", errorString));
            stringBuilder.AppendLine("------------------------------------------------------------------------");

            RegisterLooger(stringBuilder.ToString());
        }

        private static void RegisterLooger(string loogerDescription)
        {
            string subDirectory = DateTime.Now.ToString("yyyyMMdd");
            string path = string.Format("{0}{1}{2}", DIRECTORY, "\\", subDirectory);
            string archive = string.Format("{0}{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ".txt");

            try
            {
                if (!Directory.Exists(DIRECTORY))
                {
                    Directory.CreateDirectory(DIRECTORY);
                }

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string archivePath = string.Format("{0}\\{1}", path, archive);

                using (StreamWriter streamWriter = new StreamWriter(archivePath))
                {
                    FileInfo file = new FileInfo(archivePath);

                    if (!file.Exists)
                    {
                        file.Create();
                    }
                
                    streamWriter.WriteLine(loogerDescription);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (IOException ioe)
            {
                throw ioe;
            }
        }

        public void Dispose()
        {
        }
    }
}
