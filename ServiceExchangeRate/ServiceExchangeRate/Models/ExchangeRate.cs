using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceExchangeRate.Models
{
    public class ExchangeRate
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string Base { get; set; }
        public Rates rates { get; set; }
    }
}