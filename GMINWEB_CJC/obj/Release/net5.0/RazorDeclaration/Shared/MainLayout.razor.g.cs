// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Shared\MainLayout.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Shared\MainLayout.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Shared\MainLayout.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Shared\MainLayout.razor"
       

    RadzenSidebar sidebar0;
    RadzenBody body0;
    bool sidebarExpanded = true;
    bool bodyExpanded = false;
    protected override void OnInitialized()
    {
        if (httpContextAccessor != null && httpContextAccessor.HttpContext != null &&
             httpContextAccessor.HttpContext.Request != null && httpContextAccessor.HttpContext.Request.Headers.ContainsKey("User-Agent"))
        {
            var userAgent = httpContextAccessor.HttpContext.Request.Headers["User-Agent"].FirstOrDefault();
            if (!string.IsNullOrEmpty(userAgent))
            {
                if (userAgent.Contains("iPhone") || userAgent.Contains("Android") || userAgent.Contains("Googlebot"))
                {
                    sidebarExpanded = false;
                    bodyExpanded = true;
                }
            }
        }

        menus = MenuService.Menus;

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    }
    IEnumerable<Menu> menus;
    //protected override async Task OnAfterRenderAsync(bool firstRender)
    //{
    //    if (!firstRender)
    //    {
    //        var menus = MenuService.FindCurrent(UriHelper.ToAbsoluteUri(UriHelper.Uri));

    //        await JSRuntime.InvokeVoidAsync("setTitle", MenuService.TitleFor(menus));
    //    }
    //}

    void FilterPanelMenu(ChangeEventArgs args)
    {
        var term = args.Value.ToString();

        menus = MenuService.Filter(term);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> Localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMenuService MenuService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
