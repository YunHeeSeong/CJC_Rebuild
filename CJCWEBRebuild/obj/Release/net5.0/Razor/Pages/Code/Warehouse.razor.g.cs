#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "793f549996239aa5df2493e382969c8a6d1dbef8"
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/code/warehouse")]
    public partial class Warehouse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>창고 관리</h1>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"pagelocation\" id=\"menugnb\"><i class=\"fa fa-home\"></i>\r\n    <a href=\"/\">HOME</a>\r\n    > 기준정보관리 >\r\n    <strong>창고관리</strong></div>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h4>창고명 검색</h4>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "search_area");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "fl wd85p");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "class", "w3-input w3-border");
            __builder.AddAttribute(9, "id", "txtWhNm");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                                    txtWhNm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => txtWhNm = __value, txtWhNm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "fr text_right");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "submit");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                                btnSearchClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "검색");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "<h4>창고 관리</h4>\r\n    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                            btnNewClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "신규");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n<br>\r\n<br>");
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
 if (warehouses is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<p><em>Loading ...</em></p>");
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table table-striped");
            __builder.AddMarkupContent(33, "<thead><tr><th>창고코드</th>\r\n                <th>창고명</th>\r\n                <th>창고타입</th>\r\n                <th>창고위치</th>\r\n                <th>수정 및 삭제</th></tr></thead>\r\n        ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 56 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
             foreach (var warehouse in warehouses)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 59 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                         warehouse.WhCd

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 60 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                         warehouse.WhNm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                         warehouse.WhType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 62 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                         warehouse.WhLoc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "id", "btnUpdate");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                                                 ()=>btnUpdateClick(warehouse.WhCd)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "수정");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "id", "btnDelete");
            __builder.AddAttribute(57, "class", "btn btn-danger");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                                                ()=>btnDeleteClick(warehouse.WhCd)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "삭제");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<GMINWEB_CJC.Pages.Common.Confirm>(60);
            __builder.AddAttribute(61, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 72 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(62, (__value) => {
#nullable restore
#line 72 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
                                                                                       DeleteConfirmation = (GMINWEB_CJC.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 73 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    List<Warehouse> model { get; set; }

    public string selectedWhCd { get; set; }
    public string txtWhNm { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    private List<WarehouseModel> warehouses;

    protected override async Task OnInitializedAsync()
    {
        warehouses = await _db.GetData();
    }

    private async Task GetAllDatas()
    {
        warehouses = await _db.GetData();
    }

    async Task btnSearchClick()
    {
        if(txtWhNm != null)
        {
            WarehouseModel warehouseModel = new WarehouseModel
            {
                WhNm = txtWhNm
            };

            warehouses = await _db.GetData(warehouseModel);
        }
    }

    async Task btnNewClick()
    {
        var warehouseEdit = Modal.Show<WarehouseEdit>("창고등록 및 수정");
        var result = await warehouseEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    async Task btnUpdateClick(string whCd)
    {
        var selectedWarehouse = warehouses.FirstOrDefault(x => x.WhCd == whCd);

        var parameters = new ModalParameters();
        parameters.Add(nameof(WarehouseEdit.selectedModel), selectedWarehouse);

        var warehouseEdit = Modal.Show<WarehouseEdit>("창고등록 및 수정", parameters);
        var result = await warehouseEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    void btnDeleteClick(string whCd)
    {
        DeleteConfirmation.Show("삭제하시겠습니까?");

        selectedWhCd = whCd;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if(deleteConfirmed)
        {
            await _db.DeleteData(selectedWhCd);
            await GetAllDatas();
        }
        else
        {
            selectedWhCd = "";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWarehouseData _db { get; set; }
    }
}
#pragma warning restore 1591