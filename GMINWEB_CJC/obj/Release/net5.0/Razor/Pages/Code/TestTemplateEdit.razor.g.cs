#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe9bd0ba5aaee448b18709d9ce6a20918688d46"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Code
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
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class TestTemplateEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    form .row {\r\n        margin-bottom: 16px;\r\n    }\r\n</style>\r\n\r\n");
            __Blazor.GMINWEB_Rebuild.Pages.Code.TestTemplateEdit.TypeInference.CreateRadzenTemplateForm_0(__builder, 1, 2, 
#nullable restore
#line 13 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                          newWarehouse

#line default
#line hidden
#nullable disable
            , 3, (context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-md");
                __builder2.OpenComponent<Radzen.Blazor.RadzenFieldset>(8);
                __builder2.AddAttribute(9, "Text", "창고 정보");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "row");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "col-md-4 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(15);
                    __builder3.AddAttribute(16, "Text", "창고코드");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n                    ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "col-md-8");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(20);
                    __builder3.AddAttribute(21, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "Placeholder", "자동채번");
                    __builder3.AddAttribute(23, "Style", "width:100%;");
                    __builder3.AddAttribute(24, "Name", "WhCd");
                    __builder3.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                                                        newWarehouse.WhCd

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWarehouse.WhCd = __value, newWarehouse.WhCd))));
                    __builder3.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWarehouse.WhCd));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n                ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "row");
                    __builder3.OpenElement(31, "div");
                    __builder3.AddAttribute(32, "class", "col-md-4 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(33);
                    __builder3.AddAttribute(34, "Text", "창고명");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n                    ");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "class", "col-md-8");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(38);
                    __builder3.AddAttribute(39, "Style", "width:100%;");
                    __builder3.AddAttribute(40, "Name", "WhCd");
                    __builder3.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                     newWarehouse.WhNm

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWarehouse.WhNm = __value, newWarehouse.WhNm))));
                    __builder3.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWarehouse.WhNm));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n                ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "row");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-4 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(49);
                    __builder3.AddAttribute(50, "Text", "창고타입");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n                    ");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "col-md-8");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(54);
                    __builder3.AddAttribute(55, "Style", "width:100%;");
                    __builder3.AddAttribute(56, "Name", "WhCd");
                    __builder3.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                     newWarehouse.WhType

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWarehouse.WhType = __value, newWarehouse.WhType))));
                    __builder3.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWarehouse.WhType));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n                ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "row");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "class", "col-md-4 align-items-center d-flex");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(65);
                    __builder3.AddAttribute(66, "Text", "창고위치");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col-md-8");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(70);
                    __builder3.AddAttribute(71, "Style", "width:100%;");
                    __builder3.AddAttribute(72, "Name", "WhCd");
                    __builder3.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                     newWarehouse.WhLoc

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newWarehouse.WhLoc = __value, newWarehouse.WhLoc))));
                    __builder3.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newWarehouse.WhLoc));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(78);
                __builder2.AddAttribute(79, "style", "margin: 0 1rem 1rem 60px");
                __builder2.AddAttribute(80, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                    ButtonStyle.Light

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                              btnCancleClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(83, "취소");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(85);
                __builder2.AddAttribute(86, "style", "margin: 0 1rem 1rem 0");
                __builder2.AddAttribute(87, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                 ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
                                                                                               btnSaveClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(90, "저장");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Code\TestTemplateEdit.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public WarehouseModel selectedWarehouse { get; set; }

    public Warehouse warehouse { get; set; }

    private DisplayWarehouseModel newWarehouse = new DisplayWarehouseModel();

    protected override void OnInitialized()
    {
        if (selectedWarehouse is not null)
        {
            newWarehouse.WhCd = selectedWarehouse.WhCd;
            newWarehouse.WhNm = selectedWarehouse.WhNm;
            newWarehouse.WhType = selectedWarehouse.WhType;
            newWarehouse.WhLoc = selectedWarehouse.WhLoc;
        }
    }

    async Task btnSaveClick()
    {
        WarehouseModel model = new WarehouseModel
        {
            WhNm = newWarehouse.WhNm,
            WhType = newWarehouse.WhType,
            WhLoc = newWarehouse.WhLoc
        };

        if (newWarehouse.WhCd is null)
        {
            await _db.InsertData(model);
            await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
        }
        else
        {
            model.WhCd = newWarehouse.WhCd;
            await _db.UpdateData(model);

            await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
        }
    }

    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouseData _db { get; set; }
    }
}
namespace __Blazor.GMINWEB_Rebuild.Pages.Code.TestTemplateEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenTemplateForm_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext> __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenTemplateForm<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591