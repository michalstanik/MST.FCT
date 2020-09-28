(function () {
//Global export
    window.blazorAgGrid = {
        initialize: function (gridDiv) {

            var columnDefs = [
                { headerName: "Airport ID", field: "id", sortable: true, filter: true },
                { headerName: "Name", field: "name", sortable: true, filter: true },
                { headerName: "City", field: "city", sortable: true, filter: true },
                { headerName: "IATA", field: "iata", sortable: true, filter: true },
                { headerName: "ICAO", field: "icao", sortable: true, filter: true }
            ];

            function onSelectionChanged() {
                var selectedRows = gridOptions.api.getSelectedRows();
                if (selectedRows.length === 1) {
                    console.log(selectedRows[0].firstName);
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

            this.gridOptions = gridOptions;
        },
        setRowData: function(rowData) {
            this.gridOptions.api.setRowData(rowData);
        }
    };
})();