#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de72284b2aaa2076945896ef0d7a140038b84537"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages.Common
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileManagement")]
    public partial class FileManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n        .row {\r\n            margin-bottom: 16px;\r\n        }\r\n    </style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "pagelocation");
            __builder.AddAttribute(3, "id", "menugnb");
            __builder.AddMarkupContent(4, "<i class=\"fa fa-home\"></i>\r\n    ");
            __builder.AddMarkupContent(5, "<a href=\"/\">HOME</a>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(6);
            __builder.AddAttribute(7, "Text", " > 기준정보관리 > ");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<strong>파일관리</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 32 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "div");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "info_title");
                __builder2.AddMarkupContent(16, "<h1 class=\"sub_title\">파일 관리</h1>\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "post_btn");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(19);
                __builder2.AddAttribute(20, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                             btnSearchClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(21, "Style", "background-color:black; color:white");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "조회");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(25);
                __builder2.AddAttribute(26, "Style", " padding-top: 10px; padding-bottom: 10px;");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "col-sm-12");
                    __builder3.AddMarkupContent(30, "<h5>검색조건</h5>\r\n                        ");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "row");
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "col-sm-1 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(35);
                    __builder3.AddAttribute(36, "Text", "파일구분");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                            ");
                    __builder3.OpenElement(38, "div");
                    __builder3.AddAttribute(39, "class", "col-sm-2");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(40);
                    __builder3.AddAttribute(41, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "AllowVirtualization", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Class", "w-100");
                    __builder3.AddAttribute(44, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 51 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                            FileClsList

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "TextProperty", "CodeSubNm");
                    __builder3.AddAttribute(47, "ValueProperty", "CodeSubNm");
                    __builder3.AddAttribute(48, "SelectedItemChanged", new System.Action<System.Object>(
#nullable restore
#line 52 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                       args => OnChangeFileCls(args, "파일분류")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 51 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                                                        selectedFileClsNm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedFileClsNm = __value, selectedFileClsNm))));
                    __builder3.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => selectedFileClsNm));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n\r\n                            <div class=\"col-sm-2\"></div>\r\n\r\n                                ");
                    __builder3.OpenElement(53, "div");
                    __builder3.AddAttribute(54, "class", "col-sm-1 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(55);
                    __builder3.AddAttribute(56, "Text", "등록일자");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                                ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-sm-2");
                    __Blazor.GMINWEB_CJC.Pages.Common.FileManager.TypeInference.CreateRadzenDatePicker_0(__builder3, 60, 61, "ReqDelvDate", 62, "yyyy-MM-dd", 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                               arg=> StartDtChanged(arg)

#line default
#line hidden
#nullable disable
                    ), 64, "w-100", 65, 
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                     StartDt

#line default
#line hidden
#nullable disable
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartDt = __value, StartDt)), 67, () => StartDt);
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                                ");
                    __builder3.AddMarkupContent(69, "<strong>~</strong>\r\n                                ");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "class", "col-sm-2");
                    __Blazor.GMINWEB_CJC.Pages.Common.FileManager.TypeInference.CreateRadzenDatePicker_1(__builder3, 72, 73, "ReqDelvDate", 74, "yyyy-MM-dd", 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                             arg=> EndDtChanged(arg)

#line default
#line hidden
#nullable disable
                    ), 76, "w-100", 77, 
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                     EndDt

#line default
#line hidden
#nullable disable
                    , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndDt = __value, EndDt)), 79, () => EndDt);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n\r\n                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "style", "margin-top:20px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(83);
                __builder2.AddAttribute(84, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 72 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                              TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(86);
                    __builder3.AddAttribute(87, "Text", "AS리스트");
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<FileModel>>(89);
                        __builder4.AddAttribute(90, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 75 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(92, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                            FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(93, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                         5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(94, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(95, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(96, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FileModel>>(
#nullable restore
#line 76 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                                          fileModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(97, "ColumnWidth", "300px");
                        __builder4.AddAttribute(98, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(99, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 78 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                       LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(100, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(101);
                            __builder5.AddAttribute(102, "Property", "BizUnitNm");
                            __builder5.AddAttribute(103, "Title", "사업장명");
                            __builder5.AddAttribute(104, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(105, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(106);
                            __builder5.AddAttribute(107, "Property", "FileNo");
                            __builder5.AddAttribute(108, "Title", "파일번호");
                            __builder5.AddAttribute(109, "Width", "70px");
                            __builder5.AddAttribute(110, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(111, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(112);
                            __builder5.AddAttribute(113, "Property", "FileClsNm");
                            __builder5.AddAttribute(114, "Title", "파일구분");
                            __builder5.AddAttribute(115, "Width", "100px");
                            __builder5.AddAttribute(116, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(117, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(118);
                            __builder5.AddAttribute(119, "Property", "DetailClsNm");
                            __builder5.AddAttribute(120, "Title", "파일종류");
                            __builder5.AddAttribute(121, "Width", "140px");
                            __builder5.AddAttribute(122, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(123, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(124);
                            __builder5.AddAttribute(125, "Property", "CustomerNm");
                            __builder5.AddAttribute(126, "Title", "고객명");
                            __builder5.AddAttribute(127, "Width", "100px");
                            __builder5.AddAttribute(128, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(129, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(130);
                            __builder5.AddAttribute(131, "Property", "UserNm");
                            __builder5.AddAttribute(132, "Title", "사용자명");
                            __builder5.AddAttribute(133, "Width", "100px");
                            __builder5.AddAttribute(134, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(135, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(136);
                            __builder5.AddAttribute(137, "Property", "GroupNm");
                            __builder5.AddAttribute(138, "Title", "조직명");
                            __builder5.AddAttribute(139, "Width", "100px");
                            __builder5.AddAttribute(140, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(141, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(142);
                            __builder5.AddAttribute(143, "Property", "ItemNm");
                            __builder5.AddAttribute(144, "Title", "품목명");
                            __builder5.AddAttribute(145, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(146, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(147);
                            __builder5.AddAttribute(148, "Property", "FileNm");
                            __builder5.AddAttribute(149, "Title", "파일명");
                            __builder5.AddAttribute(150, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(151, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(152);
                            __builder5.AddAttribute(153, "Property", "FileData");
                            __builder5.AddAttribute(154, "Title", "파일데이터");
                            __builder5.AddAttribute(155, "Width", "120px");
                            __builder5.AddAttribute(156, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                                         false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(157, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(158);
                            __builder5.AddAttribute(159, "Property", "FileType");
                            __builder5.AddAttribute(160, "Title", "파일유형");
                            __builder5.AddAttribute(161, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(162, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(163);
                            __builder5.AddAttribute(164, "Property", "Remk");
                            __builder5.AddAttribute(165, "Title", "비고");
                            __builder5.AddAttribute(166, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(167, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<FileModel>>(168);
                            __builder5.AddAttribute(169, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 92 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                            false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(170, "Title", "다운로드");
                            __builder5.AddAttribute(171, "Width", "200px");
                            __builder5.AddAttribute(172, "CssClass", "data_center");
                            __builder5.AddAttribute(173, "Template", (Microsoft.AspNetCore.Components.RenderFragment<FileModel>)((file) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(174);
                                __builder6.AddAttribute(175, "Style", "margin: 0 0.5rem 0 0; color: darkslateblue; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(176, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
                                                                                                                                                                                                                                      ()=>btnDownloadFile(file)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(177, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(178, "다운로드");
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
                __builder2.CloseElement();
#nullable restore
#line 104 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(179, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 108 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(180, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(181, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\FileManager.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 15;     //파일관리

    ClaimsPrincipal CurrentUser;
    private List<FileModel> fileModels;
    private List<CommonCodeModel> FileClsList;

    private string loginId;
    private string RoleYN;
    private string selectedFileClsNm;
    private int selectedFileCls;

    private DateTime StartDt;
    private DateTime EndDt;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                loginId = CurrentUser.Identity.Name;

                StartDt = DateTime.Today.AddDays(-7);
                EndDt = DateTime.Today;

                if (RoleYN == "Y")
                {
                    FileClsList = await _codeManager.FindCommonCodeFromName("파일분류", loginId);
                }
            }
        }
    }
    async Task btnSearchClick()
    {
        if (selectedFileCls.GetIntNullToZero() != 0)
        {
            fileModels = await _db.GetFile(loginId, StartDt, EndDt, selectedFileCls);
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "조회할 파일구분을 선택하여 주십시오.");

        }
    }

    void btnDownloadFile(FileModel file)
    {
        var fileArr = Convert.FromBase64String(file.FileData);
        jsRuntime.InvokeVoidAsync("DownloadAsFile", file.FileNm, file.FileType, fileArr);
    }

    void StartDtChanged(object value)
    {
        if (value is not null)
        {
            StartDt = Convert.ToDateTime(value);
        }
    }
    void EndDtChanged(object value)
    {
        if (value is not null)
        {
            EndDt = Convert.ToDateTime(value);
        }
    }
    void OnChangeFileCls(object value, string name)
    {
        if (value is not null)
        {
            selectedFileCls = ((CommonCodeModel)value).CodeSeq;
            selectedFileClsNm = ((CommonCodeModel)value).CodeSubNm;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileData _db { get; set; }
    }
}
namespace __Blazor.GMINWEB_CJC.Pages.Common.FileManager
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "DateFormat", __arg1);
        __builder.AddAttribute(__seq2, "Change", __arg2);
        __builder.AddAttribute(__seq3, "Class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "DateFormat", __arg1);
        __builder.AddAttribute(__seq2, "Change", __arg2);
        __builder.AddAttribute(__seq3, "Class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591