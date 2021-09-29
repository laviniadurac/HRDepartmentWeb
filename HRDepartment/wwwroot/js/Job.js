var Job = (function () {
    function _buildPageAjax(method, route, bodyData) {
        return $.ajax({
            type: method,
            url: route,
            data: bodyData,
        }
        );
    };

    var DropDownItems = [
      "true",
       "false" 
    ];

    //upload data from db
    function _loadData() {
        $("#jobContainer").dxDataGrid({
            dataSource: jobs,
            keyExpr: "JobId",
            width:1100,
            showRowLines: true,
            showBorders: true,
            headerFilter: {
                visible: true
            },
            filterPanel: {
                visible: true,
                width:100
            },
            filterRow: {
                visible: true
            },
            loadPanel: {
                enabled: true
            },
            focusedRowEnabled: true,
            rowAlternationEnabled: true,
            filterRow: { visible: true },
            paging: {
                pageSize: 10
            },

            pager: {
                visible: true,
                allowedPageSizes: [10, 20, 'all'],
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
                    title: "Job details",
                    showTitle: true,
                    shading: true,
                    shadingColor: "rgb(200,227,236)",
                    resizeEnabled: true,
                    position: "center",
                    width: 500,
                    height: 350
                },

                //fields on pop up
                form: {

                    colCount: 1,
                    items: [
                        {
                            dataField: "JobId",
                            editorOptions:
                            {
                                disabled: true
                            },
                            visible: true
                            
                        },

                        {
                            dataField: "JobName",
                            isRequired: true,
                            colSpan: 2,
                            highlightChanges: true,
                            editorType: "dxTextArea",
                            editorOptions: {
                                height: 50
                            },
                            validationRules: [
                                {
                                    type: "required",
                                    message: "The field is required!"
                                },
                                {
                                    type: "pattern",
                                    pattern: "^[^0-9]+$",
                                    message: "Do not use digits in the Job name!"
                                },
                            ]
                        },


                        {
                            dataField: "IsAvailable",
                            editorType: "dxSelectBox",
                            caption: "Availability",
                            type:"bool",
                            width: 300,
                            editorOptions: {
                                items: DropDownItems,
                                searchEnabled: true,
                                value: ""
                            },
                            validationRules: [{
                                type: "required",
                                message: "The field is required!"
                            }]
                        }


                    ]
                }
            },

            columns: [
                {
                    dataField: "JobId",
                    caption: "Id",
                    alignment: "center",
                    width: 200,
                    allowFiltering: false,
                    cellTemplate: function (element, info) {
                        element.append("<div>" + info.text + "</div>");
                        element.append("<div>").css("font-size", "16px");
                    }
                },
                {
                    dataField: "JobName",
                    caption: "Name",
                    placeholder: "Insert the job name",
                    alignment: "center",
                    width: 400,
                    allowFiltering: true,
                    cellTemplate: function (element, info) {
                        element.append("<div>" + info.text + "</div>");
                        element.append("<div>").css("font-size", "16px");
                    }
                },

                {
                    dataField: "IsAvailable",
                    caption: "Availability",
                    placeholder: "Choose the availability",
                    alignment: "center",
                    width: 350,
                    dataType: "bool",
                    allowFiltering: true,
                    cellTemplate: function (element, info) {
                        element.append("<div>" + info.text + "</div>");
                        element.append("<div>").css("font-size", "16px");
                    }
                },


                {
                    type: "buttons",
                    buttons: ["edit", "delete", {

                        onClick: async function (e) {
                            _buildPageAjax("GET", "/Job/Index", _updatePage);
                        }
                    }
                    ]
                }
            ],

            onRowInserting: function (e) {
                _buildPageAjax("POST", "/Job/AddJob/", { JobName: e.data.JobName, IsAvailable: e.data.IsAvailable });

            },

            onRowUpdated: function (e) {
                _buildPageAjax("POST", "/Job/EditJob/", { JobId: e.data.JobId, JobName: e.data.JobName, IsAvailable: e.data.IsAvailable });
            },

            onRowRemoved: function (e) {
                _buildPageAjax("DELETE", "/Job/Delete/", { JobId: e.data.JobId });
            },


        });
    }

    _loadData();
 

    return {
        buildPage: _buildPageAjax,
        loadData: _loadData
    }

})();
