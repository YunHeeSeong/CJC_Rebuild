#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb37a637396f3e0ba16dbc62c1a3a31955151924"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages.Item
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_CJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_CJC.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\_Imports.razor"
using System.Resources.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
using GMINWEB_CJC.Pages.Dialog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadPDItem")]
    public partial class ReadPDItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pagelocation");
            __builder.AddAttribute(2, "id", "menugnb");
            __builder.AddMarkupContent(3, "<i class=\"fa fa-home\"></i>\r\n    ");
            __builder.AddMarkupContent(4, "<a href=\"/\">HOME</a>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(5);
            __builder.AddAttribute(6, "Text", " > 품목관리 > ");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<strong>제품조회</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 27 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "<div class=\"info_title\"><h1 class=\"sub_title\">제품 조회</h1></div>\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
                __builder2.AddAttribute(17, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                        TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(19);
                    __builder3.AddAttribute(20, "Text", "제품리스트");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<ItemModel>>(22);
                        __builder4.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ItemModel>>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                                                                      ItemModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ColumnWidth", "300px");
                        __builder4.AddAttribute(31, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 44 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 45 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(34);
                            __builder5.AddAttribute(35, "Property", "BizUnitNm");
                            __builder5.AddAttribute(36, "Title", "매장명");
                            __builder5.AddAttribute(37, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(39);
                            __builder5.AddAttribute(40, "Property", "FactBizUnitNm");
                            __builder5.AddAttribute(41, "Title", "공장명");
                            __builder5.AddAttribute(42, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(43, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(44);
                            __builder5.AddAttribute(45, "Property", "ItemCd");
                            __builder5.AddAttribute(46, "Title", "품목코드");
                            __builder5.AddAttribute(47, "Width", "150px");
                            __builder5.AddAttribute(48, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(50);
                            __builder5.AddAttribute(51, "Property", "ItemNm");
                            __builder5.AddAttribute(52, "Title", "품목명");
                            __builder5.AddAttribute(53, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(54, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(55);
                            __builder5.AddAttribute(56, "Property", "MadeTypeNm");
                            __builder5.AddAttribute(57, "Title", "제작방식");
                            __builder5.AddAttribute(58, "Width", "120px");
                            __builder5.AddAttribute(59, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(61);
                            __builder5.AddAttribute(62, "Property", "Item1ClsNm");
                            __builder5.AddAttribute(63, "Title", "대분류");
                            __builder5.AddAttribute(64, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(66);
                            __builder5.AddAttribute(67, "Property", "Item2ClsNm");
                            __builder5.AddAttribute(68, "Title", "중분류");
                            __builder5.AddAttribute(69, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(71);
                            __builder5.AddAttribute(72, "Property", "Item3ClsNm");
                            __builder5.AddAttribute(73, "Title", "소분류");
                            __builder5.AddAttribute(74, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(76);
                            __builder5.AddAttribute(77, "Property", "Unit");
                            __builder5.AddAttribute(78, "Title", "단위");
                            __builder5.AddAttribute(79, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(80, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(81);
                            __builder5.AddAttribute(82, "Property", "Price");
                            __builder5.AddAttribute(83, "Title", "금액");
                            __builder5.AddAttribute(84, "Width", "120px");
                            __builder5.AddAttribute(85, "FormatString", "{0:n0}");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(86, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<ItemModel>>(87);
                            __builder5.AddAttribute(88, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                        false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(89, "Title", "이미지 조회");
                            __builder5.AddAttribute(90, "Width", "170px");
                            __builder5.AddAttribute(91, "CssClass", "data_center");
                            __builder5.AddAttribute(92, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ItemModel>)((pdItem) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(93);
                                __builder6.AddAttribute(94, "Style", "margin: 0 0.5rem 0 0; color: darkorange; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(95, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                                                                                                                                                              ()=>btnImageUpload(pdItem)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(97, "이미지 조회");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n\r\n            ");
                __builder2.OpenComponent<GMINWEB_CJC.Pages.Common.Confirm>(99);
                __builder2.AddAttribute(100, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                   ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(101, (__value) => {
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
                                                                                              DeleteConfirmation = (GMINWEB_CJC.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 80 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(102, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 84 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(103, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(104, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Item\ReadPDItem.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public ItemModel selectedPDItem { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 37;

    ClaimsPrincipal CurrentUser;
    private List<ItemModel> ItemModels;
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
                    ItemModels = await _db.GetAllPDItem(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        ItemModels = await _db.GetAllPDItem(CurrentUser.Identity.Name);
    }

    void btnNewClick()
    {
        navigationManager.NavigateTo("/pdItemEdit" + "/" + CurrentUser.Identity.Name);
    }

    async Task btnImageUpload(ItemModel pditem)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(ReadPDItemImgEdit.selectedPDItem), pditem);
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var groupEdit = Modal.Show<ReadPDItemImgEdit>("제품 이미지 조회", parameters);
        var result = await groupEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }


    void btnUpdateClick(ItemModel ItemModel)
    {
        navigationManager.NavigateTo("/pdItemEdit" + "/" + CurrentUser.Identity.Name + "/" + ItemModel.ItemCd + "/" + ItemModel.BizUnit + "/" + ItemModel.FactBizUnit);
    }

    void btnDeleteClick(ItemModel ItemModel)
    {
        DeleteConfirmation.Show("정말 삭제하시겠습니까 ?");

        selectedPDItem = ItemModel;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var res = await _db.DeletePDItem(selectedPDItem, CurrentUser.Identity.Name);
            if (res.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", res.GetErrorMessages());
            }
            else
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");

            }

            await GetAllDatas();
        }
        else
        {
            selectedPDItem = null;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _db { get; set; }
    }
}
#pragma warning restore 1591