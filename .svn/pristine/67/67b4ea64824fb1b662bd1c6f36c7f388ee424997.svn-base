using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IOutItemData
    {
        Task<List<OutItemModel>> GetOutItemDetail(string loginId, OutItemModel outItemModel);
        Task<List<OutItemModel>> GetItemOrder(string loginId);
        Task<List<ResultModel>> InsertData(string loginId, OutItemModel outItem);
        Task<List<ResultModel>> DeleteData(string loginId, OutItemModel outItem);
        Task<List<ResultModel>> ShowReport(OutItemModel outItem, string outDate);
    }
}