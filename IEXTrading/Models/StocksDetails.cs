using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models
{
    public class StocksDetails
    {
        public string companyName { get; set; }
        public decimal priceToBook { get; set; }
        public decimal dividendRate { get; set; }
        
        public decimal latestEPS { get; set; }
        
        public string symbol { get; set; }
        public decimal week52high { get; set; }
        public decimal week52low { get; set; }
        public decimal EBITDA { get; set; }
        public decimal year1ChangePercent { get; set; }
    }
}
