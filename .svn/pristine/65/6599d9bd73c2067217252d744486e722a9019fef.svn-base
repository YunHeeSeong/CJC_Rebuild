using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class POInItemData : IPOInItemData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[POInItemData]";
        public POInItemData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<POInItemModel>> GetAllPOInItem(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<POInItemModel, dynamic>(sql, parameters);
        }
        public Task<List<POInItemModel>> GetMasterPOInItem(string pOInItemNo, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@pOInItemNo", pOInItemNo);


            return _db.LoadData<POInItemModel, dynamic>(sql, parameters);
        }
        public Task<List<POInItemModel>> GetDetailPOInItem(string pOInItemNo, string bizUnit)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@pOInItemNo", pOInItemNo);

            return _db.LoadData<POInItemModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> InsertMasterData(POInItemModel pOInItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POInDate", pOInItem.POInDate.GetNullToEmpty());
            parameters.Add("@POInGroupCd", pOInItem.POInGroupCd.GetIntNullToZero());
            parameters.Add("@POInUserId", pOInItem.POInUserId.GetIntNullToZero());
            parameters.Add("@POInCustCd", pOInItem.POInCustCd.GetNullToEmpty());
            parameters.Add("@TotQty", pOInItem.TotQty.GetDecimalNullToZero());
            parameters.Add("@TotAmt", pOInItem.TotAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", pOInItem.Remk.GetNullToEmpty());
            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertDetailData(POInItemModel pOInItem, string pOInItemNo, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POInDate", pOInItem.POInDate.GetNullToEmpty());
            parameters.Add("@POInItemNo", pOInItem.POInItemNo.GetNullToEmpty());
            parameters.Add("@POrderNo", pOInItem.POrderNo.GetNullToEmpty());
            parameters.Add("@POSeq", pOInItem.POSeq.GetIntNullToZero());
            parameters.Add("@ItemCd", pOInItem.ItemCd.GetNullToEmpty());
            parameters.Add("@WhCd", pOInItem.WhCd.GetIntNullToZero());
            parameters.Add("@Qty", pOInItem.Qty.GetDecimalNullToZero());
            parameters.Add("@BadQty", pOInItem.BadQty.GetDecimalNullToZero());
            parameters.Add("@BadType", pOInItem.BadType.GetIntNullToZero());
            parameters.Add("@Price", pOInItem.Price.GetDecimalNullToZero());
            parameters.Add("@Amt", pOInItem.Amt.GetDecimalNullToZero());
            parameters.Add("@Unit", pOInItem.Unit.GetNullToEmpty());
            parameters.Add("@Weight", pOInItem.Weight.GetDecimalNullToZero());
            parameters.Add("@Remk", pOInItem.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateMasterData(POInItemModel pOInItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@POInItemNo", pOInItem.POInItemNo.GetNullToEmpty());
            parameters.Add("@TotQty", pOInItem.TotQty.GetDecimalNullToZero());
            parameters.Add("@TotAmt", pOInItem.TotAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", pOInItem.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateDetailData(POInItemModel pOInItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteMasterData(POInItemModel pOInItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteDetailData(POInItemModel pOInItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

    }
}

