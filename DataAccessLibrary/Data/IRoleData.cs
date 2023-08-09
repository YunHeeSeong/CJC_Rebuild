using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IRoleData
    {
        Task DeleteDetailData(string loginId, RoleModel role);
        Task DeleteMasterData(string loginId, int RoleId);
        Task<List<ResultModel>> InsertMasterData(string loginId, RoleModel role);
        Task<List<RoleModel>> GetRoleDetailList(string loginId, int roleId);
        Task<List<RoleModel>> GetRoleMasterList(string loginId);
        Task<List<RoleModel>> GetRoleYN(string loginId, int menuId);
        Task InsertDetailData(string loginId, int roleId);
        Task UpdateDetailData(string loginId, RoleModel role);
        Task UpdateMasterData(string loginId, RoleModel role);
    }
}