using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface ICustomerData
    {
        Task<List<CustomerModel>> GetAllCustomers(string loginId);
        Task<List<CustomerModel>> GetCustomer(string loginId, string customerCd);
        Task<List<CustomerModel>> GetAccountFromCodehelp(string loginId);
        Task<List<CustomerModel>> GetCustomerFromCodeHelp(string loginId);
        Task<List<FileModel>> GetFile(string customerCd, string loginId);
        Task InsertData(CustomerModel customer, string loginId);
        Task UpdateData(CustomerModel customer, string loginId);
        Task DeleteData(CustomerModel customer, string loginId);
    }
}