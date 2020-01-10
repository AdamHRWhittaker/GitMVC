using MVC.Helpers;
using MVC.Models;
using MVC.Models.Crypto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace MVC.Managers
{
    public class CurrencyManager
    {
        private readonly string API_KEY = "dae93059-c7e8-4211-81bd-b65fb32df1ad";
        public CurrencyManager()
        {

        }

        public IEnumerable<CurrencyModel> GetCurrencies()
        {
            var helper = new Helper();
            var cryptoData = helper.DeserializeObject<Crypto>(CallAPI());
            List<CurrencyModel> currencyModels = new List<CurrencyModel>();

            foreach (var crypto in cryptoData.Data)
            {
                currencyModels.Add(SelectFiat(crypto));
            }

            return currencyModels;
        }

        private CurrencyModel SelectFiat(Data crypto) {
            if (crypto.Quote.USD != null)
            {
                return new CurrencyModel
                {
                    Rank = crypto.Cmc_Rank,
                    Name = crypto.Name,
                    Symbol = crypto.Quote.USD.Symbol,
                    MarketCap = crypto.Quote.USD.Market_Cap.ToString("C", new CultureInfo("en-US")),
                    Price = crypto.Quote.USD.Price.ToString("C", new CultureInfo("en-US"))
                };
            }

            if (crypto.Quote.GBP != null)
            {
                return new CurrencyModel
                {
                    Rank = crypto.Cmc_Rank,
                    Name = crypto.Name,
                    Symbol = crypto.Quote.GBP.Symbol,
                    MarketCap = crypto.Quote.GBP.Market_Cap.ToString("C", new CultureInfo("en-GB")),
                    Price = crypto.Quote.GBP.Price.ToString("C", new CultureInfo("en-GB"))
                };
            }

            return null;
        }
        private string CallAPI() {
            string API_KEY = "dae93059-c7e8-4211-81bd-b65fb32df1ad";

            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "100";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());
        }
    }
}
