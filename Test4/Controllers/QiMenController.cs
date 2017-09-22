using Qimen.Api;
using Qimen.Api.Request;
using Qimen.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test4.Controllers
{
    public class QiMenController : Controller
    {
        // GET: QiMen
        public ActionResult Index()
        {
            string url = "http://qimenapi.tbsandbox.com/router/qimen/service";
            IQimenClient client = new DefaultQimenClient(url, "1023883919", "sandboxff0b11ecc626508c171a5b2a2");
            #region MyRegion
            EntryorderCreateRequest req = new EntryorderCreateRequest();
            //req.GetApiName();
            //req.AddHeaderParameter("","");
            req.CustomerId = "c1498112555030";
            req.Version = "2.0";


            EntryorderCreateRequest.EntryOrderDomain obj1 = new EntryorderCreateRequest.EntryOrderDomain();
            obj1.EntryOrderCode = "E1234";
            obj1.OwnerCode = "O1234";
            obj1.WarehouseCode = "W1234";
            //obj1.TotalOrderLines = "1";
            req.EntryOrder = obj1;

            List<EntryorderCreateRequest.OrderLineDomain> list2 = new List<EntryorderCreateRequest.OrderLineDomain>();
            EntryorderCreateRequest.OrderLineDomain orderLine = new EntryorderCreateRequest.OrderLineDomain();
            orderLine.OwnerCode = "O1234";
            orderLine.ItemCode = "LK001";
            orderLine.ItemId = "a1234";
            list2.Add(orderLine);
            req.OrderLines = list2;

            DateTime ts;
            DateTime.TryParse("2017-06-24 20:35:00", out ts);
            req.Timestamp = ts;
            EntryorderCreateResponse rsp = client.Execute(req);
            Console.WriteLine(rsp.Body);

            #endregion


            #region 入库单查询接口
            //EntryorderQueryRequest req = new EntryorderQueryRequest();
            //req.CustomerId = "c1498112555030";
            //req.Version = "2.0";
            //req.OwnerCode = "O1234123";
            //req.WarehouseCode = "CK12341231";
            //req.EntryOrderCode = "EK1234123";
            //req.EntryOrderId = "RK1234123";
            //req.Page = 1L;
            //req.PageSize = 10L;
            //req.OrderType = "orderType";
            //req.ExtOrderCode = "extOrderCode";
            //EntryorderQueryResponse rsp = client.Execute(req);
            //Console.WriteLine(rsp.Body);
            #endregion

            //EntryorderConfirmRequest req = new EntryorderConfirmRequest();
            ////req.GetApiName();
            ////req.AddHeaderParameter("","");
            //req.CustomerId = "c1498112555030";
            //req.Version = "2.0";

            //EntryorderConfirmRequest.EntryOrderDomain obj1 = new EntryorderConfirmRequest.EntryOrderDomain();
            //obj1.EntryOrderCode = "E1234";
            //obj1.OwnerCode = "O1234";
            //obj1.WarehouseCode = "W1234";
            //obj1.OutBizCode = "O1234";
            //obj1.Status = "NEW";

            ////obj1.TotalOrderLines = "1";
            //req.EntryOrder = obj1;

            //List<EntryorderConfirmRequest.OrderLineDomain> list2 = new List<EntryorderConfirmRequest.OrderLineDomain>();
            //EntryorderConfirmRequest.OrderLineDomain orderLine = new EntryorderConfirmRequest.OrderLineDomain();
            //orderLine.OwnerCode = "O1234";
            //orderLine.ItemCode = "LK001";
            //orderLine.ItemId = "a1234";
            //orderLine.ActualQty = 12;
            //list2.Add(orderLine);
            //req.OrderLines = list2;

            //DateTime ts;
            //DateTime.TryParse("2017-06-24 20:35:00", out ts);
            //req.Timestamp = ts;
            //EntryorderConfirmResponse rsp = client.Execute(req);
            //Console.WriteLine(rsp.Body);

            #region 发货单创建接口
            //DeliveryorderCreateRequest req = new DeliveryorderCreateRequest();
            //req.CustomerId = "stub-cust-code";
            //req.Version = "2.0";
            //DeliveryorderCreateRequest.DeliveryOrderDomain obj1 = new DeliveryorderCreateRequest.DeliveryOrderDomain();
            //obj1.DeliveryOrderCode = "TB1234";
            //obj1.OrderType = "JYCK";
            //obj1.WarehouseCode = "OTHER";
            //req.DeliveryOrder = obj1;
            //List<DeliveryorderCreateRequest.OrderLineDomain> list2 = new List<DeliveryorderCreateRequest.OrderLineDomain>();
            //DeliveryorderCreateRequest.OrderLineDomain orderLine = new DeliveryorderCreateRequest.OrderLineDomain();
            //orderLine.OwnerCode = "H1234";
            //orderLine.ItemCode = "I1234";
            //orderLine.PlanQty = "10";
            //orderLine.ActualPrice = "12.0";
            //list2.Add(orderLine);
            //req.OrderLines = list2;
            //DeliveryorderCreateResponse rsp = client.Execute(req);
            //Console.WriteLine(rsp.Body);
            #endregion


            return View();
        }

        public ActionResult EntryorderQuery() {

            return View();
        }
    }
}