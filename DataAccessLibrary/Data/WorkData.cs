using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class WorkData : IWorkData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[WorkData]";
        public WorkData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<WorkOrderModel>> GetAllWorkOrders(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<WorkOrderModel, dynamic>(sql, parameters);
        }

        public Task<List<WorkModel>> GetWorkPerform(string loginId, WorkOrderModel workOrderModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workOrderModel.BizUnit);
            parameters.Add("@FactBizUnit", workOrderModel.FactBizUnit);
            parameters.Add("@WorkOrderNo", workOrderModel.WorkOrderNo);

            return _db.LoadData<WorkModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(WorkModel work , string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", work.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", work.FactBizUnit.GetNullToEmpty());
            parameters.Add("@WorkOrderNo", work.WorkOrderNo.GetNullToEmpty());
            parameters.Add("@ItemCd", work.ItemCd.GetNullToEmpty());
            parameters.Add("@WorkPerformDt",work.WorkPerformDt );
            parameters.Add("@Qty", work.Qty.GetDecimalNullToZero());
            parameters.Add("@OkQty", work.OkQty.GetDecimalNullToZero());
            parameters.Add("@BadQty", work.BadQty.GetDecimalNullToZero());
            parameters.Add("@BadType", work.BadType.GetIntNullToZero());
            parameters.Add("@BadReason", work.BadReason.GetNullToEmpty());
            parameters.Add("@Remk", work.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
