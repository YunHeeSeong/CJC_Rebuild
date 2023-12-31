// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Code
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using System.Resources.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Code\Warehouse.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }

    List<Warehouse> model { get; set; }

    public string selectedWhCd { get; set; }
    public string txtWhNm { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
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
