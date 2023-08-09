// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Common
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
#line 1 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\BizUnitFactoryEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\BizUnitFactoryEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class BizUnitFactoryEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 139 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\BizUnitFactoryEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public BizUnitModel selectedBizUnit { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    private List<BizUnitModel> bizUnitList;
    private List<CommonCodeModel> bizTypeList;
    private BizUnitModel bizUnitModel = new BizUnitModel();

    protected override async Task OnInitializedAsync()
    {
        if (selectedBizUnit is not null)
        {
            bizUnitList = await _db.GetBizUnit(loginId,selectedBizUnit.BizUnit);
            bizUnitModel = bizUnitList.FirstOrDefault();
        }

        bizTypeList = await _codeManager.FindCommonCodeFromName("사업장형태",loginId);
        bizUnitModel.BizType = 2;
    }

    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }

    async Task btnSaveClick()
    {
        //필수값 체크
        if (ValidationCheckBizUnit(bizUnitModel) == true)
        {
            if (bizUnitModel.BizUnit.GetNullToEmpty() == string.Empty)
            {
                await _db.InsertData(bizUnitModel, loginId);
                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
            else
            {
                await _db.UpdateData(bizUnitModel, loginId);

                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "사업장명, 사업장위치, 사업장형태를 입력하여 주십시오.");
        }

    }
    bool ValidationCheckBizUnit(BizUnitModel bizUnit)
    {
        //필수값 미입력시 false 반환
        if (bizUnit.BizNm.GetNullToEmpty() == string.Empty || bizUnit.BizType.GetIntNullToZero() == 0 || bizUnit.BizLoc.GetNullToEmpty() == string.Empty )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBizUnitData _db { get; set; }
    }
}
#pragma warning restore 1591
