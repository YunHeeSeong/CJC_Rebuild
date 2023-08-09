using Dapper;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class StkItemData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[StkItemData]";
        public StkItemData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<StkItemModel>> GetAllStkItem(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<StkItemModel, dynamic>(sql, parameters);
        }

        public Task<List<StkItemModel>> GetStkItem(string loginId, string SlipNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@SlipNo", SlipNo);

            return _db.LoadData<StkItemModel, dynamic>(sql, parameters);
        }

        public Task InsertData(StkItemModel stkItem, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            //parameters.Add("@SlipType", stkItem.SlipType.GetIntNullToZero());
            //parameters.Add("@SlipDate", asModel.CustomerCd.GetNullToEmpty());
            //parameters.Add("@@Whcd", asModel.CustomerPhone.GetNullToEmpty());
            //parameters.Add("@@ItemCd", asModel.ItemCd.GetNullToEmpty());
            //parameters.Add("@@Qty", asModel.AsType.GetIntNullToZero());
            //parameters.Add("@AsRecvDt", asModel.AsRecvDt);
            //parameters.Add("@AsCompDt", asModel.AsCompDt);
            //parameters.Add("@AsUserId", asModel.AsUserId.GetIntNullToZero());
            //parameters.Add("@AsManagerId", asModel.AsManagerId.GetIntNullToZero());
            //parameters.Add("@ProcStatus", asModel.ProcStatus.GetIntNullToZero());
            //parameters.Add("@ReqDetail", asModel.ReqDetail.GetNullToEmpty());
            //parameters.Add("@ImproveDetail", asModel.ImproveDetail.GetNullToEmpty());
            //parameters.Add("@Remk", asModel.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }
    }
}
