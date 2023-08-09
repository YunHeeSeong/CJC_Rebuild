using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface INoticeData
    {
        Task<List<NoticeModel>> GetNoticeHome();
        Task<List<NoticeModel>> GetNotice(string loginId);
        Task<List<NoticeModel>> GetNotice(string loginId, int noticeCd);
        Task InsertData(NoticeModel notice, string loginId);
        Task UpdateData(NoticeModel notice, string loginId);
        Task<List<ResultModel>> DeleteData(NoticeModel notice);
    }
}