using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.Crypto
{
    public class Crypto
    {
        public Status Status { get; set; }
        public List<Data> Data { get; set; }
    }
}
