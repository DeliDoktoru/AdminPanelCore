using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanelCore.Log
{
    public class CustomLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var message = string.Format("{0}: {1} - {2}", logLevel.ToString(), eventId.Id, formatter(state, exception));
            WriteToFile(message);
           
        }
        private static void WriteToFile(string msg)
        {
            const string filePath = "C:\\Log\\AspCoreFileLog.txt";
            try
            {
                using (var streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(msg);
                    streamWriter.Close();
                }
            }
            catch (Exception e) {
                return;
            }
        }
    }
}
