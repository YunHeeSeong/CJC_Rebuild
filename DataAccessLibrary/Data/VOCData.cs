using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class VOCData : IVOCData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[VOCData]";
        public VOCData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<VOCModel>> GetAllVoc(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<VOCModel, dynamic>(sql, parameters);
        }

        public Task<List<VOCModel>> GetVoc(string loginId, string VocNo)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@VocNo", VocNo);

            return _db.LoadData<VOCModel, dynamic>(sql, parameters);
        }

        public Task InsertData(VOCModel vocModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@VocCls", vocModel.VocCls.GetIntNullToZero());
            parameters.Add("@VocDetailCls", vocModel.VocDetailCls.GetIntNullToZero());
            parameters.Add("@VocDt", vocModel.VocDt);
            parameters.Add("@CustomerCd", vocModel.CustomerCd.GetNullToEmpty());
            parameters.Add("@Title", vocModel.Title.GetNullToEmpty());
            parameters.Add("@Contents", vocModel.Contents.GetNullToEmpty());
            parameters.Add("@ProcContents", vocModel.ProcContents.GetNullToEmpty());
            parameters.Add("@VocUserId", vocModel.VocUserId.GetIntNullToZero());
            parameters.Add("@VocManagerId", vocModel.VocManagerId.GetIntNullToZero());

            return _db.SaveData(sql, parameters);
        }
        public Task UpdateData(VOCModel vocModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@VocNo", vocModel.VocNo);
            parameters.Add("@VocCls", vocModel.VocCls.GetIntNullToZero());
            parameters.Add("@VocDetailCls", vocModel.VocDetailCls.GetIntNullToZero());
            parameters.Add("@VocDt", vocModel.VocDt);
            parameters.Add("@CustomerCd", vocModel.CustomerCd.GetNullToEmpty());
            parameters.Add("@Title", vocModel.Title.GetNullToEmpty());
            parameters.Add("@Contents", vocModel.Contents.GetNullToEmpty());
            parameters.Add("@ProcContents", vocModel.ProcContents.GetNullToEmpty());
            parameters.Add("@VocUserId", vocModel.VocUserId.GetIntNullToZero());
            parameters.Add("@VocManagerId", vocModel.VocManagerId.GetIntNullToZero());

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(VOCModel vocModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@VocNo", vocModel.VocNo);

            return _db.SaveData(sql, parameters);
        }
    }
}
