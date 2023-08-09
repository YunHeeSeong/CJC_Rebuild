using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class POrderData : IPOrderData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[POrderData]";
        public POrderData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<POrderModel>> GetAllPOrder(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<POrderModel, dynamic>(sql, parameters);
        }
        public Task<List<POrderModel>> GetMasterPOrder(string pOrderNo, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrderNo);


            return _db.LoadData<POrderModel, dynamic>(sql, parameters);
        }
        public Task<List<POrderModel>> GetDetailPOrder(string pOrderNo, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrderNo);

            return _db.LoadData<POrderModel, dynamic>(sql, parameters);
        }

        public Task<List<POrderModel>> GetPOrderFromCustomer(string customerCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R13");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderCustCd", customerCd);

            return _db.LoadData<POrderModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> InsertMasterData(POrderModel pOrder, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderDt", pOrder.POrderDt.GetNullToEmpty());
            parameters.Add("@VatYN", pOrder.VatYN.GetNullToEmpty());
            parameters.Add("@GroupCd", pOrder.GroupCd.GetIntNullToZero());
            parameters.Add("@POrderUserId", pOrder.POrderUserId.GetIntNullToZero());
            parameters.Add("@POrderCustCd", pOrder.POrderCustCd.GetIntNullToZero());
            parameters.Add("@Amt", pOrder.Amt.GetDecimalNullToZero());
            parameters.Add("@Vat", pOrder.Vat.GetDecimalNullToZero());
            parameters.Add("@Remk", pOrder.Remk.GetNullToEmpty());

             return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertDetailData(POrderModel pOrder, string pOrderNo, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrderNo.GetNullToEmpty());
            parameters.Add("@ItemCd", pOrder.ItemCd.GetNullToEmpty());
            parameters.Add("@Qty", pOrder.Qty.GetDecimalNullToZero());
            parameters.Add("@Price", pOrder.Price.GetDecimalNullToZero());
            parameters.Add("@Amt", pOrder.Amt.GetDecimalNullToZero());
            parameters.Add("@UnitCd", pOrder.UnitCd.GetNullToEmpty());
            parameters.Add("@Weight", pOrder.Weight.GetDecimalNullToZero());
            parameters.Add("@ReqDelvDate", pOrder.ReqDelvDate);
            parameters.Add("@DelvPlace", pOrder.DelvPlace.GetNullToEmpty());
            parameters.Add("@Remk", pOrder.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateMasterData(POrderModel pOrder, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrder.POrderNo.GetNullToEmpty());
            parameters.Add("@POrderDt", pOrder.POrderDt.GetNullToEmpty());
            parameters.Add("@GroupCd", pOrder.GroupCd);
            parameters.Add("@POrderUserId", pOrder.POrderUserId);
            parameters.Add("@POrderCustCd", pOrder.POrderCustCd);
            parameters.Add("@Amt", pOrder.Amt);
            parameters.Add("@Vat", pOrder.Vat);
            parameters.Add("@Remk", pOrder.Remk);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateDetailData(POrderModel pOrder, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrder.POrderNo.GetNullToEmpty());
            parameters.Add("@Seq", pOrder.Seq.GetIntNullToZero());
            parameters.Add("@ItemCd", pOrder.ItemCd.GetNullToEmpty());
            parameters.Add("@Qty", pOrder.Qty.GetDecimalNullToZero());
            parameters.Add("@Price", pOrder.Price.GetDecimalNullToZero());
            parameters.Add("@Amt", pOrder.Amt.GetDecimalNullToZero());
            parameters.Add("@UnitCd", pOrder.UnitCd.GetNullToEmpty());
            parameters.Add("@Weight", pOrder.Weight.GetDecimalNullToZero());
            parameters.Add("@ReqDelvDate", pOrder.ReqDelvDate);
            parameters.Add("@DelvPlace", pOrder.DelvPlace.GetNullToEmpty());
            parameters.Add("@Remk", pOrder.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteMasterData(POrderModel pOrder, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrder.POrderNo.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteDetailData(POrderModel pOrder, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POrderNo", pOrder.POrderNo.GetNullToEmpty());
            parameters.Add("@Seq", pOrder.Seq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

    }
}

