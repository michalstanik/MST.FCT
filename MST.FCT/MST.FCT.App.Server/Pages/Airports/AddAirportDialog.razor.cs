using Microsoft.AspNetCore.Components;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AddAirportDialog : ComponentBase
    {
        public bool ShowDialog { get; set; }

        public void Show()
        {
           // ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
    }
}
