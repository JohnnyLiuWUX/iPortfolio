
/**
 * Common.js
 *
 * Create By liya@20191030
 * 
 */


/** ================================== Alert BGEIN ================================== **/

var rc = window.rc || {};
rc.msg = {
    alert: function (message, title, callback) {
        if (title == null) title = "Info";
        rc.msg._show(title,
            message,
            null,
            "alert",
            function (result) {
                if (callback) callback(result);
            });
    },
    confirm: function (message, title, callback) {
        if (title == null) title = "Confirm";
        rc.msg._show(title,
            message,
            null,
            "confirm",
            function (result) {
                if (callback) callback(result);
            });
    },
    _show: function (title, msg, value, type, callback) {
        var html = "";
        html += '<div id="mb_box"></div><div id="mb_con"><span id="mb_tit">' + title + "</span>";
        html += '<div id="mb_msg">' + msg + '</div><div id="mb_btnbox">';
        if (type == "alert") {
            html += '<input id="mb_btn_ok" type="button" value="OK" />';
        }
        if (type == "confirm") {
            html += '<input id="mb_btn_ok" type="button" value="OK" />';
            html += '<input id="mb_btn_no" type="button" value="Cancel" />';
        }
        html += "</div></div>";

        //必须先将_html添加到body，再设置Css样式  
        $("body").append(html);
        rc.msg.initCss();

        switch (type) {
            case "alert":
                $("#mb_btn_ok").click(function () {
                    rc.msg._hide();
                    callback(true);
                });
                $("#mb_btn_ok").focus().keypress(function (e) {
                    if (e.keyCode == 13 || e.keyCode == 27) {
                        $("#mb_btn_ok").trigger("click");
                    }
                });
                break;
            case "confirm":
                $("#mb_btn_ok").click(function () {
                    rc.msg._hide();
                    if (callback) callback(true);
                });
                $("#mb_btn_no").click(function () {
                    rc.msg._hide();
                    if (callback) callback(false);
                });
                $("#mb_btn_no").focus();
                $("#mb_btn_ok, #mb_btn_no").keypress(function (e) {
                    if (e.keyCode == 13) $("#mb_btn_ok").trigger("click");
                    if (e.keyCode == 27) $("#mb_btn_no").trigger("click");
                });
                break;
        }
    },
    _hide: function () {
        $("#mb_box,#mb_con").remove();
    },
    initCss: function () {
        $("#mb_box").css({
            width: "100%",
            height: "100%",
            zIndex: "99999",
            position: "fixed",
            filter: "Alpha(opacity=60)",
            backgroundColor: "black",
            top: "0",
            left: "0",
            opacity: "0.6"
        });

        $("#mb_con").css({
            zIndex: "999999",
            width: "350px",
            height: "200px",
            position: "fixed",
            backgroundColor: "White",
        });

        $("#mb_tit").css({
            display: "block",
            fontSize: "14px",
            color: "#444",
            padding: "10px 15px",
            backgroundColor: "#fff",
            borderRadius: "15px 15px 0 0",
            fontWeight: "bold",
            "border-bottom": "1px solid #ddd"
        });

        $("#mb_msg").css({
            padding: "20px",
            lineHeight: "40px",
            textAlign: "center",
            fontSize: "18px",
            color: "#4c4c4c"
        });

        $("#mb_ico").css({
            display: "block",
            position: "absolute",
            right: "10px",
            top: "9px",
            border: "1px solid Gray",
            width: "18px",
            height: "18px",
            textAlign: "center",
            lineHeight: "16px",
            cursor: "pointer",
            borderRadius: "12px",
            fontFamily: "微软雅黑"
        });

        $("#mb_btnbox").css({ margin: "15px 0px 10px 0", textAlign: "center" });
        $("#mb_btn_ok,#mb_btn_no").css({
            width: "80px",
            height: "30px",
            color: "white",
            border: "none",
            borderRadius: "4px"
        });
        $("#mb_btn_ok").css({ backgroundColor: "#3c8dbc" });
        $("#mb_btn_no").css({ backgroundColor: "gray", marginLeft: "40px" });


        //右上角关闭按钮hover样式  
        $("#mb_ico").hover(function () { $(this).css({ backgroundColor: "Red", color: "White" }); },
            function () { $(this).css({ backgroundColor: "#DDD", color: "black" }); });

        var width = document.documentElement.clientWidth;   //屏幕宽  
        var height = document.documentElement.clientHeight; //屏幕高  

        var boxWidth = $("#mb_con").width();
        var boxHeight = $("#mb_con").height();

        //让提示框居中  
        $("#mb_con").css({ top: (height - boxHeight) / 2 + "px", left: (width - boxWidth) / 2 + "px" });
    }

};

/** ================================== Alert END ================================== **/

/**
 * 异步删除一条记录
 *
 * @ param {{url}}          异步删除的URL
 * @ param {{callback}}     成功回掉函数
 *
 * 删除成功后，当前页面刷新 location.reload()
 */
function DeleteConfirmYes(url, callback) {
    rc.msg.confirm("Confirm Delete?", "Delete", function (result) {
        if (result) {
            $.ajax({
                type: 'POST',
                url: url,
                data: '',
                success: function (data) {
                    if (data.code == 200) {
                        rc.msg.alert("Delete Success", "Delete", function () {
                            if (callback) {
                                callback();
                            } else {
                                location.reload();
                            }
                        });
                    } else {
                        rc.msg.alert(data.msg);
                    }
                },
                dataType: 'json'
            });
        }
    });
}


/**
 * 异步提交表单数据
 *
 * @ param {{url}}          异步提交的URL
 * @ param {{formId}}       表单ID
 * @ param {{callback}}     成功回掉函数
 *
 * 提交成功后，当前页面刷新 location.reload()
 */
function SubmitFormAsync(url, formId, callback) {
    $.ajax({
        type: 'POST',
        url: url,
        data: $("#" + formId).serialize(),
        dataType: 'json',
        success: function (data) {
            if (data.code == 200) {
                rc.msg.alert("Submit Success", "Submit", function () {
                    if (callback) {
                        callback();
                    } else {
                        location.reload();
                    }
                });
            } else {
                rc.msg.alert(data.msg);
            }
        }
    });
}

/**
 * 异步提交表单数据
 *
 * @ param {{url}}          异步提交的URL
 * @ param {{callback}}     成功回掉函数
 *
 * 提交成功后，调用 callback
 */
function SubmitUrlAsync(url, callback) {
    $.ajax({
        type: 'POST',
        url: url,
        data: '',
        dataType: 'json',
        success: function (data) {
            if (data.code == 200) {
                if (callback) {
                    callback();
                }
            } else {
                rc.msg.alert(data.msg);
            }
        }
    });
}