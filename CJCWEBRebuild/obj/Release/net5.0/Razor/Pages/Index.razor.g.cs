#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1715a69b1dfab57f3c4134542bed1eac4b7f4a"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_CJC.Pages
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
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
using GMINWEB_CJC.Model.Github;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
using GMINWEB_CJC.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sdsds")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 10 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
     Localizer["안녕하세요"]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.AddAttribute(7, "style", "position: relative");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-xl-3 col-lg-6 py-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(14, "h2");
                __builder2.AddContent(15, "Closed Issues ");
                __builder2.OpenElement(16, "label");
                __builder2.AddAttribute(17, "style", "color: #cb2431; position: absolute; font-size: 3rem; right: 2rem; top: 1rem");
                __builder2.AddContent(18, 
#nullable restore
#line 16 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                                                                              closedIssues?.Count()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(20);
                __builder2.AddAttribute(21, "style", "width: 100%; height: 200px");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.GMINWEB_CJC.Pages.Index.TypeInference.CreateRadzenColumnSeries_0(__builder3, 23, 24, 
#nullable restore
#line 18 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                              closedIssuesByDate

#line default
#line hidden
#nullable disable
                    , 25, "Count", 26, "Week", 27, "Issues", 28, "#cb2431");
                    __builder3.AddMarkupContent(29, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(30);
                    __builder3.AddAttribute(31, "FormatString", "{0:dd MMM}");
                    __builder3.AddAttribute(32, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                           50

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(34);
                    __builder3.AddAttribute(35, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                 10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLegend>(37);
                    __builder3.AddAttribute(38, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                           false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-xl-3 col-lg-6 py-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(42);
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(44, "h2");
                __builder2.AddContent(45, "All Issues ");
                __builder2.OpenElement(46, "label");
                __builder2.AddAttribute(47, "style", "position: absolute; font-size: 3rem; right: 2rem; top: 1rem");
                __builder2.AddContent(48, 
#nullable restore
#line 27 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                                                           issues?.Count()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenChart>(50);
                __builder2.AddAttribute(51, "style", "width: 100%; height: 200px");
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.GMINWEB_CJC.Pages.Index.TypeInference.CreateRadzenLineSeries_1(__builder3, 53, 54, 
#nullable restore
#line 29 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                            openIssuesByDate

#line default
#line hidden
#nullable disable
                    , 55, "Count", 56, "Week", 57, "Open Issues", 58, 
#nullable restore
#line 29 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
                    , 59, "#28a745");
                    __builder3.AddMarkupContent(60, "\r\n                    ");
                    __Blazor.GMINWEB_CJC.Pages.Index.TypeInference.CreateRadzenLineSeries_2(__builder3, 61, 62, 
#nullable restore
#line 30 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                            closedIssuesByDate

#line default
#line hidden
#nullable disable
                    , 63, "Count", 64, "Week", 65, "Closed Issues", 66, 
#nullable restore
#line 30 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                                                                                           true

#line default
#line hidden
#nullable disable
                    , 67, "#cb2431");
                    __builder3.AddMarkupContent(68, "\r\n                    ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(69);
                    __builder3.AddAttribute(70, "FormatString", "{0:dd MMM}");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col-xl-3 col-lg-6 py-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(74);
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "<h2>Progress</h2>\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenArcGauge>(77);
                __builder2.AddAttribute(78, "style", "width: 100%; height: 200px");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenArcGaugeScale>(80);
                    __builder3.AddAttribute(81, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                              1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                      0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "Y", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                            0.8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(84, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                                         2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenArcGaugeScaleValue>(86);
                        __builder4.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 40 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                                         closeRatio

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(88, "FormatString", "{0:P0}");
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
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-xl-6");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "row");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "col-xl-6");
            __builder.AddMarkupContent(98, "<h3>Show notification</h3>\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(99);
            __builder.AddAttribute(100, "Text", "Show notification");
            __builder.AddAttribute(101, "Style", "margin-bottom: 20px;");
            __builder.AddAttribute(102, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
                                      args => ShowNotification(new NotificationMessage {  Severity = NotificationSeverity.Info, Summary = "Success Summary", Detail = "Success Detail"})

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Index.razor"
       
    IEnumerable<Issue> issues;
    IEnumerable<Issue> openIssues;
    IEnumerable<Issue> closedIssues;

    class IssueGroup
    {
        public int Count { get; set; }
        public DateTime Week { get; set; }
    }

    class LabelGroup
    {
        public int Count { get; set; }
        public string Label { get; set; }
        public string Color { get; set; }
    }

    class UserGroup
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }

    IEnumerable<IssueGroup> openIssuesByDate;
    IEnumerable<IssueGroup> closedIssuesByDate;
    IEnumerable<LabelGroup> labelGroups;
    IEnumerable<UserGroup> openByGroups;
    IEnumerable<User> users;
    IEnumerable<Issue> filteredIssues;
    IEnumerable<string> labels;
    IEnumerable<string> selectedLabels;
    IEnumerable<IssueState> issueStates = Enum.GetValues(typeof(IssueState)).Cast<IssueState>();
    IEnumerable<string> labelColors;
    IssueState selectedState = IssueState.All;
    User mostActiveMember;
    User selectedUser;
    double closeRatio = 0;
    int currentPage = 0;
    int totalPages = 0;
    bool fetchingData = false;
    string error = null;

    //class UserComparer : IEqualityComparer<User>
    //{
    //    public bool Equals(User x, User y)
    //    {
    //        return x.Login.Equals(y.Login);
    //    }

    //    public int GetHashCode(User user)
    //    {
    //        return user.Login.GetHashCode();
    //    }
    //}

    class LabelComparer : IEqualityComparer<Label>
    {
        public bool Equals(Label x, Label y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Label user)
        {
            return user.Name.GetHashCode();
        }
    }

    void FilterIssues()
    {
        filteredIssues = issues.OrderByDescending(issue => issue.CreatedAt);

        if (selectedUser != null)
        {
            //filteredIssues = issues.Where(issue => issue.User.Login == selectedUser.Login);
        }

        if (selectedLabels != null)
        {
            foreach (var selectedLabel in selectedLabels)
            {
                filteredIssues = filteredIssues.Where(issue => issue.Labels.Any(label => label.Name == selectedLabel));
            }
        }

        if (selectedState != IssueState.All)
        {
            filteredIssues = filteredIssues.Where(issue => issue.State == selectedState);
        }
    }

    void OnProgress(FetchProgressEventArgs args)
    {
        currentPage = args.Current;
        totalPages = args.Total;

        StateHasChanged();
    }

    EventConsole console;

    void ShowNotification(NotificationMessage message)
    {
        NotificationService.Notify(message);

       // console.Log($"{message.Severity} notification");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            GitHub.OnProgress += OnProgress;
            fetchingData = true;
            try
            {
                issues = await GitHub.GetIssues(DateTime.Now);
                filteredIssues = issues.OrderByDescending(issue => issue.CreatedAt);
                openIssues = issues.Where(issue => issue.State == IssueState.Open);
                closedIssues = issues.Where(issue => issue.State == IssueState.Closed);

                closeRatio = closedIssues.Count() / (double)issues.Count();

                openIssuesByDate = openIssues.GroupBy(issue => issue.CreatedAt.EndOfWeek())
                        .Select(group => new IssueGroup
                        {
                            Week = group.Key,
                            Count = group.Count()
                        });

                closedIssuesByDate = closedIssues.GroupBy(issue => issue.ClosedAt.Value.EndOfWeek())
                        .Select(group => new IssueGroup
                        {
                            Week = group.Key,
                            Count = group.Count()
                        });

                labels = issues.SelectMany(issue => issue.Labels).Select(label => label.Name).Distinct();

                labelGroups = issues.SelectMany(issue => issue.Labels)
                                    .GroupBy(label => label, new LabelComparer())
                                    .Select(group => new LabelGroup { Label = Regex.Replace(group.Key.Name, ":\\w+:", ""), Color = $"#{group.Key.Color}", Count = group.Count() })
                                    .Where(group => group.Label != "area-blazor")
                                    .OrderByDescending(group => group.Count)
                                    .Take(5);

                labelColors = labelGroups.Select(label => label.Color);

                //openByGroups = issues.GroupBy(issue => issue.User.Login)
                //                    .Select(group => new UserGroup { Name = group.Key, Count = group.Count() })
                //                    .OrderByDescending(group => group.Count)
                //                    .Take(7);

                //mostActiveMember = issues.SelectMany(issue => issue.Assignees)
                //                    .GroupBy(assignee => assignee, new UserComparer())
                //                    .Select(group => new { User = group.Key, Count = group.Count() })
                //                    .OrderByDescending(group => group.Count)
                //                    .Select(group => group.User)
                //                    .First();

                //users = issues.Select(issue => issue.User)
                //            .Distinct(new UserComparer());

                error = null;
                fetchingData = false;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> Localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GitHubService GitHub { get; set; }
    }
}
namespace __Blazor.GMINWEB_CJC.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenColumnSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueProperty", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "Fill", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueProperty", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "Smooth", __arg4);
        __builder.AddAttribute(__seq5, "Stroke", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "ValueProperty", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "Smooth", __arg4);
        __builder.AddAttribute(__seq5, "Stroke", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
