using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using POJOS;

namespace ServiceExchangeRate.Models
{
    public class Historial
    {
        private static Dictionary<string, ExchangeRate> TipoCambios = new Dictionary<string, ExchangeRate>
        {
            ["2020-01-25"] = new ExchangeRate() { Valor = 580, Dia = DateTime.Parse("2020-01-25") }
        };

        public static ExchangeRate Add(ExchangeRate tipoCambio)
        {
            TipoCambios.Add(tipoCambio.Dia.ToString("yyyy-MM-dd"), tipoCambio);
            return tipoCambio;
        }

        public static bool Delete(ExchangeRate tipoCambio)
        {
            return TipoCambios.Remove(tipoCambio.Dia.ToString("yyyy-MM-dd"));
        }

        public static ExchangeRate Update(ExchangeRate tipoCambio)
        {
            TipoCambios[tipoCambio.Dia.ToString("yyyy-MM-dd")] = tipoCambio;
            return tipoCambio;
        }

        public static Dictionary<string, ExchangeRate> List()
        {
            return TipoCambios;
        }

        public static ExchangeRate GetId(string key)
        {
            return TipoCambios[key];
        }
    }
}