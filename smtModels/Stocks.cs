using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace smtModels
{
    public class Stocks
    {
        public Stocks(string companyName, string ticker, int totalStocks, long marketCap, decimal pastPrice, decimal currentPrice)
        {
            CompanyName = companyName;
            Ticker = ticker;
            TotalStocks = totalStocks;
            MarketCap = marketCap;
            PastPrice = pastPrice;
            CurrentPrice = currentPrice;
        }

        string CompanyName { get; set; }
        string Ticker { get; set; } 
        int TotalStocks { get; set; }   
        long MarketCap { get; set; }    
        decimal PastPrice { get; set; }
        decimal CurrentPrice { get; set; }

    }
}
