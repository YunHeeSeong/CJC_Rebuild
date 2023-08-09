using Dapper;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class SalesData : ISalesData
    {
        private readonly ISqlDataAccess _db;
        private readonly string factSql = "[dbo].[Sales_FactData]";
        private readonly string storeSql = "[dbo].[Sales_StrData]";

        public SalesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SalesModel>> GetFactPDItemData(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<SalesModel, dynamic>(factSql, parameters);
        }

        public Task<List<SalesModel>> GetStorePDItemData(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<SalesModel, dynamic>(storeSql, parameters);
        }

        public Task<List<SalesModel>> GetStoreItemData(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<SalesModel, dynamic>(storeSql, parameters);
        }
    }
}
