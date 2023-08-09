using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface ICustHistData
    {
        Task DeleteDetailData(CustHistModel custHist, string loginId);
        Task DeleteMasterData(CustHistModel custHist, string loginId);
        Task<List<CustomerModel>> GetAllCustomer(string loginId);
        Task<List<CustHistModel>> GetCustHist(string custHistCd, string loginId);
        Task InsertDetailData(CustHistModel custHist, string custHistCd, string loginId);
        Task<List<ResultModel>> InsertMasterData(CustHistModel custHistCd, string loginId);
        Task UpdateDetailData(CustHistModel custHist, string loginId);
        Task<List<CustHistModel>> GetCustHistFromCustomer(string loginId, CustomerModel customer);
        Task UpdateData(CustHistModel custHist, string loginId);
        //Task UpdateMasterData(CustHistModel custHist, string loginId);
    }
}