using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IWorkPlanData
    {
        Task<List<ResultModel>> DeleteData(WorkPlanModel workPlan, string loginId);
        Task<List<WorkPlanModel>> GetAllWorkPlan(string loginId);
        Task<List<WorkPlanModel>> GetWorkPlan(string loginId, string bizUnit, string factBizUnit, string workPlanNo);
        Task<List<ResultModel>> InsertData(WorkPlanModel workPlan, string loginId);
        Task<List<ResultModel>> UpdateData(WorkPlanModel workPlan, string loginId);
        Task<List<ResultModel>> ApproveWorkPlan(WorkPlanModel workPlan, string loginId);
        Task<List<WorkPlanModel>> GetAllWorkPlanForFact(string loginId);
    }
}