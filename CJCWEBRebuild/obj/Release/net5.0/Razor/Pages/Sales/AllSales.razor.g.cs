#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5690650052bf1ee13273f0057d40a4a84d7d680d"
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllSales")]
    public partial class AllSales : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<strong>전체 매출조회</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "<div class=\"info_title\"><h1 class=\"sub_title\">전체 매출조회</h1></div>\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
                __builder2.AddAttribute(17, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 34 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
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
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     20

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesModel>>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                                       salesModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ColumnWidth", "300px");
                        __builder4.AddAttribute(31, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
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
                    __builder3.AddMarkupContent(78, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(79);
                    __builder3.AddAttribute(80, "Text", "매장별 제품 매출현황");
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<SalesModel>>(82);
                        __builder4.AddAttribute(83, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     20

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(87, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(89, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesModel>>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                                       pditemModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(90, "ColumnWidth", "300px");
                        __builder4.AddAttribute(91, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 56 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 57 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(94);
                            __builder5.AddAttribute(95, "Property", "BizUnitNm");
                            __builder5.AddAttribute(96, "Title", "매장명");
                            __builder5.AddAttribute(97, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(98, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(99);
                            __builder5.AddAttribute(100, "Property", "FactBizUnitNm");
                            __builder5.AddAttribute(101, "Title", "공장명");
                            __builder5.AddAttribute(102, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(103, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(104);
                            __builder5.AddAttribute(105, "Property", "ItemCd");
                            __builder5.AddAttribute(106, "Title", "제품코드");
                            __builder5.AddAttribute(107, "Width", "130px");
                            __builder5.AddAttribute(108, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(109, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(110);
                            __builder5.AddAttribute(111, "Property", "ItemNm");
                            __builder5.AddAttribute(112, "Title", "제품명");
                            __builder5.AddAttribute(113, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(114, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(115);
                            __builder5.AddAttribute(116, "Property", "MadeType");
                            __builder5.AddAttribute(117, "Title", "제작형태");
                            __builder5.AddAttribute(118, "Width", "110px");
                            __builder5.AddAttribute(119, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(120, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(121);
                            __builder5.AddAttribute(122, "Property", "MadeYN");
                            __builder5.AddAttribute(123, "Title", "제작여부");
                            __builder5.AddAttribute(124, "Width", "90px");
                            __builder5.AddAttribute(125, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(126, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(127);
                            __builder5.AddAttribute(128, "Property", "Item1ClsNm");
                            __builder5.AddAttribute(129, "Title", "대분류");
                            __builder5.AddAttribute(130, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(131, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(132);
                            __builder5.AddAttribute(133, "Property", "Item2ClsNm");
                            __builder5.AddAttribute(134, "Title", "중분류");
                            __builder5.AddAttribute(135, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(136, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(137);
                            __builder5.AddAttribute(138, "Property", "Item3ClsNm");
                            __builder5.AddAttribute(139, "Title", "소분류");
                            __builder5.AddAttribute(140, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(141, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(142);
                            __builder5.AddAttribute(143, "Property", "Price");
                            __builder5.AddAttribute(144, "Title", "총금액");
                            __builder5.AddAttribute(145, "Width", "120px");
                            __builder5.AddAttribute(146, "FormatString", "{0:n0}");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(147, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(148);
                            __builder5.AddAttribute(149, "Property", "VAT");
                            __builder5.AddAttribute(150, "Title", "총부가세");
                            __builder5.AddAttribute(151, "Width", "120px");
                            __builder5.AddAttribute(152, "FormatString", "{0:n0}");
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(153, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(154);
                    __builder3.AddAttribute(155, "Text", "매장별 품목 매출현황");
                    __builder3.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<SalesModel>>(157);
                        __builder4.AddAttribute(158, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(159, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(160, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(161, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                     20

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(162, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(163, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(164, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SalesModel>>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                                                                                       itemModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(165, "ColumnWidth", "300px");
                        __builder4.AddAttribute(166, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 78 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(167, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 79 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(168, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(169);
                            __builder5.AddAttribute(170, "Property", "BizUnitNm");
                            __builder5.AddAttribute(171, "Title", "매장명");
                            __builder5.AddAttribute(172, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(173, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(174);
                            __builder5.AddAttribute(175, "Property", "ItemCd");
                            __builder5.AddAttribute(176, "Title", "제품코드");
                            __builder5.AddAttribute(177, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(178, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(179);
                            __builder5.AddAttribute(180, "Property", "ItemNm");
                            __builder5.AddAttribute(181, "Title", "제품명");
                            __builder5.AddAttribute(182, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(183, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(184);
                            __builder5.AddAttribute(185, "Property", "ItemClsNm");
                            __builder5.AddAttribute(186, "Title", "품목구분");
                            __builder5.AddAttribute(187, "Width", "110px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(188, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(189);
                            __builder5.AddAttribute(190, "Property", "Item1ClsNm");
                            __builder5.AddAttribute(191, "Title", "대분류");
                            __builder5.AddAttribute(192, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(193, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(194);
                            __builder5.AddAttribute(195, "Property", "Item2ClsNm");
                            __builder5.AddAttribute(196, "Title", "중분류");
                            __builder5.AddAttribute(197, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(198, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(199);
                            __builder5.AddAttribute(200, "Property", "Item3ClsNm");
                            __builder5.AddAttribute(201, "Title", "소분류");
                            __builder5.AddAttribute(202, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(203, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(204);
                            __builder5.AddAttribute(205, "Property", "Price");
                            __builder5.AddAttribute(206, "Title", "총금액");
                            __builder5.AddAttribute(207, "Width", "120px");
                            __builder5.AddAttribute(208, "FormatString", "{0:n0}");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(209, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<SalesModel>>(210);
                            __builder5.AddAttribute(211, "Property", "VAT");
                            __builder5.AddAttribute(212, "Title", "총부가세");
                            __builder5.AddAttribute(213, "Width", "120px");
                            __builder5.AddAttribute(214, "FormatString", "{0:n0}");
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
#line 99 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(215, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 103 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(216, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(217, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Sales\AllSales.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 57;

    ClaimsPrincipal CurrentUser;
    private List<SalesModel> salesModels;
    private List<SalesModel> pditemModels;
    private List<SalesModel> itemModels;

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
                    pditemModels = await _db.GetStorePDItemData(CurrentUser.Identity.Name);
                    itemModels = await _db.GetStoreItemData(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        salesModels = await _db.GetFactPDItemData(CurrentUser.Identity.Name);
        pditemModels = await _db.GetStorePDItemData(CurrentUser.Identity.Name);
        itemModels = await _db.GetStoreItemData(CurrentUser.Identity.Name);
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
