using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;
namespace DataAccessLibrary.Data
{
    public class DashboardData : IDashboardData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[DashBoard_Home]";
        public DashboardData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<DashboardModel>> GetPOInItem()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

        public Task<List<DashboardModel>> GetOrder()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R20");

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

        public Task<List<DashboardModel>> GetWorkPerform()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R30");

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

        public Task<List<DashboardModel>> GetOutPDItem()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R40");

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

        public Task<List<DashboardModel>> GetClameRate(int month)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R50");
            parameters.Add("@month", month);

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

        public Task<List<DashboardModel>> GetLeadTime(int month)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R60");
            parameters.Add("@month", month);

            return _db.LoadData<DashboardModel, dynamic>(sql, parameters);
        }

    }
}
