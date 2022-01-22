using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW5
{
    internal class Starter
    {
        private Action _action;
        private Logger _logger;
        private Result _result;
        public Starter()
        {
            _action = new Action();
            _logger = Logger.GetLog();
            _result = new Result();
        }

        internal void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                int typeActionMethod = new Random().Next(1, 4);

                switch (typeActionMethod)
                {
                    case 1:
                        _result = _action.CreateLogInfo();
                        break;
                    case 2:
                        _result = _action.CreateLogWarning();
                        break;
                    case 3:
                        _result = _action.BrokeLogic();
                        break;
                }

                if (!_result.Status)
                {
                    _logger.LoggerError($"Action failed by a reason: {_result.Message}");
                }

                File.WriteAllText(@"log.txt", _logger.AllLogs);
            }
        }
    }
}
