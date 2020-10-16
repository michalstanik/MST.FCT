(function () {
//Global export
    window.blazorAgGrid = {
        gridOptionsByComponentId: {},
        initialize: function (componentId, gridDiv, dotNetObjectRef) {

            function onSelectionChanged() {
                var selectedRows = gridOptions.api.getSelectedRows();
                if (selectedRows.length === 1) {
                    dotNetObjectRef.invokeMethodAsync("RaiseSelectionChangedAysnc", selectedRows[0]);
                }
            };

            var gridOptions = {
                rowSelection: 'single',
                onSelectionChanged: onSelectionChanged,
                pagination: true,
                paginationAutoPageSize: true,
                suppressCellSelection: true
            };

            new agGrid.Grid(gridDiv, gridOptions);

            this.gridOptionsByComponentId[componentId] = gridOptions;
        },
        setRowData: function (componentId, rowData) {
            this.gridOptionsByComponentId[componentId].api.setRowData(rowData);
        },
        setColumnDefs: function (componentId, columnDefs) {

            this.gridOptionsByComponentId[componentId].api.setColumnDefs(columnDefs);
        },
        dispose: function (componentId) {
            delete this.gridOptionsByComponentId[componentId];
        }
    };
})();