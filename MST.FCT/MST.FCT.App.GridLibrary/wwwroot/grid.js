(function () {
//Global export
    window.blazorAgGrid = {
        initialize: function (gridDiv) {

            var columnDefs = [
                { headerName: "Employee ID", field: "employeeId", sortable: true, filter: true },
                { headerName: "Firstname", field: "firstName", sortable: true, filter: true },
                { headerName: "Lastname", field: "lastName", sortable: true, filter: true },
                { headerName: "Email", field: "email", sortable: true, filter: true }
            ];

            var rowData = [
                { employeeId: 1, firstName: "Bethany", lastName: "Smith", email: "bethany@bethanyspieshop.com" },
                { employeeId: 2, firstName: "Julia", lastName: "Developer", email: "julia@thomasclaudiushuber.com" },
                { employeeId: 3, firstName: "Thomas Claudius", lastName: "Huber", email: "thomas@thomasclaudiushuber.com" }
            ];

            function onSelectionChanged() {
                var selectedRows = gridOptions.api.getSelectedRows();
                if (selectedRows.length === 1) {
                    console.log(selectedRows[0].firstName);
                }
            };

            var gridOptions = {
                columnDefs: columnDefs,
                rowData: rowData,
                rowSelection: 'single',
                onSelectionChanged: onSelectionChanged,
                pagination: true,
                paginationAutoPageSize: true,
                suppressCellSelection: true
            };

            new agGrid.Grid(gridDiv, gridOptions);
        }
    };
})();