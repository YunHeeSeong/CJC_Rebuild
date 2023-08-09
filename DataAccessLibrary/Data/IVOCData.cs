using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IVOCData
    {
        Task DeleteData(VOCModel asModel, string loginId);
        Task<List<VOCModel>> GetAllVoc(string loginId);
        Task<List<VOCModel>> GetVoc(string loginId, string VocNo);
        Task InsertData(VOCModel asModel, string loginId);
        Task UpdateData(VOCModel asModel, string loginId);
    }
}