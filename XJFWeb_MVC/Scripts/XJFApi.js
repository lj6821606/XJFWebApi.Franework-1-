var apiurl = "http://localhost:50230/api";
//验证文本格式内容是否输入
function GetValiTxt(obj, Txt) {
    if (obj == undefined || obj == null || obj == "") {
        $.toast("请输入" + Txt, "cancel");
        $(obj).focus();
        return false;
    }
    return true;
}
//邮箱格式验证
function GetValiEmail(obj) {
    var reg = new RegExp("^[a-z0-9]+([._\\-]*[a-z0-9])*@([a-z0-9]+[-a-z0-9]*[a-z0-9]+.){1,63}[a-z0-9]+$"); //正则表达式
    //var szReg = /^([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[_|\_|\.]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,3}$/;
    if (!reg.test(obj)) {
        $.toast("请输入有效邮箱！", "cancel");
        return false;
    }
    return true;
};
//手机格式验证
function GetValiMobile(obj) {
    var phoneNumReg = /(^[0-9]{3,4}\-[0-9]{7}$)|(^[0-9]{7}$)|(^[0-9]{3,4}[0-9]{7}$)|(^0{0,1}13[0-9]{9}$)/;
    if (!phoneNumReg.test(obj)) {
        $.toast("手机号码错误！", "cancel");
        return false;
    }
    return true;
}
//角色api start
var GetListsXJFRole = function (pagesize, pagenum) {
    $.ajax({
        type: "Post",
        dataType: "Json",
        async: "false",
        url: apiurl + "/Role/GetList",
        data: {
            PageSize: pagesize,
            PageNum: pagenum,
            Data: {

            }
        },
        success: function (result) {
            console.log(result);
            if (result.Code != "200") {
                $.toast(result.Message, "cancel");
            }
            successGet(result);
            return result;
            
        },
        error: function (result) {
            $.toast("服务器异常!", "cancel");
            return null;
        }
    });
}
//角色api end

//管理员 start
var GetListXJFAdmin = function (pagesize, pagenum) {
    $.ajax({
        type: "Post",
        dataType: "Json",
        async: "false",
        url: apiurl + "/XJFAdmin/GetList",
        data: {
            PageSize: pagesize,
            PageNum: pagenum,
            Data: {

            }
        },
        success: function (result) {
            console.log(result);
            if (result.Code != "200") {
                $.toast(result.Message, "cancel");
                //alert(result.Message);
                //return result;
            }
            return result;
        },
        error: function (result) {
            $.toast("服务器异常!", "cancel");
            return null;
        }
    });
}
var addXJFAdmin = function (obj) {
    $.ajax({
        type: "Post",
        dataType: "Json",
        async: "false",
        url: apiurl + "/XJFAdmin/AddXJFAdmin",
        data: obj,
        success: function (result) {
            console.log(result);
            if (result.Code != "200") {
                $.toast(result.CodeInfo, "cancel");
            }
            $.toast(result.CodeInfo, "success");
            return result;
        },
        error: function (result) {
            $.toast("服务器异常!", "cancel");
            return result;
        }
    });
}
//管理员 end

