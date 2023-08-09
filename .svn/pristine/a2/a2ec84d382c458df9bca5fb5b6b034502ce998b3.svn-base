using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class OrderData : IOrderData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[OrderData]";
        public OrderData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<OrderModel>> GetAllOrders(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<OrderModel, dynamic>(sql, parameters);
        }

        public Task<List<OrderModel>> GetOrderDetail(string orderNo,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderNo", orderNo);

            return _db.LoadData<OrderModel, dynamic>(sql, parameters);
        }

        public Task<List<OrderModel>> GetOrderDetailEdit(string orderNo,string factBizUnit, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R20");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderNo", orderNo);
            parameters.Add("@FactBizUnit", factBizUnit);

            return _db.LoadData<OrderModel, dynamic>(sql, parameters);
        }
        public Task<List<OrderModel>> GetOrderFromCustomer(string customerCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R30");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", customerCd);

            return _db.LoadData<OrderModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertOrderData(string loginId, OrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@OrderDt", order.OrderDt.GetNullToEmpty());
            parameters.Add("@OrderCls", order.OrderCls.GetIntNullToZero());
            parameters.Add("@CustomerCd", order.CustomerCd.GetNullToEmpty());
            parameters.Add("@PICCd", order.PICCd.GetIntNullToZero());
            parameters.Add("@ItemCd", order.ItemCd);
            parameters.Add("@ItemNm", order.ItemNm.GetNullToEmpty());
            //parameters.Add("@MadeType", order.MadeType);
            parameters.Add("@Qty", order.Qty.GetIntNullToZero());
            parameters.Add("@PayYN", order.PayYN.GetNullToEmpty());
            parameters.Add("@PayDt", order.PayDt.GetNullToEmpty());
            parameters.Add("@FactBizUnit", order.FactBizUnit.GetNullToEmpty());
            parameters.Add("@EctRequest", order.EctRequest.GetNullToEmpty());
            parameters.Add("@Price", order.Price.GetDecimalNullToZero());
            parameters.Add("@VAT", order.Vat.GetDecimalNullToZero());
             parameters.Add("@WorkState", order.WorkState.GetNullToEmpty());
            parameters.Add("@Remk", order.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> UpdateOrderData(string loginId, OrderModel order)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            //parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@OrderDt", order.OrderDt);
            parameters.Add("@OrderCls", order.OrderCls);
            parameters.Add("@CustomerCd", order.CustomerCd);
            parameters.Add("@PICCd", order.PICCd);
            parameters.Add("@Qty", order.Qty);
            parameters.Add("@PayYN", order.PayYN);
            parameters.Add("@PayDt", order.PayDt);
            parameters.Add("@FactBizUnit", order.FactBizUnit);
            parameters.Add("@EctRequest", order.EctRequest);
            parameters.Add("@Price", order.Price);
            parameters.Add("@VAT", order.Vat);
            //parameters.Add("@WorkState", order.WorkState);
            parameters.Add("@Remk", order.Remk);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }


        public Task<List<ResultModel>> DeleteData(OrderModel order, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            //parameters.Add("@CompCd", GlobalVar.CompCd);
            //parameters.Add("@loginId", loginId);
            parameters.Add("@OrderNo", order.OrderNo);
            parameters.Add("@OrderCls", order.OrderCls);
            parameters.Add("@BizUnit", order.BizUnit);
            parameters.Add("@FactBizUnit", order.FactBizUnit);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
