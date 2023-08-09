using Dapper;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class OutPDItemData : IOutPDItemData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[OutPDItemData]";
        public OutPDItemData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<OutPDItemModel>> GetAllOrdersFromFact(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            //parameters.Add("@BizUnit", outPDItem.BizUnit);
            //parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);

            return _db.LoadData<OutPDItemModel, dynamic>(sql, parameters);
        }

        public Task<List<OutPDItemModel>> GetAllOrdersFromStore(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R01");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            //parameters.Add("@BizUnit", outPDItem.BizUnit);
            //parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);

            return _db.LoadData<OutPDItemModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(OutPDItemModel outPDItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outPDItem.BizUnit);
            parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);
            parameters.Add("@ItemCd", outPDItem.ItemCd);
            parameters.Add("@OrderNo", outPDItem.OrderNo);
            parameters.Add("@OutDate", outPDItem.OutDate.GetNullToEmpty());
            parameters.Add("@OutQty", outPDItem.OutQty.GetDecimalNullToZero());
            parameters.Add("@Tax", outPDItem.Tax.GetDecimalNullToZero());
            parameters.Add("@Remk", outPDItem.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<OutPDItemModel>> GetOutPDItemDetail(string loginId, OutPDItemModel outPDItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outPDItem.BizUnit);
            parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);
            parameters.Add("@OrderNo", outPDItem.OrderNo);
            parameters.Add("@OutSeq", outPDItem.OutSeq);

            return _db.LoadData<OutPDItemModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteData(OutPDItemModel outPDItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", outPDItem.BizUnit);
            parameters.Add("@FactBizUnit", outPDItem.FactBizUnit);
            parameters.Add("@OrderNo", outPDItem.OrderNo);
            parameters.Add("@OutSeq", outPDItem.OutSeq);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
