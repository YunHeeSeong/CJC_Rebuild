using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IWarehouseData
    {
        Task DeleteData(string WhCd);
        Task<List<WarehouseModel>> GetData(WarehouseModel warehouse = null);
        Task InsertData(WarehouseModel warehouse);
        Task UpdateData(WarehouseModel warehouse);
    }
}