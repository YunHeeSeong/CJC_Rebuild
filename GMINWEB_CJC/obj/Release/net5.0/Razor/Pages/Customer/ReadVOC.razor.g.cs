#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d2054f8394b10b20f6a54ca7a8632d96f9aa210"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Customer
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.Resources.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadVOC")]
    public partial class ReadVOC : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(6, "Text", " > 영업관리 > ");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<strong>VOC조회</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "<div class=\"info_title\"><h1 class=\"sub_title\">VOC 조회</h1></div>\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
                __builder2.AddAttribute(17, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                        TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(19);
                    __builder3.AddAttribute(20, "Text", "VOC 리스트");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<VOCModel>>(22);
                        __builder4.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<VOCModel>>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                                                                      vocModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ColumnWidth", "300px");
                        __builder4.AddAttribute(31, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 44 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(34);
                            __builder5.AddAttribute(35, "Property", "VocNo");
                            __builder5.AddAttribute(36, "Title", "VOC번호");
                            __builder5.AddAttribute(37, "Width", "130px");
                            __builder5.AddAttribute(38, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(39, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(40);
                            __builder5.AddAttribute(41, "Property", "VocDt");
                            __builder5.AddAttribute(42, "Title", "VOC일자");
                            __builder5.AddAttribute(43, "Width", "130px");
                            __builder5.AddAttribute(44, "CssClass", "data_center");
                            __builder5.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VOCModel>)((data) => (__builder6) => {
                                __builder6.AddContent(46, 
#nullable restore
#line 49 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                             data.VocDt.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(48);
                            __builder5.AddAttribute(49, "Property", "VocClsNm");
                            __builder5.AddAttribute(50, "Title", "VOC구분");
                            __builder5.AddAttribute(51, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(52, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(53);
                            __builder5.AddAttribute(54, "Property", "VocDetailClsNm");
                            __builder5.AddAttribute(55, "Title", "VOC상세구분");
                            __builder5.AddAttribute(56, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(57, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(58);
                            __builder5.AddAttribute(59, "Property", "CustomerNm");
                            __builder5.AddAttribute(60, "Title", "고객명");
                            __builder5.AddAttribute(61, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(62, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(63);
                            __builder5.AddAttribute(64, "Property", "Title");
                            __builder5.AddAttribute(65, "Title", "제목");
                            __builder5.AddAttribute(66, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(67, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(68);
                            __builder5.AddAttribute(69, "Property", "VocUserIdNm");
                            __builder5.AddAttribute(70, "Title", "VOC접수자");
                            __builder5.AddAttribute(71, "Width", "100px");
                            __builder5.AddAttribute(72, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(73, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(74);
                            __builder5.AddAttribute(75, "Property", "VocManageIdNm");
                            __builder5.AddAttribute(76, "Title", "VOC처리자");
                            __builder5.AddAttribute(77, "Width", "100px");
                            __builder5.AddAttribute(78, "CssClass", "data_center");
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
                __builder2.AddMarkupContent(79, "\r\n\r\n                ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(80);
                __builder2.AddAttribute(81, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 73 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(82, (__value) => {
#nullable restore
#line 73 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
                                                                                                      DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(83, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 81 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(84, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(85, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadVOC.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public VOCModel selectedVoc { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 54;

    ClaimsPrincipal CurrentUser;
    private List<VOCModel> vocModels;
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
                    vocModels = await _db.GetAllVoc(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        vocModels = await _db.GetAllVoc(CurrentUser.Identity.Name);
    }

    void btnImageUploadClick(VOCModel vocModel)
    {

    }

    void btnNewClick()
    {
        navigationManager.NavigateTo("/vocEdit" + "/" + CurrentUser.Identity.Name);
    }


    void btnUpdateClick(VOCModel vocModel)
    {
        navigationManager.NavigateTo("/vocEdit" + "/" + CurrentUser.Identity.Name + "/" + vocModel.VocNo);

    }

    void btnDeleteClick(VOCModel vocModel)
    {
        DeleteConfirmation.Show("삭제시 등록된 AS 관련 이미지도 삭제됩니다. 정말 삭제하시겠습니까 ?");

        selectedVoc = vocModel;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteData(selectedVoc, CurrentUser.Identity.Name);
            await GetAllDatas();
        }
        else
        {
            selectedVoc = null;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVOCData _db { get; set; }
    }
}
#pragma warning restore 1591