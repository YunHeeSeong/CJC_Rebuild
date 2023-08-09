using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IInventoryCheckData
    {
        Task<List<ResultModel>> FactItemDeleteData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> FactItemInsertData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> FactPDItemDeleteData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> FactPDItemInsertData(string loginId, InventoryCheckModel checkModel);
        Task<List<InventoryCheckModel>> GetFactItemCheckData(string loginId, InventoryModel checkModel);
        Task<List<InventoryCheckModel>> GetFactPDItemCheckData(string loginId, InventoryModel checkModel);
        Task<List<InventoryCheckModel>> GetStoreItemCheckData(string loginId, InventoryModel checkModel);
        Task<List<InventoryCheckModel>> GetStorePDItemCheckData(string loginId, InventoryModel checkModel);
        Task<List<ResultModel>> StoreItemDeleteData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> StoreItemInsertData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> StorePDItemDeleteData(string loginId, InventoryCheckModel checkModel);
        Task<List<ResultModel>> StorePDItemInsertData(string loginId, InventoryCheckModel checkModel);
    }
}