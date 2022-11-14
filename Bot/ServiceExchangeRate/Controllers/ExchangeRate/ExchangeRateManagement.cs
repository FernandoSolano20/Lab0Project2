using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Crud.ExchangeRate;

namespace ServiceExchangeRate.Controllers.ExchangeRate
{
    public class ExchangeRateManagement
    {
        private ExchangeRateCrudFactory crudExchangeRate;

        public ExchangeRateManagement()
        {
            crudExchangeRate = new ExchangeRateCrudFactory();
        }

        public void Create(POJOS.ExchangeRate exchangeRate)
        {
            
            crudExchangeRate.Create(exchangeRate);

        }


        public List<POJOS.ExchangeRate> RetrieveAll()
        {
            return crudExchangeRate.RetrieveAll<POJOS.ExchangeRate>();
        }

        public POJOS.ExchangeRate RetrieveById(POJOS.ExchangeRate exchangeRate)
        {
            return crudExchangeRate.Retrieve<POJOS.ExchangeRate>(exchangeRate);
        }

        internal void Update(POJOS.ExchangeRate exchangeRate)
        {
            crudExchangeRate.Update(exchangeRate);
        }

        internal void Delete(POJOS.ExchangeRate exchangeRate)
        {
            crudExchangeRate.Delete(exchangeRate);
        }
    }
}