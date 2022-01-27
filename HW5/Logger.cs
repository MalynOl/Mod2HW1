using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Logger
    {
        private static readonly Logger Instance = new Logger();
        private StringBuilder _sbLogs;

        static Logger()
        {
        }

        private Logger()
        {
            _sbLogs = new StringBuilder();
        }

        public string AllLogs => _sbLogs.ToString();
        public static Logger GetLog()
        {
                return Instance;
        }

        public void LoggerInfo(string messageLog)
        {
            LoggerSet(TypeLog.Info, messageLog);
        }

        public void LoggerWarning(string messageLog)
        {
            LoggerSet(TypeLog.Warning, messageLog);
        }

        public void LoggerError(string messageLog)
        {
            LoggerSet(TypeLog.Error, messageLog);
        }

        public void LoggerSet(TypeLog tl, string mes)
        {
            var log = $"{DateTime.Now.ToString()}: {tl.ToString()}: {mes.ToString()}\n";
            _sbLogs.Append(log);
            Console.WriteLine(log);
        }
    }
}
