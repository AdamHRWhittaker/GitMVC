using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.Crypto
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int NumMarketPairs { get; set; }
        public DateTime DateAdded { get; set; }
        public List<string> Tags { get; set; }
        public string MaxSupply { get; set; }
        public string CirculatingSupply { get; set; }
        public string TotalSupply { get; set; }
        public object Platform { get; set; }
        public int Cmc_Rank { get; set; }
        public DateTime LastUpdated { get; set; }
        public Quote Quote { get; set; }
    }
}
