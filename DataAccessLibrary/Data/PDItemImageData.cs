using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;

namespace DataAccessLibrary.Data
{
    public class PDItemImageData : IPDItemImageData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[PDItemImageData]";

        public PDItemImageData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<PDItemImageModel>> GetPDItemImage(ItemModel orderModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@BizUnit", orderModel.BizUnit);
            parameters.Add("@FactBizUnit", orderModel.FactBizUnit);
            parameters.Add("@ItemCd", orderModel.ItemCd);

            return _db.LoadData<PDItemImageModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> InsertData(PDItemImageModel file, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", file.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", file.FactBizUnit.GetNullToEmpty());
            parameters.Add("@FileCls", file.FileCls.GetIntNullToZero());
            parameters.Add("@ItemCd", file.ItemCd.GetNullToEmpty());
            parameters.Add("@FileNm", file.FileNm.GetNullToEmpty());
            parameters.Add("@FileData", file.FileData.GetNullToEmpty());
            parameters.Add("@FileType", file.FileType.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateData(PDItemImageModel file, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@FileNo", file.FileNo);
            parameters.Add("@BizUnit", file.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", file.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", file.ItemCd.GetNullToEmpty());
            parameters.Add("@FileCls", file.FileCls.GetIntNullToZero());
            parameters.Add("@FileNm", file.FileNm);
            parameters.Add("@FileData", file.FileData);
            parameters.Add("@FileType", file.FileType);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }

        public Task<List<ResultModel>> DeleteData(PDItemImageModel file, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@FileNo", file.FileNo);
            parameters.Add("@BizUnit", file.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", file.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", file.ItemCd.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql, parameters);
        }
    }
}
