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
    public class DeliveryorderConfirmManager
    {
        public static DeliveryorderConfirmResponse InitRequest()
        {
            string url = "http://qimenapi.tbsandbox.com/router/qimen/service";
            string appkey = "1023883919";
            string secret = "sandboxff0b11ecc626508c171a5b2a2";
            //string customerId = "c1498112555030";
            string customerId = "c1498448349079";
            IQimenClient client = new DefaultQimenClient(url, appkey, secret);
            DeliveryorderConfirmRequest req = new DeliveryorderConfirmRequest();
            req.CustomerId = customerId;
            req.Version = "2.0";

            DeliveryorderConfirmRequest.DeliveryOrderDomain deliveryOrder = new DeliveryorderConfirmRequest.DeliveryOrderDomain();
            DeliveryorderConfirmRequest.OrderLineDomain orderLine = new DeliveryorderConfirmRequest.OrderLineDomain();
            List<DeliveryorderConfirmRequest.OrderLineDomain> orderLines = new List<DeliveryorderConfirmRequest.OrderLineDomain>();
            DeliveryorderConfirmRequest.PackageDomain package = new DeliveryorderConfirmRequest.PackageDomain();
            List<DeliveryorderConfirmRequest.PackageDomain> packages = new List<DeliveryorderConfirmRequest.PackageDomain>();

            deliveryOrder.OutBizCode = Guid.NewGuid().ToString("N");
            package.LogisticsCode = "SF";
            package.ExpressCode = "974701803690";
            packages.Add(package);
            req.Packages = packages;
            deliveryOrder.DeliveryOrderCode = "JY1707040014";
            deliveryOrder.WarehouseCode = "LK01";
            deliveryOrder.OrderType = "JYCK";

            req.DeliveryOrder = deliveryOrder;
            orderLine.ItemCode = "1006-1003";
            orderLine.ActualQty = "1";

            orderLines.Add(orderLine);
            req.OrderLines = orderLines;

            return client.Execute(req);
        }
       
    }
}
