using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IWorkData
    {
        Task<List<WorkOrderModel>> GetAllWorkOrders(string loginId);
        Task<List<WorkModel>> GetWorkPerform(string loginId, WorkOrderModel workOrderModel);
        Task<List<ResultModel>> InsertData(WorkModel work, string loginId);
    }
}