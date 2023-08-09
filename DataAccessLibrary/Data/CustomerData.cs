using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[CustomerData]";
        public CustomerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CustomerModel>> GetAllCustomers(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<CustomerModel, dynamic>(sql, parameters);
        }

        public Task<List<CustomerModel>> GetCustomer(string loginId, string customerCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", customerCd);

            return _db.LoadData<CustomerModel, dynamic>(sql, parameters);
        }

        public Task<List<FileModel>> GetFile(string customerCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", customerCd);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }

        public Task<List<CustomerModel>> GetAccountFromCodehelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R13");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<CustomerModel, dynamic>(sql, parameters);
        }

        public Task<List<CustomerModel>> GetCustomerFromCodeHelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R14");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<CustomerModel, dynamic>(sql, parameters);
        }



        public Task InsertData(CustomerModel customer, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CompanyYN", customer.CompanyYN.GetNullToEmpty());
            parameters.Add("@CustomerNm", customer.CustomerNm.GetNullToEmpty());
            parameters.Add("@ConsultDt", customer.ConsultDt.GetNullToEmpty());
            parameters.Add("@Birth", customer.Birth.GetNullToEmpty());
            parameters.Add("@Gender", customer.Gender.GetNullToEmpty());
            parameters.Add("@PhoneNo", customer.PhoneNo.GetNullToEmpty());
            parameters.Add("@Email", customer.Email.GetNullToEmpty());
            parameters.Add("@ZipCode", customer.ZipCode.GetNullToEmpty());
            parameters.Add("@Address", customer.Address.GetNullToEmpty());
            parameters.Add("@DetailAddress", customer.DetailAddress.GetNullToEmpty());
            parameters.Add("@Job", customer.Job.GetNullToEmpty());
            parameters.Add("@Hobby", customer.Hobby.GetNullToEmpty());
            parameters.Add("@Rank", customer.Rank.GetIntNullToZero());
            parameters.Add("@Motive", customer.Motive.GetNullToEmpty());
            parameters.Add("@HairLossType", customer.HairLossType.GetNullToEmpty());
            parameters.Add("@WigExperience", customer.WigExperience.GetNullToEmpty());
            parameters.Add("@Job", customer.Job.GetNullToEmpty());
            parameters.Add("@Remk", customer.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }
        public Task UpdateData(CustomerModel customer, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", customer.CustomerCd.GetNullToEmpty());
            parameters.Add("@CompanyYN", customer.CompanyYN.GetNullToEmpty());
            parameters.Add("@CustomerNm", customer.CustomerNm.GetNullToEmpty());
            parameters.Add("@ConsultDt", customer.ConsultDt.GetNullToEmpty());
            parameters.Add("@Birth", customer.Birth.GetNullToEmpty());
            parameters.Add("@Gender", customer.Gender.GetNullToEmpty());
            parameters.Add("@PhoneNo", customer.PhoneNo.GetNullToEmpty());
            parameters.Add("@Email", customer.Email.GetNullToEmpty());
            parameters.Add("@ZipCode", customer.ZipCode.GetNullToEmpty());
            parameters.Add("@Address", customer.Address.GetNullToEmpty());
            parameters.Add("@DetailAddress", customer.DetailAddress.GetNullToEmpty());
            parameters.Add("@Job", customer.Job.GetNullToEmpty());
            parameters.Add("@Hobby", customer.Hobby.GetNullToEmpty());
            parameters.Add("@Rank", customer.Rank.GetIntNullToZero());
            parameters.Add("@Motive", customer.Motive.GetNullToEmpty());
            parameters.Add("@HairLossType", customer.HairLossType.GetNullToEmpty());
            parameters.Add("@WigExperience", customer.WigExperience.GetNullToEmpty());
            parameters.Add("@Job", customer.Job.GetNullToEmpty());
            parameters.Add("@Remk", customer.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(CustomerModel customer, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", customer.CustomerCd);

            return _db.SaveData(sql, parameters);
        }

    }
}
