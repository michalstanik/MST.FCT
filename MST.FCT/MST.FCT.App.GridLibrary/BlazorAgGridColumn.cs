using Microsoft.AspNetCore.Components;
using System;

namespace MST.FCT.App.GridLibrary
{
    public class BlazorAgGridColumn : ComponentBase, IDisposable
    {
        private readonly ColumnDefinition _columnDef = new ColumnDefinition();

        [Parameter] public string HeaderName { get; set; }
        [Parameter] public string Field { get; set; }
        [Parameter] public bool Sortable { get; set; }
        [Parameter] public bool Filter { get; set; }
        [Parameter] public string HtmlStyle { get; set; }

        protected override void OnParametersSet()
        {
            _columnDef.HeaderName = HeaderName;
            _columnDef.Field = Field;
            _columnDef.Sortable = Sortable;
            _columnDef.Filter = Filter;
            _columnDef.HtmlStyle = HtmlStyle;
        }

        [CascadingParameter]
        public IBlazorAgGrid ParentGrid { get; set; }

        protected override void OnInitialized()
        {
            ParentGrid.ColumnDefs.Add(_columnDef);
        }

        public void Dispose()
        {
            ParentGrid.ColumnDefs.Remove(_columnDef);
        }
    }
}
