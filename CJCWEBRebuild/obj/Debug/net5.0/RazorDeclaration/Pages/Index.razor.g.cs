// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
