using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task1.Models
{
    public class CurrencyRate
    {
        public string BaseCurrency { get; set; }
        public Dictionary<string, decimal> Rates { get; set; }
    }
}