using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class InventoryData : IInventoryData
    {
        private readonly ISqlDataAccess _db;
        private readonly string factData = "[dbo].[Inventory_FactData]";
        private readonly string storeData = "[dbo].[Inventory_StrData]";
        private readonly string allData = "[dbo].[Inventory_Data]";

        public InventoryData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<InventoryModel>> GetFactPDItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(factData, parameters);
        }

        public Task<List<InventoryModel>> GetFactItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(factData, parameters);
        }

        public Task<List<InventoryModel>> GetStorePDItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(storeData, parameters);
        }

        public Task<List<InventoryModel>> GetStoreItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(storeData, parameters);
        }

        public Task<List<InventoryModel>> GetALLPDItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(allData, parameters);
        }

        public Task<List<InventoryModel>> GetALLItemInventory(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<InventoryModel, dynamic>(allData, parameters);
        }
    }
}
