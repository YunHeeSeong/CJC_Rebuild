using Dapper;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public class InventoryCheckData : IInventoryCheckData
    {
        private readonly ISqlDataAccess _db;
        private readonly string factSql = "[dbo].[InventoryCheck_FactData]";
        private readonly string storeSql = "[dbo].[InventoryCheck_StrData]";

        public InventoryCheckData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<InventoryCheckModel>> GetFactPDItemCheckData(string loginId, InventoryModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit);
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit);
            parameters.Add("@ItemCd", checkModel.ItemCd);
            parameters.Add("@Whcd", checkModel.FactBizUnit);

            return _db.LoadData<InventoryCheckModel, dynamic>(factSql, parameters);
        }

        public Task<List<InventoryCheckModel>> GetFactItemCheckData(string loginId, InventoryModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit);
            parameters.Add("@ItemCd", checkModel.ItemCd);

            return _db.LoadData<InventoryCheckModel, dynamic>(factSql, parameters);
        }

        public Task<List<ResultModel>> FactPDItemInsertData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckStkDate", checkModel.CheckStkDate.GetNullToEmpty());
            parameters.Add("@CheckStkQty", checkModel.CheckStkQty.GetDecimalNullToZero());
            parameters.Add("@CheckStkGroupCd", checkModel.CheckStkGroupCd.GetIntNullToZero());
            parameters.Add("@CheckStkUserId", checkModel.CheckStkUserId.GetIntNullToZero());
            parameters.Add("@Price", checkModel.Price.GetDecimalNullToZero());
            parameters.Add("@CheckStkAmt", checkModel.CheckStkAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", checkModel.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(factSql, parameters);
        }
        public Task<List<ResultModel>> FactItemInsertData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            //parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckStkDate", checkModel.CheckStkDate.GetNullToEmpty());
            parameters.Add("@CheckStkQty", checkModel.CheckStkQty.GetDecimalNullToZero());
            parameters.Add("@CheckStkGroupCd", checkModel.CheckStkGroupCd.GetIntNullToZero());
            parameters.Add("@CheckStkUserId", checkModel.CheckStkUserId.GetIntNullToZero());
            parameters.Add("@Price", checkModel.Price.GetDecimalNullToZero());
            parameters.Add("@CheckStkAmt", checkModel.CheckStkAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", checkModel.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(factSql, parameters);
        }

        public Task<List<ResultModel>> FactPDItemDeleteData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@Whcd", checkModel.Whcd.GetNullToEmpty());
            parameters.Add("@CheckSeq", checkModel.CheckSeq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(factSql, parameters);
        }

        public Task<List<ResultModel>> FactItemDeleteData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckSeq", checkModel.CheckSeq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(factSql, parameters);
        }

        public Task<List<InventoryCheckModel>> GetStorePDItemCheckData(string loginId, InventoryModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit);
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit);
            parameters.Add("@ItemCd", checkModel.ItemCd);
            parameters.Add("@Whcd", checkModel.BizUnit);

            return _db.LoadData<InventoryCheckModel, dynamic>(storeSql, parameters);
        }

        public Task<List<InventoryCheckModel>> GetStoreItemCheckData(string loginId, InventoryModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit);
            parameters.Add("@ItemCd", checkModel.ItemCd);

            return _db.LoadData<InventoryCheckModel, dynamic>(storeSql, parameters);
        }

        public Task<List<ResultModel>> StorePDItemInsertData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckStkDate", checkModel.CheckStkDate.GetNullToEmpty());
            parameters.Add("@CheckStkQty", checkModel.CheckStkQty.GetDecimalNullToZero());
            parameters.Add("@CheckStkGroupCd", checkModel.CheckStkGroupCd.GetIntNullToZero());
            parameters.Add("@CheckStkUserId", checkModel.CheckStkUserId.GetIntNullToZero());
            parameters.Add("@Price", checkModel.Price.GetDecimalNullToZero());
            parameters.Add("@CheckStkAmt", checkModel.CheckStkAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", checkModel.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(storeSql, parameters);
        }
        public Task<List<ResultModel>> StoreItemInsertData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            //parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckStkDate", checkModel.CheckStkDate.GetNullToEmpty());
            parameters.Add("@CheckStkQty", checkModel.CheckStkQty.GetDecimalNullToZero());
            parameters.Add("@CheckStkGroupCd", checkModel.CheckStkGroupCd.GetIntNullToZero());
            parameters.Add("@CheckStkUserId", checkModel.CheckStkUserId.GetIntNullToZero());
            parameters.Add("@Price", checkModel.Price.GetDecimalNullToZero());
            parameters.Add("@CheckStkAmt", checkModel.CheckStkAmt.GetDecimalNullToZero());
            parameters.Add("@Remk", checkModel.Remk.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(storeSql, parameters);
        }

        public Task<List<ResultModel>> StorePDItemDeleteData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", checkModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@Whcd", checkModel.Whcd.GetNullToEmpty());
            parameters.Add("@CheckSeq", checkModel.CheckSeq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(storeSql, parameters);
        }

        public Task<List<ResultModel>> StoreItemDeleteData(string loginId, InventoryCheckModel checkModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", checkModel.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", checkModel.ItemCd.GetNullToEmpty());
            parameters.Add("@CheckSeq", checkModel.CheckSeq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(storeSql, parameters);
        }
    }
}
