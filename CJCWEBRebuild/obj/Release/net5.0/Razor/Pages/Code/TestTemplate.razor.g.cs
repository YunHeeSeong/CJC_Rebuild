#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2a4f62c2686a33219dff702287de98fc941b18"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages.Code
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
using GMINWEB_CJC.Pages.Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid-simple-filter")]
    public partial class TestTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"pagelocation\" id=\"menugnb\"><i class=\"fa fa-home\"></i>\r\n    <a href=\"/\">HOME</a>\r\n    > 기준정보관리 >\r\n    <strong>창고관리</strong></div>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "info_title");
            __builder.AddMarkupContent(4, "<h1 class=\"sub_title\">창고 조회</h1>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "post_btn");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(7);
            __builder.AddAttribute(8, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                 btnNewClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Style", "background-color:black; color:white");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "신규");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
     if (warehouses is null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p><em>Loading ...</em></p>");
#nullable restore
#line 33 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenTabs>(13);
            __builder.AddAttribute(14, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                  TabRenderMode.Client

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabsItem>(16);
                __builder2.AddAttribute(17, "Text", "창고리스트");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataGrid<WarehouseModel>>(19);
                    __builder3.AddAttribute(20, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                FilterMode.Simple

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                             5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WarehouseModel>>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                                                              warehouses

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ColumnWidth", "300px");
                    __builder3.AddAttribute(28, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                           FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                           LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(31);
                        __builder4.AddAttribute(32, "Property", "WhCd");
                        __builder4.AddAttribute(33, "Title", "창고코드");
                        __builder4.AddAttribute(34, "Width", "100px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(36);
                        __builder4.AddAttribute(37, "Property", "WhNm");
                        __builder4.AddAttribute(38, "Title", "창고명");
                        __builder4.AddAttribute(39, "Width", "200px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(40, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(41);
                        __builder4.AddAttribute(42, "Property", "WhType");
                        __builder4.AddAttribute(43, "Title", "창고타입");
                        __builder4.AddAttribute(44, "Width", "120px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(46);
                        __builder4.AddAttribute(47, "Property", "WhLoc");
                        __builder4.AddAttribute(48, "Title", "창고위치");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(49, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(50);
                        __builder4.AddAttribute(51, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(52, "Title", "수정 및 삭제");
                        __builder4.AddAttribute(53, "Width", "230px");
                        __builder4.AddAttribute(54, "Template", (Microsoft.AspNetCore.Components.RenderFragment<WarehouseModel>)((warehouse) => (__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenButton>(55);
                            __builder5.AddAttribute(56, "Style", "margin: 0 1rem 1rem 0");
                            __builder5.AddAttribute(57, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                             ButtonStyle.Light

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(58, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                                                       ()=>btnUpdateClick(warehouse.WhCd)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(60, "수정");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenButton>(62);
                            __builder5.AddAttribute(63, "Style", "margin: 0 1rem 1rem 0; background-color: #375E99;");
                            __builder5.AddAttribute(64, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                                                   ()=>btnDeleteClick(warehouse.WhCd)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(66, "삭제");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(67, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<WarehouseModel>>(68);
                        __builder4.AddAttribute(69, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "Title", "레포트출력");
                        __builder4.AddAttribute(71, "Width", "150px");
                        __builder4.AddAttribute(72, "Template", (Microsoft.AspNetCore.Components.RenderFragment<WarehouseModel>)((warehouse) => (__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenButton>(73);
                            __builder5.AddAttribute(74, "Style", "margin: 0 1rem 1rem 0; background-color:#5C7C8A");
                            __builder5.AddAttribute(75, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                                                 ()=>btnReportClick(warehouse.WhCd)

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(77, "출력");
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
            }
            ));
            __builder.CloseComponent();
            __builder.OpenComponent<GMINWEB_CJC.Pages.Common.Confirm>(78);
            __builder.AddAttribute(79, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                               ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(80, (__value) => {
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
                                                                                          DeleteConfirmation = (GMINWEB_CJC.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 66 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\TestTemplate.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    public string selectedWhCd { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public IList<WarehouseModel> selectedWarehouse { get; set; }

    private List<WarehouseModel> warehouses;

    protected override async Task OnInitializedAsync()
    {
        warehouses = await _db.GetData();

        selectedWarehouse = new List<WarehouseModel>() { warehouses.FirstOrDefault() };
    }

    private async Task GetAllDatas()
    {
        warehouses = await _db.GetData();
    }

    async Task btnNewClick()
    {
        var warehouseEdit = Modal.Show<TestTemplateEdit>("창고등록 및 수정");
        var result = await warehouseEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    async Task btnUpdateClick()
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(TestTemplateEdit.selectedWarehouse), selectedWarehouse[0]);

        var warehouseEdit = Modal.Show<TestTemplateEdit>("창고등록 및 수정", parameters);
        var result = await warehouseEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    async Task btnUpdateClick(string WhCd)
    {
        var selectedWarehouse = warehouses.FirstOrDefault(x => x.WhCd == WhCd);

        var parameters = new ModalParameters();
        parameters.Add(nameof(TestTemplateEdit.selectedWarehouse), selectedWarehouse);

        var warehouseEdit = Modal.Show<TestTemplateEdit>("창고등록 및 수정", parameters);
        var result = await warehouseEdit.Result;

        if (!result.Cancelled)
        {
            //show
            await GetAllDatas();
        }
    }

    async Task btnReportClick(string WhCd)
    {
        string url = "HelloWorld?WhCd=";

        var parameter = new ModalParameters();

        DocumentViewer dv = new DocumentViewer();

        parameter.Add(nameof(dv.ReportUrl), url + WhCd);

        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeIn(1)
            ,
            Position = ModalPosition.Center
        };

        var documentviewer = Modal.Show<DocumentViewer>("View Report", parameter, options);
        var result = await documentviewer.Result;
    }

    void btnDeleteClick(string whCd)
    {
        DeleteConfirmation.Show("삭제하시겠습니까?");

        selectedWhCd = whCd;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteData(selectedWhCd);
            await GetAllDatas();
        }
        else
        {
            selectedWhCd = "";
        }
    }

    void ShowNotification(NotificationMessage message)
    {
        //NotificationService.Notify
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouseData _db { get; set; }
    }
}
#pragma warning restore 1591
