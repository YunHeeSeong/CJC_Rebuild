// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Item
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Item\BOMEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Item\BOMEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Item\BOMEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Item\BOMEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bomEdit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/bomEdit/{loginId}")]
    public partial class BOMEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Item\BOMEdit.razor"
      
    //[Parameter] public string selectedBomCd { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }



    private List<ItemModel> ItemList;
    private List<ItemModel> PartCdList;
    private List<BOMModel> detailModels;
    private List<UserModel> users;

    //private List<CustomerModel> customerList;
    //private List<OrderModel> orderList;
    public BOMModel bomToDelete { get; set; }

    public RoleModel RoleModel = new RoleModel();
    public UserModel UserModel;
    private ItemModel itemModel = new ItemModel();
    //private BOMModel masterModel = new BOMModel();
    //private BOMModel detailModel = new BOMModel();
    RadzenDataGrid<BOMModel> detailGrid;

    private BOMModel bomToInsert;

    

    protected override async Task OnInitializedAsync()
    {
        //코드헬프 - 제품리스트 가져오기
        ItemList = await _db.GetAllItem(loginId);

        //코드헬프 - 원부자재 리스트 가져오기
        PartCdList = await _itemManager.GetAllItemCodeHelp(loginId);


    }

    void btnCancleClick()
    {
        navigationManager.NavigateTo("/BomManagement");
    }

    async Task InsertRow()
    {
        if (itemModel.ItemCd.GetNullToEmpty() == string.Empty)
        {
            await jsRuntime.InvokeVoidAsync("alert", "BOM을 등록할 제품을 먼저 선택하여 주십시오.");
        }
        else
        {
            bomToInsert = new BOMModel();
            bomToInsert.ItemCd = itemModel.ItemCd;
            bomToInsert.BizUnit = itemModel.BizUnit;
            bomToInsert.FactBizUnit = itemModel.FactBizUnit;

            await detailGrid.InsertRow(bomToInsert);
        }
    }

    async Task EditRow(BOMModel bom)
    {
        bomToInsert = bom;

        await detailGrid.EditRow(bom);
    }

    async Task SaveRow(BOMModel bom)
    {
        if (bom == bomToInsert)
        {
            bomToInsert = null;
        }

        if (ValidationCheckBom(bom) == true)
        {
            if (bom.Seq == 0)
            {
                //코드가 채번되기 전이면 INSERT
                await _db.InsertData(bom, loginId);
            }
            else
            {
                //코드가 채번된 후
                await _db.UpdateData(bom, loginId);
            }


        }

        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "자재코드와 대당소요량을 입력하여 주십시오.");
        }


        await detailGrid.UpdateRow(bom);

        detailModels = await _db.GetBOM(itemModel.BizUnit,itemModel.FactBizUnit,itemModel.ItemCd);
    }



    void CancelEdit(BOMModel bom)
    {
        if (bom == bomToInsert)
        {
            bomToInsert = null;
        }

        detailGrid.CancelEditRow(bom);
    }


    async Task DeleteRow(BOMModel bom)
    {
        if (bom == bomToInsert)
        {
            bomToInsert = null;
        }

        //저장 후 삭제일 때 DB 에서 DELETE
        if (detailModels.Contains(bom))
        {
            bomToDelete = bom;
            DeleteConfirmation.Show("삭제하시겠습니까?");
        }
        //저장 전 삭제일 때 GRID UI에서만 삭제
        else
        {
            detailGrid.CancelEditRow(bom);
            await detailGrid.Reload();
        }
    }

    void btnSaveClick()
    {
        navigationManager.NavigateTo("/BomManagement");
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteData(bomToDelete, loginId);
            detailModels = await _db.GetBOM(itemModel.BizUnit,itemModel.FactBizUnit,itemModel.ItemCd);
            await detailGrid.Reload();
        }
        else
        {
            bomToDelete = null;
        }
    }

    bool ValidationCheckBom(BOMModel bom)
    {
        //필수값 미입력시 false 반환
        if (bom.ItemCd.GetNullToEmpty() == string.Empty) return false;
        if (bom.PartCd.GetNullToEmpty() == string.Empty) return false;
        if (bom.ReqQty.GetDecimalNullToZero() == 0) return false;

        return true;
    }

    async Task RowSelect(ItemModel selectedItem)
    {
        //선택한 품목의 bom이 등록되어 있는지 조회
        var bomList = await _db.GetBOM(selectedItem.BizUnit,selectedItem.FactBizUnit,selectedItem.ItemCd);

        //등록되어 있다면 상세내역까지 조회
        detailModels = bomList;

        itemModel.BizUnit = selectedItem.BizUnit;
        itemModel.FactBizUnit = selectedItem.FactBizUnit;
        itemModel.ItemCd = selectedItem.ItemCd;
        itemModel.ItemNm = selectedItem.ItemNm;
    }

    void OnChangePartCd(object value)
    {
        if (value is not null && bomToInsert is not null)
        {
            //bomToInsert.PartCd = ((ItemModel)value).ItemCd;
            bomToInsert.PartNm = ((ItemModel)value).ItemNm;
        }
    }

    void OnChnageReqQty(object value)
    {
        if (value is not null)
        {
            bomToInsert.ReqQty = Convert.ToDecimal(value);
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData RoleData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IItemData _itemManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBOMData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
