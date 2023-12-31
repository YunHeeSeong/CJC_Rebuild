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
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ItemOrderEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ItemOrderEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ItemOrderEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ItemOrderEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemOrderEdit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemOrderEdit/{loginId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/itemOrderEdit/{loginId}/{storeBizUnit}/{selectedOrderNo}")]
    public partial class ItemOrderEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 210 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ItemOrderEdit.razor"
       
    [Parameter] public string selectedOrderNo { get; set; }
    [Parameter] public string storeBizUnit { get; set; }
    [Parameter] public string loginId { get; set; }

    private GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    private ItemOrderModel itemOrderToDelete { get; set; }

    private ItemOrderModel masterModel = new ItemOrderModel();
    private ItemOrderModel detailModel = new ItemOrderModel();
    private List<ItemOrderModel> detailModels;

    RadzenDataGrid<ItemOrderModel> detailGrid;

    private ItemOrderModel itemOrderToInsert;

    //공통코드
    List<UserModel> userlist;
    List<CustomerModel> customerList;
    List<ItemModel> ItemCdList;

    int payYN = 1;

    DateTime orderDt;           //주문일자
    DateTime payDt;             //결제일자
    bool isDisabled;

    #region // ** 페이지 로드시 진입점 Init ** //
    protected override async Task OnInitializedAsync()
    {
        //수정일때
        if (selectedOrderNo is not null)
        {
            isDisabled = true;

            var orderlist = await _orderManager.GetOrderMaster(loginId, storeBizUnit, selectedOrderNo);
            masterModel = orderlist.FirstOrDefault();

            detailModels = await _orderManager.GetOrderDetail(loginId, masterModel.BizUnit, masterModel.OrderNo);

            //날짜 컬럼 형변환
            orderDt = Convert.ToDateTime(masterModel.OrderDt);
            payDt = Convert.ToDateTime(masterModel.PayDt);

            //결제여부
            if (masterModel.PayYN == "Y")
            {
                payYN = 1;
            }
            else
            {
                payYN = 2;
            }

        }
        //신규일때
        else
        {
            isDisabled = false;
            masterModel.OrderCls = 2;

            orderDt = DateTime.Today;
            payDt = DateTime.Today;

            masterModel.OrderDt = DateTime.Today.ToString("yyyy-MM-dd");
            masterModel.PayDt = DateTime.Today.ToString("yyyy-MM-dd");

            masterModel.PayYN = "Y";
        }

        //공통코드세팅
        ItemCdList = await _itemManager.GetAllItemCodeHelp(loginId);
        customerList = await _customerManager.GetCustomerFromCodeHelp(loginId);
        userlist = await _userManager.GetUserFromCodehelp(loginId);

    }

    #endregion

    #region // ** 그리드 컨트롤 ** //
    async Task InsertRow()
    {
        //마스터 저장 전
        if (masterModel.OrderNo.GetNullToEmpty() == string.Empty)
        {
            //필수코드 점검
            if (ValidationCheckOrder(masterModel) == false)
            {
                await jsRuntime.InvokeVoidAsync("alert", "빨간색으로 표시된 필수코드들을 모두 입력하여 주십시오.");
                return;
            }

            //주문저장
            var result = await _orderManager.InsertMasterData(loginId, masterModel);

            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                var orderNo = result.FirstOrDefault().RTN_KEY;
                var bizUnit = result.FirstOrDefault().RTN_KEY2;

                //주문조회
                var orderlist = await _orderManager.GetOrderMaster(loginId, bizUnit, orderNo);
                masterModel = orderlist.FirstOrDefault();

                //주문상세조회
                detailModels =  await _orderManager.GetOrderDetail(loginId, masterModel.BizUnit, masterModel.OrderNo);
            }
        }
        else
        {
            itemOrderToInsert = new ItemOrderModel();
            itemOrderToInsert.BizUnit = masterModel.BizUnit;
            itemOrderToInsert.OrderNo = masterModel.OrderNo;

            await detailGrid.InsertRow(itemOrderToInsert);
        }

    }

    async Task EditRow(ItemOrderModel detailModel)
    {
        itemOrderToInsert = detailModel;

        await detailGrid.EditRow(detailModel);
    }

    async Task SaveRow(ItemOrderModel detailModel)
    {
        if (detailModel == itemOrderToInsert)
        {
            itemOrderToInsert = null;
        }

        if (ValidationCheckDetail(detailModel) == true)
        {
            if (detailModel.OrderSeq == 0)
            {
                //코드가 채번되기 전이면 INSERT
                var res = await _orderManager.InsertDetailData(loginId, detailModel);

                if (res.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", res.GetErrorMessages());
                }
            }
            else
            {
                //파일넘버가 기존에 존재하면 UPDATE
                var res = await _orderManager.UpdateOrderDetail(loginId, detailModel);
                if (res.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", res.GetErrorMessages());
                    return;
                }
            }

            await detailGrid.UpdateRow(detailModel);
            detailModels = await _orderManager.GetOrderDetail(loginId, masterModel.BizUnit, masterModel.OrderNo);

            //총금액, 총부가세 재계산
            CalculatePriceVAT(detailModels);
            var result = await _orderManager.UpdateOrderMaster(loginId, masterModel);

            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                var itemOrderModels = await _orderManager.GetOrderMaster(loginId, detailModel.BizUnit, detailModel.OrderNo);
                masterModel = itemOrderModels.FirstOrDefault();
            }

        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "코드명을 입력하여 주십시오");
        }


    }

    void CancelEdit(ItemOrderModel detailModel)
    {
        if (detailModel == itemOrderToInsert)
        {
            itemOrderToInsert = null;
        }

        detailGrid.CancelEditRow(detailModel);
    }

    async Task DeleteRow(ItemOrderModel detailModel)
    {
        if (detailModel == itemOrderToInsert)
        {
            itemOrderToInsert = null;
        }

        //저장 후 삭제일 때 DB 에서 DELETE
        if (detailModels.Contains(detailModel))
        {
            itemOrderToDelete = detailModel;
            DeleteConfirmation.Show("삭제하시겠습니까?");
        }
        //저장 전 삭제일 때 GRID UI에서만 삭제
        else
        {
            detailGrid.CancelEditRow(detailModel);
            await detailGrid.Reload();
        }
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            //삭제
            var result = await _orderManager.DeleteDetailData(itemOrderToDelete, loginId);

            //그리드 재조회
            detailModels = await _orderManager.GetOrderDetail(loginId, masterModel.BizUnit, masterModel.OrderNo);
            await detailGrid.Reload();
        }
        else
        {
            itemOrderToDelete = null;
        }
    }
    #endregion




    #region // * 필수값 체크 * //
    bool ValidationCheckOrder(ItemOrderModel order)
    {
        if (order.OrderDt.GetNullToEmpty() == string.Empty) return false;
        //if (order.OrderCls.GetIntNullToZero() == 0) return false;
        if (order.CustomerCd.GetNullToEmpty() == string.Empty) return false;

        return true;
    }


    bool ValidationCheckDetail(ItemOrderModel order)
    {
        if (order.Qty.GetIntNullToZero() == 0) return false;
        if (order.ItemCd.GetNullToEmpty() == string.Empty) return false;

        return true;
    }
    #endregion

    #region // * 이벤트 처리기 * //
    void btnCancleClick()
    {
        //ModalInstance.CancelAsync();
        navigationManager.NavigateTo("/ItemOrderManagement");
    }

    async Task btnSaveClick()
    {
        //필수코드 점검
        if (ValidationCheckOrder(masterModel) == false)
        {
            await jsRuntime.InvokeVoidAsync("alert", "빨간색으로 표시된 필수코드들을 모두 입력하여 주십시오.");
            return;
        }

        //신규 등록일 경우
        if (masterModel.OrderNo.GetNullToEmpty() == string.Empty)
        {
            var result = await _orderManager.InsertMasterData(loginId, masterModel);

            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다");
                navigationManager.NavigateTo("/ItemOrderManagement");
            }
        }
        //수정인 경우
        else
        {
            //총금액 , 총부가세 재계산
            CalculatePriceVAT(detailModels);
            var result = await _orderManager.UpdateOrderMaster(loginId, masterModel);

            //출하가 진행되어 수정이 불가능할 경우
            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                navigationManager.NavigateTo("/ItemOrderManagement");
            }
        }

    }

    void CalculatePriceVAT(List<ItemOrderModel> itemOrders)
    {
        decimal totPrice = 0;
        decimal totVAT = 0;

        if (itemOrders.Count > 0)
        {
            foreach (var item in itemOrders)
            {
                totPrice += item.Price;
                totVAT += item.Vat;
            }

            masterModel.TotPrice= totPrice;
            masterModel.TotVAT = totVAT;
        }
    }


    void OnChangeItemCd(object value)
    {
        if (value is not null && itemOrderToInsert is not null)
        {
            //itemOrderToInsert.ItemCd = ((ItemModel)value).ItemCd;
            itemOrderToInsert.ItemNm = ((ItemModel)value).ItemNm;
        }
    }
    void OnChangeQty(decimal value)
    {

        decimal qty = Convert.ToDecimal(value);

        itemOrderToInsert.Price = itemOrderToInsert.UPR * qty;
        itemOrderToInsert.Vat = itemOrderToInsert.Price * Convert.ToDecimal(0.1);

    }
    void OrderDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            masterModel.OrderDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }

    void PayDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            masterModel.PayDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }
    void OnChangeOrderCls(int? value, string name)
    {
        if (value is not null)
        {
            masterModel.OrderCls = value.Value;
        }
    }

    void OnChangePICCd(object value, string name)
    {
        masterModel.PICCd = (int)value;
    }
    void OnChangePayYN(int? value, string name)
    {
        if (value.Value == 1)
        {
            masterModel.PayYN = "Y";
        }
        else
        {
            masterModel.PayYN = "N";
        }
    }

    void OnChangeCustomerCd(object value, string name)
    {
        if (value is not null)
        {
            masterModel.CustomerCd = value.ToString();
        }
    }
    void OnChangeUPR(decimal value)
    {

        decimal upr = Convert.ToDecimal(value);

        itemOrderToInsert.Price = itemOrderToInsert.Qty * upr;
        itemOrderToInsert.Vat = itemOrderToInsert.Price * Convert.ToDecimal(0.1);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemOrderData _orderManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerData _customerManager { get; set; }
    }
}
#pragma warning restore 1591
