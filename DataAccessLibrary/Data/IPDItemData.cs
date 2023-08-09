using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IPDItemData
    {
        Task<List<PDItemModel>> GetAllPDItem(string loginId);
        Task<List<PDItemModel>> GetItem(string loginId, PDItemModel pditem);
        Task InsertItemData(string loginId, PDItemModel pditem);
        Task DeleteData(string loginId, PDItemModel pditem);
    }
}