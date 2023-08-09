using DataAccessLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
    public interface IItemData
    {
        Task DeleteItem(ItemModel item, string loginId);
        Task<List<FileModel>> GetFile(ItemModel itemModel, string loginId);
        Task<List<ResultModel>> DeleteMachineMdItemDetail(string loginId, MachineMdItemModel machineMdItem);
        Task<List<ResultModel>> DeletePDItem(ItemModel item, string loginId);
        Task<List<ItemModel>> GetAllItem(string loginId);
        Task<List<ItemModel>> GetAllItemCodeHelp(string loginId);
        Task<List<ItemModel>> GetAllPDItem(string loginId);
        Task<List<PDItemImgModel>> GetPDItemImg(string loginId, ItemModel itemModel);
        Task InsertPDItemImgData(string loginId, ItemModel item, PDItemImgModel imgModel);
        //기타추가
        Task<List<EtcItemModel>> GetEtcItem(string loginId, string bizUnit, string factBizUnit, string itemCd);
        Task<List<ResultModel>> InsertEtcItemData(string loginId, ItemModel item, EtcItemModel etcItem);
        Task<List<ResultModel>> UpdateEtcItemData(string loginId, ItemModel item, EtcItemModel etcItem);

        Task<List<HandMdItemModel>> GetHandMdItem(string loginId, string bizUnit, string factBizUnit, string itemCd);
        Task<List<ItemModel>> GetItem(string loginId, string bizUnit, string itemCd);
        Task<List<ResultModel>> UpdatePDItemImgData(string loginId, PDItemImgModel imgModel);
        Task<List<ItemModel>> GePDItemFromCodehelp(string loginId);
        Task<List<MachineMdItemModel>> GetMachineMdItemDetail(string loginId, string bizUnit, string factBizUnit, string itemCd);
        Task<List<MachineMdItemModel>> GetMachineMdItemMaster(string loginId, string bizUnit, string factBizUnit, string itemCd);
        Task<List<ItemModel>> GetPDItem(string loginId, string bizUnit, string factBizUnit, string itemCd);
        Task<List<ResultModel>> InsertHandMdItemData(string loginId, ItemModel item, HandMdItemModel handItem);
        Task InsertItemData(string loginId, ItemModel item);
        //Task InsertMachineMdItemData(string loginId, ItemModel item, MachineMdItemModel machineMdItem);
        Task<List<ResultModel>> InsertMachineMdItemData(string loginId, ItemModel item, MachineMdItemModel machineMdItem);
        Task InsertMachineMdItemDetailData(string loginId, MachineMdItemModel machineMdItem);
        Task<List<ResultModel>> UpdateHandMdItemData(string loginId, ItemModel item, HandMdItemModel handItem);
        Task UpdateItemData(string loginId, ItemModel item);
        Task<List<ResultModel>> UpdateMachineMdItemData(string loginId, ItemModel item, MachineMdItemModel machineMdItem);
        Task<List<ResultModel>> UpdateMachineMdItemDetailData(string loginId, MachineMdItemModel machineMdItem);
    }
}