using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using ServiceExchangeRate.Models;

namespace ServiceExchangeRate.Controllers
{
    public class ExchangeRateController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            //var url = "https://openexchangerates.org/api/historical/" + dateRequest + ".json?app_id=39eeb15e57a44405b41bed1c750e79ed";
            /*var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);
            return Ok(new CrcRate()
            {
                Colon = result.rates?.CRC ?? 560.50
            });*/
            return Ok(Historial.List());
        }

        public async Task<IHttpActionResult> Post(TipoCambio tipoCambio)
        {
            var tC = Historial.Add(tipoCambio);
            return Content(HttpStatusCode.OK, tC);
        }

        public async Task<IHttpActionResult> Get(string dateRequest)
        {
            return Ok(Historial.GetId(dateRequest));
        }

        public async Task<IHttpActionResult> Put(TipoCambio tipoCambio2)
        {
            var tC = Historial.Update(tipoCambio2);
            return Content(HttpStatusCode.OK, tC);
        }

        public async Task<IHttpActionResult> Delete(string id)
        {
            var tC = Historial.GetId(id);
            Historial.Delete(tC);
            return Content(HttpStatusCode.OK, tC);
        }

    }
}
