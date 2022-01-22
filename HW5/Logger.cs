using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Logger
    {
        private static readonly Logger Log = new Logger();
        private StringBuilder _sbLogs;

        static Logger()
        {
        }

        private Logger()
        {
            _sbLogs = new StringBuilder();
        }

        public DateTime LogTime { get; set; }
        public TypeLog LogType { get; set; }

        public string LogMessage { get; set; }

        public string AllLogs => _sbLogs.ToString();
        public static Logger GetLog()
        {
                return Log;
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
            Log.LogType = tl;
            Log.LogMessage = mes;
            Log.LogTime = DateTime.Now;
            var log = $"{Log.LogTime.ToString()}: {Log.LogType.ToString()}: {Log.LogMessage.ToString()}\n";
            _sbLogs.Append(log);
            Console.WriteLine(log);
        }
    }
}
