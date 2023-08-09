using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class OrderMonitoringData : IOrderMonitoringData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[OrderMonitoring]";
        public OrderMonitoringData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<OrderMonitoringModel>> GetOrderMonitoringData(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<OrderMonitoringModel, dynamic>(sql, parameters);
        }

    }
}
