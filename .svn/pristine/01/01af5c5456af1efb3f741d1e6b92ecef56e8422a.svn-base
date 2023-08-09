using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[UserData]";
        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetUserCodeHelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task<List<UserModel>> GetAllUsers(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");

            if (loginId != null)
            {
                parameters.Add("@LoginId", loginId);
                //parameters.Add("@LoginPw", user.LoginPw);
            }

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task<List<UserModel>> GetUser(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");

            if (loginId != null)
            {
                parameters.Add("@LoginId", loginId);
            }

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }
        public Task<List<UserModel>> GetUser(int userCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R13");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@UserCd", userCd);

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task<List<UserModel>> GetUserFromCodehelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R14");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task<List<FileModel>> GetFile(int userCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@UserCd", userCd);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }
        public Task<List<UserModel>> LoginAsync(UserModel user = null)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");

            if (user != null)
            {
                parameters.Add("@LoginId", user.LoginId);
                //parameters.Add("@LoginPw", user.LoginPw);
            }

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task<List<UserModel>> PasswordInfo(string Email) //패스워드 찾기 프로시저 추가
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R15");
            parameters.Add("@LoginId", Email);

            return _db.LoadData<UserModel, dynamic>(sql, parameters);
        }

        public Task InsertData(UserModel user)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@UserId", user.UserId);
            parameters.Add("@LoginId", user.LoginId);
            parameters.Add("@LoginPw", user.LoginPw);
            parameters.Add("@UserNm", user.UserNm);
            parameters.Add("@PhoneNo", user.PhoneNo); //TB_User 테이블 PhoneNo 컬럼에 데이터 추가

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteUser(UserModel user)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@UserCd", user.UserCd);

            return _db.DeleteData(sql, parameters);
        }

        public Task UpdateUser(UserModel user, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@BizUnit", user.BizUnit);
            parameters.Add("@UserNm", user.UserNm);
            parameters.Add("@RoleId", user.RoleId);
            parameters.Add("@GroupCd", user.GroupCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@UserCd", user.UserCd);
            parameters.Add("@HireDate", user.HireDate);
            parameters.Add("@PhoneNo", user.PhoneNo);

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateUserName(string email, string userNm)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@UserNm", userNm);
            parameters.Add("@LoginId", email);

            return _db.SaveData(sql, parameters);
        }

       
        
        public Task ChangePassword(string LoginPw, string LoginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U12");
            parameters.Add("@LoginPw", LoginPw);
            parameters.Add("@LoginId", LoginId);

            return _db.SaveData(sql, parameters);
        }
    }
}
