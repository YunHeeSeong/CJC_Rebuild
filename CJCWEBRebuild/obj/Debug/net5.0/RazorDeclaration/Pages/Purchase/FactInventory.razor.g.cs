// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_CJC.Pages.Purchase
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Purchase\FactInventory.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Purchase\FactInventory.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Purchase\FactInventory.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Purchase\FactInventory.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FactInventory")]
    public partial class FactInventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Purchase\FactInventory.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 34;     //공장별 재고현황

    ClaimsPrincipal CurrentUser;
    private List<InventoryModel> pditemModels;
    private List<InventoryModel> itemModels;

    private string RoleYN;
    private string loginId;

    protected override async Task OnInitializedAsync()
    {
        //로그인을 한 사용자인지
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            //사용자 정보가 있는지
            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                loginId = CurrentUser.Identity.Name;

                //조회권한이 있는지
                if (RoleYN == "Y")
                {
                    //제품 재고 현황 조회
                    pditemModels = await _db.GetFactPDItemInventory(loginId);

                    //품목 재고 현황 조회
                    itemModels = await _db.GetFactItemInventory(loginId);
                }

            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IInventoryData _db { get; set; }
    }
}
#pragma warning restore 1591
