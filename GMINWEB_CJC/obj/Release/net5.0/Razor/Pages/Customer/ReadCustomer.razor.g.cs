#pragma checksum "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7823379bbb5516039ad7b00578c492a7081d1ef9"
// <auto-generated/>
#pragma warning disable 1591
namespace GMINWEB_Rebuild.Pages.Customer
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
#line 3 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ReadCustomer")]
    public partial class ReadCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "pagelocation");
            __builder.AddAttribute(2, "id", "menugnb");
            __builder.AddMarkupContent(3, "<i class=\"fa fa-home\"></i>\r\n    ");
            __builder.AddMarkupContent(4, "<a href=\"/\">HOME</a>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(5);
            __builder.AddAttribute(6, "Text", " > 고객관리 > ");
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<strong>고객조회</strong>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 26 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
         if (RoleYN == "Y")
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "<div class=\"info_title\"><h1 class=\"sub_title\">고객 조회</h1></div>\r\n\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "style", "margin-top:45px");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTabs>(16);
                __builder2.AddAttribute(17, "RenderMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TabRenderMode>(
#nullable restore
#line 38 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                            TabRenderMode.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Tabs", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTabsItem>(19);
                    __builder3.AddAttribute(20, "Text", "고객리스트");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenDataGrid<CustomerModel>>(22);
                        __builder4.AddAttribute(23, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "AllowColumnResize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                            FilterMode.Simple

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                         5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CustomerModel>>(
#nullable restore
#line 42 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                                                                          customerModels

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ColumnWidth", "300px");
                        __builder4.AddAttribute(31, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 43 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "LogicalFilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.LogicalFilterOperator>(
#nullable restore
#line 44 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                       LogicalFilterOperator.Or

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(34);
                            __builder5.AddAttribute(35, "Property", "CustomerCd");
                            __builder5.AddAttribute(36, "Title", "고객코드");
                            __builder5.AddAttribute(37, "Width", "130px");
                            __builder5.AddAttribute(38, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(39, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(40);
                            __builder5.AddAttribute(41, "Property", "BizUnitNm");
                            __builder5.AddAttribute(42, "Title", "취급점");
                            __builder5.AddAttribute(43, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(45);
                            __builder5.AddAttribute(46, "Property", "CustomerNm");
                            __builder5.AddAttribute(47, "Title", "고객명");
                            __builder5.AddAttribute(48, "Width", "120px");
                            __builder5.AddAttribute(49, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(50, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(51);
                            __builder5.AddAttribute(52, "Property", "ConsultDt");
                            __builder5.AddAttribute(53, "Title", "상담일자");
                            __builder5.AddAttribute(54, "Width", "150px");
                            __builder5.AddAttribute(55, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(56, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(57);
                            __builder5.AddAttribute(58, "Property", "RankNm");
                            __builder5.AddAttribute(59, "Title", "고객등급");
                            __builder5.AddAttribute(60, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(61, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(62);
                            __builder5.AddAttribute(63, "Property", "Birth");
                            __builder5.AddAttribute(64, "Title", "생년월일");
                            __builder5.AddAttribute(65, "Width", "150px");
                            __builder5.AddAttribute(66, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(67, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(68);
                            __builder5.AddAttribute(69, "Property", "Gender");
                            __builder5.AddAttribute(70, "Title", "성별");
                            __builder5.AddAttribute(71, "Width", "80px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(72, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(73);
                            __builder5.AddAttribute(74, "Property", "PhoneNo");
                            __builder5.AddAttribute(75, "Title", "이동전화");
                            __builder5.AddAttribute(76, "Width", "150px");
                            __builder5.AddAttribute(77, "CssClass", "data_center");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(78, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(79);
                            __builder5.AddAttribute(80, "Property", "Email");
                            __builder5.AddAttribute(81, "Title", "이메일");
                            __builder5.AddAttribute(82, "Width", "150px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(83, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(84);
                            __builder5.AddAttribute(85, "Property", "Remk");
                            __builder5.AddAttribute(86, "Title", "상담내역");
                            __builder5.AddAttribute(87, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(88, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(89);
                            __builder5.AddAttribute(90, "Property", "ZipCode");
                            __builder5.AddAttribute(91, "Title", "우편번호");
                            __builder5.AddAttribute(92, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(93, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(94);
                            __builder5.AddAttribute(95, "Property", "Address");
                            __builder5.AddAttribute(96, "Title", "주소");
                            __builder5.AddAttribute(97, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(98, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(99);
                            __builder5.AddAttribute(100, "Property", "Job");
                            __builder5.AddAttribute(101, "Title", "직업");
                            __builder5.AddAttribute(102, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(103, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(104);
                            __builder5.AddAttribute(105, "Property", "Hobby");
                            __builder5.AddAttribute(106, "Title", "취미");
                            __builder5.AddAttribute(107, "Width", "100px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(108, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(109);
                            __builder5.AddAttribute(110, "Property", "Motive");
                            __builder5.AddAttribute(111, "Title", "방문동기");
                            __builder5.AddAttribute(112, "Width", "200px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(113, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(114);
                            __builder5.AddAttribute(115, "Property", "HairLossType");
                            __builder5.AddAttribute(116, "Title", "탈모유형");
                            __builder5.AddAttribute(117, "Width", "120px");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(118, "\r\n                                        ");
                            __builder5.OpenComponent<Radzen.Blazor.RadzenDataGridColumn<CustomerModel>>(119);
                            __builder5.AddAttribute(120, "Property", "WigExperience");
                            __builder5.AddAttribute(121, "Title", "가발착용경험");
                            __builder5.AddAttribute(122, "Width", "100px");
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
                __builder2.AddMarkupContent(123, "\r\n\r\n\r\n                ");
                __builder2.OpenComponent<GMINWEB_Rebuild.Pages.Common.Confirm>(124);
                __builder2.AddAttribute(125, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                           ConfirmDelete_Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(126, (__value) => {
#nullable restore
#line 77 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
                                                                                                      DeleteConfirmation = (GMINWEB_Rebuild.Pages.Common.Confirm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 81 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(127, "<p>조회 권한이 없는 사용자입니다.</p>");
#nullable restore
#line 85 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(128, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(129, "<p>로그인 후 이용하실 수 있습니다.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJCWEB_Rebuild\CJC\GMINWEB_CJC\Pages\Customer\ReadCustomer.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    [CascadingParameter] private Task<AuthenticationState> authenticationStateTask { get; set; }
    public CustomerModel selectedCustomer { get; set; }
    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }
    public int MenuId = 43;

    ClaimsPrincipal CurrentUser;
    private List<CustomerModel> customerModels;
    private string RoleYN;

    protected override async Task OnInitializedAsync()
    {
        if (authenticationStateTask is not null)
        {
            CurrentUser = (await authenticationStateTask).User;

            if (CurrentUser.Identity.Name is not null)
            {
                var RoleList = await _RoleManager.GetRoleYN(CurrentUser.Identity.Name, MenuId);
                RoleYN = RoleList.FirstOrDefault().ReadWrtYN;

                if (RoleYN == "Y")
                {
                    customerModels = await _db.GetAllCustomers(CurrentUser.Identity.Name);
                }
            }
        }
    }

    private async Task GetAllDatas()
    {
        customerModels = await _db.GetAllCustomers(CurrentUser.Identity.Name);
    }


    async Task btnNewClick()
    {
        //var parameters = new ModalParameters();
        //parameters.Add("loginId", CurrentUser.Identity.Name);

        //var customerEdit = Modal.Show<CustomerEdit>("고객 등록", parameters);
        //var result = await customerEdit.Result;

        //if (!result.Cancelled)
        //{
        //    await GetAllDatas();
        //}

        navigationManager.NavigateTo("/customerEdit" + "/" + CurrentUser.Identity.Name);

    }

    async Task btnUpdateClick(CustomerModel customer)
    {
        //var parameters = new ModalParameters();
        //parameters.Add(nameof(CustomerEdit.selectedCustomer), customer);
        //parameters.Add("loginId", CurrentUser.Identity.Name);

        //var customerEdit = Modal.Show<CustomerEdit>("조직등록 및 수정", parameters);
        //var result = await customerEdit.Result;

        //if (!result.Cancelled)
        //{
        //    await GetAllDatas();
        //}

        navigationManager.NavigateTo("/customerEdit" + "/" + CurrentUser.Identity.Name + "/" + customer.CustomerCd);

    }

    void btnDeleteClick(CustomerModel customer)
    {
        DeleteConfirmation.Show("삭제시 등록된 고객 관련 이미지도 삭제됩니다. 정말 삭제하시겠습니까 ?");

        selectedCustomer = customer;
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _db.DeleteData(selectedCustomer, CurrentUser.Identity.Name);
            await GetAllDatas();
        }
        else
        {
            selectedCustomer = null;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleData _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerData _db { get; set; }
    }
}
#pragma warning restore 1591
