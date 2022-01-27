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
        private Logger _instance;
        public Starter()
        {
            _action = new Action();
            _instance = Logger.GetLog();
        }

        internal void Run()
        {
            Result result = new Result();
            for (int i = 0; i < 100; i++)
            {
                int typeActionMethod = new Random().Next(1, 4);

                switch (typeActionMethod)
                {
                    case 1:
                        result = _action.CreateLogInfo();
                        break;
                    case 2:
                        result = _action.CreateLogWarning();
                        break;
                    case 3:
                        result = _action.BrokeLogic();
                        break;
                }

                if (!result.Status)
                {
                    _instance.LoggerError($"Action failed by a reason: {result.Message}");
                }

                File.WriteAllText(@"log.txt", _instance.AllLogs);
            }
        }
    }
}
