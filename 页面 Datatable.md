
@{
    ViewBag.Title = "Framwork Log Index ";
    Layout = "~/Views/Shared/_Layout.cshtml";
}


<div class="page-bar">
    <ul class="page-breadcrumb">
        <li>
            <a href="index.html">Home</a>
            <i class="fa fa-circle"></i>
        </li>
        <li>
            <a href="#">日志</a>
            <i class="fa fa-circle"></i>
        </li>
        <li>
            <span>框架日志</span>
        </li>
    </ul>
</div>
<!-- END PAGE BAR -->
<!-- BEGIN PAGE TITLE-->
@*<h3 class="page-title">
        Datatables
        <small>basic datatable samples</small>
    </h3>*@
<!-- END PAGE TITLE-->
<!-- END PAGE HEADER-->
<div class="row">
    <div class="col-md-12">

        <!-- Begin: life time stats -->
        <div class="portlet light portlet-fit portlet-datatable bordered">

            <div class="portlet-body">
                <div class="table-container">
                    <div class="table-actions-wrapper">
                        <span> </span>
                    </div>
                    <table class="table table-striped table-bordered table-hover table-checkable" id="framwork-log-table">
                        <thead>
                            <tr role="row" class="heading">
                                <th width="10%"> ID&nbsp;# </th>
                                <th width="5%"> 创建时间 </th>
                                <th width="5%"> 用户标识 </th>
                                <th width="7%"> 客户端 </th>
                                <th width="10%"> 请求IP </th>
                                <th width="10%"> 请求地址 </th>
                                <th width="10%"> 日志类型 </th>
                                <th width="10%"> 服务器 </th>
                                <th width="10%">性能(ms)</th>
                                <th width="8%">输入数据 </th>
                                <th width="8%">返回数据 </th>
                                <th width="8%">错误信息 </th>
                                <th width="8%">错误堆栈 </th>
                                <th width="8%">Actions </th>
                            </tr>
                            <tr role="row" class="filter">
                                <td width="10%">
                                    <input type="text" class="form-control form-filter input-sm" name="ID">
                                </td>
                                <td width="15%">
                                    <div class="form-group">
                                        <div class="input-group date form_datetime " data-link-field="CreateTimeStart">
                                            <input class="form-control input-sm" size="16" type="text" placeholder="开始时间" readonly>
                                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
                                        </div>
                                        <input type="hidden" class="form-filter" name="CreateTimeStart" id="CreateTimeStart" />
                                    </div>
                                    <div class="form-group">
                                        <div class="input-group date form_datetime" data-link-field="CreateTimeEnd">
                                            <input class="form-control input-sm" size="16" type="text" placeholder="结束时间" readonly>
                                            <span class="input-group-addon btn-sm"><span class="glyphicon glyphicon-remove"></span></span>
                                        </div>
                                        <input type="hidden" class="form-filter" name="CreateTimeEnd" id="CreateTimeEnd" />
                                    </div>
                                    @*<div class="input-group date date-picker margin-bottom-5" data-date-format="yyyy/mm/dd">
                                        <input type="text" class="form-control form-filter input-sm" readonly name="CreateTimeStart" placeholder="From">
                                        <span class="input-group-btn">
                                            <button class="btn btn-sm default" type="button">
                                                <i class="fa fa-calendar"></i>
                                            </button>
                                        </span>
                                    </div>
                                    <div class="input-group date date-picker" data-date-format="yyyy/mm/dd">
                                        <input type="text" class="form-control form-filter input-sm" readonly name="CreateTimeEnd" placeholder="To">
                                        <span class="input-group-btn">
                                            <button class="btn btn-sm default" type="button">
                                                <i class="fa fa-calendar"></i>
                                            </button>
                                        </span>
                                    </div>*@
                                </td>
                                <td width="6%">
                                    <input type="text" class="form-control form-filter input-sm" name="UserIdentify">
                                </td>
                                <td></td>
                                <td>
                                    <input type="text" class="form-control form-filter input-sm" name="IP">
                                </td>

                                <td width="13%">
                                    <input type="text" class="form-control form-filter input-sm" name="Url" placeholder="Url" />
                                </td>
                                <td width="10%">
                                    <select name="LogType" class="form-control form-filter input-sm">
                                        <option value="">---请选择类型--</option>
                                        <option value="1">认证错误</option>
                                        <option value="2">常规请求</option>
                                        <option value="3">内部异常</option>

                                    </select>
                                </td>
                                <td></td>
                                <td width="5%">
                                    <input type="text" class="form-control form-filter input-sm" name="Elapsed" placeholder="大于(>)" />
                                </td>
                                <td width="10%">
                                    <input type="text" class="form-control form-filter input-sm" name="InputData" placeholder="模糊查询(包含)" />
                                </td>
                                <td width="6%"> </td>
                                <td width="6%"> </td>
                                <td width="6%"> </td>
                                <td>
                                    <div class="margin-bottom-5">
                                        <button class="btn btn-sm green btn-outline filter-submit margin-bottom">
                                            <i class="fa fa-search"></i> 查询
                                        </button>
                                    </div>
                                    <button class="btn btn-sm red btn-outline filter-cancel">
                                        <i class="fa fa-times"></i> 重置
                                    </button>
                                </td>
                            </tr>
                        </thead>
                        <tbody> </tbody>
                    </table>
                </div>
            </div>
        </div>
        <!-- End: life time stats -->
    </div>
</div>
<!--格式化json -->
<div class="modal fade" id="json-modal" tabindex="-1" role="dialog" aria-labelledby="json-modal-Label" aria-hidden="true">
    <div class="modal-dialog" style="width: 980px;">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">× </button>
                <h4 class="modal-title" id="json-modal-Label">
                    格式化的数据
                </h4>
            </div>
            <div class="modal-body">
                <pre style="background-color:#ddd;color:#333" id="json-content">
			
				</pre>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default"
                        data-dismiss="modal">
                    关闭
                </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

@*分页请求*@
<script type="text/javascript">


    $(function () {
        $(".form_datetime").datetimepicker({
            language: "zh-CN",
            format: "yyyy/mm/dd hh:ii",
            autoclose: true,
            todayHighlight: 1,
            todayBtn: true,
            initialDate: new Date(),
        });
    });

    var FramworkLogDT = function () {

        var initPickers = function () {
            //init date pickers
            $('.date-picker').datepicker({
                rtl: App.isRTL(),
                autoclose: true
            });
        }

        var handleRecords = function () {

            var grid = new Datatable();

            grid.init({
                src: $("#framwork-log-table"),
                onSuccess: function (grid, response) {
                    // grid:        grid object
                    // response:    json object of server side ajax response
                    // execute some code after table records loaded
                },
                onError: function (grid) {
                    // execute some code on network or other general error
                },
                onDataLoad: function (grid) {
                    // execute some code on ajax data load
                },
                loadingMessage: 'Loading...',
                dataTable: { // here you can define a typical datatable settings from http://datatables.net/usage/options

                    // Uncomment below line("dom" parameter) to fix the dropdown overflow issue in the datatable cells. The default datatable layout
                    // setup uses scrollable div(table-scrollable) with overflow:auto to enable vertical scroll(see: assets/global/scripts/datatable.js).
                    // So when dropdowns used the scrollable div should be removed.
                    "dom": "<'row'<'col-md-8 col-sm-12'pli><'col-md-4 col-sm-12'<'table-group-actions pull-right'>>r>t<'row'<'col-md-8 col-sm-12'pli><'col-md-4 col-sm-12'>>",


                    "bStateSave": true, // save datatable state(pagination, sort, etc) in cookie.


                    "lengthMenu": [
                        [10, 20, 50, 100, 150, -1],
                        [10, 20, 50, 100, 150, "All"] // change per page values here
                    ],
                    "pageLength": 20, // default record count per page
                    "ajax": {
                        "url": "/FramworkLog/GetPageInfo", // ajax source
                    },

                    "columns": [
                        {
                            data: "ID", "orderable": false,"sWidth":"10%",
                            render: function (data) {
                                return '<p style="word-wrap:break-word;">' + data + '</p>';
                            }
                        },
                        {
                            data: "CreateTime", "orderable": false,
                            render: function (data) {
                                return new Date(parseInt(data.substr(6, 13))).toFormate("yyyy/MM/dd HH:mm");
                            }
                        },
                        {
                            data: "UserIdentify", "orderable": false,

                        },
                        {
                            data: "ID", "orderable": false,
                            render: function (data, type, row) {
                                if (row.InputData) {
                                    try {
                                        var inputJson = JSON.parse(row.InputData);
                                        return inputJson.ClientName;
                                    } catch (e) { }
                                }
                                return "";
                            }
                        },
                        {
                            data: "IP", "orderable": false,
                        },
                        {
                            data: "Url", "orderable": false,
                        },
                        {
                            data: "LogType", "orderable": true,
                            render: function (data) {

                                switch (data) {
                                    case 1:
                                        return '<span class="label label-danger"> 认证错误</span>';
                                    case 2:
                                        return '<span class="label label-default"> 正常</span>';
                                    case 3:
                                        return '<span class="label label-danger"> 内部异常</span>';
                                    default:
                                        return data;
                                }
                            }
                        },
                        {
                            data: "CurrentServer", "orderable": false,
                            render: function (data) {
                                var html = '<span>Id:' + data.ID + '</span>';
                                html += '<span> 地址：' + data.InternetIP + '</span>';
                                return html;
                            }
                        },
                        {
                            data: "Elapsed", "orderable": true,
                            render: function (data) {
                                return new Number(data).toFixed(2);
                            }
                        },
                        {
                            data: "InputData", "orderable": false,
                            render: function (data) {
                                if (data == null || data.length == 0) return "";
                                var html = '<a onClick=showJsonContent(this) target="_blank" class="btn btn-xs btn-success"><i class="fa fa-search"></i>详情</a><div  hidden>' + data + '</div>';
                                return html;
                            }
                        },
                        {
                            data: "ResultData", "orderable": false,
                            render: function (data) {
                                if (data == null || data.length == 0) return "*****";
                                var html = '<a onClick=showJsonContent(this) target="_blank" class="btn btn-xs btn-success"><i class="fa fa-search"></i>详情</a><div  hidden>' + data + '</div>';
                                return html;
                            }
                        },
                        {
                            data: "ErrorInfo", "orderable": false,
                            render: function (data) {
                                if (data == null || data.length == 0) return "*****";
                                var html = '<a onClick=showTextContent(this) target="_blank" class="btn btn-xs btn-danger"><i class="fa fa-search"></i>详情</a><div hidden>' + data + '</div>';
                                return html;
                            }
                        },
                        {
                            data: "StackTrace", "orderable": false,
                            render: function (data) {
                                if (data == null || data.length == 0) return "*****";
                                var html = '<a onClick=showTextContent(this) target="_blank" class="btn btn-xs btn-danger"><i class="fa fa-search"></i>详情</a><div  hidden>' + data + '</div>';
                                return html;
                            }
                        },
                        {
                            data: "", "orderable": false,
                            render: function (data) {
                                return '';
                            }
                        }
                    ],

                    "order": [
                        [1, "asc"]
                    ],// set first column as a default sort by asc
                    "language": { // language settings
                        "info": "&nbsp; 列表总数：_TOTAL_"
                    }
                }
            });

            // handle group actionsubmit button click
            grid.getTableWrapper().on('click', '.table-group-action-submit', function (e) {
                e.preventDefault();
                var action = $(".table-group-action-input", grid.getTableWrapper());
                if (action.val() != "" && grid.getSelectedRowsCount() > 0) {
                    grid.setAjaxParam("customActionType", "group_action");
                    grid.setAjaxParam("customActionName", action.val());
                    grid.setAjaxParam("id", grid.getSelectedRows());
                    grid.getDataTable().ajax.reload();
                    grid.clearAjaxParams();
                } else if (action.val() == "") {
                    App.alert({
                        type: 'danger',
                        icon: 'warning',
                        message: 'Please select an action',
                        container: grid.getTableWrapper(),
                        place: 'prepend'
                    });
                } else if (grid.getSelectedRowsCount() === 0) {
                    App.alert({
                        type: 'danger',
                        icon: 'warning',
                        message: 'No record selected',
                        container: grid.getTableWrapper(),
                        place: 'prepend'
                    });
                }
            });

            //grid.setAjaxParam("customActionType", "group_action");
            //grid.getDataTable().ajax.reload();
            //grid.clearAjaxParams();
        }

        return {

            //main function to initiate the module
            init: function () {
                initPickers();
                handleRecords();
            }

        };

    }();
    jQuery(document).ready(function () {
        FramworkLogDT.init();
    });

    function showJsonContent(target) {
        var content = $(target).next().text();
        var jsonFromat = JSON.stringify(JSON.parse(content), null, 2)
        $("#json-content").html(jsonFromat);
        $("#json-modal").modal("show");
    }
    function showTextContent(target) {
        var content = $(target).next("div").text();
        $("#json-content").html(content);
        $("#json-modal").modal("show");
    }
</script>
