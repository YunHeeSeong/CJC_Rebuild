#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f24a5dfacedc02389a1843761a7ec1dff8098a"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Customer
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadCustHis")]
    public partial class ReadCustHis : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"pagelocation\" id=\"menugnb\"><i class=\"fa fa-home\"></i>\r\n    <a href=\"/\">HOME</a>\r\n    > 영업관리 >\r\n    <strong>이용이력조회</strong></div>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 22 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.AddMarkupContent(4, "<div class=\"info_title\"><h1 class=\"sub_title\">이용이력 조회</h1></div>\r\n\r\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(7);
                __builder2.AddAttribute(8, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 33 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                        TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(10);
                    __builder3.AddAttribute(11, "Text", "이용이력 리스트");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<CustomerModel>>(13);
                        __builder4.AddAttribute(14, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CustomerModel>>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                                                      customerList

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "ColumnWidth", "300px");
                        __builder4.AddAttribute(22, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CustomerModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CustomerModel>(this, 
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                                      RowSelect

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(24, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "EmptyText", "조회된 이용이력이 없습니다.");
                        __builder4.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(27);
                            __builder5.AddAttribute(28, "Property", "CustomerCd");
                            __builder5.AddAttribute(29, "Title", "고객코드");
                            __builder5.AddAttribute(30, "Width", "100px");
                            __builder5.AddAttribute(31, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(32, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(33);
                            __builder5.AddAttribute(34, "Property", "BizUnitNm");
                            __builder5.AddAttribute(35, "Title", "취급점");
                            __builder5.AddAttribute(36, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(37, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(38);
                            __builder5.AddAttribute(39, "Property", "CustomerNm");
                            __builder5.AddAttribute(40, "Title", "고객명");
                            __builder5.AddAttribute(41, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(42, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(43);
                            __builder5.AddAttribute(44, "Property", "ConsultDt");
                            __builder5.AddAttribute(45, "Title", "상담일자");
                            __builder5.AddAttribute(46, "Width", "150px");
                            __builder5.AddAttribute(47, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(48, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(49);
                            __builder5.AddAttribute(50, "Property", "RankNm");
                            __builder5.AddAttribute(51, "Title", "고객등급");
                            __builder5.AddAttribute(52, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(54);
                            __builder5.AddAttribute(55, "Property", "Birth");
                            __builder5.AddAttribute(56, "Title", "생년월일");
                            __builder5.AddAttribute(57, "Width", "150px");
                            __builder5.AddAttribute(58, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(60);
                            __builder5.AddAttribute(61, "Property", "Gender");
                            __builder5.AddAttribute(62, "Title", "성별");
                            __builder5.AddAttribute(63, "Width", "90px");
                            __builder5.AddAttribute(64, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(66);
                            __builder5.AddAttribute(67, "Property", "PhoneNo");
                            __builder5.AddAttribute(68, "Title", "이동전화");
                            __builder5.AddAttribute(69, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(71);
                            __builder5.AddAttribute(72, "Property", "Email");
                            __builder5.AddAttribute(73, "Title", "이메일");
                            __builder5.AddAttribute(74, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(76);
                            __builder5.AddAttribute(77, "Property", "ZipCode");
                            __builder5.AddAttribute(78, "Title", "우편번호");
                            __builder5.AddAttribute(79, "Width", "100px");
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
                __builder2.AddMarkupContent(80, "\r\n\r\n            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "style", "margin-top:20px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(83);
                __builder2.AddAttribute(84, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                        TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(86);
                    __builder3.AddAttribute(87, "Text", "이용이력 상세 리스트");
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<CustHistModel>>(89);
                        __builder4.AddAttribute(90, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(94, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(95, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(96, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CustHistModel>>(
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                                                      selectedCustHistCd

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(97, "ColumnWidth", "300px");
                        __builder4.AddAttribute(98, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 64 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(100, "EmptyText", "조회된 이용이력 상세 정보가 없습니다.");
                        __builder4.AddAttribute(101, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(102);
                            __builder5.AddAttribute(103, "Property", "BizUnitNm");
                            __builder5.AddAttribute(104, "Title", "매장명");
                            __builder5.AddAttribute(105, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(106, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(107);
                            __builder5.AddAttribute(108, "Property", "FactBizUnitNm");
                            __builder5.AddAttribute(109, "Title", "생산사업장");
                            __builder5.AddAttribute(110, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(112);
                            __builder5.AddAttribute(113, "Property", "OrderNo");
                            __builder5.AddAttribute(114, "Title", "주문번호");
                            __builder5.AddAttribute(115, "Width", "130px");
                            __builder5.AddAttribute(116, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(117, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(118);
                            __builder5.AddAttribute(119, "Property", "OrderDt");
                            __builder5.AddAttribute(120, "Title", "주문일자");
                            __builder5.AddAttribute(121, "Width", "150px");
                            __builder5.AddAttribute(122, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(123, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(124);
                            __builder5.AddAttribute(125, "Property", "ItemCd");
                            __builder5.AddAttribute(126, "Title", "품목코드");
                            __builder5.AddAttribute(127, "Width", "130px");
                            __builder5.AddAttribute(128, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(129, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(130);
                            __builder5.AddAttribute(131, "Property", "ItemNm");
                            __builder5.AddAttribute(132, "Title", "품목명");
                            __builder5.AddAttribute(133, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(134, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(135);
                            __builder5.AddAttribute(136, "Property", "Qty");
                            __builder5.AddAttribute(137, "Title", "주문수량");
                            __builder5.AddAttribute(138, "Width", "80px");
                            __builder5.AddAttribute(139, "FormatString", "{0:n0}");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(140, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(141);
                            __builder5.AddAttribute(142, "Property", "PayYN");
                            __builder5.AddAttribute(143, "Title", "결제여부");
                            __builder5.AddAttribute(144, "Width", "70px");
                            __builder5.AddAttribute(145, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(146, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustHistModel>>(147);
                            __builder5.AddAttribute(148, "Property", "Remk");
                            __builder5.AddAttribute(149, "Title", "비고");
                            __builder5.AddAttribute(150, "Width", "200px");
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
                __builder2.AddMarkupContent(151, "\r\n\r\n            ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(152);
                __builder2.AddAttribute(153, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 84 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                       ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(154, (__value) => {
#nullable restore
#line 84 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
                                                                                                  DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 87 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(155, "<p>권한이 없는 사용자입니다.</p>");
#nullable restore
#line 91 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(156, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(157, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public CustHistModel deleteCommonCodeModel { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    public int MenuId = 50;

    ClaimsPrincipal CurrentUser;

    private List<CustomerModel> customerList;
    private List<CustHistModel> selectedCustHistCd;
    private string RoleYN;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _roleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                if (RoleYN == "Y")
                {
                    customerList = await _db.GetAllCustomer(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        customerList = await _db.GetAllCustomer(CurrentUser.Identity.Name);
        selectedCustHistCd = null;
    }

    //async Task btnNewClick()
    //{
    //    var parameters = new ModalParameters();
    //    parameters.Add("loginId", CurrentUser.Identity.Name);

    //    var custHistEdit = Modal.Show<CustHistoryEdit>("이용이력 등록 및 수정", parameters);
    //    var result = await custHistEdit.Result;

    //    if (!result.Cancelled)
    //    {
    //        await GetAllDatas();
    //    }
    //}

    //async Task btnUpdateClick(CustHistModel code)
    //{
    //    var parameters = new ModalParameters();
    //    parameters.Add(nameof(CustHistoryEdit.selectedCustHist), code);
    //    parameters.Add("loginId", CurrentUser.Identity.Name);

    //    var custHistEdit = Modal.Show<CustHistoryEdit>("이용이력 등록 및 수정", parameters);
    //    var result = await custHistEdit.Result;

    //    if (!result.Cancelled)
    //    {
    //        //show
    //        await GetAllDatas();
    //    }
    //}


    void btnDeleteClick(CustHistModel code)
    {
        DeleteConfirmation.Show("삭제 시 고객의 상세 이용이력도 삭제됩니다. 정말 삭제하시겠습니까 ?");

        deleteCommonCodeModel = code;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteMasterData(deleteCommonCodeModel, CurrentUser.Identity.Name);
            await GetAllDatas();
        }
        else
        {
            deleteCommonCodeModel = null;
        }
    }

    public async Task RowSelect(CustomerModel customer)
    {
        selectedCustHistCd = await _db.GetCustHistFromCustomer(CurrentUser.Identity.Name, customer);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustHistData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _roleManager { get; set; }
    }
}
#pragma warning restore 1591
