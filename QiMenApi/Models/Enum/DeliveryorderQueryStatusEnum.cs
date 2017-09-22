using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace QiMenApi.Models.Enum
{
    public enum DeliveryorderQueryStatusEnum
    {
        [Description("未开始处理")]
        NEW,
        [Description("仓库接单")]
        ACCEPT,
        [Description("部分发货完成")]
        PARTDELIVERED,
        [Description("发货完成")]
        DELIVERED,
        [Description("异常")]
        EXCEPTION,
        [Description("取消")]
        CANCELED,
        [Description("关闭")]
        CLOSED,
        [Description("拒单")]
        REJECT,
        [Description("取消失败")]
        CANCELEDFAIL,
    }
}