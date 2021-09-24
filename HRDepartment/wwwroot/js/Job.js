var Job = (function () {
    function _executeAjax(method, route, toDo, bodyData) {
        return $.ajax({
            type: method,
            url: route,
            data: bodyData,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result) {
                if (toDo != null && toDo != undefined) {
                    toDo(result);
                }
            }
        }
        );
    };



    async function _updateDataSource(result) {
        $("#jobContainer").dxDataGrid("option", "dataSource", result);
    }


    function _loadData() {
        $("#jobContainer").dxDataGrid({
            dataSource: jobs,
            keyExpr: "jobId",
            showRowLines: true,
            showBorders: true,
            rowAlternationEnabled: true,
            filterRow: { visible: true },
            paging: {
                pageSize: 5
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
                allowAdding: true,
                useIcons: true,
                popup: {
                    title: "Job Info",
                    showTitle: true,
                    width: 700,
                    height: 500
                },
                //form: {
                //    items: [{
                //        itemType: "group",
                //        colCount: 2,
                //        colSpan: 2,
                //        items: [
                //            {
                //                dataField: "orderId",
                //                editorOptions:
                //                {
                //                    disabled: true
                //                },
                //                visible: false
                //            },



                //            "submitOrderDate",
                //            "totalAmount",
                //            "estimativeDeliveryDate"]
                //    }]
                //}
            },
            columns: [
                {
                    dataField: "jobId",
                    alignment: "left",
                    allowFiltering: false,
                    visible: false
                },
                {
                    dataField: "jobName",
                    alignment: "left",
                    allowFiltering: false
                },

                {
                    dataField: "isAvailable",
                    dataType: "bool",
                    allowFiltering: true
                },
                {
                    type: "buttons",
                    buttons: ["edit", "delete", {



                        onClick: async function (e) {
                            _executeAjax("GET", "/Job/Index", _updateDataSource);
                        }
                    }
                    ]
                }
            ],

            onEditorPreparing: function (e) {
            },
            onEditingStart: function (e) {



            },
            onInitNewRow: function (e) {
            },
            onRowInserting: async function (e) {
                await _executeAjax("POST", "/Job/AddJob/", updateAlerts, JSON.stringify(e.data));
                _executeAjax("GET", "/Job/GetJobs", _updateDataSource);
            },
            onRowInserted: function (e) {



            },
            onRowUpdating: function (e) {



            },
            onRowUpdated: async function (e) {
            },
            onRowRemoving: function (e) {



            },
            onRowRemoved: function (e) {
                _executeAjax("DELETE", "/Job/DeleteJob/", updateAlerts, JSON.stringify(e.data.orderId));
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
    _executeAjax("GET", "/Job/Index", _updateDataSource);



    return {
        updateDataSource: _updateDataSource,
        executeAjax: _executeAjax,
        loadData: _loadData
    }



})();