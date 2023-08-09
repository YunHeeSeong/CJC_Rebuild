// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace GMINWEB_Rebuild.Pages.Common
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 14 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\_Imports.razor"
using Radzen.Blazor;

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
#line 1 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\GroupEdit.razor"
using GMINWEB_Rebuild.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\GroupEdit.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\GroupEdit.razor"
using DataAccessLibrary.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\GroupEdit.razor"
using DataAccessLibrary.Data;

#line default
#line hidden
#nullable disable
    public partial class GroupEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Rebuild_CJC\CJC\GMINWEB_CJC\Pages\Common\GroupEdit.razor"
       

    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [Parameter] public GroupModel selectedGroup { get; set; }
    [Parameter] public string loginId { get; set; }

    public GMINWEB_Rebuild.Pages.Common.ConfirmBase DeleteConfirmation { get; set; }


    private List<FileModel> fileModels;
    public FileModel selectedFile { get; set; }
    private GroupModel groupModel = new GroupModel();

    RadzenDataGrid<FileModel> detailGrid;
    private List<CommonCodeModel> DetailClsList;

    private FileModel fileModelToInsert;
    private FileModel fileModelToDelete;

    string imgSrc = "";
    IFileListEntry file = null;
    byte[] _fileBytes = null;

    protected override async Task OnInitializedAsync()
    {
        if (selectedGroup is not null)
        {
            groupModel.BizUnit = selectedGroup.BizUnit;
            groupModel.GroupCd = selectedGroup.GroupCd;
            groupModel.GroupNm = selectedGroup.GroupNm;
            groupModel.GroupType = selectedGroup.GroupType;
            groupModel.ParentGCd = selectedGroup.ParentGCd;
            groupModel.DispSeq = selectedGroup.DispSeq;

            fileModels = await _db.GetFile(groupModel.GroupCd, loginId);
        }

        DetailClsList = await _codeManager.FindCommonCodeFromName("조직관련파일", loginId);

    }

    void OnChangeDetailCls(object value, string name)
    {
        if (value is not null && fileModelToInsert is not null)
        {
            fileModelToInsert.DetailCls = ((CommonCodeModel)value).CodeSeq;
            fileModelToInsert.DetailClsNm = ((CommonCodeModel)value).CodeSubNm;

        }
    }

    void btnCancleClick()
    {
        ModalInstance.CancelAsync();
    }

    async Task InsertRow()
    {
        if (groupModel.GroupCd != 0)
        {
            fileModelToInsert = new FileModel();
            fileModelToInsert.GroupCd = groupModel.GroupCd;
            fileModelToInsert.FileCls = 1; // 부서 정보 파일

            await detailGrid.InsertRow(fileModelToInsert);
        }

        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "파일 업로드는 조직 정보 저장 후 등록할 수 있습니다.");
            //ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Warning, Summary = "!경고!", Detail = "파일 업로드는 조직 정보 저장 후 등록할 수 있습니다." });
        }
    }

    async Task EditRow(FileModel file)
    {
        fileModelToInsert = file;

        await detailGrid.EditRow(file);
    }

    async Task SaveRow(FileModel file)
    {
        if (file == fileModelToInsert)
        {
            fileModelToInsert = null;
        }

        if (ValidationCheckFile(file) == true)
        {
            if (file.FileNo == 0)
            {
                //파일넘버가 채번되기 전이면 INSERT 
                await _fileManager.InsertData(file, loginId);
            }
            else
            {
                //파일넘버가 기존에 존재하면 UPDATE
                await _fileManager.UpdateData(file, loginId);
            }
            await detailGrid.UpdateRow(file);
            fileModels = await _db.GetFile(groupModel.GroupCd, loginId);
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "파일 종류와 파일을 선택하여 주십시오.");
        }
    }

    void CancelEdit(FileModel file)
    {
        if (file == fileModelToInsert)
        {
            fileModelToInsert = null;
        }

        detailGrid.CancelEditRow(file);
    }

    async Task DeleteRow(FileModel file)
    {
        if (file == fileModelToInsert)
        {
            fileModelToInsert = null;
        }

        //저장 후 삭제일 때 DB 에서 DELETE 
        if (fileModels.Contains(file))
        {
            selectedFile = file;
            DeleteConfirmation.Show("삭제하시겠습니까?");
        }
        //저장 전 삭제일 때 GRID UI에서만 삭제
        else
        {
            detailGrid.CancelEditRow(file);
            await detailGrid.Reload();
        }
    }

    public async Task HandleFileSelected(IFileListEntry[] files)
    {
        if (files.Count() > 0)
        {
            file = files.FirstOrDefault();
            using (var ms = new MemoryStream())
            {
                await file.Data.CopyToAsync(ms);
                _fileBytes = ms.ToArray();

                fileModelToInsert.FileNm = file.Name;
                fileModelToInsert.FileType = file.Type;
                fileModelToInsert.FileData = Convert.ToBase64String(_fileBytes);
            }
        }
    }


    void btnDownloadFile(FileModel file)
    {
        var fileArr = Convert.FromBase64String(file.FileData);
        jsRuntime.InvokeVoidAsync("DownloadAsFile", file.FileNm, file.FileType, fileArr);
    }

    async Task btnSaveClick()
    {
        //필수값 체크
        if (ValidationCheckGroup(groupModel) == true)
        {
            if (groupModel.GroupCd == 0)
            {
                await _db.InsertData(groupModel, loginId);
                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
            else
            {
                await _db.UpdateData(groupModel,loginId);

                await ModalInstance.CloseAsync(ModalResult.Ok("Form was submitted successfully."));
            }
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("alert", "조직명을 입력하여 주십시오.");
        }

    }

    void ShowNotification(NotificationMessage message)
    {
        NotificationService.Notify(message);
    }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            await _fileManager.DeleteData(selectedFile, loginId);
            fileModels = await _db.GetFile(groupModel.GroupCd, loginId);
            await detailGrid.Reload();
        }
        else
        {
            selectedFile = null;
        }
    }

    bool ValidationCheckFile(FileModel file)
    {
        //필수값 미입력시 false 반환
        if (file.FileNm is null || file.FileData is null || file.FileType is null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    bool ValidationCheckGroup(GroupModel group)
    {
        //필수값 미입력시 false 반환
        if (group.GroupNm is null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileData _fileManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGroupData _db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICommonCodeData _codeManager { get; set; }
    }
}
#pragma warning restore 1591