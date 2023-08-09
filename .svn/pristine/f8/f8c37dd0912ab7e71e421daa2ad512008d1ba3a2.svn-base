using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IPOrderData
    {
        Task<List<ResultModel>> DeleteDetailData(POrderModel pOrder, string loginId);
        Task<List<ResultModel>> DeleteMasterData(POrderModel pOrder, string loginId);
        Task<List<POrderModel>> GetAllPOrder(string loginId);
        Task<List<POrderModel>> GetPOrderFromCustomer(string customerCd, string loginId);
        Task<List<POrderModel>> GetMasterPOrder(string pOrderNo, string loginId);
        Task<List<POrderModel>> GetDetailPOrder(string pOrderNo, string loginId);
        Task<List<ResultModel>> InsertDetailData(POrderModel pOrder, string pOrderNo, string loginId);
        Task<List<ResultModel>> InsertMasterData(POrderModel pOrder, string loginId);
        Task<List<ResultModel>> UpdateDetailData(POrderModel pOrder, string loginId);
        Task<List<ResultModel>> UpdateMasterData(POrderModel pOrder, string loginId);
    }
}