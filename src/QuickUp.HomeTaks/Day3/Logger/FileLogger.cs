using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Logger
{
    public class FileLogger : ILogger
    {
        private string _filepath;
        private object _lock = new object();

        public FileLogger(string path)
        {
            _filepath = path;
        }
        public IDisposable BeginScope<Tstate>(Tstate state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel loglevel)
        {
            return loglevel == LogLevel.Trace;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock (_lock)
                {

                    File.AppendAllText(_filepath, formatter(state, exception) + Environment.NewLine);
                   
                }

            }
        }
    }
}
