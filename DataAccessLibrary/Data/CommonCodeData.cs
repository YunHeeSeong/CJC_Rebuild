using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class CommonCodeData : ICommonCodeData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[CommonCodeData]";
        public CommonCodeData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<CommonCodeModel>> GetAllCommonCodes(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<CommonCodeModel, dynamic>(sql, parameters);
        }

        public Task<List<CommonCodeModel>> GetCommonCode(int codeId, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", codeId);

            return _db.LoadData<CommonCodeModel, dynamic>(sql, parameters);
        }
        public Task<List<CommonCodeModel>> FindCommonCodeFromName(string codeNm, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeNm", codeNm);

            return _db.LoadData<CommonCodeModel, dynamic>(sql, parameters);
        }

        public Task<List<CommonCodeModel>> GetCommonCodeDetail(int codeId ,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", codeId);

            return _db.LoadData<CommonCodeModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertMasterData(CommonCodeModel code, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeNm", code.CodeNm);
            parameters.Add("@Remk", code.Remk);

            return _db.SaveDataGetReuslt<ResultModel,dynamic>(sql, parameters);
        }

        public Task InsertDetailData(CommonCodeModel code, int codeId, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", codeId);
            parameters.Add("@CodeSubNm", code.CodeSubNm);
            parameters.Add("@SubRemk", code.SubRemk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateMasterData(CommonCodeModel code, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", code.CodeId);
            parameters.Add("@CodeNm", code.CodeNm);
            parameters.Add("@Remk", code.Remk);

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateDetailData(CommonCodeModel code, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", code.CodeId);
            parameters.Add("@CodeSeq", code.CodeSeq);
            parameters.Add("@CodeSubNm", code.CodeSubNm);
            parameters.Add("@SubRemk", code.SubRemk);

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteMasterData(CommonCodeModel code, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", code.CodeId);

            return _db.DeleteData(sql, parameters);
        }

        public Task DeleteDetailData(CommonCodeModel code, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CodeId", code.CodeId);
            parameters.Add("@CodeSeq", code.CodeSeq);

            return _db.DeleteData(sql, parameters);
        }

    }
}

