using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IWorkOrderData
    {
        Task<List<WorkOrderModel>> GetAllWorkOrder(string loginId);
        //Task<List<WorkOrderModel>> GetWorkOrder(string loginId, string workOrderNo);
        Task<List<ResultModel>> UpdateWorkOrder(string loginId, WorkOrderModel workOrder);
        Task InsertWorkOrderDataFromOrder(string loginId, string orderNo, WorkOrderModel workOrder);
        Task<List<WorkOrderModel>> GetWorkOrderFromOrder(string loginId, string orderNo, string bizUnit, string factBizUnit);
        Task<List<ResultModel>> UpdateWorkOrderDataFromOrder(string loginId, WorkOrderModel workOrder);
        Task<List<WorkOrderModel>> GetWorkOrder(string loginId, string workOrderNo, string bizUnit, string factBizUnit);
    }
}