using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class MenuData : IMenuData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[Menu]";
        public MenuData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<MenuModel>> GetAllMenus()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");

            return _db.LoadData<MenuModel, dynamic>(sql, parameters);
        }
    }
}
