using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class ItemOrderData : IItemOrderData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[ItemOrderData]";
        public ItemOrderData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<ItemOrderModel>> GetAllOrders(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemOrderModel, dynamic>(sql, parameters);
        }
        public Task<List<ItemOrderModel>> GetOrderMaster(string loginId, string bizUnit, string orderNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@OrderNo", orderNo);

            return _db.LoadData<ItemOrderModel, dynamic>(sql, parameters);
        }

        public Task<List<ItemOrderModel>> GetOrderDetail(string loginId, string bizUnit, string orderNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@OrderNo", orderNo);

            return _db.LoadData<ItemOrderModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertMasterData(string loginId, ItemOrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderDt", order.OrderDt.GetNullToEmpty());
            parameters.Add("@OrderCls", order.OrderCls.GetIntNullToZero());
            parameters.Add("@CustomerCd", order.CustomerCd.GetNullToEmpty());
            parameters.Add("@PICCd", order.PICCd.GetIntNullToZero());
            parameters.Add("@PayYN", order.PayYN.GetNullToEmpty());
            parameters.Add("@PayDt", order.PayDt.GetNullToEmpty());
            parameters.Add("@EctRequest", order.EctRequest.GetNullToEmpty());
            parameters.Add("@TotPrice", order.TotPrice.GetDecimalNullToZero());
            parameters.Add("@TotVAT", order.TotVAT.GetDecimalNullToZero());
            parameters.Add("@Remk", order.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> InsertDetailData(string loginId, ItemOrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@ItemCd", order.ItemCd);
            parameters.Add("@Qty", order.Qty.GetDecimalNullToZero());
            parameters.Add("@UPR", order.UPR.GetDecimalNullToZero());
            parameters.Add("@Price", order.Price.GetDecimalNullToZero());
            parameters.Add("@VAT", order.Vat.GetDecimalNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> UpdateOrderMaster(string loginId, ItemOrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@OrderDt", order.OrderDt);
            parameters.Add("@PayYN", order.PayYN);
            parameters.Add("@PayDt", order.PayDt);
            parameters.Add("@TotPrice", order.TotPrice);
            parameters.Add("@TotVAT", order.TotVAT);
            parameters.Add("@EctRequest", order.EctRequest);
            parameters.Add("@Remk", order.Remk);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateOrderDetail(string loginId, ItemOrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@OrderSeq", order.OrderSeq);
            parameters.Add("@ItemCd", order.ItemCd);
            parameters.Add("@Qty", order.Qty.GetDecimalNullToZero());
            parameters.Add("@UPR", order.UPR.GetDecimalNullToZero());
            parameters.Add("@Price", order.Price.GetDecimalNullToZero());
            parameters.Add("@VAT", order.Vat.GetDecimalNullToZero());
            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteMasterData(ItemOrderModel order, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@loginId", loginId);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@OrderNo", order.OrderNo);


            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteDetailData(ItemOrderModel order, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@loginId", loginId);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@OrderSeq", order.OrderSeq);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
