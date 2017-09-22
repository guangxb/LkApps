using Apps.Models;
using Qimen.Api;
using Qimen.Api.Request;
using Qimen.Api.Response;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using log4net;
using System.Configuration;
using System.Threading.Tasks;

namespace QiMenApi.Common
{
    public class QimenApiConfirm
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static string url = ConfigurationManager.AppSettings["URL"].ToString();
        static string appkey = ConfigurationManager.AppSettings["APPKEY"].ToString();//"1023883919"; 23883919
        static string secret = ConfigurationManager.AppSettings["SECRET"].ToString();//"sandboxff0b11ecc626508c171a5b2a2"; 
        static string customeId = ConfigurationManager.AppSettings["CUSTOMEID"].ToString();
        DateTime timestamp = DateTime.Now;
        static string v = ConfigurationManager.AppSettings["v"].ToString();
        string[] customerArr = customeId.Split(',');
        //const string sign_method = "md5";
        //const string sign = "2.0";
        private SCVDBContainer dbContext;
        public QimenApiConfirm() { }
        public void Excute()
        {
            Task.Run(() => DeliveryorderConfirm());
            Task.Run(() => EntryorderConfirm());
            Task.Run(() => ReturnorderConfirm());
            Task.Run(() => StockoutConfirm());
        }

        #region 发货单确认
        /// <summary>
        /// 发货单确认
        /// </summary>
        public bool DeliveryorderConfirm()
        {
            log.Info("----------------启用定时任务：发货单确认" + DateTime.Now.Hour + "--------------");
            try
            {
                dbContext = new SCVDBContainer();
                DbSet<SHIPMENT_HEADER> dbset0 = dbContext.Set<SHIPMENT_HEADER>();
                DbSet<SHIPMENT_DETAIL> dbset1 = dbContext.Set<SHIPMENT_DETAIL>();
                DbSet<SHIPMENT_HEADER_TEMP> dbset_Temp = dbContext.Set<SHIPMENT_HEADER_TEMP>();

                IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                DeliveryorderConfirmRequest req = new DeliveryorderConfirmRequest();
                DeliveryorderConfirmResponse rsp = new DeliveryorderConfirmResponse();

                DeliveryorderConfirmRequest.DeliveryOrderDomain obj1 = new DeliveryorderConfirmRequest.DeliveryOrderDomain();

                DeliveryorderConfirmRequest.PackageDomain package = new DeliveryorderConfirmRequest.PackageDomain();
                List<DeliveryorderConfirmRequest.PackageDomain> packageList = new List<DeliveryorderConfirmRequest.PackageDomain>();

                DeliveryorderConfirmRequest.ItemDomain itemDomain = new DeliveryorderConfirmRequest.ItemDomain();
                List<DeliveryorderConfirmRequest.ItemDomain> itemList = new List<DeliveryorderConfirmRequest.ItemDomain>();

                DeliveryorderConfirmRequest.OrderLineDomain orderLine = new DeliveryorderConfirmRequest.OrderLineDomain();
                List<DeliveryorderConfirmRequest.OrderLineDomain> orderLineList = new List<DeliveryorderConfirmRequest.OrderLineDomain>();
                for (int i = 0; i < customerArr.Length; i++)
                {
                    var confirmlList = dbset0
                        .Where(t => t.TRAILING_STS.ToString() == "900"
                        && (
                        t.SHIPMENT_TYPE == "JYCK"
                        || t.SHIPMENT_TYPE == "HHCK"
                        || t.SHIPMENT_TYPE == "BFCK"
                        || t.SHIPMENT_TYPE == "QTCK")
                        && t.COMPANY == customeId)
                        .OrderByDescending(t => t.INTERNAL_SHIPMENT_NUM)
                        .Take(100).AsNoTracking().ToList();
                    var confirmTempList = dbset_Temp
                        .Where(t => t.TRAILING_STS.ToString() == "900"
                        && (
                        t.SHIPMENT_TYPE == "JYCK"
                        || t.SHIPMENT_TYPE == "HHCK"
                        || t.SHIPMENT_TYPE == "BFCK"
                        || t.SHIPMENT_TYPE == "QTCK")
                        && t.COMPANY == customeId)
                        .OrderBy(t => t.INTERNAL_SHIPMENT_NUM)
                        .Take(100).AsNoTracking().ToList();
                    List<SHIPMENT_DETAIL> detailList = new List<SHIPMENT_DETAIL>();
                    List<SHIPMENT_HEADER_TEMP> tempList = new List<SHIPMENT_HEADER_TEMP>();

                    confirmlList = confirmlList
                    .Where(a => !confirmTempList.Exists(t => a.INTERNAL_SHIPMENT_NUM.ToString() == t.INTERNAL_SHIPMENT_NUM.ToString()))
                    .OrderByDescending(t => t.INTERNAL_SHIPMENT_NUM).ToList();

                    req.CustomerId = customerArr[i].Trim();
                    req.Version = v;
                    req.Timestamp = DateTime.Now;
                    if (confirmlList.Count == 0)
                    {
                        log.Info("客户：" + req.CustomerId + " " + "需确认的发货单为空，不需要确认！！！");
                        continue;
                    }
                    foreach (var item in confirmlList)
                    {
                        detailList = dbset1.Where(t => t.INTERNAL_SHIPMENT_NUM == item.INTERNAL_SHIPMENT_NUM).ToList();
                        obj1.DeliveryOrderCode = item.SHIPMENT_ID;
                        obj1.WarehouseCode = item.WAREHOUSE;
                        obj1.OrderType = item.SHIPMENT_TYPE;//"JYCK"
                        obj1.ConfirmType = 0L;               //仅仅确认最终状态的订单
                        obj1.OutBizCode = Guid.NewGuid().ToString();
                        req.DeliveryOrder = obj1;
                        foreach (var itemChildren in detailList)
                        {
                            itemDomain.ItemCode = itemChildren.ITEM;
                            itemDomain.Quantity = (long)itemChildren.REQUEST_QTY;
                            itemList.Add(itemDomain);

                            package.ExpressCode = item.SHIPPING_CONTAINER.Where(t => t.PARENT == 0 && t.STATUS == 900).FirstOrDefault().TRACKING_NUMBER;
                            package.LogisticsCode = item.CARRIER;// item.CARRIER; //"SF";随便设置值
                            package.Items = itemList;
                            packageList.Add(package);

                            orderLine.PlanQty = itemChildren.REQUEST_QTY.ToString();
                            orderLine.ItemCode = itemChildren.ITEM;
                            orderLine.ActualQty = itemChildren.REQUEST_QTY.ToString();
                            orderLineList.Add(orderLine);
                        }
                        req.Packages = packageList;
                        req.OrderLines = orderLineList;
                        try
                        {
                            rsp = client.Execute(req);
                            log.Info(" " + "发货单确认--单号：" + item.INTERNAL_SHIPMENT_NUM + " " + "确认:" + rsp.Flag + " " + "消息：" + rsp.Message);
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error", ex);
                            continue;
                        }
                        if (rsp.Flag == "success")
                        {
                            SHIPMENT_HEADER_TEMP headerTemp = new SHIPMENT_HEADER_TEMP()
                            {
                                COMPANY = item.COMPANY,
                                INTERNAL_SHIPMENT_NUM = item.INTERNAL_SHIPMENT_NUM,
                                TRAILING_STS = item.TRAILING_STS,
                                LEADING_STS = item.LEADING_STS,
                                SHIPMENT_ID = item.SHIPMENT_ID,
                                WAREHOUSE = item.WAREHOUSE,
                                SHIPMENT_TYPE = item.SHIPMENT_TYPE,
                                FLAG = rsp.Flag,
                                CODE = rsp.Code,
                                MESSAGE = rsp.Message,
                                DATE_TIME_STAMP = DateTime.Now,
                            };
                            dbset_Temp.Add(headerTemp);
                        }
                    }
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Error", ex);
                return false;
            }
        }
        #endregion

        #region 入库单确认
        /// <summary>
        /// 入库单确认
        /// </summary>
        public bool EntryorderConfirm()
        {
            log.Info("----------------启用定时任务：入库单确认" + DateTime.Now.Hour + "--------------");
            try
            {
                dbContext = new SCVDBContainer();
                DbSet<RECEIPT_HEADER> dbset0 = dbContext.Set<RECEIPT_HEADER>();
                DbSet<RECEIPT_DETAIL> dbset1 = dbContext.Set<RECEIPT_DETAIL>();
                DbSet<RECEIPT_HEADER_TEMP> dbset_Temp = dbContext.Set<RECEIPT_HEADER_TEMP>();

                IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                EntryorderConfirmRequest req = new EntryorderConfirmRequest();
                EntryorderConfirmResponse rsp = new EntryorderConfirmResponse();

                EntryorderConfirmRequest.EntryOrderDomain obj1 = new EntryorderConfirmRequest.EntryOrderDomain();

                EntryorderConfirmRequest.OrderLineDomain orderLine = new EntryorderConfirmRequest.OrderLineDomain();
                List<EntryorderConfirmRequest.OrderLineDomain> orderLineList = new List<EntryorderConfirmRequest.OrderLineDomain>();
                for (int i = 0; i < customerArr.Length; i++)
                {
                    var confirmlList = dbset0
                                        .Where(t =>
                                        t.TRAILING_STS.ToString() == "900"
                                        && (t.RECEIPT_TYPE.Contains("SCRK")
                                        || t.RECEIPT_TYPE.Contains("LYRK")
                                        || t.RECEIPT_TYPE.Contains("CCRK")
                                        || t.RECEIPT_TYPE.Contains("CGRK")
                                        || t.RECEIPT_TYPE.Contains("DBRK")
                                        || t.RECEIPT_TYPE.Contains("QTRK")
                                        || t.RECEIPT_TYPE.Contains("B2BRK")
                                        && t.COMPANY == customeId)
                                        ).OrderByDescending(t => t.INTERNAL_RECEIPT_NUM)
                                        .Take(100).AsNoTracking().ToList();
                    var confirmTempList = dbset_Temp.Where(t =>
                                        t.TRAILING_STS.ToString() == "900"
                                        && (t.RECEIPT_TYPE.Contains("SCRK")
                                        || t.RECEIPT_TYPE.Contains("LYRK")
                                        || t.RECEIPT_TYPE.Contains("CCRK")
                                        || t.RECEIPT_TYPE.Contains("CGRK")
                                        || t.RECEIPT_TYPE.Contains("DBRK")
                                        || t.RECEIPT_TYPE.Contains("QTRK")
                                        || t.RECEIPT_TYPE.Contains("B2BRK")
                                        && t.COMPANY == customeId)
                                        ).OrderByDescending(t => t.INTERNAL_RECEIPT_NUM)
                                        .Take(100).AsNoTracking().ToList();

                    List<RECEIPT_DETAIL> tempList = new List<RECEIPT_DETAIL>();
                    //过滤已确认的数据
                    confirmlList = confirmlList
                        .Where(a => !confirmTempList.Exists(t => a.INTERNAL_RECEIPT_NUM == t.INTERNAL_RECEIPT_NUM))
                        .ToList();

                    req.CustomerId = customerArr[i].Trim();
                    req.Version = v;
                    req.Timestamp = DateTime.Now;
                    if (confirmlList.Count == 0)
                    {
                        log.Info("客户：" + req.CustomerId + " " + "需确认的入库单为空，不需要确认！！！");
                        continue;
                    }
                    foreach (var item in confirmlList)
                    {
                        tempList = dbset1.Where(t => t.INTERNAL_RECEIPT_NUM == item.INTERNAL_RECEIPT_NUM).ToList();
                        obj1.EntryOrderCode = item.RECEIPT_ID;
                        obj1.OwnerCode = item.COMPANY;
                        obj1.WarehouseCode = item.WAREHOUSE;
                        obj1.OutBizCode = Guid.NewGuid().ToString();
                        obj1.Status = "FULFILLED";//item.TRAILING_STS.ToString();
                        obj1.ConfirmType = 0L;
                        obj1.TotalOrderLines = (long)item.TOTAL_LINES;
                        obj1.EntryOrderId = item.RECEIPT_ID;
                        req.EntryOrder = obj1;
                        foreach (var itemChildren in tempList)
                        {
                            orderLine.ItemId = itemChildren.ITEM;
                            orderLine.OwnerCode = itemChildren.COMPANY;
                            orderLine.ItemCode = itemChildren.ITEM;
                            orderLine.PlanQty = (long)itemChildren.OPEN_QTY;
                            orderLine.ActualQty = (long)itemChildren.TOTAL_QTY;
                            orderLineList.Add(orderLine);
                        }
                        req.OrderLines = orderLineList;
                        try
                        {
                            rsp =  client.Execute(req);
                            log.Info(" " + "入库确认--订单号：" + item.INTERNAL_RECEIPT_NUM + " " + "确认结果:" + rsp.Flag + " " + "消息：" + rsp.Message);
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error", ex);
                            continue;
                        }

                        if (rsp.Flag == "success")
                        {
                            DbSet<RECEIPT_HEADER_TEMP> header = dbContext.Set<RECEIPT_HEADER_TEMP>();

                            RECEIPT_HEADER_TEMP headerTemp = new RECEIPT_HEADER_TEMP()
                            {
                                COMPANY = item.COMPANY,
                                ACTUAL_ARRIVE_DATE = DateTime.Now,
                                TRAILING_STS = item.TRAILING_STS,
                                INTERNAL_RECEIPT_NUM = item.INTERNAL_RECEIPT_NUM,
                                DATE_TIME_STAMP = DateTime.Now,
                                RECEIPT_ID = item.RECEIPT_ID,
                                WAREHOUSE = item.WAREHOUSE,
                                RECEIPT_TYPE = item.RECEIPT_TYPE,
                                FLAG = rsp.Flag,
                                CODE = rsp.Code,
                                MESSAGE = rsp.Message

                            };
                            header.Add(headerTemp);
                        }
                    }
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Error", ex);
                return false;
            }
        }
        #endregion

        #region 退货入库单确认
        /// <summary>
        /// 退货入库单确认
        /// </summary>
        public bool ReturnorderConfirm()
        {
            log.Info("----------------启用定时任务：退货入库单确认" + DateTime.Now.Hour + "--------------");
            try
            {
                dbContext = new SCVDBContainer();
                DbSet<RECEIPT_HEADER> dbset0 = dbContext.Set<RECEIPT_HEADER>();
                DbSet<RECEIPT_DETAIL> dbset1 = dbContext.Set<RECEIPT_DETAIL>();
                DbSet<RECEIPT_HEADER_TEMP> dbset_Temp = dbContext.Set<RECEIPT_HEADER_TEMP>();
                IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                ReturnorderConfirmRequest req = new ReturnorderConfirmRequest();
                ReturnorderConfirmResponse rsp = new ReturnorderConfirmResponse();
                //退货单信息
                ReturnorderConfirmRequest.ReturnOrderDomain obj1 = new ReturnorderConfirmRequest.ReturnOrderDomain();
                //发件人信息
                ReturnorderConfirmRequest.SenderInfoDomain send = new ReturnorderConfirmRequest.SenderInfoDomain();
                //订单信息
                ReturnorderConfirmRequest.OrderLineDomain orderLine = new ReturnorderConfirmRequest.OrderLineDomain();
                List<ReturnorderConfirmRequest.OrderLineDomain> orderLineList = new List<ReturnorderConfirmRequest.OrderLineDomain>();
                for (int i = 0; i < customerArr.Length; i++)
                {
                    var confirmlList = dbset0
                                        .Where(t =>
                                        t.TRAILING_STS.ToString() == "900"
                                        && (
                                        t.RECEIPT_TYPE.Contains("THRK") ||
                                        t.RECEIPT_TYPE.Contains("HHRK")
                                        ) && t.COMPANY == customeId)
                                        .OrderByDescending(t => t.INTERNAL_RECEIPT_NUM)
                                        .Take(100).AsNoTracking().ToList();
                    var confirmTempList = dbset_Temp
                                          .Where(t =>
                                          t.TRAILING_STS.ToString() == "900"
                                          && (
                                          t.RECEIPT_TYPE.Contains("THRK") ||
                                          t.RECEIPT_TYPE.Contains("HHRK")
                                          ) && t.COMPANY == customeId)
                                          .OrderByDescending(t => t.INTERNAL_RECEIPT_NUM)
                                          .Take(100).AsNoTracking().ToList();

                    List<RECEIPT_HEADER_TEMP> tempList = new List<RECEIPT_HEADER_TEMP>();
                    List<RECEIPT_DETAIL> detailList = new List<RECEIPT_DETAIL>();
                    //排除已确认的数据,并且一次性只处理100个订单
                    confirmlList = confirmlList
                        .Where(a => !confirmTempList.Exists(t => a.INTERNAL_RECEIPT_NUM == t.INTERNAL_RECEIPT_NUM))
                        .OrderByDescending(t => t.INTERNAL_RECEIPT_NUM).ToList();

                    req.CustomerId = customerArr[i].Trim();
                    req.Version = v;
                    req.Timestamp = DateTime.Now;
                    if (confirmlList.Count == 0)
                    {
                        log.Info("客户：" + req.CustomerId + " " + "需确认的退货入库单为空，不需要确认！！！");
                        continue;
                    }

                    foreach (var item in confirmlList)
                    {
                        detailList = dbset1.Where(t => t.INTERNAL_RECEIPT_NUM == item.INTERNAL_RECEIPT_NUM).ToList();

                        obj1.ReturnOrderCode = item.RECEIPT_ID;//"R1234";//item.ERP_ORDER_ID;
                        obj1.WarehouseCode = item.WAREHOUSE;
                        obj1.LogisticsCode = "SF"; //"SF";//item.CARRER;
                        obj1.OutBizCode = Guid.NewGuid().ToString();
                        send.Name = item.SHIP_FROM_NAME;//"老王";//
                        send.Mobile = item.SHIP_FROM_PHONE_NUM;//"13214567869";//
                        send.Province = item.SHIP_FROM_COUNTRY;//"浙江省";//
                        send.City = item.SHIP_FROM_CITY; //"杭州"; //
                        send.DetailAddress = item.SHIP_FROM_ADDRESS1 != null ? item.SHIP_FROM_ADDRESS1 : item.SHIP_FROM_ADDRESS2;//"杭州市余杭区989号";//
                        obj1.SenderInfo = send;

                        foreach (var itemChildren in detailList)
                        {
                            orderLine.OwnerCode = itemChildren.COMPANY;
                            orderLine.ItemCode = itemChildren.ITEM;
                            orderLine.PlanQty = (long)itemChildren.OPEN_QTY;//12L;// 
                            orderLine.ActualQty = itemChildren.TOTAL_QTY.ToString();
                            orderLineList.Add(orderLine);
                        }
                        req.ReturnOrder = obj1;
                        req.OrderLines = orderLineList;
                        try
                        {
                            rsp = client.Execute(req);
                            log.Info(" " + "退货入库确认--订单号：" + item.INTERNAL_RECEIPT_NUM + " " + "确认结果:" + rsp.Flag + " " + "消息：" + rsp.Message);
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error", ex);
                            continue;
                        }
                        if (rsp.Flag == "success")
                        {
                            DbSet<RECEIPT_HEADER_TEMP> header = dbContext.Set<RECEIPT_HEADER_TEMP>();

                            RECEIPT_HEADER_TEMP headerTemp = new RECEIPT_HEADER_TEMP()
                            {
                                INTERNAL_RECEIPT_NUM = item.INTERNAL_RECEIPT_NUM,
                                DATE_TIME_STAMP = DateTime.Now,
                                RECEIPT_ID = item.RECEIPT_ID,
                                WAREHOUSE = item.WAREHOUSE,
                                RECEIPT_TYPE = item.RECEIPT_TYPE,
                                TRAILING_STS = item.TRAILING_STS,
                                LEADING_STS = item.LEADING_STS,
                                FLAG = rsp.Flag,
                                CODE = rsp.Code,
                                MESSAGE = rsp.Message
                            };
                            header.Add(headerTemp);

                        }
                    }
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Error", ex);
                return false;
            }
        }
        #endregion

        #region 出库单确认
        /// <summary>
        /// 出库单确认
        /// </summary>
        public bool StockoutConfirm()
        {
            log.Info("----------------启用定时任务：出库单确认" + DateTime.Now.Hour + "--------------");
            try
            {
                dbContext = new SCVDBContainer();
                DbSet<SHIPMENT_HEADER> dbset0 = dbContext.Set<SHIPMENT_HEADER>();
                DbSet<SHIPMENT_DETAIL> dbset1 = dbContext.Set<SHIPMENT_DETAIL>();
                DbSet<SHIPMENT_HEADER_TEMP1> dbset_Temp = dbContext.Set<SHIPMENT_HEADER_TEMP1>();

                IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                StockoutConfirmRequest req = new StockoutConfirmRequest();
                StockoutConfirmResponse rsp = new StockoutConfirmResponse();

                StockoutConfirmRequest.DeliveryOrderDomain obj1 = new StockoutConfirmRequest.DeliveryOrderDomain();

                StockoutConfirmRequest.PackageDomain package = new StockoutConfirmRequest.PackageDomain();
                List<StockoutConfirmRequest.PackageDomain> packageList = new List<StockoutConfirmRequest.PackageDomain>();

                StockoutConfirmRequest.ItemDomain itemDomain = new StockoutConfirmRequest.ItemDomain();
                List<StockoutConfirmRequest.ItemDomain> itemDomainList = new List<StockoutConfirmRequest.ItemDomain>();

                StockoutConfirmRequest.OrderLineDomain orderLine = new StockoutConfirmRequest.OrderLineDomain();
                List<StockoutConfirmRequest.OrderLineDomain> orderLineList = new List<StockoutConfirmRequest.OrderLineDomain>();
                for (int i = 0; i < customerArr.Length; i++)
                {
                    var confirmlList = dbset0
                        .Where(t => t.TRAILING_STS.ToString() == "900"
                        && t.COMPANY == customeId)
                        .OrderByDescending(t => t.INTERNAL_SHIPMENT_NUM)
                        .Take(100).AsNoTracking().ToList();
                    var confirmTempList = dbset_Temp
                        .Where(t => t.TRAILING_STS.ToString() == "900"
                        && t.COMPANY == customeId)
                        .OrderByDescending(t => t.INTERNAL_SHIPMENT_NUM)
                        .Take(100).AsNoTracking().ToList();

                    List<SHIPMENT_DETAIL> detailList = new List<SHIPMENT_DETAIL>();
                    confirmlList = confirmlList
                        .Where(a => !confirmTempList.Exists(t => a.INTERNAL_SHIPMENT_NUM == t.INTERNAL_SHIPMENT_NUM))
                        .OrderByDescending(t => t.INTERNAL_SHIPMENT_NUM).ToList();

                    req.CustomerId = customerArr[i].Trim();
                    req.Version = v;
                    req.Timestamp = DateTime.Now;
                    if (confirmlList.Count == 0)
                    {
                        log.Info("客户：" + req.CustomerId + " " + "需确认的出库单为空，不需要确认！！！");
                        continue;
                    }
                    foreach (var item in confirmlList)
                    {
                        detailList = dbset1.Where(t => t.INTERNAL_SHIPMENT_NUM == item.INTERNAL_SHIPMENT_NUM).ToList();
                        obj1.DeliveryOrderId = item.SHIPMENT_ID.ToString();
                        obj1.OutBizCode = Guid.NewGuid().ToString();
                        obj1.DeliveryOrderCode = item.SHIPMENT_ID;
                        obj1.WarehouseCode = item.WAREHOUSE;
                        obj1.OrderType = item.SHIPMENT_TYPE;
                        req.DeliveryOrder = obj1;
                        foreach (var itemChildren in detailList)
                        {
                            itemDomain.ItemCode = itemChildren.ITEM;
                            itemDomain.Quantity = (long)itemChildren.REQUEST_QTY;
                            itemDomainList.Add(itemDomain);

                            package.ExpressCode = item.SHIPPING_CONTAINER
                                .Where(t => t.PARENT == 0 && t.STATUS == 900)
                                .FirstOrDefault().TRACKING_NUMBER;
                            package.Items = itemDomainList;
                            package.LogisticsCode = item.CARRIER;
                            packageList.Add(package);

                            orderLine.ItemCode = itemChildren.ITEM;
                            orderLine.ActualQty = (long)itemChildren.REQUEST_QTY;
                            orderLineList.Add(orderLine);
                        }
                        req.OrderLines = orderLineList;
                        req.Packages = packageList;
                        try
                        {
                            rsp = client.Execute(req);
                            log.Info(" " + "出库确认--订单号：" + item.INTERNAL_SHIPMENT_NUM + " " + "确认结果:" + rsp.Flag + " " + "消息：" + rsp.Message);
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error", ex);
                            continue;
                        }

                        if (rsp.Flag == "success")
                        {
                            SHIPMENT_HEADER_TEMP1 headerTemp = new SHIPMENT_HEADER_TEMP1()
                            {
                                LEADING_STS = item.LEADING_STS,
                                DATE_TIME_STAMP = DateTime.Now,
                                TRAILING_STS = item.TRAILING_STS,
                                TOTAL_QTY = item.TOTAL_QTY,
                                INTERNAL_SHIPMENT_NUM = item.INTERNAL_SHIPMENT_NUM,
                                SHIPMENT_ID = item.SHIPMENT_ID,
                                WAREHOUSE = item.WAREHOUSE,
                                COMPANY = item.COMPANY,
                                SHIPMENT_TYPE = item.SHIPMENT_TYPE,
                                FLAG = rsp.Flag,
                                CODE = rsp.Code,
                                MESSAGE = rsp.Message
                            };
                            dbset_Temp.Add(headerTemp);
                        }
                    }
                    dbContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Error", ex);
                return false;
            }
        }
        #endregion

        #region 库存异动通知  ?????  判断出入库的异动
        /// <summary>
        /// 库存异动通知
        /// </summary>
        //public bool StockchangeReport()
        //{
        //    try
        //    {
        //        using (dbContext = new SCVDBContainer())
        //        {
        //            IQimenClient client = new DefaultQimenClient(url, appkey, secret);
        //            StockchangeReportRequest req = new StockchangeReportRequest();
        //            StockchangeReportResponse rsp = new StockchangeReportResponse();

        //            DeliveryorderConfirmRequest.ItemDomain item = new DeliveryorderConfirmRequest.ItemDomain();
        //            List<DeliveryorderConfirmRequest.ItemDomain> itemList = new List<DeliveryorderConfirmRequest.ItemDomain>();

        //            var confirmlList = dbContext.LOCATION_INVENTORY.ToList();
        //            var confirmTempList = dbContext.LOCATION_INVENTORY_TEMP.ToList();
        //            List<LOCATION_INVENTORY_TEMP> tempList = new List<LOCATION_INVENTORY_TEMP>();
        //            confirmlList = confirmlList.Where(a => (!confirmTempList.Exists(t => a.INTERNAL_LOCATION_INV.Contains(t.INTERNAL_LOCATION_INV))) || (!confirmlList.Exists(t => a.DATE_TIME_STAMP.Equals(t.DATE_TIME_STAMP) && t.INTERNAL_LOCATION_INV == a.INTERNAL_LOCATION_INV))).ToList().Take(1000);

        //            req.CustomerId = customeId;
        //            req.Version = v;
        //            foreach (var item in confirmlList)
        //            {
        //                tempList = dbContext.LOCATION_INVENTORY_TEMP.Where(t => t.INTERNAL_LOCATION_INV == item.INTERNAL_LOCATION_INV).ToList();
        //                obj1.DeliveryOrderCode = item.;
        //                obj1.WarehouseCode = item.WAREHOUSE;
        //                obj1.OrderType = item.SHIPMENT_TYPE;
        //                req.DeliveryOrder = obj1;
        //                foreach (var itemChildren in tempList)
        //                {
        //                    package.LogisticsCode = itemChildren.CARRIER;
        //                    package.ExpressCode = itemChildren.SHIPMENT_ID;
        //                    packageList.Add(package);
        //                }
        //                rsp = client.Execute(req);
        //                if (rsp.Flag == "success")
        //                {
        //                    DbSet<SHIPMENT_HEADER_TEMP> header = new DbSet<SHIPMENT_HEADER_TEMP>();

        //                    SHIPMENT_HEADER_TEMP headerTemp = new SHIPMENT_HEADER_TEMP()
        //                    {
        //                        SHIPMENT_ID = item.SHIPMENT_ID,
        //                        WAREHOUSE = item.WAREHOUSE,
        //                        SHIPMENT_TYPE = item.SHIPMENT_TYPE,
        //                        ISDELIVERYORDER_CONFORM = "YES"
        //                    };
        //                    header.Add(headerTemp);
        //                    dbContext.SaveChanges();
        //                }
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        #endregion

    }
}