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
    public class ReturnorderConfirmManager
    {
        public static ReturnorderConfirmResponse InitRequest()
        {
            string url = "http://qimenapi.tbsandbox.com/router/qimen/service";
            string appkey = "1023883919";
            string secret = "sandboxff0b11ecc626508c171a5b2a2";
            //string customerId = "c1498112555030";
            string customerId = "c1498448349079";
            IQimenClient client = new DefaultQimenClient(url, appkey, secret);
            ReturnorderConfirmRequest req = new ReturnorderConfirmRequest();
            req.CustomerId = customerId;
            req.Version = "2.0";

            ReturnorderConfirmRequest.ReturnOrderDomain returnOrder = new ReturnorderConfirmRequest.ReturnOrderDomain();
            ReturnorderConfirmRequest.OrderLineDomain orderLine = new ReturnorderConfirmRequest.OrderLineDomain();
            List<ReturnorderConfirmRequest.OrderLineDomain> orderLines = new List<ReturnorderConfirmRequest.OrderLineDomain>();

            returnOrder.ReturnOrderCode = "RK1707040006";
            returnOrder.WarehouseCode = "LK01";
            returnOrder.LogisticsCode = "";

            orderLine.OwnerCode = "ZK";
            orderLine.ItemCode = "1006-1003";
            orderLine.ActualQty = "1";
            orderLine.PlanQty = 1;

            orderLines.Add(orderLine);
            req.ReturnOrder = returnOrder;
            req.OrderLines = orderLines;

            return client.Execute(req);
        }
    }
}
