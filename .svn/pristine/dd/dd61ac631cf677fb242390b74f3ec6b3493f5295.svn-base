using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface ISalesData
    {
        Task<List<SalesModel>> GetFactPDItemData(string loginId);
        Task<List<SalesModel>> GetStoreItemData(string loginId);
        Task<List<SalesModel>> GetStorePDItemData(string loginId);
    }
}