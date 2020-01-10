using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.Crypto
{
    public class USD : Fiat
    {
        public string Symbol
        {
            get { return "$"; }
        }
    }
}
