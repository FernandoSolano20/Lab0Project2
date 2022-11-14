using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceExchangeRate.Models
{
    public static class Historial
    {
        private static Dictionary<string, TipoCambio> TipoCambios = new Dictionary<string, TipoCambio>
        {
            ["2020-01-25"] = new TipoCambio() { Valor = 580 ,Dia = "2020-01-25"}
        };

        public static TipoCambio Add(TipoCambio tipoCambio)
        {
            TipoCambios.Add(tipoCambio.Dia, tipoCambio);
            return tipoCambio;
        }

        public static bool Delete(TipoCambio tipoCambio)
        {
            return TipoCambios.Remove(tipoCambio.Dia);
        }

        public static TipoCambio Update(TipoCambio tipoCambio)
        {
            TipoCambios[tipoCambio.Dia] = tipoCambio;
            return tipoCambio;
        }

        public static Dictionary<string,TipoCambio> List()
        {
            return TipoCambios;
        }

        public static TipoCambio GetId(string key)
        {
            return TipoCambios[key];
        }
    }
}