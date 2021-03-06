var Job = (function () {
    function _executeAjax(method, route, bodyData) {
        return $.ajax({
            type: method,
            url: route,
            data: bodyData,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
        }
        );
    };

    function _loadData() {
        $("#futureEmployeeTableContainer").dxDataGrid({
            dataSource: futureEmployees,
            keyExpr: "EmployeeId",
            showRowLines: true,
            showBorders: true,
            rowAlternationEnabled: true,
            filterRow: { visible: true },
            paging: {
                pageSize: 8
            },
            pager: {
                visible: true,
                allowedPageSizes: [5, 10, 'all'],
                showPageSizeSelector: true,
                showInfo: true,
                showNavigationButtons: true
            },
            editing: {
                mode: "popup",
                allowUpdating: true,
                allowDeleting: true,
                allowAdding: false,
                useIcons: true,
            },
            headerFilter: {
                visible: true
            },
            filterPanel: {
                visible: true,
                width: 100
            },
            filterRow: {
                visible: true
            },
            focusedRowEnabled: true,
            filterRow: { visible: true },
            groupPanel: {
                visible: true
            },
            columns: [
                {
                    dataField: "EmployeeId",
                    allowGrouping: true,
                    editorOptions:
                    {
                        disabled: true
                    },
                    alignment: "left",
                    allowFiltering: true,
                    visible: true
                },
                {
                    dataField: "EmployeeName",
                    alignment: "left",
                    allowFiltering: true
                },
                {
                    dataField: "Status",
                    alignment: "left",
                    allowFiltering: true
                },
                {
                    dataField: "JobName",
                    alignment: "left",
                    allowFiltering: true
                },
                {
                    dataField: "Technology",
                    alignment: "left",
                    allowFiltering: true
                },
                {
                    dataField: "Experience",
                    alignment: "left",
                    allowFiltering: true
                }
            ],

            onEditorPreparing: function (e) {
            },
            onEditingStart: function (e) {
            },
            onInitNewRow: function (e) {
            },
            onRowInserted: function (e) {
            },
            onRowUpdating: function (e) {
            },
            onRowUpdated: async function (e) {
            },
            onRowRemoving: function (e) {
            },
            onSaving: function (e) {
            },
            onSaved: function (e) {
            },
            onEditCanceling: function (e) {
            },
            onEditCanceled: function (e) {
            }
        });
    }

    _loadData();

    return {
        executeAjax: _executeAjax,
        loadData: _loadData
    }
})();