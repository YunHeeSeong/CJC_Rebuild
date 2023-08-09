// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Purchase
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
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Purchase\ReadStoreOutItem.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Purchase\ReadStoreOutItem.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Purchase\ReadStoreOutItem.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Purchase\ReadStoreOutItem.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadStoreOutItem")]
    public partial class ReadStoreOutItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 205 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Purchase\ReadStoreOutItem.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 23;     //출하등록(매장)

    ClaimsPrincipal CurrentUser;
    private List<OutItemModel> outItemModels;
    private List<OutItemModel> selectedOutItemModels;
    private List<OutPDItemModel> outPDItemModels;
    private List<OutPDItemModel> selectedOutPDItemModels;
    private List<UserModel> OutUserIdList;

    private OutItemModel detailModel = new OutItemModel();
    private OutItemModel outItemModelToDelete;
    private OutItemModel outItemModelToInsert;
    private OutPDItemModel outPDItemModel = new OutPDItemModel();
    private OutPDItemModel outPDItemModelToDelete;

    private string RoleYN;
    private string selectedBizUnit;
    private string selectedFactBizUnit;
    private string loginId;
    private string searchOutDate = string.Empty;
    private DateTime OutDate;
    private DateTime SearchOutDate;
    private bool isDisable;

    RadzenDataGrid<OutItemModel> detailGrid;


    protected override async Task OnInitializedAsync()
    {
        //로그인을 한 사용자인지
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            //사용자 정보가 있는지
            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                loginId = CurrentUser.Identity.Name;

                //조회권한이 있는지
                if (RoleYN == "Y")
                {
                    //품목 출하 내역 조회
                    outItemModels = await _outItemManager.GetItemOrder(loginId);

                    //제품 출하 내역 조회
                    outPDItemModels = await _outPDItemManager.GetAllOrdersFromStore(loginId);
                }

                OutUserIdList = await _userManager.GetUserFromCodehelp(loginId);

            }
        }
    }


    //상세조회 버튼 이벤트
    void btnShowEdit(OutItemModel outPDItem)
    {
        navigationManager.NavigateTo("/outItemEdit" + "/" + CurrentUser.Identity.Name + "/" + selectedBizUnit + "/" + outPDItem.OutItemNo);
    }

    //상단 그리드 로우 선택시 하단 출하내역 조회하는 이벤트
    public async Task ItemRowSelect(OutItemModel outPDItem)
    {
        selectedOutItemModels = await _outItemManager.GetOutItemDetail(loginId, outPDItem);
    }


    //상단 그리드에서 주문 선택시 하단 출하내역 조회하는 이벤트
    public async Task PDItemRowSelect(OutPDItemModel outPDItem)
    {
        outPDItemModel = outPDItem;

        selectedBizUnit = outPDItemModel.BizUnit;
        selectedFactBizUnit = outPDItemModel.FactBizUnit;

        selectedOutPDItemModels = await _outPDItemManager.GetOutPDItemDetail(loginId, outPDItemModel);
    }


    //출하등록 버튼 이벤트
    async Task btnUpdateClick(OutPDItemModel outPDItem)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(FactOutItemEdit.selectedOutPDItem), outPDItem);
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var outPDItemEdit = Modal.Show<FactOutItemEdit>("출하등록", parameters);
        var result = await outPDItemEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    //제품 레포트 출력 버튼 이벤트
    async Task btnShowReportClick(OutPDItemModel outPDItem)
    {
        //로그인한 유저 정보 가져오기
        var userList = await _userManager.GetUserCodeHelp(CurrentUser.Identity.Name);
        var bizType = userList.FirstOrDefault().BizType;

        //공장일때 
        if (bizType == 2)
        {
            await jsRuntime.InvokeVoidAsync("alert", "거래명세서 조회 권한이 없는 사용자입니다.");
            return;
        }
        //협회 또는 매장일 때 
        else
        {
            string url = string.Format("Transaction?BizUnit={0}&FactBizUnit={1}&OrderNo={2}&OutSeq={3}", outPDItem.BizUnit, outPDItem.FactBizUnit, outPDItem.OrderNo, outPDItem.OutSeq);

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
    }


    //품목 레포트 출력 버튼 이벤트
    async Task btnShowItemReportClick(OutItemModel outItem)
    {
        if (searchOutDate == string.Empty)
        {
            await jsRuntime.InvokeVoidAsync("alert", "거래명세서를 출력할 일자를 선택하여 주십시오.");
            return;
        }

        //로그인한 유저 정보 가져오기
        var userList = await _userManager.GetUserCodeHelp(CurrentUser.Identity.Name);
        var bizType = userList.FirstOrDefault().BizType;

        //공장일때 
        if (bizType == 2)
        {
            await jsRuntime.InvokeVoidAsync("alert", "거래명세서 조회 권한이 없는 사용자입니다.");
            return;
        }
        //협회 또는 매장일 때 
        else
        {
            //선택한 출하일자에 해당하는 출고 내역이 있는지 확인
            var res = await _outItemManager.ShowReport(outItem, searchOutDate);
            if (res.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", res.GetErrorMessages());
            }
            else
            {
                string url = string.Format("Transaction_Item?BizUnit={0}&OrderNo={1}&OutDate={2}", outItem.BizUnit, outItem.OrderNo, searchOutDate);

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
        }
    }

    //출하내역 삭제 버튼 이벤트
    void btnDeleteItemClick(OutItemModel outPDItem)
    {
        DeleteConfirmation.Show("정말 출하 내역을 삭제하시겠습니까 ?");

        outItemModelToDelete = outPDItem;
    }

    //출하내역 삭제 버튼 이벤트
    void btnDeletePDItemClick(OutPDItemModel outPDItem)
    {
        DeleteConfirmation.Show("정말 출하 내역을 삭제하시겠습니까 ?");

        outPDItemModelToDelete = outPDItem;

        outPDItemModelToDelete.BizUnit = selectedBizUnit;
        outPDItemModelToDelete.FactBizUnit = selectedFactBizUnit;
    }

    async Task EditRow(OutItemModel detailModel)
    {
        if (detailModel.OutSeq.GetIntNullToZero() != 0)
        {
            await jsRuntime.InvokeVoidAsync("alert", "이미 출고가 완료된 주문입니다.");
        }
        else
        {
            outItemModelToInsert = detailModel;
            OutDate = DateTime.Today;
            //outItemModelToInsert.OutDate = DateTime.Today.ToString("yyyy-MM-dd");
            await detailGrid.EditRow(detailModel);
        }
    }

    async Task SaveRow(OutItemModel detailModel)
    {
        if (detailModel == outItemModelToInsert)
        {
            outItemModelToInsert = null;
        }

        //필수코드 체크
        var errMessage = ValidationCheckDetail(detailModel);

        if (errMessage == string.Empty)
        {
            //순번이 채번되기 전이면 INSERT
            if (detailModel.OutSeq == 0)
            {
                var res = await _outItemManager.InsertData(loginId, detailModel);

                if (res.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", res.GetErrorMessages());
                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                }
            }

            //재조회
            await detailGrid.UpdateRow(detailModel);
            selectedOutItemModels = await _outItemManager.GetOutItemDetail(loginId, detailModel);

        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", errMessage);
        }


    }

    string ValidationCheckDetail(OutItemModel detailModel)
    {
        if (detailModel.OutQty.GetDecimalNullToZero() == 0)
        {
            return "출하 수량을 입력하여 주세요.";
        }
        return string.Empty;
    }

    void CancelEdit(OutItemModel detailModel)
    {
        if (detailModel == outItemModelToInsert)
        {
            outItemModelToInsert = null;
        }

        detailGrid.CancelEditRow(detailModel);
    }

    async Task DeleteRow(OutItemModel detailModel)
    {
        if (detailModel == outItemModelToInsert)
        {
            outItemModelToInsert = null;
        }

        //저장 후 삭제일 때 DB 에서 DELETE
        if (selectedOutItemModels.Contains(detailModel))
        {
            outItemModelToDelete = detailModel;
            DeleteConfirmation.Show("삭제하시겠습니까?");
        }
        //저장 전 삭제일 때 GRID UI에서만 삭제
        else
        {
            detailGrid.CancelEditRow(detailModel);
            await detailGrid.Reload();
        }
    }

    //삭제 확인 팝업
    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            //품목출하 삭제
            if (outItemModelToDelete is not null)
            {
                var result = await _outItemManager.DeleteData(loginId, outItemModelToDelete);
                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                }

            }
            //제품출하 삭제
            else
            {
                var result = await _outPDItemManager.DeleteData(outPDItemModelToDelete, loginId);

                if (result.IsError())
                {
                    await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
                }
                else
                {
                    await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                }
            }

            await GetAllDatas();
        }
        else
        {
            outItemModelToDelete = null;
            outPDItemModelToDelete = null;
        }
    }

    //검색조건 이벤트
    void OutDateChanged(object value)
    {
        if (value is not null)
        {
            outItemModelToInsert.OutDate = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }

    void SearchOutDateChanged(object value)
    {
        if (value is not null)
        {
            searchOutDate = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }

    void OnChangeOutUserId(object value)
    {
        if (value is not null)
        {
            detailModel.OutUserId = (int)value;
        }
    }


    //재조회
    private async Task GetAllDatas()
    {
        //outItemModels = await _db.GetOutItemMaster(CurrentUser.Identity.Name);
        outPDItemModels = await _outPDItemManager.GetAllOrdersFromStore(loginId);
        selectedOutPDItemModels = null;
        selectedOutItemModels = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOutItemData _outItemManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOutPDItemData _outPDItemManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBizUnitData _bizUnitManager { get; set; }
    }
}
#pragma warning restore 1591
