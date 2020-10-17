using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AddAirportDialog : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        public bool ShowDialog { get; set; }

        public void Show()
        {
           // ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
    }
}
