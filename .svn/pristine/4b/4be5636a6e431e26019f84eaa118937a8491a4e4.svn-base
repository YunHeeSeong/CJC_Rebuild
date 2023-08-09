using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IBOMData
    {
        Task DeleteData(BOMModel bom, string loginId);
        Task<List<ItemModel>> GetAllItem(string loginId);
        Task<List<BOMModel>> GetBOM(string bizUnit, string factBizUnit, string itemCd);
        Task<List<BOMModel>> GetBOMDetail(string bomCd, string loginId);
        Task<List<ResultModel>> InsertData(BOMModel bom, string loginId);
        Task UpdateData(BOMModel bom, string loginId);
    }
}