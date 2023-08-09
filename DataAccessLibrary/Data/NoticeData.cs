using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class NoticeData : INoticeData
    {

        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[Notice]";
        private readonly string sql_home = "[dbo].[Notice_Home]";

        public NoticeData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<NoticeModel>> GetNoticeHome()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");

            return _db.LoadData<NoticeModel, dynamic>(sql_home, parameters);
        }
        public Task<List<NoticeModel>> GetNotice(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<NoticeModel, dynamic>(sql, parameters);
        }

        public Task<List<NoticeModel>> GetNotice(string loginId, int noticeCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@NoticeCd", noticeCd);


            return _db.LoadData<NoticeModel, dynamic>(sql, parameters);
        }
        public Task InsertData(NoticeModel notice, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@Title", notice.Title.GetNullToEmpty());
            parameters.Add("@Contents", notice.Contents.GetNullToEmpty());
            parameters.Add("@StartDate", notice.StartDate.GetNullToEmpty());
            parameters.Add("@EndDate", notice.EndDate.GetNullToEmpty());
            parameters.Add("@ReadRoleId", notice.ReadRoleId.GetIntNullToZero());
            parameters.Add("@Remk", notice.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateData(NoticeModel notice, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@NoticeCd", notice.NoticeCd);
            parameters.Add("@Title", notice.Title.GetNullToEmpty());
            parameters.Add("@Contents", notice.Contents.GetNullToEmpty());
            parameters.Add("@StartDate", notice.StartDate.GetNullToEmpty());
            parameters.Add("@EndDate", notice.EndDate.GetNullToEmpty());
            parameters.Add("@ReadRoleId", notice.ReadRoleId.GetIntNullToZero());
            parameters.Add("@Remk", notice.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteData(NoticeModel notice)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@NoticeCd", notice.NoticeCd);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
