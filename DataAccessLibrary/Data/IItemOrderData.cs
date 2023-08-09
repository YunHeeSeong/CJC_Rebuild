using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IItemOrderData
    {
        Task<List<ResultModel>> DeleteDetailData(ItemOrderModel order, string loginId);
        Task<List<ResultModel>> DeleteMasterData(ItemOrderModel order, string loginId);
        Task<List<ItemOrderModel>> GetAllOrders(string loginId);
        Task<List<ItemOrderModel>> GetOrderDetail(string loginId, string bizUnit, string orderNo);
        Task<List<ItemOrderModel>> GetOrderMaster(string loginId, string bizUnit, string orderNo);
        Task<List<ResultModel>> InsertMasterData(string loginId, ItemOrderModel order);
        Task<List<ResultModel>> InsertDetailData(string loginId, ItemOrderModel order);
        Task<List<ResultModel>> UpdateOrderDetail(string loginId, ItemOrderModel order);
        Task<List<ResultModel>> UpdateOrderMaster(string loginId, ItemOrderModel order);
    }
}