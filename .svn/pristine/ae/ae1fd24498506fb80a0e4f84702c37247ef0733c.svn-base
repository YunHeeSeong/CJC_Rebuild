using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IASData
    {
        Task<List<OrderModel>> GetOrderFromCodehelp(string loginId);
        Task DeleteData(ASModel asModel, string loginId);
        Task<List<ASModel>> GetAllAS(string loginId);
        Task<List<ASModel>> GetAS(string loginId, string AsNo);
        Task<List<FileModel>> GetImage(string loginId, string AsNo);
        Task InsertData(ASModel asModel, string loginId);
        Task UpdateData(ASModel asModel, string loginId);
    }
}