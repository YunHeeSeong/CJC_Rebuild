#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97cc24d265164cbfc92fa2f35d0dbe4d7f91d5ef"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Common
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using GMINWEB_Rebuild.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using BlazorFileUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\_Imports.razor"
using System.Resources.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NoticeManagement")]
    public partial class Notice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"pagelocation\" id=\"menugnb\"><i class=\"fa fa-home\"></i>\r\n    <a href=\"/\">HOME</a>\r\n    > 기준정보관리 >\r\n    <strong>공지사항등록</strong></div>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 23 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "info_title");
                __builder2.AddMarkupContent(6, "<h1 class=\"sub_title\">공지사항 등록</h1>\r\n                    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "post_btn");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(9);
                __builder2.AddAttribute(10, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                             btnNewClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "Style", "background-color:black; color:white");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "신규");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(15);
                __builder2.AddAttribute(16, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 33 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                          TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(18);
                    __builder3.AddAttribute(19, "Text", "공지사항리스트");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<NoticeModel>>(21);
                        __builder4.AddAttribute(22, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                            true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                        FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                     5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<NoticeModel>>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                                                      notice

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "ColumnWidth", "300px");
                        __builder4.AddAttribute(30, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                   LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "EmptyText", "조회된 공지사항이 없습니다.");
                        __builder4.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(34);
                            __builder5.AddAttribute(35, "Property", "NoticeCd");
                            __builder5.AddAttribute(36, "Title", "코드");
                            __builder5.AddAttribute(37, "Width", "70px");
                            __builder5.AddAttribute(38, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(39, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(40);
                            __builder5.AddAttribute(41, "Property", "Title");
                            __builder5.AddAttribute(42, "Title", "제목");
                            __builder5.AddAttribute(43, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(45);
                            __builder5.AddAttribute(46, "Property", "Contents");
                            __builder5.AddAttribute(47, "Title", "내용");
                            __builder5.AddAttribute(48, "Width", "600px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(50);
                            __builder5.AddAttribute(51, "Property", "StartDate");
                            __builder5.AddAttribute(52, "Title", "게시시작일");
                            __builder5.AddAttribute(53, "Width", "120px");
                            __builder5.AddAttribute(54, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(55, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(56);
                            __builder5.AddAttribute(57, "Property", "EndDate");
                            __builder5.AddAttribute(58, "Title", "게시종료일");
                            __builder5.AddAttribute(59, "Width", "120px");
                            __builder5.AddAttribute(60, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                                    ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<NoticeModel>>(62);
                            __builder5.AddAttribute(63, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(64, "Title", "수정 및 삭제");
                            __builder5.AddAttribute(65, "Width", "230px");
                            __builder5.AddAttribute(66, "CssClass", "data_center");
                            __builder5.AddAttribute(67, "Template", (Microsoft.AspNetCore.Components.RenderFragment<NoticeModel>)((notice) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(68);
                                __builder6.AddAttribute(69, "Style", "margin: 0 0.5rem 0 0; color: darkblue; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(70, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 48 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                                                                                                                                                  ButtonStyle.Light

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(71, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                                                                                                                                                                            ()=>btnUpdateClick(notice)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(73, "수정");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(74, "\r\n                                            ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(75);
                                __builder6.AddAttribute(76, "Style", "margin: 0 0.5rem 0 0; color: darkred; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(78, "삭제");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n\r\n                ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(80);
                __builder2.AddAttribute(81, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 58 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(82, (__value) => {
#nullable restore
#line 58 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
                                                                                                      DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(83, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 65 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(84, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(85, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\Notice.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    [Parameter] public string loginId { get; set; }

    private NoticeModel noticeModel = new NoticeModel();

    public NoticeModel selectedNoticeCd { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    public int MenuId = 13;
    private string RoleYN;

    ClaimsPrincipal CurrentUser;
    string currentUserBizUnit;

    private List<NoticeModel> notice;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                var userDatas = await _userData.GetUser(CurrentUser.Identity.Name);
                currentUserBizUnit = userDatas.FirstOrDefault().BizUnit;

                //await _db.GetNoticeRole(CurrentUser.Identity.Name);

                if (RoleYN == "Y")
                {
                    notice = await _db.GetNotice(CurrentUser.Identity.Name);

                }
            }

        }
    }

    private async Task GetAllDatas()
    {
        notice = await _db.GetNotice(CurrentUser.Identity.Name);
    }

    async Task btnNewClick()
    {
        var parameters = new ModalParameters();
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var noticeEdit = Modal.Show<NoticeEdit>("공지사항등록 및 수정", parameters);
        var result = await noticeEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }
    }

    async Task btnUpdateClick(NoticeModel noticeCd)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(NoticeEdit.selectedNoticeCd), noticeCd);
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var noticeEdit = Modal.Show<NoticeEdit>("공지사항등록 및 수정", parameters);
        var result = await noticeEdit.Result;

        if (!result.Cancelled)
        {
            await GetAllDatas();
        }

    }

    void btnDeleteClick(NoticeModel noticeCd)
    {
        DeleteConfirmation.Show("정말 삭제하시겠습니까 ?");

        selectedNoticeCd = noticeCd;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var result = await _db.DeleteData(selectedNoticeCd);
            if (result.IsError())
            {
                await jsRuntime.InvokeVoidAsync("alert", result.GetErrorMessages());

            }
            else
            {
                await jsRuntime.InvokeVoidAsync("alert", "처리되었습니다.");

            }
            await GetAllDatas();
        }
        else
        {
            selectedNoticeCd = null;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _userData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoticeData _db { get; set; }
    }
}
#pragma warning restore 1591
