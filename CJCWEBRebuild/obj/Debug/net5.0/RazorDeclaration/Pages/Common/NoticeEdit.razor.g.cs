// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_CJC.Pages.Common
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
#line 1 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\NoticeEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\NoticeEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class NoticeEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "D:\작업장\Desktop\개발 솔루션\cjc관련 파일\CJC\GMINWEB_CJC\Pages\Common\NoticeEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public NoticeModel selectedNoticeCd { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_CJC.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }

    private List<NoticeModel> noticeList;
    private List<CommunityRoleModel> RoleYNList;
    private List<CommonCodeModel> ReadRoleIdList;
    private NoticeModel noticeModel = new NoticeModel();
    private CommunityRoleModel roleModel = new CommunityRoleModel();

    DateTime StartDate;
    DateTime EndDate;

    IEnumerable<int> checkValues = new int[] { };

    protected override async Task OnInitializedAsync()
    {
        //수정일때
        if (selectedNoticeCd is not null)
        {
            noticeList = await _db.GetNotice(loginId, selectedNoticeCd.NoticeCd);
            noticeModel = noticeList.FirstOrDefault();

            StartDate = Convert.ToDateTime(noticeModel.StartDate);
            EndDate = Convert.ToDateTime(noticeModel.EndDate);
        }
        //신규일때
        else
        {
            StartDate = DateTime.Today;
            EndDate = DateTime.Today.AddDays(+7);
            noticeModel.StartDate = DateTime.Today.ToString("yyyy-MM-dd");
            noticeModel.EndDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

        ReadRoleIdList = await _codeManager.FindCommonCodeFromName("게시판권한", loginId);
    }

    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }

    async Task btnSaveClick()
    {
        //필수값 체크
        if (ValidationCheckNotice(noticeModel) == true)
        {
            if (noticeModel.NoticeCd.GetIntNullToZero() == 0)
            {
                await _db.InsertData(noticeModel, loginId);

                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
            else
            {
                await _db.UpdateData(noticeModel, loginId);

                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "제목, 내용, 게시시작일, 게시종료일을 입력하여 주십시오.");
        }
    }
    bool ValidationCheckNotice(NoticeModel noticeModel)
    {
        //필수값 미입력시 false 반환
        if (noticeModel.Title.GetNullToEmpty() == string.Empty || noticeModel.Contents.GetNullToEmpty() == string.Empty || noticeModel.StartDate.GetNullToEmpty() == string.Empty || noticeModel.EndDate.GetNullToEmpty() == string.Empty)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    void StartDateChanged(DateTime? value)
    {
        if (value is not null)
        {
            noticeModel.StartDate = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }

    void EndDateChanged(DateTime? value)
    {
        if (value is not null)
        {
            noticeModel.EndDate = ((DateTime)value).ToString("yyyy-MM-dd");
        }
    }

    void OnChangeReadRoleId(object value, string name)
    {
        noticeModel.ReadRoleId= (int)value;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INoticeData _db { get; set; }
    }
}
#pragma warning restore 1591
