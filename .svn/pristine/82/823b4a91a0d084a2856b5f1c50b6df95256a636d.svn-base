using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IOrderData
    {
        Task<List<ResultModel>> DeleteData(OrderModel order, string loginId);
        Task<List<OrderModel>> GetAllOrders(string loginId);
        Task<List<OrderModel>> GetOrderDetail(string orderNo, string loginId);
        Task<List<OrderModel>> GetOrderDetailEdit(string orderNo, string factBizUnit, string loginId);
        Task<List<OrderModel>> GetOrderFromCustomer(string customerCd, string loginId);
        Task<List<ResultModel>> InsertOrderData(string loginId, OrderModel order);
        Task<List<ResultModel>> UpdateOrderData(string loginId, OrderModel order);
    }
}