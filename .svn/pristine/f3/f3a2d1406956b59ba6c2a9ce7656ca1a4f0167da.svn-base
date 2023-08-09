using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class RoleData : IRoleData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[RoleData]";
        public RoleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<RoleModel>> GetRoleYN(string loginId, int menuId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@MenuId", menuId);

            return _db.LoadData<RoleModel, dynamic>(sql, parameters);
        }

        public Task<List<RoleModel>> GetRoleMasterList(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<RoleModel, dynamic>(sql, parameters);
        }
        public Task<List<RoleModel>> GetRoleDetailList(string loginId, int roleId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@RoleId", roleId);


            return _db.LoadData<RoleModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertMasterData(string loginId, RoleModel role)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@RoleNm", role.RoleNm);
            parameters.Add("@RoleDesc", role.RoleDesc);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task InsertDetailData(string loginId, int roleId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@RoleId", roleId);
            parameters.Add("@LoginId", loginId);

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteMasterData(string loginId, int RoleId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@loginId", loginId);
            parameters.Add("@RoleId", RoleId);

            return _db.DeleteData(sql, parameters);
        }

        public Task DeleteDetailData(string loginId, RoleModel role)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@RoleId", role.RoleId);
            parameters.Add("@RoleSeq", role.RoleSeq);


            return _db.DeleteData(sql, parameters);
        }

        public Task UpdateMasterData(string loginId, RoleModel role)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@RoleId", role.RoleId);
            parameters.Add("@loginId", loginId);
            parameters.Add("@RoleNm", role.RoleNm);
            parameters.Add("@RoleDesc", role.RoleDesc);

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateDetailData(string loginId, RoleModel role)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@RoleId", role.RoleId);
            parameters.Add("@RoleSeq", role.RoleSeq);
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@ReadWrtYN", role.ReadWrtYN);

            return _db.SaveData(sql, parameters);
        }
    }
}
