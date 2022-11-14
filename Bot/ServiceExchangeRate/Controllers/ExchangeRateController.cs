using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using POJOS;
using ServiceExchangeRate.Models;

namespace ServiceExchangeRate.Controllers
{
    public class ExchangeRateController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            return Ok(Historial.List());
        }

        public async Task<IHttpActionResult> Post(POJOS.ExchangeRate tipoCambio)
        {
            var tC = Historial.Add(tipoCambio);
            //management.Create(tipoCambio);
            return Content(HttpStatusCode.OK, tC);
        }

        public async Task<IHttpActionResult> Get(string dateRequest)
        {
            var exchangeRate = new POJOS.ExchangeRate
            {
                Dia = DateTime.Parse(dateRequest)
            };
            //management.RetrieveById(exchangeRate)
            return Ok(Historial.GetId(dateRequest));
        }

        public async Task<IHttpActionResult> Put(POJOS.ExchangeRate tipoCambio2)
        {
            var tC = Historial.Update(tipoCambio2);
            //management.Update(tipoCambio2);
            return Content(HttpStatusCode.OK, tC);
        }

        public async Task<IHttpActionResult> Delete(string id)
        {
            var tC = Historial.GetId(id);
            Historial.Delete(tC);
            //var exchangeRate = new POJOS.ExchangeRate()
            //{
            //    Dia = DateTime.Parse(id)
            //};
            //management.Delete(exchangeRate);
            return Content(HttpStatusCode.OK, tC);
        }
    }
}
