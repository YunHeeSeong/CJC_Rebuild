using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IGroupData
    {
        Task<List<GroupModel>> GetGroup(string userNm);
        Task<List<FileModel>> GetFile(int groupCd, string loginId);
        Task InsertData(GroupModel group, string userNm);
        Task UpdateData(GroupModel group, string userNm);
        Task DeleteData(GroupModel group, string userNm);

    }
}