using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IPOInItemData
    {
        Task<List<ResultModel>> DeleteDetailData(POInItemModel pOrder, string loginId);
        Task<List<ResultModel>> DeleteMasterData(POInItemModel pOrder, string loginId);
        Task<List<POInItemModel>> GetAllPOInItem(string loginId);
        Task<List<POInItemModel>> GetDetailPOInItem(string pOInItemNo, string bizUnit);
        Task<List<POInItemModel>> GetMasterPOInItem(string pOInItemNo, string loginId);
        Task<List<ResultModel>> InsertDetailData(POInItemModel pOrder, string pOInItemNo, string loginId);
        Task<List<ResultModel>> InsertMasterData(POInItemModel pOrder, string loginId);
        Task<List<ResultModel>> UpdateDetailData(POInItemModel pOrder, string loginId);
        Task<List<ResultModel>> UpdateMasterData(POInItemModel pOrder, string loginId);
    }
}