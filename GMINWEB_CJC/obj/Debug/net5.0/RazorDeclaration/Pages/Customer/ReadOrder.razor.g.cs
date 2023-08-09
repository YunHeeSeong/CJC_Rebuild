// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Customer
{
    #line hidden
    using System;
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
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
using GMINWEB_Rebuild.Pages.Dialog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadOrder")]
    public partial class ReadOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Customer\ReadOrder.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public OrderModel selectedOrder { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 46;

    ClaimsPrincipal CurrentUser;

    private List<OrderModel> orders;      //일반수주
    private List<OrderModel> selectedOrders;       //재고수주
    private string RoleYN;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                if (RoleYN == "Y")
                {
                    orders = await _db.GetAllOrders(CurrentUser.Identity.Name);
                }
            }

        }
    }

    private async Task GetAllDatas()
    {
        orders = await _db.GetAllOrders(CurrentUser.Identity.Name);
    }

    void btnNewClick()
    {
        navigationManager.NavigateTo("/orderEdit" + "/" + CurrentUser.Identity.Name);
    }

    async Task btnImageUpload(OrderModel order)
    {
        ItemModel itemModel = new ItemModel();
        itemModel.BizUnit = order.BizUnit;
        itemModel.FactBizUnit = order.FactBizUnit;
        itemModel.BizUnitNm = order.BizUnitNm;
        itemModel.FactBizUnitNm = order.FactBizUnitNm;
        itemModel.ItemCd = order.ItemCd;
        itemModel.ItemNm = order.ItemNm;

        var parameters = new ModalParameters();
        parameters.Add(nameof(ReadPDItemImgEdit.selectedPDItem), itemModel);
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var groupEdit = Modal.Show<ReadPDItemImgEdit>("제품 이미지 조회", parameters);
        var result = await groupEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    void btnUpdateClick(OrderModel order)
    {
        navigationManager.NavigateTo("/orderEdit" + "/" + CurrentUser.Identity.Name + "/" + order.BizUnit + "/" + order.FactBizUnit + "/" + order.OrderNo);
    }

    void btnDeleteClick(OrderModel order)
    {
        DeleteConfirmation.Show("정말 삭제하시겠습니까 ?");

        selectedOrder = order;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var result = await _db.DeleteData(selectedOrder, CurrentUser.Identity.Name);

            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
            else
            {
                await GetAllDatas();
            }
        }
        else
        {
            selectedOrder = null;
        }
    }

    public async Task RowSelect(OrderModel order)
    {
        selectedOrders = await _db.GetOrderDetailEdit(order.OrderNo, order.FactBizUnit, CurrentUser.Identity.Name);
    }

    //레포트 출력 버튼 이벤트
    async Task btnShowReportClick(OrderModel order)
    {
        string url = string.Format("Contract?BizUnit={0}&FactBizUnit={1}&OrderNo={2}", order.BizUnit, order.FactBizUnit, order.OrderNo);

        var parameter = new ModalParameters();

        DocumentViewer dv = new DocumentViewer();

        parameter.Add(nameof(dv.ReportUrl), url);

        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeIn(1)
,
            Position = ModalPosition.Center
        };

        var documentviewer = Modal.Show<DocumentViewer>("View Report", parameter, options);
        var result = await documentviewer.Result;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderData _db { get; set; }
    }
}
#pragma warning restore 1591
