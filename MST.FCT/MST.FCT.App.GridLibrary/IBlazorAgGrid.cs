using System.Collections.Generic;

namespace MST.FCT.App.GridLibrary
{
    public interface IBlazorAgGrid
    {
        IList<ColumnDefinition> ColumnDefs { get; }
    }
}
