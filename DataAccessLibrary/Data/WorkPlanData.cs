using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class WorkPlanData : IWorkPlanData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[WorkPlanData]";
        public WorkPlanData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<WorkPlanModel>> GetAllWorkPlan(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<WorkPlanModel, dynamic>(sql, parameters);
        }

        public Task<List<WorkPlanModel>> GetAllWorkPlanForFact(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R20");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<WorkPlanModel, dynamic>(sql, parameters);
        }

        public Task<List<WorkPlanModel>> GetWorkPlan(string loginId,string bizUnit, string factBizUnit, string workPlanNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@WorkPlanNo", workPlanNo);

            return _db.LoadData<WorkPlanModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(WorkPlanModel workPlan, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workPlan.BizUnit);
            parameters.Add("@FactBizUnit", workPlan.FactBizUnit);
            parameters.Add("@WorkPlanNo", workPlan.WorkPlanNo.GetNullToEmpty());
            parameters.Add("@WorkPlanDt", workPlan.WorkPlanDt.GetNullToEmpty());
            parameters.Add("@ItemCd", workPlan.ItemCd.GetNullToEmpty());
            parameters.Add("@Qty", workPlan.Qty.GetDecimalNullToZero());
            parameters.Add("@EctRequest", workPlan.EctRequest.GetNullToEmpty());
            parameters.Add("@Remk", workPlan.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> ApproveWorkPlan(WorkPlanModel workPlan, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U00");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@ItemCd", workPlan.ItemCd.GetNullToEmpty());
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workPlan.BizUnit);
            parameters.Add("@FactBizUnit", workPlan.FactBizUnit);
            parameters.Add("@WorkOrderNo", workPlan.WorkOrderNo.GetNullToEmpty());
            parameters.Add("@WorkPlanNo", workPlan.WorkPlanNo.GetNullToEmpty());
            parameters.Add("@Qty", workPlan.Qty.GetDecimalNullToZero());
            //parameters.Add("@AppDt", workPlan.AppDt.GetNullToEmpty());
            parameters.Add("@AppYN", workPlan.AppYN.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateData(WorkPlanModel workPlan, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workPlan.BizUnit);
            parameters.Add("@FactBizUnit", workPlan.FactBizUnit);
            parameters.Add("@WorkPlanNo", workPlan.WorkPlanNo.GetNullToEmpty());
            parameters.Add("@WorkPlanDt", workPlan.WorkPlanDt.GetNullToEmpty());
            parameters.Add("@ItemCd", workPlan.ItemCd.GetNullToEmpty());
            parameters.Add("@Qty", workPlan.Qty.GetDecimalNullToZero());
            parameters.Add("@EctRequest", workPlan.EctRequest.GetNullToEmpty());
            parameters.Add("@Remk", workPlan.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteData(WorkPlanModel workPlan, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workPlan.BizUnit);
            parameters.Add("@FactBizUnit", workPlan.FactBizUnit);
            parameters.Add("@WorkPlanNo", workPlan.WorkPlanNo.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

    }
}

