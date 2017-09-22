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
    public class StockoutConfirmManager
    {
        public static StockoutConfirmResponse InitRequest() {

            string url = "http://qimenapi.tbsandbox.com/router/qimen/service";
            string appkey = "1023883919";
            string secret = "sandboxff0b11ecc626508c171a5b2a2";
            //string customerId = "c1498112555030";
            string customerId = "c1498448349079";
            IQimenClient client = new DefaultQimenClient(url, appkey, secret);
            StockoutConfirmRequest req = new StockoutConfirmRequest();
            req.CustomerId = customerId;
            req.Version = "2.0";

            StockoutConfirmRequest.DeliveryOrderDomain deliveryOrder = new StockoutConfirmRequest.DeliveryOrderDomain();
            StockoutConfirmRequest.OrderLineDomain orderLine = new StockoutConfirmRequest.OrderLineDomain();
            List<StockoutConfirmRequest.OrderLineDomain> orderLines = new List<StockoutConfirmRequest.OrderLineDomain>();

            deliveryOrder.DeliveryOrderCode = "JY1707120007";
            deliveryOrder.WarehouseCode = "LK01";
            deliveryOrder.OrderType = "JYCK";

            req.DeliveryOrder = deliveryOrder;

            orderLine.ItemCode = "6900404523492";
            orderLine.ActualQty = 1;

            orderLines.Add(orderLine);

            StockoutConfirmRequest.OrderLineDomain orderLine1 = new StockoutConfirmRequest.OrderLineDomain();

            orderLine1.ItemCode = "6900404523768";
            orderLine1.ActualQty = 1;
            orderLines.Add(orderLine1);

            StockoutConfirmRequest.OrderLineDomain orderLine2 = new StockoutConfirmRequest.OrderLineDomain();

            orderLine2.ItemCode = "6900404520958";
            orderLine2.ActualQty = 1;
            orderLines.Add(orderLine2);

            req.OrderLines = orderLines;

            return client.Execute(req);
        }
    }
}
