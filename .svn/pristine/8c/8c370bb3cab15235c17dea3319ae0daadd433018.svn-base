using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class BizUnitData : IBizUnitData
    {

        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[BizUnit]";
        public BizUnitData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<BizUnitModel>> GetAllBizUnit(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R00");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<BizUnitModel, dynamic>(sql, parameters);
        }
        public Task<List<BizUnitModel>> GetFactoryBizUnit(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<BizUnitModel, dynamic>(sql, parameters);
        }
        public Task<List<BizUnitModel>> GetStoreBizUnit(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<BizUnitModel, dynamic>(sql, parameters);
        }

        public Task<List<BizUnitModel>> GetBizUnit(string loginId,string bizUnit)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);

            return _db.LoadData<BizUnitModel, dynamic>(sql, parameters);
        }
        public Task<List<BizUnitModel>> GetAllStoreBizUnit()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R13");

            return _db.LoadData<BizUnitModel, dynamic>(sql, parameters);
        }

        public Task InsertData(BizUnitModel bizUnit, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizNm", bizUnit.BizNm.GetNullToEmpty());
            parameters.Add("@BizLoc", bizUnit.BizLoc.GetNullToEmpty());
            parameters.Add("@BizType", bizUnit.BizType.GetNullToEmpty());
            parameters.Add("@OwnerNm", bizUnit.OwnerNm.GetNullToEmpty());
            parameters.Add("@PICNm", bizUnit.PICNm.GetNullToEmpty());
            parameters.Add("@PhoneNo", bizUnit.PhoneNo.GetNullToEmpty());
            parameters.Add("@LawBusiNo", bizUnit.LawBusiNo.GetNullToEmpty());
            parameters.Add("@SoleBusiNo", bizUnit.SoleBusiNo.GetNullToEmpty());
            parameters.Add("@AnnualSales", bizUnit.AnnualSales.GetNullToEmpty());
            parameters.Add("@EmpNumber", bizUnit.EmpNumber.GetIntNullToZero());
            parameters.Add("@Country", bizUnit.Country.GetNullToEmpty());
            parameters.Add("@Bank", bizUnit.Bank.GetNullToEmpty());
            parameters.Add("@BankNm", bizUnit.BankNm.GetNullToEmpty());
            parameters.Add("@BankNo", bizUnit.BankNo.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task UpdateData(BizUnitModel bizUnit, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit.BizUnit);
            parameters.Add("@BizNm", bizUnit.BizNm);
            parameters.Add("@BizLoc", bizUnit.BizLoc);
            parameters.Add("@BizType", bizUnit.BizType);
            parameters.Add("@OwnerNm", bizUnit.OwnerNm);
            parameters.Add("@PICNm", bizUnit.PICNm);
            parameters.Add("@PhoneNo", bizUnit.PhoneNo);
            parameters.Add("@LawBusiNo", bizUnit.LawBusiNo);
            parameters.Add("@SoleBusiNo", bizUnit.SoleBusiNo);
            parameters.Add("@AnnualSales", bizUnit.AnnualSales);
            parameters.Add("@EmpNumber", bizUnit.EmpNumber);
            parameters.Add("@Country", bizUnit.Country);
            parameters.Add("@Bank", bizUnit.Bank.GetNullToEmpty());
            parameters.Add("@BankNm", bizUnit.BankNm.GetNullToEmpty());
            parameters.Add("@BankNo", bizUnit.BankNo.GetNullToEmpty());

            return _db.SaveData(sql, parameters);
        }

        public Task DeleteData(BizUnitModel bizUnit, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@BizUnit", bizUnit.BizUnit);

            return _db.DeleteData(sql, parameters);
        }

    }
}
