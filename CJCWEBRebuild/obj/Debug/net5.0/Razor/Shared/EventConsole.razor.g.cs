#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a576a31c02d88970ed54ab4fe0b8d751f94a65"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Shared
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
    public partial class EventConsole : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "console");
            __builder.AddMultipleAttributes(2, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
                                  Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "console-header");
            __builder.AddMarkupContent(5, "<div class=\"console-title\">Console Log</div>\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "console-clear");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
                                                OnClearClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Clear");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "console-content");
            __builder.AddElementReferenceCapture(13, (__value) => {
#nullable restore
#line 8 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
                                       console = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 9 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
         foreach (var message in messages)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "console-message");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "console-message-time");
            __builder.AddContent(18, 
#nullable restore
#line 12 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
                                                    message.Date.ToString("HH:mm:ss.ff")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "console-message-text");
            __builder.AddContent(22, 
#nullable restore
#line 13 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
                                                    message.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Shared\EventConsole.razor"
       
    class Message
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    ElementReference console;

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> Attributes { get; set; }
    IList<Message> messages = new List<Message>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
        {
            await JSRuntime.InvokeVoidAsync("scrollToBottom", console);
        }
    }

    void OnClearClick()
    {
        Clear();
    }

    public void Clear()
    {
        messages.Clear();

        InvokeAsync(StateHasChanged);
    }

    public void Log(string message)
    {
        messages.Add(new Message { Date = DateTime.Now, Text = message });

        InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
