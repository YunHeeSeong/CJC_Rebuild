// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Production
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
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkOrderEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkOrderEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkOrderEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkOrderEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/workOrderEdit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/workOrderEdit/{loginId}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/workOrderEdit/{loginId}/{selectedWorkOrderNo}/{storeBizUnit}/{factBizUnit}")]
    public partial class WorkOrderEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 805 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkOrderEdit.razor"
       

    [Parameter] public string selectedWorkOrderNo { get; set; }
    [Parameter] public string storeBizUnit { get; set; }
    [Parameter] public string factBizUnit { get; set; }

    [Parameter] public string loginId { get; set; }

    //기타아이템모델추가
    private EtcItemModel etcItemModel = new EtcItemModel();

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    private PDItemImgModel itemImgModel = new PDItemImgModel();
    private WorkOrderModel workOrderModel = new WorkOrderModel();
    private HandMdItemModel handMdItemModel = new HandMdItemModel();
    private MachineMdItemModel machineMdItemMaster = new MachineMdItemModel();
    private MachineMdItemModel machineMdItemDetail = new MachineMdItemModel();
    private ItemModel itemModel = new ItemModel();

    private List<MachineMdItemModel> machineMdItemModels;

    RadzenDataGrid<MachineMdItemModel> detailGrid;

    List<CommonCodeModel> workStateList;
    //List<ItemModel> ItemCdList;

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

    DateTime WorkOrderDt;
    DateTime ShipDt;
    DateTime ProdDueDt;
    DateTime manufactedDt;      //머신메이드-제조일자

    bool isDisable;

    private OrderModel selectedOrderModel = new OrderModel();

    protected override async Task OnInitializedAsync()
    {
        if (selectedWorkOrderNo is not null)
        {
            var workOrderList = await _db.GetWorkOrder(loginId, selectedWorkOrderNo,storeBizUnit, factBizUnit);
            workOrderModel = workOrderList.FirstOrDefault();

            //신규등록이 아닐경우 특정 컬럼 수정 불가
            isDisable = true;

            var itemList = await _itemManager.GetPDItem(loginId, workOrderModel.BizUnit, workOrderModel.FactBizUnit, workOrderModel.ItemCd);
            itemModel = itemList.FirstOrDefault();

            //var pdItemImgList = await _itemManager.GetPDItemImg(loginId, itemModel);
            //if (pdItemImgList.Count > 0)
            //{
            //    itemImgModel = pdItemImgList.FirstOrDefault();
            //}

            //핸드메이드일 경우
            if (itemModel.MadeType == 1)
            {
                var handMdItemList = await _itemManager.GetHandMdItem(loginId, workOrderModel.BizUnit, workOrderModel.FactBizUnit, workOrderModel.ItemCd);
                handMdItemModel = handMdItemList.FirstOrDefault();
            }
            //머신메이드일 경우
            else if (itemModel.MadeType == 2)
            {
                //머신메이드 마스터 조회
                var machineMdItemList = await _itemManager.GetMachineMdItemMaster(loginId, workOrderModel.BizUnit, workOrderModel.FactBizUnit, workOrderModel.ItemCd);
                machineMdItemMaster = machineMdItemList.FirstOrDefault();

                if (machineMdItemMaster.ManufactedDt.GetNullToEmpty() != string.Empty)
                {
                    manufactedDt = Convert.ToDateTime(machineMdItemMaster.ManufactedDt);
                }

                //머신메이드 상세 조회
                machineMdItemModels = await _itemManager.GetMachineMdItemDetail(loginId, workOrderModel.BizUnit, workOrderModel.FactBizUnit, workOrderModel.ItemCd);
            }
            //기타일 경우
            else if (itemModel.MadeType == 3)
            {
                var etcItemList = await _itemManager.GetEtcItem(loginId, workOrderModel.BizUnit, workOrderModel.FactBizUnit, workOrderModel.ItemCd);
                etcItemModel = etcItemList.FirstOrDefault();
            }
        }
        else
        {
            //신규등록일 경우 모든 컬럼 활성화
            isDisable = false;
        }
        //날짜컬럼들 형변환 처리
        SetDateTimeConvert(workOrderModel);

        //ItemCdList = await _itemManager.GetAllItem(loginId);
        customerList = await _customerManager.GetAllCustomers(loginId);
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
        madeTypeList = await _codeManager.FindCommonCodeFromName("제작형태", loginId);
        hairColorList = await _codeManager.FindCommonCodeFromName("모발색상", loginId);

    }

    void btnCancleClick()
    {
        navigationManager.NavigateTo("/WorkOrderManagement");
    }

    async Task btnSaveClick()
    {
        //필수값 체크
        if (ValidationWorkOrder(workOrderModel) == true)
        {
            //신규일때
            if (workOrderModel.WorkOrderNo.GetNullToEmpty() == string.Empty)
            {
                //await _db.(workOrderModel, loginId);
            }
            else
            {
                await _db.UpdateWorkOrder(loginId, workOrderModel);
            }

            navigationManager.NavigateTo("/WorkOrderManagement");

        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "지시일자와 품목코드, 수량을 입력하여 주세요.");
        }

    }


    bool ValidationWorkOrder(WorkOrderModel workOrderModel)
    {
        ////필수값 미입력시 false 반환
        if (workOrderModel.WorkOrderDt.GetNullToEmpty() == string.Empty || workOrderModel.ItemCd.GetNullToEmpty() == string.Empty || workOrderModel.Qty.GetDecimalNullToZero() == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void WorkOrderDtChanged(object value)
    {
        if (value is not null)
        {
            workOrderModel.WorkOrderDt = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }
    void ManufactedDtChanged(DateTime? value)
    {
        if (value is not null)
        {
            machineMdItemMaster.ManufactedDt = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }
    void ShipDtChanged(object value)
    {
        if (value is not null)
        {
            workOrderModel.ShipDt = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }
    void ProdDueDtChanged(object value)
    {
        if (value is not null)
        {
            workOrderModel.ProdDueDt = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }
    void OnChangeWorkState(object value, string name)
    {
        workOrderModel.WorkState = (int)value;
    }

    void SetDateTimeConvert(WorkOrderModel workOrderModel)
    {
        if (workOrderModel.WorkOrderDt.GetNullToEmpty() == string.Empty)
        {
            WorkOrderDt = DateTime.Today;
            workOrderModel.WorkOrderDt = Convert.ToDateTime(WorkOrderDt).ToString("yyyy-MM-dd");
        }
        else
        {
            WorkOrderDt = Convert.ToDateTime(workOrderModel.WorkOrderDt);
        }

        if (workOrderModel.ShipDt.GetNullToEmpty() == string.Empty)
        {
            ShipDt = DateTime.Today;
            workOrderModel.ShipDt = Convert.ToDateTime(ShipDt).ToString("yyyy-MM-dd");
        }
        else
        {
            ShipDt = Convert.ToDateTime(workOrderModel.ShipDt);
        }

        if (workOrderModel.ProdDueDt.GetNullToEmpty() == string.Empty)
        {
            ProdDueDt = DateTime.Today;
            workOrderModel.ProdDueDt = Convert.ToDateTime(ProdDueDt).ToString("yyyy-MM-dd");
        }
        else
        {
            ProdDueDt = Convert.ToDateTime(workOrderModel.ProdDueDt);
        }
    }

    public async Task GetWorkPlan()
    {
        //var parameters = new ModalParameters();
        //parameters.Add(nameof(DialogPOrderList.POInCustCd), masterModel.POInCustCd);
        //parameters.Add("loginId", loginId);

        //var groupEdit = Modal.Show<DialogPOrderList>("발주서 선택", parameters);
        //var result = await groupEdit.Result;

        //if (!result.Cancelled)
        //{
        //    if (DialogPOrderList.selectedPOrder is not null)
        //    {
        //        var selectedPOrder = DialogPOrderList.selectedPOrder;
        //        pOInItemToInsert.POrderNo = selectedPOrder.POrderNo;
        //        pOInItemToInsert.POSeq = selectedPOrder.Seq;
        //        pOInItemToInsert.ItemCd = selectedPOrder.ItemCd;
        //        pOInItemToInsert.ItemNm = selectedPOrder.ItemNm;
        //        pOInItemToInsert.Price = selectedPOrder.Prsice;
        //        pOInItemToInsert.Unit = selectedPOrder.UnitCd;
        //        pOInItemToInsert.Weight = selectedPOrder.Weight;
        //    }

        //}
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _itemManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkOrderData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBizUnitData _bizUnitManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkOrderData _workOrderManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerData _customerManager { get; set; }
    }
}
#pragma warning restore 1591
