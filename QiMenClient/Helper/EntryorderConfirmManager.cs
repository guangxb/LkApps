using Qimen.Api;
using Qimen.Api.Request;
using Qimen.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenClient.Helper
{
    public class EntryorderConfirmManager
    {
        public static EntryorderConfirmResponse InitRequest()
        {
            string url = "http://qimenapi.tbsandbox.com/router/qimen/service";
            string appkey = "1023883919";
            string secret = "sandboxff0b11ecc626508c171a5b2a2";
            //string customerId = "c1498112555030";
            string customerId = "c1498448349079";
            IQimenClient client = new DefaultQimenClient(url, appkey, secret);
            EntryorderConfirmRequest req = new EntryorderConfirmRequest();
            req.CustomerId = customerId;
            req.Version = "2.0";
            EntryorderConfirmRequest.EntryOrderDomain entryOrder = new EntryorderConfirmRequest.EntryOrderDomain();
            entryOrder.EntryOrderCode = "RK1706300003";
            entryOrder.OwnerCode = "ZK";
            entryOrder.WarehouseCode = "LK01";
            entryOrder.OutBizCode = Guid.NewGuid().ToString("N");
            entryOrder.Status = "FULFILLED";
            req.EntryOrder = entryOrder;

            List<EntryorderConfirmRequest.OrderLineDomain> orderLines = new List<EntryorderConfirmRequest.OrderLineDomain>();

            EntryorderConfirmRequest.OrderLineDomain orderLine= new EntryorderConfirmRequest.OrderLineDomain();
            orderLine.OwnerCode = "ZK";
            orderLine.ItemCode = "1006-1003";
            orderLine.PlanQty = 20;
            orderLine.ActualQty = 20;
            orderLines.Add(orderLine);

            EntryorderConfirmRequest.OrderLineDomain orderLine1 = new EntryorderConfirmRequest.OrderLineDomain();
            orderLine1.OwnerCode = "ZK";
            orderLine1.ItemCode = "1006-1002";
            orderLine1.PlanQty = 20;
            orderLine1.ActualQty = 20;
            orderLines.Add(orderLine1);

            EntryorderConfirmRequest.OrderLineDomain orderLine2 = new EntryorderConfirmRequest.OrderLineDomain();
            orderLine2.OwnerCode = "ZK";
            orderLine2.ItemCode = "1001-1001";
            orderLine2.PlanQty = 10;
            orderLine2.ActualQty = 10;
            orderLines.Add(orderLine2);

            EntryorderConfirmRequest.OrderLineDomain orderLine3 = new EntryorderConfirmRequest.OrderLineDomain();
            orderLine3.OwnerCode = "ZK";
            orderLine3.ItemCode = "1001-1000";
            orderLine3.PlanQty = 10;
            orderLine3.ActualQty = 10;
            orderLines.Add(orderLine3);

            EntryorderConfirmRequest.OrderLineDomain orderLine4 = new EntryorderConfirmRequest.OrderLineDomain();
            orderLine4.OwnerCode = "ZK";
            orderLine4.ItemCode = "1000-0";
            orderLine4.PlanQty = 10;
            orderLine4.ActualQty = 10;
            orderLines.Add(orderLine4);

            req.OrderLines = orderLines;

            return client.Execute(req);
            //EntryorderConfirmResponse rsp = client.Execute(req);
            //Console.WriteLine(rsp.Body);
        }
    }
}
