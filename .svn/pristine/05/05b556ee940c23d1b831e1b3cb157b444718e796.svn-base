using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class WarehouseData : IWarehouseData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[WarehouseData]";
        public WarehouseData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<WarehouseModel>> GetData(WarehouseModel warehouse = null)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");

            if (warehouse != null)
            {
                parameters.Add("@WhNm", warehouse.WhNm);
            }

            return _db.LoadData<WarehouseModel, dynamic>(sql, parameters);
        }

        public Task InsertData(WarehouseModel warehouse)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@WhNm", warehouse.WhNm);
            parameters.Add("@WhType", warehouse.WhType);
            parameters.Add("@WhLoc", warehouse.WhLoc);

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(string WhCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@WhCd", WhCd);

            return _db.DeleteData(sql, parameters);
        }

        public Task UpdateData(WarehouseModel warehouse)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@WhCd", warehouse.WhCd);
            parameters.Add("@WhNm", warehouse.WhNm);
            parameters.Add("@WhType", warehouse.WhType);
            parameters.Add("@WhLoc", warehouse.WhLoc);

            return _db.SaveData(sql, parameters);
        }
    }
}
