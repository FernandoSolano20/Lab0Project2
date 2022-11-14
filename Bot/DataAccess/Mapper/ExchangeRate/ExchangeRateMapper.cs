using System;
using System.Collections.Generic;
using DataAccess.Dao;
using POJOS;

namespace DataAccess.Mapper.ExchangeRate
{
    public class ExchangeRateMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DB_COL_DATE = "DATERATE";
        private const string DB_COL_EXCHANGE_RATE = "EXCHANGERATE";
        //dcordoba@coffebitcr.com

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var entity = BuildObject(row);
                lstResults.Add(entity);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var exchangeRate = new POJOS.ExchangeRate
            {
                Dia = GetDateValue(row,DB_COL_DATE),
                Valor = GetDoubleValue(row, DB_COL_EXCHANGE_RATE),
            };

            return exchangeRate;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_EXCHANGE_RATE_PR" };

            var c = (POJOS.ExchangeRate)entity;
            operation.AddDateParam(DB_COL_DATE, c.Dia);
            operation.AddDoubleParam(DB_COL_EXCHANGE_RATE, c.Valor);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_EXCHANGE_RATE_PR" };

            var c = (POJOS.ExchangeRate)entity;
            operation.AddDateParam(DB_COL_DATE, c.Dia);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_EXCHANGE_RATE_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_EXCHANGE_RATE_PR" };

            var c = (POJOS.ExchangeRate)entity;
            operation.AddDateParam(DB_COL_DATE, c.Dia);
            operation.AddDoubleParam(DB_COL_EXCHANGE_RATE, c.Valor);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_EXCHANGE_RATE_PR" };

            var c = (POJOS.ExchangeRate)entity;
            operation.AddDateParam(DB_COL_DATE, c.Dia);
            return operation;
        }
    }
}
