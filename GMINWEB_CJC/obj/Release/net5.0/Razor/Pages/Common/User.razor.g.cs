#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dea865fde41204b61e8192a1ac1bde98c9fc1db"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Common
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserManagment")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"pagelocation\" id=\"menugnb\"><i class=\"fa fa-home\"></i>\r\n    <a href=\"/\">HOME</a>\r\n    > 기준정보관리 >\r\n    <strong>사용자등록</strong></div>\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 23 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "div");
                __builder2.AddMarkupContent(4, "<div class=\"info_title\"><h1 class=\"sub_title\">사용자 등록</h1></div>\r\n\r\n                ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(7);
                __builder2.AddAttribute(8, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 31 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                            TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(10);
                    __builder3.AddAttribute(11, "Text", "사용자 리스트");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<UserModel>>(13);
                        __builder4.AddAttribute(14, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 35 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                            FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 35 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                         5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(18, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<UserModel>>(
#nullable restore
#line 35 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                                          userList

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "ColumnWidth", "300px");
                        __builder4.AddAttribute(22, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 36 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 37 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                       LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "EmptyText", "조회된 사용자가 없습니다.");
                        __builder4.AddAttribute(25, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(26);
                            __builder5.AddAttribute(27, "Property", "UserCd");
                            __builder5.AddAttribute(28, "Title", "사용자코드");
                            __builder5.AddAttribute(29, "Width", "100px");
                            __builder5.AddAttribute(30, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                                       false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(31, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(32);
                            __builder5.AddAttribute(33, "Property", "UserNm");
                            __builder5.AddAttribute(34, "Title", "사용자명");
                            __builder5.AddAttribute(35, "Width", "100px");
                            __builder5.AddAttribute(36, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(37, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(38);
                            __builder5.AddAttribute(39, "Property", "LoginId");
                            __builder5.AddAttribute(40, "Title", "아이디");
                            __builder5.AddAttribute(41, "Width", "230px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(42, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(43);
                            __builder5.AddAttribute(44, "Property", "BizNm");
                            __builder5.AddAttribute(45, "Title", "사업장명");
                            __builder5.AddAttribute(46, "Width", "180px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(48);
                            __builder5.AddAttribute(49, "Property", "GroupNm");
                            __builder5.AddAttribute(50, "Title", "부서명");
                            __builder5.AddAttribute(51, "Width", "80px");
                            __builder5.AddAttribute(52, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(53, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(54);
                            __builder5.AddAttribute(55, "Property", "PhoneNo");
                            __builder5.AddAttribute(56, "Title", "핸드폰번호");
                            __builder5.AddAttribute(57, "Width", "200px");
                            __builder5.AddAttribute(58, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(59, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(60);
                            __builder5.AddAttribute(61, "Property", "Email");
                            __builder5.AddAttribute(62, "Title", "이메일");
                            __builder5.AddAttribute(63, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(64, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(65);
                            __builder5.AddAttribute(66, "Property", "RoleNm");
                            __builder5.AddAttribute(67, "Title", "권한");
                            __builder5.AddAttribute(68, "Width", "180px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(69, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(70);
                            __builder5.AddAttribute(71, "Property", "HireDate");
                            __builder5.AddAttribute(72, "Title", "입사일자");
                            __builder5.AddAttribute(73, "Width", "180px");
                            __builder5.AddAttribute(74, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(75, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<UserModel>>(76);
                            __builder5.AddAttribute(77, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                            false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(78, "Title", "수정 및 삭제");
                            __builder5.AddAttribute(79, "Width", "230px");
                            __builder5.AddAttribute(80, "CssClass", "data_center");
                            __builder5.AddAttribute(81, "Template", (Microsoft.AspNetCore.Components.RenderFragment<UserModel>)((user) => (__builder6) => {
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(82);
                                __builder6.AddAttribute(83, "Style", "margin: 0 0.5rem 0 0; color: darkblue; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(84, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                                                                                                                                      ButtonStyle.Light

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(85, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                                                                                                                                                                ()=>btnUpdateClick(user)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(87, "수정");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(88, "\r\n                                                ");
                                __builder6.OpenComponent<Radzen.Blazor.RadzenButton>(89);
                                __builder6.AddAttribute(90, "Style", "margin: 0 0.5rem 0 0; color: darkred; font-weight: bold; background-color: transparent; font-size: 20px; padding-left: 15px; padding-right: 15px;");
                                __builder6.AddAttribute(91, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                                                                                                                                               ()=>btnDeleteClick(user)

#line default
#line hidden
#nullable disable
                                )));
                                __builder6.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(93, "삭제");
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
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n                ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(95);
                __builder2.AddAttribute(96, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(97, (__value) => {
#nullable restore
#line 61 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
                                                                                                      DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 64 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(98, "<p>권한이 없는 사용자입니다.</p>");
#nullable restore
#line 68 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(99, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(100, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Common\User.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public UserModel selectedUser { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    public int MenuId = 1;

    ClaimsPrincipal CurrentUser;

    private List<UserModel> userList;
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
                    userList = await _db.GetAllUsers(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        userList = await _db.GetAllUsers(CurrentUser.Identity.Name);
    }

    async Task btnUpdateClick(UserModel user)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(UserEdit.selectedUser), user);
        parameters.Add("loginId", CurrentUser.Identity.Name);

        var roleEdit = Modal.Show<UserEdit>("사용자 정보 수정", parameters);
        var result = await roleEdit.Result;

        if (!result.Cancelled)
        {
            //show
            await GetAllDatas();
        }
    }


    void btnDeleteClick(UserModel user)
    {
        DeleteConfirmation.Show("정말 삭제하시겠습니까 ?");

        selectedUser = user;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteUser(selectedUser);
            await GetAllDatas();
        }
        else
        {
            selectedUser = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _db { get; set; }
    }
}
#pragma warning restore 1591