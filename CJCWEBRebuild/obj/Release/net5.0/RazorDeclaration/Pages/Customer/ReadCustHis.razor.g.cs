// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_CJC.Pages.Customer
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
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadCustHis")]
    public partial class ReadCustHis : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Customer\ReadCustHis.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public CustHistModel deleteCommonCodeModel { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    public int MenuId = 50;

    ClaimsPrincipal CurrentUser;

    private List<CustomerModel> customerList;
    private List<CustHistModel> selectedCustHistCd;
    private string RoleYN;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _roleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                if (RoleYN == "Y")
                {
                    customerList = await _db.GetAllCustomer(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        customerList = await _db.GetAllCustomer(CurrentUser.Identity.Name);
        selectedCustHistCd = null;
    }

    //async Task btnNewClick()
    //{
    //    var parameters = new ModalParameters();
    //    parameters.Add("loginId", CurrentUser.Identity.Name);

    //    var custHistEdit = Modal.Show<CustHistoryEdit>("이용이력 등록 및 수정", parameters);
    //    var result = await custHistEdit.Result;

    //    if (!result.Cancelled)
    //    {
    //        await GetAllDatas();
    //    }
    //}

    //async Task btnUpdateClick(CustHistModel code)
    //{
    //    var parameters = new ModalParameters();
    //    parameters.Add(nameof(CustHistoryEdit.selectedCustHist), code);
    //    parameters.Add("loginId", CurrentUser.Identity.Name);

    //    var custHistEdit = Modal.Show<CustHistoryEdit>("이용이력 등록 및 수정", parameters);
    //    var result = await custHistEdit.Result;

    //    if (!result.Cancelled)
    //    {
    //        //show
    //        await GetAllDatas();
    //    }
    //}


    void btnDeleteClick(CustHistModel code)
    {
        DeleteConfirmation.Show("삭제 시 고객의 상세 이용이력도 삭제됩니다. 정말 삭제하시겠습니까 ?");

        deleteCommonCodeModel = code;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteMasterData(deleteCommonCodeModel, CurrentUser.Identity.Name);
            await GetAllDatas();
        }
        else
        {
            deleteCommonCodeModel = null;
        }
    }

    public async Task RowSelect(CustomerModel customer)
    {
        selectedCustHistCd = await _db.GetCustHistFromCustomer(CurrentUser.Identity.Name, customer);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustHistData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _roleManager { get; set; }
    }
}
#pragma warning restore 1591