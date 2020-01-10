using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.Crypto
{
    public abstract class Fiat
    {
        public double Price { get; set; }
        public double Volume_24h { get; set; }
        public double Percent_Change_1h { get; set; }
        public double Percent_Change_24h { get; set; }
        public double Percent_Change_7d { get; set; }
        public double Market_Cap { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
