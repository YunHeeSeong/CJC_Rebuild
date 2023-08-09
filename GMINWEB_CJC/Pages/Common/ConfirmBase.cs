using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace GMINWEB_Rebuild.Pages.Common
{
    public class ConfirmBase : ComponentBase
    {
        public bool ShowConfirmation { get; set; }
        public string Message { get; set; }

        public void Show(string message)
        {
            ShowConfirmation = true;
            Message = message;
            StateHasChanged();
        }

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        protected async Task OnConfirmationChange(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
