using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class ASData : IASData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[ASData]";
        public ASData(ISqlDataAccess db)
        {
            _db = db;
        }


        public Task<List<OrderModel>> GetOrderFromCodehelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<OrderModel, dynamic>(sql, parameters);
        }

        public Task<List<ASModel>> GetAllAS(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ASModel, dynamic>(sql, parameters);
        }

        public Task<List<ASModel>> GetAS(string loginId, string AsNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@AsNo", AsNo);

            return _db.LoadData<ASModel, dynamic>(sql, parameters);
        }

        public Task<List<FileModel>> GetImage(string loginId, string AsNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@AsNo", AsNo);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }

        public Task InsertData(ASModel asModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@FactBizUnit", asModel.FactBizUnit);
            parameters.Add("@OrderNo", asModel.OrderNo);
            parameters.Add("@CustomerCd", asModel.CustomerCd.GetNullToEmpty());
            parameters.Add("@CustomerPhone", asModel.CustomerPhone.GetNullToEmpty());
            parameters.Add("@ItemCd", asModel.ItemCd.GetNullToEmpty());
            parameters.Add("@AsType", asModel.AsType.GetIntNullToZero());
            parameters.Add("@AsRecvDt", asModel.AsRecvDt);
            parameters.Add("@AsCompDt", asModel.AsCompDt);
            parameters.Add("@AsUserId", asModel.AsUserId.GetIntNullToZero());
            parameters.Add("@AsManagerId", asModel.AsManagerId.GetIntNullToZero());
            parameters.Add("@ProcStatus", asModel.ProcStatus.GetIntNullToZero());
            parameters.Add("@ReqDetail", asModel.ReqDetail.GetNullToEmpty());
            parameters.Add("@ImproveDetail", asModel.ImproveDetail.GetNullToEmpty());
            parameters.Add("@Remk", asModel.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }
        public Task UpdateData(ASModel asModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@AsNo", asModel.AsNo);
            parameters.Add("@OrderNo", asModel.OrderNo);
            parameters.Add("@CustomerCd", asModel.CustomerCd.GetNullToEmpty());
            parameters.Add("@CustomerPhone", asModel.CustomerPhone.GetNullToEmpty());
            parameters.Add("@ItemCd", asModel.ItemCd.GetNullToEmpty());
            parameters.Add("@AsType", asModel.AsType.GetIntNullToZero());
            parameters.Add("@AsRecvDt", asModel.AsRecvDt);
            parameters.Add("@AsCompDt", asModel.AsCompDt);
            parameters.Add("@AsUserId", asModel.AsUserId.GetIntNullToZero());
            parameters.Add("@AsManagerId", asModel.AsManagerId.GetIntNullToZero());
            parameters.Add("@ProcStatus", asModel.ProcStatus.GetIntNullToZero());
            parameters.Add("@ReqDetail", asModel.ReqDetail.GetNullToEmpty());
            parameters.Add("@ImproveDetail", asModel.ImproveDetail.GetNullToEmpty());
            parameters.Add("@Remk", asModel.Remk.GetNullToEmpty());
            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(ASModel asModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@AsNo", asModel.AsNo);

            return _db.SaveData(sql, parameters);
        }
    }
}
