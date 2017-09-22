using CustomHttpClient.Response;
using QiMenPush.ClienTest.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenPush.ClienTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryorderConfirmResponse rsp = DeliveryorderConfirmManager.InitRequest();
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
    }
}
