using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task1.Models
{
    public class Rates
    {
        [JsonProperty("USD")]
        public double Usd { get; set; }

        [JsonProperty("GBP")]
        public double Gbp { get; set; }

        [JsonProperty("EUR")]
        public double Eur { get; set; }

        // Add other currencies as needed
    }
}
