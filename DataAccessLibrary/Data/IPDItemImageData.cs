using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IPDItemImageData
    {
        Task<List<PDItemImageModel>> GetPDItemImage(ItemModel orderModel);
        Task<List<ResultModel>> InsertData(PDItemImageModel file, string loginId);
        Task<List<ResultModel>> UpdateData(PDItemImageModel file, string loginId);
        Task<List<ResultModel>> DeleteData(PDItemImageModel file, string loginId);
    }
}