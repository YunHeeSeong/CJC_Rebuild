// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Production
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
#line 1 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class WorkEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Production\WorkEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public WorkOrderModel selectedWorkOrder { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }


    private List<WorkModel> workModels;
    private WorkModel workModel = new WorkModel();
    private WorkOrderModel workOrderModel = new WorkOrderModel();

    private List<CommonCodeModel> BadTypeList;

    protected override async Task OnInitializedAsync()
    {
        if (selectedWorkOrder is not null)
        {
            workModel.BizUnit = selectedWorkOrder.BizUnit;
            workModel.FactBizUnit = selectedWorkOrder.FactBizUnit;
            workModel.ItemCd = selectedWorkOrder.ItemCd;
            workModel.ItemNm = selectedWorkOrder.ItemNm;
            workModel.WorkOrderNo = selectedWorkOrder.WorkOrderNo;

            workOrderModel.WorkOrderNo = selectedWorkOrder.WorkOrderNo;
            workOrderModel.Qty = selectedWorkOrder.Qty;


            workModel.WorkPerformDt = DateTime.Today;

            BadTypeList = await _codeManager.FindCommonCodeFromName("불량유형", loginId);
        }
    }

    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }


    async Task btnSaveClick()
    {
        //필수값 체크
        var errMessage = ValidationCheckWork(workModel);

        if (errMessage == string.Empty)
        {
            var result = await _db.InsertData(workModel, loginId);

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


    private string ValidationCheckWork(WorkModel work)
    {
        if (work.OkQty.GetDecimalNullToZero() == 0 && work.BadQty.GetDecimalNullToZero() == 0)
        {
            return "양품수량 또는 불량수량을 입력하여 주십시오";
        }
        if (work.BadQty.GetDecimalNullToZero() > 0 && work.BadType.GetIntNullToZero() == 0)
        {
            return "불량유형을 선택하여 주십시오";
        }
        if (work.BadQty.GetDecimalNullToZero() == 0 && work.BadType.GetIntNullToZero() != 0)
        {
            return "불량수량을 입력하여 주십시오";
        }

        return string.Empty;
    }

    void OnChangeBadType(object value, string name)
    {
        if (value is not null)
        {
            workModel.BadType = (int)value;
        }
    }

    void WorkPerformDtChanged(object value)
    {
        if (value is not null)
        {
            workModel.WorkPerformDt = Convert.ToDateTime(value);
        }
    }

    void OnChangeOKQty(object value)
    {
        if (value is not null)
        {
            workModel.Qty = Convert.ToDecimal(value) + workModel.BadQty.GetDecimalNullToZero();
        }
    }

    void OnChangeBadQty(object value)
    {
        if (value is not null)
        {
            workModel.Qty = Convert.ToDecimal(value) + workModel.OkQty.GetDecimalNullToZero();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkData _db { get; set; }
    }
}
#pragma warning restore 1591
