// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Customer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.Resources.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\OrderEdit.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\OrderEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\OrderEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderEdit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderEdit/{loginId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderEdit/{loginId}/{storeBizUnit}/{factBizUnit}/{selectedOrderNo}")]
    public partial class OrderEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 991 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\OrderEdit.razor"
       
    [Parameter] public string selectedOrderNo { get; set; }
    [Parameter] public string factBizUnit { get; set; }
    [Parameter] public string storeBizUnit { get; set; }
    [Parameter] public string loginId { get; set; }

    private GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    private MachineMdItemModel machineItemToDelete { get; set; }

    private OrderModel orderModel = new OrderModel();
    private HandMdItemModel handMdItemModel = new HandMdItemModel();
    private MachineMdItemModel machineMdItemMaster = new MachineMdItemModel();
    private MachineMdItemModel machineMdItemDetail = new MachineMdItemModel();
    private PDItemImgModel itemImgModel = new PDItemImgModel();
    private ItemModel itemModel = new ItemModel();
    private WorkOrderModel workOrderModel = new WorkOrderModel();
    private List<MachineMdItemModel> machineMdItemModels;

    RadzenDataGrid<MachineMdItemModel> detailGrid;

    private MachineMdItemModel machineToInsert;
    IEnumerable<int> values = new int[] {  };

    //공통코드
    List<UserModel> userlist;
    List<CustomerModel> customerList;
    List<BizUnitModel> factBizUnitList;
    List<CommonCodeModel> itemClsList;
    List<CommonCodeModel> item1ClsList;
    List<CommonCodeModel> item2ClsList;
    List<CommonCodeModel> item3ClsList;
    List<CommonCodeModel> modelTypeList;
    List<CommonCodeModel> attachTypeList;
    List<CommonCodeModel> hairDirectioneList;
    List<CommonCodeModel> hairColorList;
    List<CommonCodeModel> frontKnottingList;
    List<CommonCodeModel> baseNetList;
    List<CommonCodeModel> frontList;
    List<CommonCodeModel> nanoSkinThinList;
    List<CommonCodeModel> nanoSkinCoatingList;
    List<CommonCodeModel> skinColorList;
    List<CommonCodeModel> partCrownList;
    List<CommonCodeModel> madeTypeList;
    List<CommonCodeModel> workStateList;
    List<ItemModel> pdItemCdList;
    List<int> HDirec;

    int orderCls = 1;
    int payYN = 1;

    DateTime orderDt;           //주문일자
    DateTime payDt;             //결제일자
    DateTime manufactedDt;      //머신메이드-제조일자
    bool isDisabled;

    #region // ** 페이지 로드시 진입점 Init ** //
    protected override async Task OnInitializedAsync()
    {
        //수정일때
        if (selectedOrderNo is not null && factBizUnit is not null)
        {
            isDisabled = true;

            orderModel.OrderNo = selectedOrderNo;
            orderModel.FactBizUnit = factBizUnit;
            orderModel.BizUnit = storeBizUnit;

            var orderlist = await _orderManager.GetOrderDetailEdit(orderModel.OrderNo, factBizUnit, loginId);
            orderModel = orderlist.FirstOrDefault();

            //날짜 컬럼 형변환
            orderDt = Convert.ToDateTime(orderModel.OrderDt);
            payDt = Convert.ToDateTime(orderModel.PayDt);

            //결제여부
            if (orderModel.PayYN == "Y")
            {
                payYN = 1;
            }
            else
            {
                payYN = 2;
            }

            //주문제작 수주 일 때
            if (orderModel.OrderCls == 1)
            {
                var workorderList = await _workOrderManager.GetWorkOrderFromOrder(loginId, orderModel.OrderNo, orderModel.BizUnit, orderModel.FactBizUnit);
                workOrderModel = workorderList.FirstOrDefault();

                var itemList = await _itemManager.GetPDItem(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                itemModel = itemList.FirstOrDefault();

                //var pdItemImgList = await _itemManager.GetPDItemImg(loginId, itemModel);
                //if (pdItemImgList.Count > 0)
                //{
                //    itemImgModel = pdItemImgList.FirstOrDefault();
                //}

                //핸드메이드일 경우
                if (itemModel.MadeType == 1)
                {
                    var handMdItemList = await _itemManager.GetHandMdItem(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                    handMdItemModel = handMdItemList.FirstOrDefault();
                    string[] xx = handMdItemModel.HairDirectionx.Split(",");
                    int[] ints = Array.ConvertAll(xx, s => int.Parse(s));
                    values = ints;
                }
                //머신메이드일 경우
                else
                {
                    //머신메이드 마스터 조회
                    var machineMdItemList = await _itemManager.GetMachineMdItemMaster(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                    machineMdItemMaster = machineMdItemList.FirstOrDefault();

                    if (machineMdItemMaster.ManufactedDt.GetNullToEmpty() != string.Empty)
                    {
                        manufactedDt = Convert.ToDateTime(machineMdItemMaster.ManufactedDt);
                    }

                    //머신메이드 상세 조회
                    machineMdItemModels = await _itemManager.GetMachineMdItemDetail(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                }
            }
            else
            {
                var itemList = await _itemManager.GetPDItem(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                itemModel = itemList.FirstOrDefault();
            }

        }
        //신규일때
        else
        {
            isDisabled = false;
            orderModel.OrderCls = 1;
            itemModel.MadeType = 1;
            orderDt = DateTime.Today;
            payDt = DateTime.Today;
            manufactedDt = DateTime.Today;
            orderModel.OrderDt = DateTime.Today.ToString("yyyy-MM-dd");
            orderModel.PayDt = DateTime.Today.ToString("yyyy-MM-dd");
            workOrderModel.WorkOrderDt = DateTime.Today.ToString("yyyy-MM-dd");
            machineMdItemMaster.ManufactedDt = DateTime.Today.ToString("yyyy-MM-dd");
            orderModel.PayYN = "Y";
            handMdItemModel.HairDirection2 = new int[] { 1 };
        }

        //공통코드세팅
        pdItemCdList = await _itemManager.GetAllPDItem(loginId);
        customerList = await _customerManager.GetCustomerFromCodeHelp(loginId);
        userlist = await _userManager.GetUserFromCodehelp(loginId);
        factBizUnitList = await _bizUnitManager.GetFactoryBizUnit(loginId);
        itemClsList = await _codeManager.FindCommonCodeFromName("품목구분", loginId);
        item1ClsList = await _codeManager.FindCommonCodeFromName("품목대분류", loginId);
        item2ClsList = await _codeManager.FindCommonCodeFromName("품목중분류", loginId);
        item3ClsList = await _codeManager.FindCommonCodeFromName("품목소분류", loginId);
        modelTypeList = await _codeManager.FindCommonCodeFromName("종류", loginId);
        attachTypeList = await _codeManager.FindCommonCodeFromName("부착방식", loginId);
        hairDirectioneList = await _codeManager.FindCommonCodeFromName("모방향", loginId);
        frontKnottingList = await _codeManager.FindCommonCodeFromName("앞라인넛팅", loginId);
        baseNetList = await _codeManager.FindCommonCodeFromName("망", loginId);
        frontList = await _codeManager.FindCommonCodeFromName("앞", loginId);
        nanoSkinThinList = await _codeManager.FindCommonCodeFromName("나노스킨두께", loginId);
        nanoSkinCoatingList = await _codeManager.FindCommonCodeFromName("나노스킨코팅", loginId);
        skinColorList = await _codeManager.FindCommonCodeFromName("스킨색상", loginId);
        partCrownList = await _codeManager.FindCommonCodeFromName("가르마,크라운", loginId);
        workStateList = await _codeManager.FindCommonCodeFromName("작업상태", loginId);
        madeTypeList = await _codeManager.FindCommonCodeFromName("제작형식", loginId);
        hairColorList = await _codeManager.FindCommonCodeFromName("모발색상", loginId);


        //품목구분 제품으로 고정
        itemModel.ItemCls = 1;
    }

    #endregion

    #region // ** 머신메이드 제품 상세 그리드 컨트롤 ** //
    async Task InsertRow()
    {
        //마스터 저장 후
        if (machineMdItemMaster.ItemCd.GetNullToEmpty() != string.Empty)
        {
            //PK 세팅
            machineToInsert = new MachineMdItemModel();
            machineToInsert.ItemCd = machineMdItemMaster.ItemCd;
            machineToInsert.BizUnit = machineMdItemMaster.BizUnit;
            machineToInsert.FactBizUnit = machineMdItemMaster.FactBizUnit;

            await detailGrid.InsertRow(machineToInsert);
        }
        //마스터 저장 전이라면 마스터 먼저 저장
        else
        {
            //필수코드 점검
            if (ValidationCheckOrder(orderModel) == false || ValidationCheckItem(itemModel) == false)
            {
                await jsRuntime.InvokeVoidAsync("alert", "빨간색으로 표시된 필수코드들을 모두 입력하여 주십시오.");
                return;
            }

            //주문저장
            var result = await _orderManager.InsertOrderData(loginId, orderModel);

            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                var orderNo = result.FirstOrDefault().RTN_KEY;
                var itemCd = result.FirstOrDefault().RTN_KEY2;

                //주문 등록 프로시저에서 채번된 품목코드 세팅
                workOrderModel.ItemCd = itemCd;
                itemModel.ItemCd = itemCd;

                //매장코드 공장코드 세팅
                await SetCommonParameter();

                //작업지시저장
                await _workOrderManager.InsertWorkOrderDataFromOrder(loginId, orderNo, workOrderModel);

                //제품과 머신메이드 상세내역 저장
                await _itemManager.InsertMachineMdItemData(loginId, itemModel, machineMdItemMaster);

                //주문조회
                var orderlist = await _orderManager.GetOrderDetailEdit(orderNo, orderModel.FactBizUnit, loginId);
                orderModel = orderlist.FirstOrDefault();

                //제품조회
                var itemList = await _itemManager.GetPDItem(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                itemModel = itemList.FirstOrDefault();

                //머신메이드제품 마스터 조회
                var machineMdItemList = await _itemManager.GetMachineMdItemMaster(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                machineMdItemMaster = machineMdItemList.FirstOrDefault();

                //머신메이드제품 상세내역 조회
                machineMdItemModels = await _itemManager.GetMachineMdItemDetail(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
                machineMdItemDetail = machineMdItemModels.FirstOrDefault();

                //machineToInsert = new MachineMdItemModel();
                //machineToInsert.ItemCd = machineMdItemMaster.ItemCd;
                //machineToInsert.BizUnit = machineMdItemMaster.BizUnit;
                //machineToInsert.FactBizUnit = machineMdItemMaster.FactBizUnit;

                //await detailGrid.InsertRow(machineToInsert);
            }
        }

    }

    async Task EditRow(MachineMdItemModel machineMdItemDetail)
    {
        machineToInsert = machineMdItemDetail;

        await detailGrid.EditRow(machineMdItemDetail);
    }

    async Task SaveRow(MachineMdItemModel machineMdItemDetail)
    {
        if (machineMdItemDetail == machineToInsert)
        {
            machineToInsert = null;
        }

        if (ValidationCheckMachineMdItemDetail(machineMdItemDetail) == true)
        {
            if (machineMdItemDetail.Seq == 0)
            {
                //코드가 채번되기 전이면 INSERT
                await _itemManager.InsertMachineMdItemDetailData(loginId, machineMdItemDetail);
            }
            else
            {
                //파일넘버가 기존에 존재하면 UPDATE
                await _itemManager.UpdateMachineMdItemDetailData(loginId, machineMdItemDetail);
            }
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "호수를 입력하여 주십시오");
        }

        await detailGrid.UpdateRow(machineMdItemDetail);

        machineMdItemModels = await _itemManager.GetMachineMdItemDetail(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
    }

    void CancelEdit(MachineMdItemModel machineMdItemDetail)
    {
        if (machineMdItemDetail == machineToInsert)
        {
            machineToInsert = null;
        }

        detailGrid.CancelEditRow(machineMdItemDetail);
    }

    async Task DeleteRow(MachineMdItemModel machineMdItemDetail)
    {
        if (machineMdItemDetail == machineToInsert)
        {
            machineToInsert = null;
        }

        //저장 후 삭제일 때 DB 에서 DELETE
        if (machineMdItemModels.Contains(machineMdItemDetail))
        {
            machineItemToDelete = machineMdItemDetail;
            DeleteConfirmation.Show("삭제하시겠습니까?");
        }
        //저장 전 삭제일 때 GRID UI에서만 삭제
        else
        {
            detailGrid.CancelEditRow(machineMdItemDetail);
            await detailGrid.Reload();
        }
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            //삭제
            var result = await _itemManager.DeleteMachineMdItemDetail(loginId, machineItemToDelete);

            //그리드 재조회
            machineMdItemModels = await _itemManager.GetMachineMdItemDetail(loginId, orderModel.BizUnit, orderModel.FactBizUnit, orderModel.ItemCd);
            await detailGrid.Reload();
        }
        else
        {
            machineItemToDelete = null;
        }
    }
    #endregion


    #region // * 기본 정보 세팅 * //
    async Task SetCommonParameter()
    {
        //매장코드 세팅
        var userList = await _userManager.GetUser(loginId);
        var storeBizUnit = userList.FirstOrDefault().BizUnit;

        workOrderModel.BizUnit = storeBizUnit;
        itemModel.BizUnit = storeBizUnit;
        handMdItemModel.BizUnit = storeBizUnit;
        machineMdItemMaster.BizUnit = storeBizUnit;

        //공장코드 세팅
        var factBizUnit = orderModel.FactBizUnit;

        workOrderModel.FactBizUnit = factBizUnit;
        itemModel.FactBizUnit = factBizUnit;
        handMdItemModel.FactBizUnit = factBizUnit;
        machineMdItemMaster.FactBizUnit = factBizUnit;

        //주문제작유무 세팅
        itemModel.MadeYN = "Y";
    }
    #endregion

    #region // * 필수값 체크 * //
    bool ValidationCheckOrder(OrderModel order)
    {
        if (order.FactBizUnit.GetNullToEmpty() == string.Empty) return false;
        if (order.OrderDt.GetNullToEmpty() == string.Empty) return false;
        if (order.OrderCls.GetIntNullToZero() == 0) return false;
        if (order.CustomerCd.GetNullToEmpty() == string.Empty) return false;
        if (order.Qty.GetIntNullToZero() == 0) return false;

        return true;
    }

    bool ValidationCheckItem(ItemModel item)
    {
        if (item.ItemNm.GetNullToEmpty() == string.Empty) return false;
        if (item.MadeType.GetIntNullToZero() == 0) return false;
        if (item.Item1Cls.GetIntNullToZero() == 0) return false;
        if (item.Item2Cls.GetIntNullToZero() == 0) return false;
        if (item.Item3Cls.GetIntNullToZero() == 0) return false;

        return true;

    }

    bool ValidationCheckMachineMdItemDetail(MachineMdItemModel machineMdItem)
    {
        if (machineMdItem.Size.GetIntNullToZero() == 0) return false;

        return true;
    }
    #endregion

    #region // * 이벤트 처리기 * //
    void btnCancleClick()
    {
        //ModalInstance.CancelAsync();
        navigationManager.NavigateTo("/OrderManagement");
    }

    async Task btnSaveClick()
    {
        //주문제작일 경우
        if (orderModel.OrderCls == 1)
        {
            //필수코드 점검
            if (ValidationCheckOrder(orderModel) == false || ValidationCheckItem(itemModel) == false)
            {
                await jsRuntime.InvokeVoidAsync("alert", "빨간색으로 표시된 필수코드들을 모두 입력하여 주십시오.");
                return;
            }

            //신규 등록일 경우
            if (orderModel.OrderNo.GetNullToEmpty() == string.Empty)
            {
                var result = await _orderManager.InsertOrderData(loginId, orderModel);

                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
                }
                else
                {
                    var orderNo = result.FirstOrDefault().RTN_KEY;
                    var itemCd = result.FirstOrDefault().RTN_KEY2;

                    //주문 등록 프로시저에서 채번된 품목코드 세팅
                    workOrderModel.ItemCd = itemCd;
                    itemModel.ItemCd = itemCd;

                    //매장코드 공장코드 세팅
                    await SetCommonParameter();

                    await _workOrderManager.InsertWorkOrderDataFromOrder(loginId, orderNo, workOrderModel);

                    //핸드메이드 저장
                    if (itemModel.MadeType == 1)
                    {
                        await _itemManager.InsertHandMdItemData(loginId, itemModel, handMdItemModel);
                    }
                    //머신메이드 저장
                    else
                    {
                        await _itemManager.InsertMachineMdItemData(loginId, itemModel, machineMdItemMaster);
                    }
                }

                navigationManager.NavigateTo("/OrderManagement");
            }
            //수정인 경우
            if(orderModel.OrderNo.GetNullToEmpty() != string.Empty && isDisabled == true)
            {
                var result = await _orderManager.UpdateOrderData(loginId, orderModel);

                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                    navigationManager.NavigateTo("/OrderManagement");
                }
            }
            //페이지 내에서 저장 프로세스 진행한 후 페이지 이동 처리 
            if (orderModel.OrderNo.GetNullToEmpty() != string.Empty && isDisabled == false)
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                navigationManager.NavigateTo("/OrderManagement");
            }
        }
        //재고수주일 경우
        else
        {
            //필수코드 점검
            if (ValidationCheckOrder(orderModel) == false)
            {
                await jsRuntime.InvokeVoidAsync("alert", "빨간색으로 표시된 필수코드들을 모두 입력하여 주십시오.");
                return;
            }

            //신규일때
            if (orderModel.OrderNo.GetNullToEmpty() == string.Empty)
            {
                var result = await _orderManager.InsertOrderData(loginId, orderModel);
                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());

                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                    navigationManager.NavigateTo("/OrderManagement");

                }
            }
            //수정일 때 
            else
            {
                var result = await _orderManager.UpdateOrderData(loginId, orderModel);
                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());

                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                    navigationManager.NavigateTo("/OrderManagement");
                }
            }
        }


    }

    public static Image Base64ToImage(string base64EncodedData)
    {
        string sp = ",";
        var spString = base64EncodedData.Split(sp);

        byte[] imageBytes = Convert.FromBase64String(spString[1]);
        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

        ms.Write(imageBytes, 0, imageBytes.Length);
        Image image = Image.FromStream(ms, true);

        return image;
    }

    void OnError(UploadErrorEventArgs args, string name)
    {

    }

    //void OnChangeItemCd(string itemCd)
    //{
    //    if (itemCd is not null)
    //    {
    //        orderModel.ItemCd = itemCd;
    //        itemModel.ItemCd = itemCd;
    //        workOrderModel.ItemCd = itemCd;
    //        handMdItemModel.ItemCd = itemCd;
    //        machineMdItemMaster.ItemCd = itemCd;
    //    }
    //}

    void OnChangeItemNm(string itemNm)
    {
        if (itemNm is not null)
        {
            orderModel.ItemNm = itemNm;
            itemModel.ItemNm = itemNm;
        }
    }

    void OnChangeQty(int qty)
    {
        workOrderModel.Qty = Convert.ToDecimal(qty);
    }
    void OrderDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            orderModel.OrderDt = ((DateTime)value).ToString("yyyy-MM-dd");
            workOrderModel.WorkOrderDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }
    void ManufactedDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            machineMdItemMaster.ManufactedDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }
    void PayDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            orderModel.PayDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }
    void OnChangeOrderCls(int? value, string name)
    {
        if (value is not null)
        {
            orderModel.OrderCls = value.Value;
        }
    }

    void OnChangePICCd(object value, string name)
    {
        orderModel.PICCd = (int)value;
    }

    void OnChangeWorkState(object value, string name)
    {
        workOrderModel.WorkState = (int)value;
    }

    void OnChangeFactBizUnit(object value, string name)
    {
        if (value is not null)
        {
            orderModel.FactBizUnit = value.ToString();
            workOrderModel.FactBizUnit = value.ToString();
            itemModel.FactBizUnit = value.ToString();
            handMdItemModel.FactBizUnit = value.ToString();
            machineMdItemMaster.FactBizUnit = value.ToString();
            machineMdItemDetail.FactBizUnit = value.ToString();
        }
    }

    void OnChangeMadeType(int? value, string name)
    {
        if (value is not null)
        {
            itemModel.MadeType = value.Value;
        }
    }

    void OnChangeItemCls(object value, string name)
    {
        if (value is not null)
        {
            itemModel.ItemCls = (int)value;
        }
    }

    void OnChangeItem1Cls(object value, string name)
    {
        if (value is not null)
        {
            itemModel.Item1Cls = (int)value;
        }
    }

    void OnChangeItem2Cls(object value, string name)
    {
        if (value is not null)
        {
            itemModel.Item2Cls = (int)value;
        }
    }

    void OnChangeItem3Cls(object value, string name)
    {
        if (value is not null)
        {
            itemModel.Item3Cls = (int)value;
        }
    }

    void OnChangeModelType(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.ModelType = (int)value;
        }
    }

    void OnChangeAttachType(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.AttachType = (int)value;
        }
    }

    void OnChangeAttachType2(IEnumerable<int> value)
    {
        if (value is not null)
        {
            handMdItemModel.AttachTypex = "";
            List<int> HD = value.ToList();
            int cnt = HD.Count();
            int i = 0;
            foreach (int val in HD)
            {
                if (i != cnt - 1)
                {
                    handMdItemModel.AttachTypex = handMdItemModel.AttachTypex + val.ToString() + ",";
                }
                else
                {
                    handMdItemModel.AttachTypex = handMdItemModel.AttachTypex + val.ToString();
                }

                i += 1;
            }
        }
    }

    void OnChangeHairDirection2(IEnumerable<int> value)
    {
        if (value is not null)
        {
            handMdItemModel.HairDirectionx = "";
            List<int> HD = value.ToList();
            int cnt = HD.Count();
            int i = 0;
            foreach (int val in HD)
            {
                if(i != cnt - 1)
                {
                    handMdItemModel.HairDirectionx = handMdItemModel.HairDirectionx + val.ToString() + ",";
                }
                else
                {
                    handMdItemModel.HairDirectionx = handMdItemModel.HairDirectionx + val.ToString();
                }

                i += 1;
            }
        }
    }



    void OnChangeHairDirection(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.HairDirection = (int)value;
        }
    }
    void OnChangeFrontKnotting(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.FrontKnotting = (int)value;
        }
    }
    void OnChangeBaseNet(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.BaseNet = (int)value;
        }
    }
    void OnChangeFront(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.Front = (int)value;
        }
    }
    void OnChangeNanoSkinThin(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.NanoSkinThin = (int)value;
        }
    }
    void OnChangeNanoSkinCoating(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.NanoSkinCoating = (int)value;
        }
    }
    void OnChangeSkinColor(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.SkinColor = (int)value;
        }
    }
    void OnChangePartCrown(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.PartCrown = (int)value;
        }
    }
    void OnChangeWorkOrderContent(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.WorkOrderContent = value.ToString();
        }
    }
    void OnChangeRemk(object value, string name)
    {
        if (value is not null)
        {
            orderModel.Remk = value.ToString();
        }
    }
    void OnChangeEctRequest(object value, string name)
    {
        if (value is not null)
        {
            orderModel.EctRequest = value.ToString();
        }
    }
    void OnChangePayYN(int? value, string name)
    {
        if (value.Value == 1)
        {
            orderModel.PayYN = "Y";
        }
        else
        {
            orderModel.PayYN = "N";
        }
    }

    void OnChangeHairColor(object value, string name)
    {
        if (value is not null)
        {
            handMdItemModel.HairColor = (int)value;
        }
    }
    void OnChangeCustomerCd(object value, string name)
    {
        if (value is not null)
        {
            orderModel.CustomerCd = value.ToString();
        }
    }
    void OnChangePrice(object value)
    {
        if (value is not null)
        {
            itemModel.Price = Convert.ToDecimal(value);
            orderModel.Price = Convert.ToDecimal(value);
        }
    }

    void OnChangePDItemCd(object value)
    {
        if (value is not null)
        {
            orderModel.FactBizUnit = ((ItemModel)value).FactBizUnit;
            orderModel.ItemNm = ((ItemModel)value).ItemNm;
            itemModel.Unit = ((ItemModel)value).Unit;
            itemModel.ItemCls = ((ItemModel)value).ItemCls;
            itemModel.Item1Cls = ((ItemModel)value).Item1Cls;
            itemModel.Item2Cls = ((ItemModel)value).Item2Cls;
            itemModel.Item3Cls = ((ItemModel)value).Item3Cls;
            itemModel.MadeType = ((ItemModel)value).MadeType;
        }
    }

    void OnChangeImageData(object value ,string name)
    {

    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBizUnitData _bizUnitManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _itemManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkOrderData _workOrderManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderData _orderManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerData _customerManager { get; set; }
    }
}
#pragma warning restore 1591
