using Dapper;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class OutItemData : IOutItemData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[OutItemData]";
        private readonly string sql2 = "[dbo].[RP_Transaction_Item]";


        public OutItemData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<OutItemModel>> GetItemOrder(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<OutItemModel, dynamic>(sql, parameters);
        }

        public Task<List<OutItemModel>> GetOutItemDetail(string loginId, OutItemModel outItemModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outItemModel.BizUnit);
            parameters.Add("@OrderNo", outItemModel.OrderNo);

            return _db.LoadData<OutItemModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(string loginId, OutItemModel outItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outItem.BizUnit);
            //parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);
            parameters.Add("@ItemCd", outItem.ItemCd);
            parameters.Add("@OrderNo", outItem.OrderNo);
            parameters.Add("@OrderSeq", outItem.OrderSeq);
            parameters.Add("@OutDate", outItem.OutDate.GetNullToEmpty());
            parameters.Add("@OutQty", outItem.OutQty.GetDecimalNullToZero());
            //parameters.Add("@Tax", outPDItem.Tax.GetDecimalNullToZero());
            parameters.Add("@Remk", outItem.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }


        public Task<List<ResultModel>> DeleteData(string loginId, OutItemModel outItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outItem.BizUnit);
            parameters.Add("@OrderNo", outItem.OrderNo);
            parameters.Add("@OrderSeq", outItem.OrderSeq);
            parameters.Add("@OutSeq", outItem.OutSeq);
            parameters.Add("@ItemCd", outItem.ItemCd);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> ShowReport(OutItemModel outItem, string outDate)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "P10");
            parameters.Add("@BizUnit", outItem.BizUnit);
            parameters.Add("@OrderNo", outItem.OrderNo);
            parameters.Add("@OutDate", outDate);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }
    }
}
