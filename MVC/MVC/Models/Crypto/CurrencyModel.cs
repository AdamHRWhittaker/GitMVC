using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class CurrencyModel
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string MarketCap { get; set; }
        public string Price { get; set; }
        public string Symbol { get; set; }
    }
}
