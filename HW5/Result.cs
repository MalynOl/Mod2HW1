using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Result
    {
        private bool _status = true;

        public Result(bool status) => Status = status;

        public Result(bool status, string msg)
        {
            Status = status;
            Message = msg;
        }

        public Result()
        {
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string Message { get; set; }
    }
}