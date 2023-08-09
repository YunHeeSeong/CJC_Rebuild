using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class CustHistData : ICustHistData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[CustHistData]";
        public CustHistData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<CustomerModel>> GetAllCustomer(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<CustomerModel, dynamic>(sql, parameters);
        }


        public Task<List<CustHistModel>> GetCustHist(string custHistCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustHistCd", custHistCd);

            return _db.LoadData<CustHistModel, dynamic>(sql, parameters);
        }

        public Task<List<CustHistModel>> GetCustHistFromCustomer(string loginId,CustomerModel customer)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", customer.BizUnit);
            parameters.Add("@CustomerCd", customer.CustomerCd);

            return _db.LoadData<CustHistModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertMasterData(CustHistModel custHist, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustomerCd", custHist.CustomerCd.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task InsertDetailData(CustHistModel custHist, string custHistCd, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@CustHistCd", custHistCd);
            parameters.Add("@OrderNo", custHist.OrderNo.GetNullToEmpty());
            //parameters.Add("@History", custHist.History.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        //public Task UpdateMasterData(CustHistModel custHist, string loginId)
        //{
        //    DynamicParameters parameters = new DynamicParameters();
        //    parameters.Add("@R_CRUD", "U10");
        //    parameters.Add("@CompCd", GlobalVar.CompCd);
        //    parameters.Add("@LoginId", loginId);

        //    return _db.SaveData(sql, parameters);
        //}

        public Task UpdateDetailData(CustHistModel custHist, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            //parameters.Add("@OrderNo", custHist.OrderNo);
            //parameters.Add("@History", custHist.History.GetNullToEmpty());
            //parameters.Add("@CustHistCd", custHist.CustHistCd.GetNullToEmpty());
            //parameters.Add("@Seq", custHist.Seq.GetIntNullToZero());

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateData(CustHistModel custHist, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", custHist.BizUnit);
            parameters.Add("@FactBizUnit", custHist.FactBizUnit.GetNullToEmpty());
            parameters.Add("@OrderNo", custHist.OrderNo.GetNullToEmpty());
            parameters.Add("@Remk", custHist.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteMasterData(CustHistModel custHist, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            //parameters.Add("@LoginId", loginId);
            //parameters.Add("@CustHistCd", custHist.CustHistCd);


            return _db.DeleteData(sql, parameters);
        }

        public Task DeleteDetailData(CustHistModel custHist, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            //parameters.Add("@CustHistCd", custHist.CustHistCd);
            //parameters.Add("@Seq", custHist.Seq);

            return _db.DeleteData(sql, parameters);
        }

    }
}

