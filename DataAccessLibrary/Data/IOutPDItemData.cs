using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IOutPDItemData
    {
        Task<List<ResultModel>> DeleteData(OutPDItemModel outPDItem, string loginId);
        Task<List<OutPDItemModel>> GetAllOrdersFromFact(string loginId);
        Task<List<OutPDItemModel>> GetOutPDItemDetail(string loginId, OutPDItemModel outPDItem);
        Task<List<OutPDItemModel>> GetAllOrdersFromStore(string loginId);
        Task<List<ResultModel>> InsertData(OutPDItemModel outPDItem, string loginId);
    }
}