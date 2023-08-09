using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class BOMData : IBOMData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[BOMData]";
        public BOMData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<ItemModel>> GetAllItem(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemModel, dynamic>(sql, parameters);
        }


        public Task<List<BOMModel>> GetBOM(string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<BOMModel, dynamic>(sql, parameters);
        }
        public Task<List<BOMModel>> GetBOMDetail(string bomCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BomCd", bomCd);

            return _db.LoadData<BOMModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(BOMModel bom, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bom.BizUnit);
            parameters.Add("@FactBizUnit", bom.FactBizUnit);
            parameters.Add("@ItemCd", bom.ItemCd.GetNullToEmpty());
            parameters.Add("@PartCd", bom.PartCd.GetNullToEmpty());
            parameters.Add("@ReqQty", bom.ReqQty);
            parameters.Add("@Remk", bom.Remk.GetNullToEmpty());



            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task UpdateData(BOMModel bom, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@Seq", bom.Seq.GetIntNullToZero());
            parameters.Add("@BizUnit", bom.BizUnit);
            parameters.Add("@FactBizUnit", bom.FactBizUnit);
            parameters.Add("@ItemCd", bom.ItemCd.GetNullToEmpty());
            parameters.Add("@PartCd", bom.PartCd.GetNullToEmpty());
            parameters.Add("@ReqQty", bom.ReqQty);
            parameters.Add("@Remk", bom.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(BOMModel bom, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bom.BizUnit);
            parameters.Add("@FactBizUnit", bom.FactBizUnit);
            parameters.Add("@ItemCd", bom.ItemCd.GetNullToEmpty());
            parameters.Add("@Seq", bom.Seq.GetIntNullToZero());

            return _db.DeleteData(sql, parameters);
        }

    }
}

