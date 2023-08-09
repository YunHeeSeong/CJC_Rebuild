using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class GroupData : IGroupData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[Group]";
        public GroupData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<GroupModel>> GetGroup(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<GroupModel, dynamic>(sql, parameters);
        }

        public Task<List<FileModel>> GetFile(int groupCd,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@GroupCd", groupCd);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }

        public Task InsertData(GroupModel group, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@GroupNm", group.GroupNm);

            return _db.SaveData(sql, parameters);
        }
        public Task UpdateData(GroupModel group , string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@GroupCd", group.GroupCd);
            parameters.Add("@GroupNm", group.GroupNm);

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(GroupModel group, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@GroupCd", group.GroupCd);

            return _db.DeleteData(sql, parameters);
        }

    }
}
