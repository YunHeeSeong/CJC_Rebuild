#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7506e8a6e60a27036fb74087955434445e5b1ef"
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/VOCManagement")]
    public partial class VOC : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(8, "<strong>VOC등록</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "info_title");
                __builder2.AddMarkupContent(15, "<h1 class=\"sub_title\">VOC 등록</h1>\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "post_btn");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(18);
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                             btnNewClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(20, "Style", "background-color:black; color:white");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "신규");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(24);
                __builder2.AddAttribute(25, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                          TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(27);
                    __builder3.AddAttribute(28, "Text", "VOC 리스트");
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<VOCModel>>(30);
                        __builder4.AddAttribute(31, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(35, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(37, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<VOCModel>>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                                                      vocModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(38, "ColumnWidth", "300px");
                        __builder4.AddAttribute(39, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(42);
                            __builder5.AddAttribute(43, "Property", "VocNo");
                            __builder5.AddAttribute(44, "Title", "VOC번호");
                            __builder5.AddAttribute(45, "Width", "130px");
                            __builder5.AddAttribute(46, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(48);
                            __builder5.AddAttribute(49, "Property", "VocDt");
                            __builder5.AddAttribute(50, "Title", "VOC일자");
                            __builder5.AddAttribute(51, "Width", "130px");
                            __builder5.AddAttribute(52, "CssClass", "data_center");
                            __builder5.AddAttribute(53, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VOCModel>)((data) => (__builder6) => {
                                __builder6.AddContent(54, 
#nullable restore
#line 48 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                             data.VocDt.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(55, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(56);
                            __builder5.AddAttribute(57, "Property", "VocClsNm");
                            __builder5.AddAttribute(58, "Title", "VOC구분");
                            __builder5.AddAttribute(59, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(60, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(61);
                            __builder5.AddAttribute(62, "Property", "VocDetailClsNm");
                            __builder5.AddAttribute(63, "Title", "VOC상세구분");
                            __builder5.AddAttribute(64, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(65, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(66);
                            __builder5.AddAttribute(67, "Property", "CustomerNm");
                            __builder5.AddAttribute(68, "Title", "고객명");
                            __builder5.AddAttribute(69, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(71);
                            __builder5.AddAttribute(72, "Property", "Title");
                            __builder5.AddAttribute(73, "Title", "제목");
                            __builder5.AddAttribute(74, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(76);
                            __builder5.AddAttribute(77, "Property", "VocUserIdNm");
                            __builder5.AddAttribute(78, "Title", "VOC접수자");
                            __builder5.AddAttribute(79, "Width", "100px");
                            __builder5.AddAttribute(80, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(81, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(82);
                            __builder5.AddAttribute(83, "Property", "VocManageIdNm");
                            __builder5.AddAttribute(84, "Title", "VOC처리자");
                            __builder5.AddAttribute(85, "Width", "100px");
                            __builder5.AddAttribute(86, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(87, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<VOCModel>>(88);
                            __builder5.AddAttribute(89, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                       false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(90, "Title", "수정 및 삭제");
                            __builder5.AddAttribute(91, "Width", "230px");
                            __builder5.AddAttribute(92, "CssClass", "data_center");
                            __builder5.AddAttribute(93, "Template", (Microsoft.AspNetCore.Components.RenderFragment<VOCModel>)((vocModel) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(94);
                                __builder6.AddAttribute(95, "Style", "margin: 0 0.5rem 0 0; color: darkblue; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(96, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                                                                                                                                                  ButtonStyle.Light

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(97, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                                                                                                                                                                            ()=>btnUpdateClick(vocModel)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(99, "수정");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(100, "\r\n                                            ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(101);
                                __builder6.AddAttribute(102, "Style", "margin: 0 0.5rem 0 0; color: darkred; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(103, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                                                                                                                                           ()=>btnDeleteClick(vocModel)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(105, "삭제");
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
                __builder2.AddMarkupContent(106, "\r\n\r\n                ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(107);
                __builder2.AddAttribute(108, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 70 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(109, (__value) => {
#nullable restore
#line 70 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
                                                                                                      DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 74 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(110, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 78 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(111, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(112, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\VOC.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public VOCModel selectedVoc { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 53;

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
