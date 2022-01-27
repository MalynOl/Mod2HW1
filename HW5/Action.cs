using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Action
    {
        private readonly Logger _instance = Logger.GetLog();
        internal Result CreateLogInfo()
        {
            _instance.LoggerInfo($"Start method: CreateLogInfo()");
            Result result = new Result(true);
            return result;
        }

        internal Result CreateLogWarning()
        {
            _instance.LoggerWarning("Skipped logic in method: CreateLogWarning()");
            Result result = new Result(true);
            return result;
        }

        internal Result BrokeLogic()
        {
            Result result = new Result(false, "I broke a logic");
            return result;
        }
    }
}
