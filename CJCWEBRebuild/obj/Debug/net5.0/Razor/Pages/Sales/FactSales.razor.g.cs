#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946a5aca119e80c3a32b508f5d43d2c1cfdbccbf"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages.Sales
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FactSales")]
    public partial class FactSales : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<strong>공장별 매출조회</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "<div class=\"info_title\"><h1 class=\"sub_title\">공장별 매출조회</h1></div>\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
                __builder2.AddAttribute(17, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 34 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                        TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(19);
                    __builder3.AddAttribute(20, "Text", "공장별 매출현황");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<SalesModel>>(22);
                        __builder4.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                                     20

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesModel>>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                                                                                       salesModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ColumnWidth", "300px");
                        __builder4.AddAttribute(31, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(34);
                            __builder5.AddAttribute(35, "Property", "FactBizUnitNm");
                            __builder5.AddAttribute(36, "Title", "공장명");
                            __builder5.AddAttribute(37, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(39);
                            __builder5.AddAttribute(40, "Property", "BizUnitNm");
                            __builder5.AddAttribute(41, "Title", "매장명");
                            __builder5.AddAttribute(42, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(43, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(44);
                            __builder5.AddAttribute(45, "Property", "ItemCd");
                            __builder5.AddAttribute(46, "Title", "제품코드");
                            __builder5.AddAttribute(47, "Width", "130px");
                            __builder5.AddAttribute(48, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(50);
                            __builder5.AddAttribute(51, "Property", "ItemNm");
                            __builder5.AddAttribute(52, "Title", "제품명");
                            __builder5.AddAttribute(53, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(54, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(55);
                            __builder5.AddAttribute(56, "Property", "OrderNo");
                            __builder5.AddAttribute(57, "Title", "주문번호");
                            __builder5.AddAttribute(58, "Width", "150px");
                            __builder5.AddAttribute(59, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(61);
                            __builder5.AddAttribute(62, "Property", "OutGroupCdNm");
                            __builder5.AddAttribute(63, "Title", "출하부서");
                            __builder5.AddAttribute(64, "Width", "100px");
                            __builder5.AddAttribute(65, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(66, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(67);
                            __builder5.AddAttribute(68, "Property", "OutUserIdNm");
                            __builder5.AddAttribute(69, "Title", "출하담당자");
                            __builder5.AddAttribute(70, "Width", "100px");
                            __builder5.AddAttribute(71, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(72, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(73);
                            __builder5.AddAttribute(74, "Property", "Tax");
                            __builder5.AddAttribute(75, "Title", "통관비");
                            __builder5.AddAttribute(76, "Width", "120px");
                            __builder5.AddAttribute(77, "FormatString", "{0:n0}");
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
                __builder2.CloseElement();
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(78, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(79, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(80, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\FactSales.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 57;

    ClaimsPrincipal CurrentUser;
    private List<SalesModel> salesModels;
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
                    salesModels = await _db.GetFactPDItemData(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        salesModels = await _db.GetFactPDItemData(CurrentUser.Identity.Name);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesData _db { get; set; }
    }
}
#pragma warning restore 1591
