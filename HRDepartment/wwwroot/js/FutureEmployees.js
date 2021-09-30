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
            columns: [
                {
                    dataField: "EmployeeId",
                    editorOptions:
                    {
                        disabled:true
                    },
                    alignment: "left",
                    allowFiltering: false,
                    visible: true
                },
                {
                    dataField: "EmployeeName",
                    alignment: "left",
                    allowFiltering: false
                },
                {
                    dataField: "Status",
                    alignment: "left",
                    allowFiltering: false
                },
                {
                    dataField: "JobName",
                    alignment: "left",
                    allowFiltering: false
                },
                {
                    dataField: "Technology",
                    alignment: "left",
                    allowFiltering: false
                },
                {
                    dataField: "Experience",
                    alignment: "left",
                    allowFiltering: false
                }
                //{
                //    type: "buttons",
                //    buttons: ["edit", "delete", {



                //        onClick: async function (e) {
                //            _executeAjax("GET", "/Job/Index", _updateDataSource);
                //        }
                //    }
                //    ]
                //}
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
            //onRowRemoved: function (e) {
            //    _executeAjax("DELETE", "/Job/DeleteJob/", JSON.stringify(e.data.EmployeeId));
            //},
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