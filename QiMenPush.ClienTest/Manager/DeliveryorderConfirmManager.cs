using CustomHttpClient;
using CustomHttpClient.Request;
using CustomHttpClient.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenPush.ClienTest.Manager
{
    public class DeliveryorderConfirmManager
    {
        public static ZQHJsonDeliveryorderConfirmResponse InitRequest()
        {
            //string url = "http://106.87.85.97:9090/api/QiMenApi";
            //string appkey = "1023883919";
            //string secret = "sandboxff0b11ecc626508c171a5b2a2";
            ////string customerId = "c1498112555030";
            //string customerId = "c1498448349079";
            //ICustomClient client = new DefaultCustomClient(url, appkey, secret);
            //DeliveryorderConfirmRequest req = new DeliveryorderConfirmRequest();
            //req.CustomerId = customerId;
            //req.Version = "2.0";

            //DeliveryorderConfirmRequest.DeliveryOrderDomain deliveryOrder = new DeliveryorderConfirmRequest.DeliveryOrderDomain();
            //DeliveryorderConfirmRequest.OrderLineDomain orderLine = new DeliveryorderConfirmRequest.OrderLineDomain();
            //List<DeliveryorderConfirmRequest.OrderLineDomain> orderLines = new List<DeliveryorderConfirmRequest.OrderLineDomain>();
            //DeliveryorderConfirmRequest.PackageDomain package = new DeliveryorderConfirmRequest.PackageDomain();
            //List<DeliveryorderConfirmRequest.PackageDomain> packages = new List<DeliveryorderConfirmRequest.PackageDomain>();

            //deliveryOrder.OutBizCode = Guid.NewGuid().ToString("N");
            //package.LogisticsCode = "SF";
            //package.ExpressCode = "974701803690";
            //packages.Add(package);
            //req.Packages = packages;
            //deliveryOrder.DeliveryOrderCode = "JY1707040014";
            //deliveryOrder.WarehouseCode = "LK01";
            //deliveryOrder.OrderType = "JYCK";

            //req.DeliveryOrder = deliveryOrder;
            //orderLine.ItemCode = "1006-1003";
            //orderLine.ActualQty = "1";

            //orderLines.Add(orderLine);
            //req.OrderLines = orderLines;

            
            ZQHJsonDeliveryorderConfirmRequest req = new ZQHJsonDeliveryorderConfirmRequest();
            string url = req.GetApiName();
            ICustomClient client = new DefaultCustomClient(url, null, null);
            req.Db = "shop01";
            req.Function = "sp_mobile";
            req.Intype = "qrcode_out";
            req.Inpara = "20170416591020," +"MAI2800000009001";
            
            return client.Execute(req);
        }

    }
}
