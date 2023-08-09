using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DataAccessLibrary.Model;


namespace DataAccessLibrary.Data
{
    public class ItemData : IItemData
    {
        private readonly ISqlDataAccess _db;
        private readonly string sql = "[dbo].[ItemData]";
        private readonly string sql2 = "[dbo].[PDItemData]";
        private readonly string sql3 = "[dbo].[PDItemImgData]";
        public ItemData(ISqlDataAccess db)
        {
            _db = db;
        }


        public Task<List<ItemModel>> GetAllItemCodeHelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R01");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemModel, dynamic>(sql, parameters);
        }

        public Task<List<ItemModel>> GetAllItem(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemModel, dynamic>(sql, parameters);
        }

        public Task<List<ItemModel>> GetAllPDItem(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemModel, dynamic>(sql2, parameters);
        }
        public Task<List<ItemModel>> GetPDItem(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<ItemModel, dynamic>(sql2, parameters);
        }

        public Task<List<ItemModel>> GetItem(string loginId, string bizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R11");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<ItemModel, dynamic>(sql, parameters);
        }
        //기타조회 추가
        public Task<List<EtcItemModel>> GetEtcItem(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R32");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<EtcItemModel, dynamic>(sql2, parameters);
        }
        //기타 인서트
        public Task<List<ResultModel>> InsertEtcItemData(string loginId, ItemModel item, EtcItemModel etcItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@FactBizUnit", item.FactBizUnit.GetNullToEmpty());
            //parameters.Add("@BizUnit", item.BizUnit);
           
            parameters.Add("@LoginId", loginId);
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            parameters.Add("@ModelType", etcItem.ModelType.GetIntNullToZero());
            parameters.Add("@AttachType", etcItem.AttachType.GetIntNullToZero());
            //parameters.Add("@AttachTypex", )
            parameters.Add("@AttachQty", etcItem.AttachQty.GetDecimalNullToZero());
            parameters.Add("@ItemWidth", etcItem.ItemWidth.GetDecimalNullToZero());
            parameters.Add("@ItemHeight", etcItem.ItemHeight.GetDecimalNullToZero());
            parameters.Add("@HairDirection", etcItem.HairDirection.GetIntNullToZero());
            parameters.Add("@HairDirectionx", etcItem.HairDirectionx.GetNullToEmpty());
            parameters.Add("@FiberTypeCN", etcItem.FiberTypeCN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeIN", etcItem.FiberTypeIN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeSTN", etcItem.FiberTypeSTN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeH", etcItem.FiberTypeH.GetDecimalNullToZero());
            parameters.Add("@FiberTypeEtc", etcItem.FiberTypeEtc.GetDecimalNullToZero());
            parameters.Add("@HairColor", etcItem.HairColor.GetIntNullToZero());
            parameters.Add("@HairColorFront", etcItem.HairColorFront.GetNullToEmpty());
            parameters.Add("@HairColorCenter", etcItem.HairColorCenter.GetNullToEmpty());
            parameters.Add("@HairColorEar", etcItem.HairColorEar.GetNullToEmpty());
            parameters.Add("@HairColorSide", etcItem.HairColorSide.GetNullToEmpty());
            parameters.Add("@HairColorBack", etcItem.HairColorBack.GetNullToEmpty());
            parameters.Add("@HairLengthFornt", etcItem.HairLengthFornt.GetDecimalNullToZero());
            parameters.Add("@HairLengthCenter", etcItem.HairLengthCenter.GetDecimalNullToZero());
            parameters.Add("@HairLengthEar", etcItem.HairLengthEar);
            parameters.Add("@HairLengthSide", etcItem.HairLengthSide);
            parameters.Add("@HairLengthBack", etcItem.HairLengthBack);
            parameters.Add("@HairAmountFront", etcItem.HairAmountFront);
            parameters.Add("@HairAmountCenter", etcItem.HairAmountCenter);
            parameters.Add("@HairAmountEar", etcItem.HairAmountEar);
            parameters.Add("@HairAmountSide", etcItem.HairAmountSide);
            parameters.Add("@HairAmountBack", etcItem.HairAmountBack);
            parameters.Add("@WHairAmountFront", etcItem.WHairAmountFront);
            parameters.Add("@WHairAmountCenter", etcItem.WHairAmountCenter);
            parameters.Add("@WHairAmountEar", etcItem.WHairAmountEar);
            parameters.Add("@WHairAmountSide", etcItem.WHairAmountSide);
            parameters.Add("@WHairAmountBack", etcItem.WHairAmountBack);
            parameters.Add("@CurlFront", etcItem.CurlFront);
            parameters.Add("@CurlCenter", etcItem.CurlCenter);
            parameters.Add("@CurlEar", etcItem.CurlEar);
            parameters.Add("@CurlSide", etcItem.CurlSide);
            parameters.Add("@CurlBack", etcItem.CurlBack);
            parameters.Add("@PartCrown", etcItem.PartCrown);
            parameters.Add("@FrontKnotting", etcItem.FrontKnotting);
            parameters.Add("@NanoSkinThin", etcItem.NanoSkinThin);
            parameters.Add("@NanoSkinCoating", etcItem.NanoSkinCoating);
            parameters.Add("@Round", etcItem.Round);
            parameters.Add("@RoundMeasure", etcItem.RoundMeasure);
            parameters.Add("@BaseNet", etcItem.BaseNet);
            parameters.Add("@SkinColor", etcItem.SkinColor);
            parameters.Add("@NanoSkinFront", etcItem.NanoSkinFront);
            parameters.Add("@NetItem", etcItem.NetItem);
            parameters.Add("@Front", etcItem.Front);


            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }
        //기타업데이트
        public Task<List<ResultModel>> UpdateEtcItemData(string loginId, ItemModel item, EtcItemModel etcItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@FactBizUnit", item.FactBizUnit);
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            
            

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }


        public Task<List<HandMdItemModel>> GetHandMdItem(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<HandMdItemModel, dynamic>(sql2, parameters);
        }

        public Task<List<MachineMdItemModel>> GetMachineMdItemMaster(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R13");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<MachineMdItemModel, dynamic>(sql2, parameters);
        }

        public Task<List<MachineMdItemModel>> GetMachineMdItemDetail(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R14");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", bizUnit);
            parameters.Add("@FactBizUnit", factBizUnit);
            parameters.Add("@ItemCd", itemCd);

            return _db.LoadData<MachineMdItemModel, dynamic>(sql2, parameters);
        }

        public Task<List<ItemModel>> GePDItemFromCodehelp(string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R15");
            parameters.Add("@LoginId", loginId);

            return _db.LoadData<ItemModel, dynamic>(sql2, parameters);
        }

        public Task<List<PDItemImgModel>> GetPDItemImg(string loginId, ItemModel itemModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R10");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", itemModel.BizUnit);
            parameters.Add("@FactBizUnit", itemModel.FactBizUnit);
            parameters.Add("@ItemCd", itemModel.ItemCd);

            return _db.LoadData<PDItemImgModel, dynamic>(sql3, parameters);
        }

        public Task<List<FileModel>> GetFile(ItemModel itemModel, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "R12");
            parameters.Add("@LoginId", loginId);
            parameters.Add("@ItemCd", itemModel.ItemCd);

            return _db.LoadData<FileModel, dynamic>(sql, parameters);
        }
        public Task<List<ResultModel>> InsertHandMdItemData(string loginId, ItemModel item, HandMdItemModel handItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@FactBizUnit", item.FactBizUnit.GetNullToEmpty());
            //parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            parameters.Add("@ModelType", handItem.ModelType.GetIntNullToZero());
            parameters.Add("@AttachType", handItem.AttachType.GetIntNullToZero());
            parameters.Add("@AttachTypex", handItem.AttachTypex.GetNullToEmpty());
            parameters.Add("@AttachQty", handItem.AttachQty.GetDecimalNullToZero());
            parameters.Add("@ItemWidth", handItem.ItemWidth.GetDecimalNullToZero());
            parameters.Add("@ItemHeight", handItem.ItemHeight.GetDecimalNullToZero());
            parameters.Add("@HairDirection", handItem.HairDirection.GetIntNullToZero());
            parameters.Add("@HairDirectionx", handItem.HairDirectionx.GetNullToEmpty());
            parameters.Add("@FiberTypeCN", handItem.FiberTypeCN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeIN", handItem.FiberTypeIN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeSTN", handItem.FiberTypeSTN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeH", handItem.FiberTypeH.GetDecimalNullToZero());
            parameters.Add("@FiberTypeEtc", handItem.FiberTypeEtc.GetDecimalNullToZero());
            parameters.Add("@HairColor", handItem.HairColor.GetIntNullToZero());
            parameters.Add("@HairColorFront", handItem.HairColorFront.GetNullToEmpty());
            parameters.Add("@HairColorCenter", handItem.HairColorCenter.GetNullToEmpty());
            parameters.Add("@HairColorEar", handItem.HairColorEar.GetNullToEmpty());
            parameters.Add("@HairColorSide", handItem.HairColorSide.GetNullToEmpty());
            parameters.Add("@HairColorBack", handItem.HairColorBack.GetNullToEmpty());
            parameters.Add("@HairLengthFornt", handItem.HairLengthFornt.GetDecimalNullToZero());
            parameters.Add("@HairLengthCenter", handItem.HairLengthCenter.GetDecimalNullToZero());
            parameters.Add("@HairLengthEar", handItem.HairLengthEar);
            parameters.Add("@HairLengthSide", handItem.HairLengthSide);
            parameters.Add("@HairLengthBack", handItem.HairLengthBack);
            parameters.Add("@HairAmountFront", handItem.HairAmountFront);
            parameters.Add("@HairAmountCenter", handItem.HairAmountCenter);
            parameters.Add("@HairAmountEar", handItem.HairAmountEar);
            parameters.Add("@HairAmountSide", handItem.HairAmountSide);
            parameters.Add("@HairAmountBack", handItem.HairAmountBack);
            parameters.Add("@WHairAmountFront", handItem.WHairAmountFront);
            parameters.Add("@WHairAmountCenter", handItem.WHairAmountCenter);
            parameters.Add("@WHairAmountEar", handItem.WHairAmountEar);
            parameters.Add("@WHairAmountSide", handItem.WHairAmountSide);
            parameters.Add("@WHairAmountBack", handItem.WHairAmountBack);
            parameters.Add("@CurlFront", handItem.CurlFront);
            parameters.Add("@CurlCenter", handItem.CurlCenter);
            parameters.Add("@CurlEar", handItem.CurlEar);
            parameters.Add("@CurlSide", handItem.CurlSide);
            parameters.Add("@CurlBack", handItem.CurlBack);
            parameters.Add("@PartCrown", handItem.PartCrown);
            parameters.Add("@FrontKnotting", handItem.FrontKnotting);
            parameters.Add("@NanoSkinThin", handItem.NanoSkinThin);
            parameters.Add("@NanoSkinCoating", handItem.NanoSkinCoating);
            parameters.Add("@Round", handItem.Round);
            parameters.Add("@RoundMeasure", handItem.RoundMeasure);
            parameters.Add("@BaseNet", handItem.BaseNet);
            parameters.Add("@SkinColor", handItem.SkinColor);
            parameters.Add("@NanoSkinFront", handItem.NanoSkinFront);
            parameters.Add("@NetItem", handItem.NetItem);
            parameters.Add("@Front", handItem.Front);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }

        public Task<List<ResultModel>> InsertMachineMdItemData(string loginId, ItemModel item, MachineMdItemModel machineMdItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@FactBizUnit", item.FactBizUnit.GetNullToEmpty());
            //parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            parameters.Add("@Buyer", machineMdItem.Buyer.GetNullToEmpty());
            parameters.Add("@Fiber", machineMdItem.Fiber.GetNullToEmpty());
            parameters.Add("@MachineType", machineMdItem.MachineType.GetNullToEmpty());
            parameters.Add("@Weight", machineMdItem.Weight.GetDecimalNullToZero());
            parameters.Add("@ManufactedDt", machineMdItem.ManufactedDt.GetNullToEmpty());
            parameters.Add("@HairLength", machineMdItem.HairLength.GetNullToEmpty());
            parameters.Add("@GongGo", machineMdItem.GongGo.GetNullToEmpty());
            parameters.Add("@GongInsoo", machineMdItem.GongInsoo.GetNullToEmpty());
            parameters.Add("@GongIngye", machineMdItem.GongIngye.GetNullToEmpty());
            parameters.Add("@WeightHand", machineMdItem.WeightHand.GetNullToEmpty());
            parameters.Add("@WeightInsoo", machineMdItem.WeightInsoo.GetNullToEmpty());
            parameters.Add("@WeightIngye", machineMdItem.WeightIngye.GetNullToEmpty());
            parameters.Add("@WeightLength", machineMdItem.WeightLength.GetNullToEmpty());
            parameters.Add("@CapWeight", machineMdItem.CapWeight.GetNullToEmpty());
            parameters.Add("@CapRound", machineMdItem.CapRound.GetNullToEmpty());
            parameters.Add("@CapLength", machineMdItem.CapLength.GetNullToEmpty());
            parameters.Add("@CapFrontBack", machineMdItem.CapFrontBack.GetNullToEmpty());
            parameters.Add("@CapPartItem", machineMdItem.CapPartItem.GetNullToEmpty());
            parameters.Add("@PartHair", machineMdItem.PartHair.GetNullToEmpty());
            parameters.Add("@PartSize", machineMdItem.PartSize.GetNullToEmpty());
            parameters.Add("@SkinWeight", machineMdItem.SkinWeight.GetDecimalNullToZero());
            parameters.Add("@Loss", machineMdItem.Loss.GetNullToEmpty());
            parameters.Add("@TotalWeight", machineMdItem.TotalWeight.GetDecimalNullToZero());

            return _db.SaveDataGetReuslt<ResultModel,dynamic>(sql2, parameters);
        }

        public Task InsertMachineMdItemDetailData(string loginId, MachineMdItemModel machineMdItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@FactBizUnit", machineMdItem.FactBizUnit.GetNullToEmpty());
            parameters.Add("@BizUnit", machineMdItem.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", machineMdItem.ItemCd.GetNullToEmpty());
            parameters.Add("@LoginId", loginId);
            parameters.Add("@Size", machineMdItem.Size.GetIntNullToZero());
            parameters.Add("@StretchCut", machineMdItem.StretchCut.GetNullToEmpty());
            parameters.Add("@StretchYN", machineMdItem.StretchYN.GetNullToEmpty());
            parameters.Add("@StretchWeight", machineMdItem.StretchWeight.GetNullToEmpty());
            parameters.Add("@TwinHairLength", machineMdItem.TwinHairLength.GetNullToEmpty());
            parameters.Add("@TwinHand", machineMdItem.TwinHand.GetNullToEmpty());
            parameters.Add("@TwinCut", machineMdItem.TwinCut.GetNullToEmpty());
            parameters.Add("@CurlPipe", machineMdItem.CurlPipe.GetNullToEmpty());
            parameters.Add("@CurlDirection", machineMdItem.CurlDirection.GetNullToEmpty());
            parameters.Add("@CurlSpecial", machineMdItem.CurlSpecial.GetNullToEmpty());
            parameters.Add("@CurlRemk", machineMdItem.CurlRemk.GetNullToEmpty());
            parameters.Add("@CurlThickness", machineMdItem.CurlThickness.GetNullToEmpty());

            return _db.SaveData(sql2, parameters);
        }

        public Task InsertItemData(string loginId, ItemModel item)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId.GetNullToEmpty());
            parameters.Add("@BizUnit", item.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@ItemCls", item.ItemCls);
            parameters.Add("@Item1Cls", item.Item1Cls);
            parameters.Add("@Item2Cls", item.Item2Cls);
            parameters.Add("@Item3Cls", item.Item3Cls);
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());

            return _db.SaveData(sql, parameters);

        }

        public Task InsertPDItemImgData(string loginId, ItemModel item, PDItemImgModel imgModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "I10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId.GetNullToEmpty());
            parameters.Add("@BizUnit", item.BizUnit.GetNullToEmpty());
            parameters.Add("@FactBizUnit", item.FactBizUnit.GetNullToEmpty());
            parameters.Add("@ImageData", imgModel.ImageData.GetNullToEmpty());
            parameters.Add("@RealImageData", imgModel.RealImageData);
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@Remk", imgModel.Remk.GetNullToEmpty());

            return _db.SaveData(sql3, parameters);
        }
        public Task UpdateItemData(string loginId, ItemModel item)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@ItemCd", item.ItemCd);
            parameters.Add("@ItemNm", item.ItemNm);
            parameters.Add("@ItemCls", item.ItemCls);
            parameters.Add("@Item1Cls", item.Item1Cls);
            parameters.Add("@Item2Cls", item.Item2Cls);
            parameters.Add("@Item3Cls", item.Item3Cls);
            parameters.Add("@Unit", item.Unit);
            parameters.Add("@Price", item.Price);
            parameters.Add("@Remk", item.Remk);

            return _db.SaveData(sql, parameters);
        }

        public Task<List<ResultModel>> UpdateHandMdItemData(string loginId, ItemModel item, HandMdItemModel handItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId);
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@FactBizUnit", item.FactBizUnit);
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            parameters.Add("@ModelType", handItem.ModelType.GetIntNullToZero());
            parameters.Add("@AttachType", handItem.AttachType.GetIntNullToZero());
            parameters.Add("@AttachTypex", handItem.AttachTypex.GetNullToEmpty());
            parameters.Add("@AttachQty", handItem.AttachQty.GetDecimalNullToZero());
            parameters.Add("@ItemWidth", handItem.ItemWidth.GetDecimalNullToZero());
            parameters.Add("@ItemHeight", handItem.ItemHeight.GetDecimalNullToZero());
            parameters.Add("@HairDirection", handItem.HairDirection.GetIntNullToZero());
            parameters.Add("@FiberTypeCN", handItem.FiberTypeCN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeIN", handItem.FiberTypeIN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeSTN", handItem.FiberTypeSTN.GetDecimalNullToZero());
            parameters.Add("@FiberTypeH", handItem.FiberTypeH.GetDecimalNullToZero());
            parameters.Add("@FiberTypeEtc", handItem.FiberTypeEtc.GetDecimalNullToZero());
            parameters.Add("@HairColor", handItem.HairColor.GetIntNullToZero());
            parameters.Add("@HairColorFront", handItem.HairColorFront.GetNullToEmpty());
            parameters.Add("@HairColorCenter", handItem.HairColorCenter.GetNullToEmpty());
            parameters.Add("@HairColorEar", handItem.HairColorEar.GetNullToEmpty());
            parameters.Add("@HairColorSide", handItem.HairColorSide.GetNullToEmpty());
            parameters.Add("@HairColorBack", handItem.HairColorBack.GetNullToEmpty());
            parameters.Add("@HairLengthFornt", handItem.HairLengthFornt.GetDecimalNullToZero());
            parameters.Add("@HairLengthCenter", handItem.HairLengthCenter.GetDecimalNullToZero());
            parameters.Add("@HairLengthEar", handItem.HairLengthEar);
            parameters.Add("@HairLengthSide", handItem.HairLengthSide);
            parameters.Add("@HairLengthBack", handItem.HairLengthBack);
            parameters.Add("@HairAmountFront", handItem.HairAmountFront);
            parameters.Add("@HairAmountCenter", handItem.HairAmountCenter);
            parameters.Add("@HairAmountEar", handItem.HairAmountEar);
            parameters.Add("@HairAmountSide", handItem.HairAmountSide);
            parameters.Add("@HairAmountBack", handItem.HairAmountBack);
            parameters.Add("@WHairAmountFront", handItem.WHairAmountFront);
            parameters.Add("@WHairAmountCenter", handItem.WHairAmountCenter);
            parameters.Add("@WHairAmountEar", handItem.WHairAmountEar);
            parameters.Add("@WHairAmountSide", handItem.WHairAmountSide);
            parameters.Add("@WHairAmountBack", handItem.WHairAmountBack);
            parameters.Add("@CurlFront", handItem.CurlFront);
            parameters.Add("@CurlCenter", handItem.CurlCenter);
            parameters.Add("@CurlEar", handItem.CurlEar);
            parameters.Add("@CurlSide", handItem.CurlSide);
            parameters.Add("@CurlBack", handItem.CurlBack);
            parameters.Add("@PartCrown", handItem.PartCrown);
            parameters.Add("@FrontKnotting", handItem.FrontKnotting);
            parameters.Add("@NanoSkinThin", handItem.NanoSkinThin);
            parameters.Add("@NanoSkinCoating", handItem.NanoSkinCoating);
            parameters.Add("@Round", handItem.Round);
            parameters.Add("@RoundMeasure", handItem.RoundMeasure);
            parameters.Add("@BaseNet", handItem.BaseNet);
            parameters.Add("@SkinColor", handItem.SkinColor);
            parameters.Add("@NanoSkinFront", handItem.NanoSkinFront);
            parameters.Add("@NetItem", handItem.NetItem);
            parameters.Add("@Front", handItem.Front);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }

        public Task<List<ResultModel>> UpdateMachineMdItemData(string loginId, ItemModel item, MachineMdItemModel machineMdItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@FactBizUnit", item.FactBizUnit.GetNullToEmpty());
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@LoginId", loginId);
            parameters.Add("@MadeYN", item.MadeYN.GetNullToEmpty());
            parameters.Add("@MadeType", item.MadeType.GetIntNullToZero());
            parameters.Add("@ItemCd", item.ItemCd.GetNullToEmpty());
            parameters.Add("@ItemNm", item.ItemNm.GetNullToEmpty());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@ItemCls", item.ItemCls.GetIntNullToZero());
            parameters.Add("@Item1Cls", item.Item1Cls.GetIntNullToZero());
            parameters.Add("@Item2Cls", item.Item2Cls.GetIntNullToZero());
            parameters.Add("@Item3Cls", item.Item3Cls.GetIntNullToZero());
            parameters.Add("@Unit", item.Unit.GetNullToEmpty());
            parameters.Add("@Price", item.Price.GetDecimalNullToZero());
            parameters.Add("@Remk", item.Remk.GetNullToEmpty());
            parameters.Add("@Buyer", machineMdItem.Buyer.GetNullToEmpty());
            parameters.Add("@Fiber", machineMdItem.Fiber.GetNullToEmpty());
            parameters.Add("@MachineType", machineMdItem.MachineType.GetNullToEmpty());
            parameters.Add("@Weight", machineMdItem.Weight.GetDecimalNullToZero());
            parameters.Add("@ManufactedDt", machineMdItem.ManufactedDt.GetNullToEmpty());
            parameters.Add("@HairLength", machineMdItem.HairLength.GetNullToEmpty());
            parameters.Add("@GongGo", machineMdItem.GongGo.GetNullToEmpty());
            parameters.Add("@GongInsoo", machineMdItem.GongInsoo.GetNullToEmpty());
            parameters.Add("@GongIngye", machineMdItem.GongIngye.GetNullToEmpty());
            parameters.Add("@WeightHand", machineMdItem.WeightHand.GetNullToEmpty());
            parameters.Add("@WeightInsoo", machineMdItem.WeightInsoo.GetNullToEmpty());
            parameters.Add("@WeightIngye", machineMdItem.WeightIngye.GetNullToEmpty());
            parameters.Add("@WeightLength", machineMdItem.WeightLength.GetNullToEmpty());
            parameters.Add("@CapWeight", machineMdItem.CapWeight.GetNullToEmpty());
            parameters.Add("@CapRound", machineMdItem.CapRound.GetNullToEmpty());
            parameters.Add("@CapLength", machineMdItem.CapLength.GetNullToEmpty());
            parameters.Add("@CapFrontBack", machineMdItem.CapFrontBack.GetNullToEmpty());
            parameters.Add("@CapPartItem", machineMdItem.CapPartItem.GetNullToEmpty());
            parameters.Add("@PartHair", machineMdItem.PartHair.GetNullToEmpty());
            parameters.Add("@PartSize", machineMdItem.PartSize.GetNullToEmpty());
            parameters.Add("@SkinWeight", machineMdItem.SkinWeight.GetDecimalNullToZero());
            parameters.Add("@Loss", machineMdItem.Loss.GetNullToEmpty());
            parameters.Add("@TotalWeight", machineMdItem.TotalWeight.GetDecimalNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }



        public Task<List<ResultModel>> UpdateMachineMdItemDetailData(string loginId, MachineMdItemModel machineMdItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@LoginId", loginId.GetNullToEmpty());
            parameters.Add("@FactBizUnit", machineMdItem.FactBizUnit.GetNullToEmpty());
            parameters.Add("@BizUnit", machineMdItem.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", machineMdItem.ItemCd.GetNullToEmpty());
            parameters.Add("@Size", machineMdItem.Size.GetIntNullToZero());
            parameters.Add("@StretchCut", machineMdItem.StretchCut.GetDecimalNullToZero());
            parameters.Add("@StretchYN", machineMdItem.StretchYN.GetNullToEmpty());
            parameters.Add("@StretchWeight", machineMdItem.StretchWeight.GetNullToEmpty());
            parameters.Add("@TwinHairLength", machineMdItem.TwinHairLength.GetNullToEmpty());
            parameters.Add("@TwinHand", machineMdItem.TwinHand.GetNullToEmpty());
            parameters.Add("@TwinCut", machineMdItem.TwinCut.GetNullToEmpty());
            parameters.Add("@CurlPipe", machineMdItem.CurlPipe.GetNullToEmpty());
            parameters.Add("@CurlDirection", machineMdItem.CurlDirection.GetNullToEmpty());
            parameters.Add("@CurlSpecial", machineMdItem.CurlSpecial.GetNullToEmpty());
            parameters.Add("@CurlRemk", machineMdItem.CurlRemk.GetNullToEmpty());
            parameters.Add("@CurlThickness", machineMdItem.CurlThickness.GetNullToEmpty());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }

        public Task<List<ResultModel>> UpdatePDItemImgData(string loginId, PDItemImgModel imgModel)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "U10");
            parameters.Add("@LoginId", loginId.GetNullToEmpty());
            parameters.Add("@FactBizUnit", imgModel.FactBizUnit.GetNullToEmpty());
            parameters.Add("@BizUnit", imgModel.BizUnit.GetNullToEmpty());
            parameters.Add("@ItemCd", imgModel.ItemCd.GetNullToEmpty());
            parameters.Add("@ImageData", imgModel.ImageData);
            parameters.Add("@Seq", imgModel.Seq.GetIntNullToZero());

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql3, parameters);
        }


        public Task<List<ResultModel>> DeletePDItem(ItemModel item, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@loginId", loginId);
            parameters.Add("@FactBizUnit", item.FactBizUnit);
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@ItemCd", item.ItemCd);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }

        public Task<List<ResultModel>> DeleteMachineMdItemDetail(string loginId, MachineMdItemModel machineMdItem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D11");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@loginId", loginId);
            parameters.Add("@FactBizUnit", machineMdItem.FactBizUnit);
            parameters.Add("@BizUnit", machineMdItem.BizUnit);
            parameters.Add("@ItemCd", machineMdItem.ItemCd);
            parameters.Add("@Seq", machineMdItem.Seq);

            return _db.SaveDataGetReuslt<ResultModel, dynamic>(sql2, parameters);
        }


        public Task DeleteItem(ItemModel item, string loginId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@R_CRUD", "D10");
            parameters.Add("@CompCd", GlobalVar.CompCd);
            parameters.Add("@loginId", loginId);
            parameters.Add("@BizUnit", item.BizUnit);
            parameters.Add("@ItemCd", item.ItemCd);

            return _db.DeleteData(sql, parameters);
        }

        public Task<List<EtcItemModel>> GetEtcItemModel(string loginId, string bizUnit, string factBizUnit, string itemCd)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultModel>> InsertEtcItemModelData(string loginId, ItemModel item, HandMdItemModel handItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
