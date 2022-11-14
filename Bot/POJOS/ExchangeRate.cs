using System;

namespace POJOS
{
    public class ExchangeRate : BaseEntity
    {
        public double Valor { get; set; }
        public DateTime Dia { get; set; }

        public ExchangeRate()
        {

        }
    }
}
