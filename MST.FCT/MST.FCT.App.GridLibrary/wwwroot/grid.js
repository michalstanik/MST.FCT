(function () {
//Global export
    window.blazorAgGrid = {
        gridOptionsByComponentId: {},
        initialize: function (componentId, gridDiv, dotNetObjectRef) {

            var columnDefs = [
                { headerName: "Airport ID", field: "id", sortable: true, filter: true },
                { headerName: "Name", field: "name", sortable: true, filter: true },
                { headerName: "Country", field: "countryName", sortable: true, filter: true },
                { headerName: "State", field: "state", sortable: true, filter: true },
                { headerName: "City", field: "city", sortable: true, filter: true },
                { headerName: "IATA", field: "iata", sortable: true, filter: true },
                { headerName: "ICAO", field: "icao", sortable: true, filter: true }
            ];

            function onSelectionChanged() {
                var selectedRows = gridOptions.api.getSelectedRows();
                if (selectedRows.length === 1) {
                    dotNetObjectRef.invokeMethodAsync("RaiseSelectionChangedAysnc", selectedRows[0]);
                }
            };

            var gridOptions = {
                columnDefs: columnDefs,
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
        dispose: function (componentId) {
            delete this.gridOptionsByComponentId[componentId];
        }
    };
})();