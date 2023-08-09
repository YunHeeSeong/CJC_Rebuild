using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class WorkOrderData : IWorkOrderData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[WorkOrder]";
        public WorkOrderData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<WorkOrderModel>> GetAllWorkOrder(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<WorkOrderModel, dynamic>(sql, parameters);
        }

        public Task<List<WorkOrderModel>> GetWorkOrderFromOrder(string loginId,string orderNo,string bizUnit,string factBizUnit)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderNo", orderNo);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);

            return _db.LoadData<WorkOrderModel, dynamic>(sql, parameters);
        }

        public Task<List<WorkOrderModel>> GetWorkOrder(string loginId, string workOrderNo, string bizUnit, string factBizUnit)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R20");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@WorkOrderNo", workOrderNo);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);

            return _db.LoadData<WorkOrderModel, dynamic>(sql, parameters);
        }

        //주문등록 내의 작업지시서 수정
        public Task<List<ResultModel>> UpdateWorkOrderDataFromOrder(string loginId, WorkOrderModel workOrder)
         {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderNo", workOrder.OrderNo);
            parameters.Add("@WorkOrderDt", workOrder.WorkOrderDt);
            parameters.Add("@Qty", workOrder.Qty);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        //작업지시등록 내의 수정
        public Task<List<ResultModel>> UpdateWorkOrder(string loginId, WorkOrderModel workOrder)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", workOrder.BizUnit);
            parameters.Add("@FactBizUnit", workOrder.FactBizUnit);
            parameters.Add("@WorkOrderNo", workOrder.WorkOrderNo);
            parameters.Add("@ShipDt", workOrder.ShipDt);
            parameters.Add("@ProdDueDt", workOrder.ProdDueDt);
            //parameters.Add("@OrderNo", workOrder.OrderNo);
     

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task InsertWorkOrderDataFromOrder(string loginId, string orderNo, WorkOrderModel workOrder)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@WorkOrderDt", workOrder.WorkOrderDt.GetNullToEmpty());
            parameters.Add("@WorkState", workOrder.WorkState.GetIntNullToZero());
            parameters.Add("@OrderNo", orderNo.GetNullToEmpty());
            parameters.Add("@ItemCd", workOrder.ItemCd.GetNullToEmpty());
            parameters.Add("@Qty", workOrder.Qty.GetDecimalNullToZero());
            parameters.Add("@BizUnit", workOrder.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", workOrder.FactBizUnit.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }
    }
}
