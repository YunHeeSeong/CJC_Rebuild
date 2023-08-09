using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IBizUnitData
    {
        Task<List<BizUnitModel>> GetAllBizUnit(string loginId);
        Task<List<BizUnitModel>> GetFactoryBizUnit(string loginId);
        Task<List<BizUnitModel>> GetAllStoreBizUnit();
        Task<List<BizUnitModel>> GetStoreBizUnit(string loginId);
        Task<List<BizUnitModel>> GetBizUnit(string loginId, string bizUnit);
        Task InsertData(BizUnitModel bizUnit, string loginId);
        Task UpdateData(BizUnitModel bizUnit, string loginId);
        Task DeleteData(BizUnitModel bizUnit, string loginId);

    }
}