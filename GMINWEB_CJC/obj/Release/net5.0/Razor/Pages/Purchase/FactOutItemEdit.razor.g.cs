#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d9058a94462c0536c58172a754132461328e20"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Purchase
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
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class FactOutItemEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .row {\r\n        margin-bottom: 16px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "width:1100px;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(6);
            __builder.AddAttribute(7, "Text", "출하등록");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(13);
                __builder2.AddAttribute(14, "Text", "주문번호");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(18);
                __builder2.AddAttribute(19, "TValue", "string");
                __builder2.AddAttribute(20, "Style", "width:100%;");
                __builder2.AddAttribute(21, "Name", "OrderNo");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                    outPDItemModel.OrderNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.OrderNo = __value, outPDItemModel.OrderNo))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => outPDItemModel.OrderNo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(28);
                __builder2.AddAttribute(29, "Text", "매장명");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                __builder2.AddAttribute(34, "TValue", "string");
                __builder2.AddAttribute(35, "Style", "width:100%;");
                __builder2.AddAttribute(36, "Name", "BizUnitNm");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                      outPDItemModel.BizUnitNm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.BizUnitNm = __value, outPDItemModel.BizUnitNm))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => outPDItemModel.BizUnitNm));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(45);
                __builder2.AddAttribute(46, "Text", "주문수량");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(50);
                __builder2.AddAttribute(51, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Style", "width:100%;");
                __builder2.AddAttribute(53, "Name", "OrderQty");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                                  outPDItemModel.OrderQty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.OrderQty = __value, outPDItemModel.OrderQty))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => outPDItemModel.OrderQty));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(60);
                __builder2.AddAttribute(61, "Text", "기출하수량");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal>>(65);
                __builder2.AddAttribute(66, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "style", "width: 100%;");
                __builder2.AddAttribute(68, "Name", "TotQty");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal>(
#nullable restore
#line 45 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                                     outPDItemModel.TotQty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.TotQty = __value, outPDItemModel.TotQty))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<decimal>>>(() => outPDItemModel.TotQty));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "row");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(77);
                __builder2.AddAttribute(78, "Text", "품목코드");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(82);
                __builder2.AddAttribute(83, "Style", "width:100%;");
                __builder2.AddAttribute(84, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "Name", "ItemCd");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                   outPDItemModel.ItemCd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.ItemCd = __value, outPDItemModel.ItemCd))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => outPDItemModel.ItemCd));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(92);
                __builder2.AddAttribute(93, "Text", "품목명");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(97);
                __builder2.AddAttribute(98, "Style", "width:100%;");
                __builder2.AddAttribute(99, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "Name", "ItemNm");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                   outPDItemModel.ItemNm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.ItemNm = __value, outPDItemModel.ItemNm))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => outPDItemModel.ItemNm));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "row");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(109);
                __builder2.AddAttribute(110, "Text", "출하일자");
                __builder2.AddAttribute(111, "Style", "color:red");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "col-sm-3");
                __Blazor.GMINWEB_Rebuild.Pages.Purchase.FactOutItemEdit.TypeInference.CreateRadzenDatePicker_0(__builder2, 115, 116, "yyyy-MM-dd", 117, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 67 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                             arg=> OutDateChanged(arg)

#line default
#line hidden
#nullable disable
                ), 118, "w-100", 119, 
#nullable restore
#line 67 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                   OutDate

#line default
#line hidden
#nullable disable
                , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OutDate = __value, OutDate)), 121, () => OutDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "row");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(127);
                __builder2.AddAttribute(128, "Text", "출하수량");
                __builder2.AddAttribute(129, "Style", "color:red");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.OpenElement(131, "div");
                __builder2.AddAttribute(132, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal>>(133);
                __builder2.AddAttribute(134, "Style", "width:100%;");
                __builder2.AddAttribute(135, "Name", "OutQty");
                __builder2.AddAttribute(136, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal>(
#nullable restore
#line 81 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                    outPDItemModel.OutQty

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.OutQty = __value, outPDItemModel.OutQty))));
                __builder2.AddAttribute(138, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<decimal>>>(() => outPDItemModel.OutQty));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(142);
                __builder2.AddAttribute(143, "Text", "통관비");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "col-sm-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal>>(147);
                __builder2.AddAttribute(148, "Style", "width:100%;");
                __builder2.AddAttribute(149, "Name", "Tax");
                __builder2.AddAttribute(150, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal>(
#nullable restore
#line 87 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                                 outPDItemModel.Tax

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(151, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.Tax = __value, outPDItemModel.Tax))));
                __builder2.AddAttribute(152, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<decimal>>>(() => outPDItemModel.Tax));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n            ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "row");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "col-sm-3 align-items-center d-flex");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(158);
                __builder2.AddAttribute(159, "Text", "비고");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                ");
                __builder2.OpenElement(161, "div");
                __builder2.AddAttribute(162, "class", "col-sm-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(163);
                __builder2.AddAttribute(164, "Style", "width:100%;");
                __builder2.AddAttribute(165, "Name", "Remk");
                __builder2.AddAttribute(166, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 95 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                 outPDItemModel.Remk

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(167, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => outPDItemModel.Remk = __value, outPDItemModel.Remk))));
                __builder2.AddAttribute(168, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => outPDItemModel.Remk));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n\r\n");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "style", "width:300px;margin:0 auto;");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(172);
            __builder.AddAttribute(173, "style", "margin: 0 1rem 1rem 60px");
            __builder.AddAttribute(174, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 103 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                ButtonStyle.Light

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(175, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                          btnCancleClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(176, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(177, "취소");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(178, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(179);
            __builder.AddAttribute(180, "style", "margin: 0 1rem 1rem 0");
            __builder.AddAttribute(181, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 104 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                             ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(182, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
                                                                                           btnSaveClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(183, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(184, "저장");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Purchase\FactOutItemEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public OutPDItemModel selectedOutPDItem { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }


    private List<OutPDItemModel> outPDItemModels;
    private OutPDItemModel outPDItemModel = new OutPDItemModel();

    private List<CommonCodeModel> BadTypeList;

    DateTime OutDate;

    protected override async Task OnInitializedAsync()
    {
        if (selectedOutPDItem is not null)
        {
            //선택한 주문서 바인딩
            outPDItemModel = selectedOutPDItem;

            //출하일자 기본값 세팅
            OutDate = DateTime.Today;
            outPDItemModel.OutDate = OutDate.ToString("yyyy-MM-dd");

            //출하수량 기본값 
            outPDItemModel.OutQty = 0;
        }
    }

    #region // ** 이벤트 ** //
    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }

    async Task btnSaveClick()
    {
        var errMessage = ValidationFactOutPDItem(outPDItemModel);
        //필수값 체크
        if (errMessage == string.Empty)
        {
            var result = await _db.InsertData(outPDItemModel, loginId);

            if (!result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");
                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
            else
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());
            }
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", errMessage);

        }

    }

    void OutDateChanged(object value)
    {
        if (value is not null)
        {
            OutDate = Convert.ToDateTime(value);
            outPDItemModel.OutDate = Convert.ToDateTime(value).ToString("yyyy-MM-dd");
        }
    }
    #endregion


    //필수코드 체크
    string ValidationFactOutPDItem(OutPDItemModel outPDItemModel)
    {
        if (outPDItemModel.OutDate.GetNullToEmpty() == string.Empty)
        {
            return "출하일자를 선택하여 주십시오.";
        }
        if (outPDItemModel.OutQty.GetDecimalNullToZero() == 0)
        {
            return "출하 수량을 입력하여 주십시오.";
        }

        return string.Empty;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOutPDItemData _db { get; set; }
    }
}
namespace __Blazor.GMINWEB_Rebuild.Pages.Purchase.FactOutItemEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Change", __arg1);
        __builder.AddAttribute(__seq2, "Class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591