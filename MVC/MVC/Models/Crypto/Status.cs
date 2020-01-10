using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.Crypto
{
    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int ErrorCode { get; set; }
        public object ErrorMessage { get; set; }
        public int Elapsed { get; set; }
        public int CreditCount { get; set; }
        public object Notice { get; set; }
    }
}
