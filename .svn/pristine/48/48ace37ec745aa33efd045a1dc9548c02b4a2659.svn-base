using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IInventoryData
    {
        Task<List<InventoryModel>> GetALLPDItemInventory(string loginId);
        Task<List<InventoryModel>> GetFactPDItemInventory(string loginId);
        Task<List<InventoryModel>> GetFactItemInventory(string loginId);
        Task<List<InventoryModel>> GetStorePDItemInventory(string loginId);
        Task<List<InventoryModel>> GetStoreItemInventory(string loginId);
        Task<List<InventoryModel>> GetALLItemInventory(string loginId);
    }
}