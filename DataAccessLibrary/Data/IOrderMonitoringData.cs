using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IOrderMonitoringData
    {
        Task<List<OrderMonitoringModel>> GetOrderMonitoringData(string loginId);
    }
}