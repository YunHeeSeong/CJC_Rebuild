#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f413f4a68384c82cb4d27028c4e63410c2f10e40"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages.Dialog
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
using GMINWEB_CJC.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class ReadPDItemImgEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    form .row {\r\n        margin-bottom: 16px;\r\n    }\r\n</style>\r\n\r\n");
            __Blazor.GMINWEB_CJC.Pages.Dialog.ReadPDItemImgEdit.TypeInference.CreateRadzenTemplateForm_0(__builder, 1, 2, "width:1200px; overflow-x:auto; height:550px; overflow-y:auto;", 3, 
#nullable restore
#line 17 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                selectedPDItem

#line default
#line hidden
#nullable disable
            , 4, (context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-sm");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(9);
                __builder2.AddAttribute(10, "Text", "제품 정보");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "row");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "col-sm-3 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                    __builder3.AddAttribute(17, "Text", "취급매장");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n                    ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "col-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(21);
                    __builder3.AddAttribute(22, "TValue", "string");
                    __builder3.AddAttribute(23, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "style", "width: 100%;");
                    __builder3.AddAttribute(25, "Name", "BizUnitNm");
                    __builder3.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                           selectedPDItem.BizUnitNm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedPDItem.BizUnitNm = __value, selectedPDItem.BizUnitNm))));
                    __builder3.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selectedPDItem.BizUnitNm));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                    ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "col-sm-3 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(32);
                    __builder3.AddAttribute(33, "Text", "생산사업장");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                    ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(37);
                    __builder3.AddAttribute(38, "Style", "width:100%;");
                    __builder3.AddAttribute(39, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Name", "FactBizUnitNm");
                    __builder3.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                              selectedPDItem.FactBizUnitNm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedPDItem.FactBizUnitNm = __value, selectedPDItem.FactBizUnitNm))));
                    __builder3.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selectedPDItem.FactBizUnitNm));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n                ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-sm-3 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", "제품코드");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n                    ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(54);
                    __builder3.AddAttribute(55, "TValue", "string");
                    __builder3.AddAttribute(56, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "style", "width: 100%;");
                    __builder3.AddAttribute(58, "Name", "ItemCd");
                    __builder3.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                        selectedPDItem.ItemCd

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedPDItem.ItemCd = __value, selectedPDItem.ItemCd))));
                    __builder3.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selectedPDItem.ItemCd));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n                    ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-sm-3 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(65);
                    __builder3.AddAttribute(66, "Text", "제품명");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(70);
                    __builder3.AddAttribute(71, "Style", "width:100%;");
                    __builder3.AddAttribute(72, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Name", "ItemNm");
                    __builder3.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                       selectedPDItem.ItemNm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedPDItem.ItemNm = __value, selectedPDItem.ItemNm))));
                    __builder3.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => selectedPDItem.ItemNm));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(78);
                __builder2.AddAttribute(79, "Text", "제품 관련 문서");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGrid<PDItemImageModel>>(81);
                    __builder3.AddAttribute(82, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                      5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridEditMode>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                                       Radzen.DataGridEditMode.Single

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<PDItemImageModel>>(
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                       pdItemImageModels

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "EmptyText", "");
                    __builder3.AddAttribute(89, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(90);
                        __builder4.AddAttribute(91, "Property", "FileNo");
                        __builder4.AddAttribute(92, "Title", "파일코드");
                        __builder4.AddAttribute(93, "Width", "70px");
                        __builder4.AddAttribute(94, "CssClass", "data_center");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(96);
                        __builder4.AddAttribute(97, "Property", "ItemNm");
                        __builder4.AddAttribute(98, "Title", "품목명");
                        __builder4.AddAttribute(99, "Width", "200px");
                        __builder4.AddAttribute(100, "CssClass", "data_center");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(101, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(102);
                        __builder4.AddAttribute(103, "Property", "FileCls");
                        __builder4.AddAttribute(104, "Title", "파일구분");
                        __builder4.AddAttribute(105, "Width", "120px");
                        __builder4.AddAttribute(106, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                              false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(107, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<PDItemImageModel>)((file) => (__builder5) => {
                            __Blazor.GMINWEB_CJC.Pages.Dialog.ReadPDItemImgEdit.TypeInference.CreateRadzenNumeric_1(__builder5, 108, 109, "FileCls", 110, 
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                            , 111, 
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                           file.FileCls

#line default
#line hidden
#nullable disable
                            , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => file.FileCls = __value, file.FileCls)), 113, () => file.FileCls);
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(114, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(115);
                        __builder4.AddAttribute(116, "Property", "FileClsNm");
                        __builder4.AddAttribute(117, "Title", "파일구분명");
                        __builder4.AddAttribute(118, "Width", "120px");
                        __builder4.AddAttribute(119, "EditTemplate", (Microsoft.AspNetCore.Components.RenderFragment<PDItemImageModel>)((file) => (__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDropDown<string>>(120);
                            __builder5.AddAttribute(121, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 66 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                            true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(122, "AllowVirtualization", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 66 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(123, "Class", "w-100");
                            __builder5.AddAttribute(124, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 67 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(125, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 67 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                            FileClsNmList

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(126, "TextProperty", "CodeSubNm");
                            __builder5.AddAttribute(127, "ValueProperty", "CodeSubNm");
                            __builder5.AddAttribute(128, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 67 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                                                                                          file.FileClsNm

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(129, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => file.FileClsNm = __value, file.FileClsNm))));
                            __builder5.AddAttribute(130, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => file.FileClsNm));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(131, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(132);
                        __builder4.AddAttribute(133, "Property", "FileNm");
                        __builder4.AddAttribute(134, "Title", "파일명");
                        __builder4.AddAttribute(135, "Width", "200px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(136, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(137);
                        __builder4.AddAttribute(138, "Property", "FileData");
                        __builder4.AddAttribute(139, "Title", "데이터");
                        __builder4.AddAttribute(140, "Width", "100px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(141, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(142);
                        __builder4.AddAttribute(143, "Property", "FileType");
                        __builder4.AddAttribute(144, "Title", "파일형식");
                        __builder4.AddAttribute(145, "Width", "120px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(146, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<PDItemImageModel>>(147);
                        __builder4.AddAttribute(148, "Title", "다운로드");
                        __builder4.AddAttribute(149, "Width", "150px");
                        __builder4.AddAttribute(150, "CssClass", "data_center");
                        __builder4.AddAttribute(151, "Template", (Microsoft.AspNetCore.Components.RenderFragment<PDItemImageModel>)((file) => (__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenButton>(152);
                            __builder5.AddAttribute(153, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 80 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(154, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                     ()=>btnDownloadFile(file)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(155, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(156, "다운로드");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(157, (__value) => {
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                      detailGrid = (Radzen.Blazor.RadzenDataGrid<PDItemImageModel>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n\r\n    ");
                __builder2.OpenElement(159, "div");
                __builder2.AddAttribute(160, "style", "width:300px;margin:0 auto;");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(161);
                __builder2.AddAttribute(162, "style", "margin: 0 1rem 1rem 60px");
                __builder2.AddAttribute(163, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 112 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                    ButtonStyle.Light

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
                                                                                              btnCancleClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(165, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(166, "닫기");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Dialog\ReadPDItemImgEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public ItemModel selectedPDItem { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }


    private List<PDItemImageModel> pdItemImageModels;
    public PDItemImageModel selectedFile { get; set; }

    RadzenDataGrid<PDItemImageModel> detailGrid;
    private List<CommonCodeModel> FileClsNmList;

    private PDItemImageModel fileModelToInsert;
    private PDItemImageModel fileModelToDelete;

    string imgSrc = "";
    IFileListEntry file = null;
    byte[] _fileBytes = null;

    protected override async Task OnInitializedAsync()
    {
        if (selectedPDItem is not null)
        {
            pdItemImageModels = await _imageManager.GetPDItemImage(selectedPDItem);
        }

        FileClsNmList = await _codeManager.FindCommonCodeFromName("제품관련파일", loginId);

    }


    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }



    void btnDownloadFile(PDItemImageModel file)
    {
        var fileArr = Convert.FromBase64String(file.FileData);
        jsRuntime.InvokeVoidAsync("DownloadAsFile", file.FileNm, file.FileType, fileArr);
    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPDItemImageData _imageManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
    }
}
namespace __Blazor.GMINWEB_CJC.Pages.Dialog.ReadPDItemImgEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenTemplateForm_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext> __arg2)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenTemplateForm<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Style", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "ReadOnly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591