using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface ICommonCodeData
    {
        Task DeleteDetailData(CommonCodeModel code, string loginId);
        Task DeleteMasterData(CommonCodeModel code, string loginId);
        Task<List<CommonCodeModel>> GetAllCommonCodes(string loginId);
        Task<List<CommonCodeModel>> GetCommonCode(int codeId, string loginId);
        Task<List<CommonCodeModel>> FindCommonCodeFromName(string codeNm, string loginId);

        Task<List<CommonCodeModel>> GetCommonCodeDetail(int codeId, string loginId);
        Task InsertDetailData(CommonCodeModel code, int codeId, string loginId);
        Task<List<ResultModel>> InsertMasterData(CommonCodeModel code, string loginId);
        Task UpdateDetailData(CommonCodeModel code, string loginId);
        Task UpdateMasterData(CommonCodeModel code, string loginId);
    }
}