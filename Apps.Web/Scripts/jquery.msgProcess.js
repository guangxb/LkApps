//调用 jqObj的extend方法 向jqObj中扩展 函数属性 msgProcess

/*参数 jsonText 格式：
    1.字符串：{"Status":3,"Msg":"验证码错误~","BackUrl":null,"Data":null}
    2.js对象：{Status,Msg,BackUrl,Data}
  参数 funcOk：业务成功时执行的回调函数
  参数 funcNoOk：业务失败时执行的回调函数
*/
function msgProcess(jsonText, funcOk, funcNoOk) {
    var msgObj = null;
    //一、判断格式
    //1.判断 参数 是否为 字符串
    if (typeof (jsonText) == "string") {
        //msgObj = JSON.parse(jsonText);
        try {
            //1.1将字符串 尝试转成 js 对象
            //处理 数组字面量表示法的 json字符串：[{},{}]
            msgObj = eval(jsonText);
        } catch (e) {
            try {
                //处理 对象字面量表示法的 json字符串:{}
                msgObj = eval("(" + jsonText + ")");
            } catch (e1) {
                if (window.msgBoxObj && (msgBoxObj instanceof Function)) {
                    msgBoxObj("格式错误：必须为json格式字符串~！");
                } else {
                    layer.alert("格式错误：必须为json格式字符串~！");
                }
            }
        }
    }
        //2.判断 参数 是否为 规定格式 的 对象
    else {
        //2.1如果 对象 包含 Status，则 认为 其符合 规定的格式
        if (typeof (jsonText.Status) == "undefined") {
            return true;
        } else {
            msgObj = jsonText;//直接将 符合格式的 对象 设置给 msgObj
        }
    }


    //3.根据 服务器返回的 消息状态 进行不同的操作
    switch (msgObj.Status)//根据状态做不同处理
    {
        case 1://ok
            invokeFunc(funcOk, msgObj);
            return doesMsgBox(msgObj);
            break;
        case 2://nook
            invokeFunc(funcNoOk, msgObj);
            return doesMsgBox(msgObj);

            //funcNoOk
            break;
        case 3://nologin
            return doesMsgBox(msgObj);
            break;
        case 4://nopermission
            return doesMsgBox(msgObj);
            break;
        case 5://err
            return doesMsgBox(msgObj);
            break;
    }
}




//二、统一按规则处理消息
//1.判断 是否存在消息框对象
function doesMsgBox(msgObj) {
    if (window.msgBoxObj && (msgBoxObj instanceof Function)) {
        msgBoxObj(msgObj);
    } else {

        if (msgObj.Status != 1) {
            layer.alert(msgObj.Msg, {
                icon: 0,
                skin: 'layer-ext-moon',
                closeBtn: 0,
            }, function () {

                if (typeof (msgObj.BackUrl) == "string" && msgObj.BackUrl) {
                    if (window.top == window) {
                        window.location = msgObj.BackUrl;
                    }
                    else { window.top.location = msgObj.BackUrl; }
                } else {
                    layer.closeAll();
                }
            })
            return false;
        } else { return true };
    }
}
//2.定义 一个 执行回调函数的方法
function invokeFunc(func, msgObj) {
    if (func && func instanceof Function) {
        func(msgObj);//执行回调函数，并把消息对象传给 回调函数
    }
    //如果 没有传入回调函数，则执行默认代码
    //else {
    //    //1.判断消息对象里的 BackUrl 是否为空，如果不空，则跳转到 BackUrl
    //    if (typeof (msgObj.BackUrl) == "string" && msgObj.BackUrl) {
    //        if (window.top == window)
    //            window.location = msgObj.BackUrl;
    //        else window.top.location = msgObj.BackUrl;
    //    }
    //}
}
