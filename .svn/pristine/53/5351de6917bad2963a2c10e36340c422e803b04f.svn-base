using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLibrary.Data
{
    public class FileData : IFileData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[File]";
        public FileData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<FileModel>> GetFile(string loginId, DateTime startDt, DateTime endDt, int selectedFileCls)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@StartDt", startDt);
            parameters.Add("@EndDt", endDt);
            parameters.Add("@FileCls", selectedFileCls);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }
        public Task InsertData(FileModel file,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@FileCls", file.FileCls.GetIntNullToZero());
            parameters.Add("@DetailCls", file.DetailCls.GetIntNullToZero());
            parameters.Add("@UserCd", file.UserCd.GetIntNullToZero());
            parameters.Add("@GroupCd", file.GroupCd.GetIntNullToZero());
            parameters.Add("@CustomerCd", file.CustomerCd.GetIntNullToZero());
            parameters.Add("@ItemCd", file.ItemCd.GetNullToEmpty());
            parameters.Add("@FileNm", file.FileNm.GetNullToEmpty());
            parameters.Add("@FileData",file.FileData.GetNullToEmpty());
            parameters.Add("@FileType", file.FileType.GetNullToEmpty());
            parameters.Add("@Remk", file.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateData(FileModel file,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@DetailCls", file.DetailCls.GetIntNullToZero());
            parameters.Add("@FileNo", file.FileNo);
            parameters.Add("@FileNm", file.FileNm);
            parameters.Add("@FileData", file.FileData);
            parameters.Add("@FileType", file.FileType);
            parameters.Add("@Remk", file.Remk);

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(FileModel file,string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@FileNo", file.FileNo);

            return _db.DeleteData(sql, parameters);
        }
    }
}
