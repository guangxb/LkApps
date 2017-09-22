using Qimen.Api.Response;
using QiMenClient.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntryorderConfirmResponse rsp = EntryorderConfirmManager.InitRequest();
            StockoutConfirmResponse rsp = StockoutConfirmManager.InitRequest();
            //ReturnorderConfirmResponse rsp = ReturnorderConfirmManager.InitRequest();
            //DeliveryorderConfirmResponse rsp = DeliveryorderConfirmManager.InitRequest();
            //Console.WriteLine(rsp.Body);
            //Console.WriteLine(DeliveryorderQueryStatusEnum.NEW.ToString());
            //Console.WriteLine(DeliveryorderQueryStatusEnum.NEW);
            //Console.WriteLine(DeliveryorderQueryStatusEnum.CANCELEDFAIL);
            //Console.WriteLine(AjaxMsgStatu.Ok);
            Console.WriteLine(rsp.Message);
            Console.ReadKey();


        }

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

        public enum AjaxMsgStatu
        {
            /// <summary>
            /// 操作成功
            /// </summary>
            Ok = 1,
            /// <summary>
            /// 操作失败
            /// </summary>
            NoOk = 2,
            /// <summary>
            /// 尚未登陆
            /// </summary>
            NoLogin = 3,
            /// <summary>
            /// 没有访问权限
            /// </summary>
            NoPermission = 4,
            /// <summary>
            /// 异常
            /// </summary>
            Error = 5
        }
    }
}
