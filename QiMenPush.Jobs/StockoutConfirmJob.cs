﻿using Apps.Models;
using Common.Logging;
using Qimen.Api;
using Qimen.Api.Request;
using QiMenPush.Jobs.Emum;
using Quartz;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiMenPush.Jobs
{
    public class StockoutConfirmJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const string SHIPMENT = "SHIPMENT";
        private const string INTERFACE = "StockoutConfirm";
        public void Execute(IJobExecutionContext context)
        {
            string url = ConfigurationManager.AppSettings["URL"].ToString();
            string appkey = ConfigurationManager.AppSettings["APPKEY"].ToString();//"1023883919"; 23883919
            string secret = ConfigurationManager.AppSettings["SECRET"].ToString();//"sandboxff0b11ecc626508c171a5b2a2"; 
            string customeId = ConfigurationManager.AppSettings["CUSTOMEID"].ToString();
            string v = ConfigurationManager.AppSettings["v"].ToString();
            string[] customerArr = customeId.Split(',');

            try
            {
                _logger.Info("StockoutConfirmJob 开始执行... " + DateTime.Now + "");
                foreach (var cId in customerArr)
                {
                    using (SCVDBContainer dbContext = new SCVDBContainer())
                    using (DBContainer dbContext1 = new DBContainer())
                    {
                        DbSet<SHIPMENT_HEADER> header = dbContext.Set<SHIPMENT_HEADER>();
                        DbSet<SHIPMENT_DETAIL> detail = dbContext.Set<SHIPMENT_DETAIL>();
                        //DbSet<QiMen_PushTimeStatus> dbSet0 = dbContext1.Set<QiMen_PushTimeStatus>();
                        DbSet<QiMen_PushLog> dbSet1 = dbContext1.Set<QiMen_PushLog>();
                        IQimenClient client;
                        if (cId == "RB")
                        {
                            string rbUrl = "";
                            client = new DefaultQimenClient(rbUrl, appkey, secret, true);
                        }
                        else {
                            client = new DefaultQimenClient(url, appkey, secret);
                        }
                       

                        StockoutConfirmRequest req = new StockoutConfirmRequest();


                        //DateTime lastTime;
                        //QiMen_PushTimeStatus qmt = dbSet0.Where(q => q.CustomerId == cId && q.OrderType == SHIPMENT && q.Interface == INTERFACE).FirstOrDefault();
                        //if (qmt == null)
                        //{
                        //    qmt = new QiMen_PushTimeStatus() { CustomerId = cId, ActualShipTime = DateTime.Now, OrderType = SHIPMENT, Interface = INTERFACE };
                        //    dbSet0.Add(qmt);
                        //    lastTime = DateTime.Now.AddMinutes(-1);
                        //}
                        //else
                        //{
                        //    lastTime = ((DateTime)qmt.ActualShipTime).AddMinutes(-1);
                        //}
                        //&& (h.SHIPMENT_TYPE.Equals("LKCK", StringComparison.OrdinalIgnoreCase))
                        //var confirmlList = header.Where(h => h.COMPANY == cId && h.TRAILING_STS == 900 && h.ACTUAL_SHIP_DATE_TIME >= lastTime).OrderByDescending(h => h.ACTUAL_SHIP_DATE_TIME).Include(s => s.SHIPMENT_DETAIL).Include(s => s.SHIPPING_CONTAINER).AsNoTracking().ToList();
                        var confirmlList = new List<SHIPMENT_HEADER>();

                        if (cId == "XGQQG")
                        {
                            confirmlList = header.Where(h => h.COMPANY == cId
                                && (h.SHIPMENT_CATEGORY6 == null || h.SHIPMENT_CATEGORY6 == QimenPushStatus.Failure.ToString()
                                || h.SHIPMENT_CATEGORY6 == "1" || h.SHIPMENT_CATEGORY6 == "2" || h.SHIPMENT_CATEGORY6 == "3" || h.SHIPMENT_CATEGORY6 == "4" || h.SHIPMENT_CATEGORY6 == "5")
                                && (h.TRAILING_STS == 800 || h.TRAILING_STS == 850 || h.TRAILING_STS == 900)
                                && (h.PROCESS_TYPE == "NORMAL")
                                ).Include(s => s.SHIPMENT_DETAIL).Include(s => s.SHIPPING_CONTAINER).ToList();
                        }
                        else
                        {
                            confirmlList = header.Where(h => h.COMPANY == cId
                               && h.CREATE_USER == "StockOutCreate"
                               && (h.SHIPMENT_CATEGORY6 == null || h.SHIPMENT_CATEGORY6 == QimenPushStatus.Failure.ToString()
                               || h.SHIPMENT_CATEGORY6 == "1" || h.SHIPMENT_CATEGORY6 == "2" || h.SHIPMENT_CATEGORY6 == "3" || h.SHIPMENT_CATEGORY6 == "4" || h.SHIPMENT_CATEGORY6 == "5")
                               && (h.TRAILING_STS == 800 || h.TRAILING_STS == 850 || h.TRAILING_STS == 900)
                               && (h.PROCESS_TYPE == "NORMAL")
                               ).Include(s => s.SHIPMENT_DETAIL).Include(s => s.SHIPPING_CONTAINER).ToList();
                        }


                        //if (cId == "CQHGE")
                        //{
                        //    confirmlList = confirmlList.Where(l => l.CREATE_USER == "StockOutCreate").ToList();
                        //}

                        if (cId == "XGQQG")
                        {
                            CustomHttpClient.Request.YSJsonDeliveryorderConfirmRequest ysReq = new CustomHttpClient.Request.YSJsonDeliveryorderConfirmRequest();
                            string ysUrl = ysReq.GetApiName();
                            CustomHttpClient.ICustomClient customClient = new CustomHttpClient.DefaultCustomClient(ysUrl, null, null);
                            ysReq.Db = "shop01";
                            ysReq.Function = "sp_mobile";
                            ysReq.Intype = "qrcode_out";
                            foreach (var itemHeader in confirmlList)
                            {  
                                var snList = dbContext.SERIAL_NUMBER.Where(s=>s.INTERNAL_SHIPMENT_NUM == itemHeader.INTERNAL_SHIPMENT_NUM).ToList();

                                if (!snList.Any()) {
                                    itemHeader.SHIPMENT_CATEGORY6 = "Skip";
                                }

                                int successCount = 0;

                                foreach (var sn in snList) {
                                    ysReq.Inpara = itemHeader.SHIPMENT_ID + "," + sn.SERIAL_NUMBER1;
                                    //ysReq.Inpara = "20170416591020," + "MAI2800000009001";
                                    CustomHttpClient.Response.YSJsonDeliveryorderConfirmResponse ysRsp = customClient.Execute(ysReq);
                                    QiMen_PushLog log = new QiMen_PushLog();
                                    log.InternalOrderID = itemHeader.INTERNAL_SHIPMENT_NUM;
                                    log.OrderType = INTERFACE;
                                    log.CustomerId = cId;
                                    log.Flag = ysRsp.Success ? "success" : "failure";
                                    log.Message = ysRsp.Err + ":" + ysRsp.OutContext;
                                    log.CreateTime = DateTime.Now;
                                    dbSet1.Add(log);

                                    if (ysRsp.Success)
                                    {
                                        successCount++;
                                        if (successCount == snList.Count()) {
                                            itemHeader.SHIPMENT_CATEGORY6 = QimenPushStatus.Success.ToString();
                                            _logger.Info("出库单:" + itemHeader.SHIPMENT_ID + "确认成功----" + DateTime.Now);
                                        }
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(itemHeader.SHIPMENT_CATEGORY6))
                                        {
                                            itemHeader.SHIPMENT_CATEGORY6 = "1";
                                        }
                                        else
                                        {
                                            int parseResult;
                                            if (int.TryParse(itemHeader.SHIPMENT_CATEGORY6, out parseResult))
                                            {
                                                itemHeader.SHIPMENT_CATEGORY6 = (parseResult + 1).ToString();
                                            }
                                        }
                                        _logger.Info("出库单:" + itemHeader.SHIPMENT_ID + "确认失败:-" + ysRsp.OutContext + DateTime.Now);
                                    }
                                }
                            }
                            dbContext.SaveChanges();
                            dbContext1.SaveChanges();
                            continue;
                        }

                        if (cId == "CH")
                        {
                            req.CustomerId = "CH1";
                        }
                        else
                        {
                            req.CustomerId = cId;
                        }
                        req.Version = v;
                        req.Timestamp = DateTime.Now;
                        //bool pushFlag = true;

                        foreach (var itemHeader in confirmlList)
                        {
                            StockoutConfirmRequest.DeliveryOrderDomain deliveryOrder = new StockoutConfirmRequest.DeliveryOrderDomain();

                            deliveryOrder.DeliveryOrderCode = itemHeader.SHIPMENT_ID;
                            deliveryOrder.WarehouseCode = itemHeader.WAREHOUSE;
                            deliveryOrder.OrderType = itemHeader.SHIPMENT_TYPE;
                            deliveryOrder.ConfirmType = 0L;
                            deliveryOrder.DeliveryOrderId = itemHeader.INTERNAL_SHIPMENT_NUM.ToString();
                            deliveryOrder.OutBizCode = itemHeader.INTERNAL_SHIPMENT_NUM.ToString();
                            deliveryOrder.TotalOrderLines = (long)itemHeader.TOTAL_LINES;
                            deliveryOrder.Status = "DELIVERED";

                            req.DeliveryOrder = deliveryOrder;

                            List<StockoutConfirmRequest.PackageDomain> packageList = new List<StockoutConfirmRequest.PackageDomain>();
                            List<StockoutConfirmRequest.OrderLineDomain> orderLineList = new List<StockoutConfirmRequest.OrderLineDomain>();

                            foreach (var container in itemHeader.SHIPPING_CONTAINER.Where(t => t.PARENT == 0))
                            {
                                var childContainer = itemHeader.SHIPPING_CONTAINER.Where(c => c.PARENT == container.INTERNAL_CONTAINER_NUM);
                                List<StockoutConfirmRequest.ItemDomain> itemList = new List<StockoutConfirmRequest.ItemDomain>();
                                StockoutConfirmRequest.PackageDomain package = new StockoutConfirmRequest.PackageDomain();

                                foreach (var child in childContainer)
                                {
                                    StockoutConfirmRequest.ItemDomain itemDomain = new StockoutConfirmRequest.ItemDomain();
                                    itemDomain.ItemCode = child.ITEM;
                                    itemDomain.Quantity = (int)child.QUANTITY;
                                    itemList.Add(itemDomain);
                                }

                                if (string.IsNullOrEmpty(deliveryOrder.ExpressCode) || string.IsNullOrEmpty(deliveryOrder.LogisticsCode))
                                {
                                    deliveryOrder.ExpressCode = container.TRACKING_NUMBER;
                                    deliveryOrder.LogisticsCode = itemHeader.CARRIER;
                                }
                                package.ExpressCode = container.TRACKING_NUMBER;
                                package.LogisticsCode = itemHeader.CARRIER;
                                package.Items = itemList;
                                packageList.Add(package);
                            }

                            //---------------package add test data

                            //if (!packageList.Any())
                            //{

                            //    for (int i = 0; i < 1; i++)
                            //    {
                            //        List<StockoutConfirmRequest.ItemDomain> itemList = new List<StockoutConfirmRequest.ItemDomain>();
                            //        StockoutConfirmRequest.PackageDomain package = new StockoutConfirmRequest.PackageDomain();
                            //        StockoutConfirmRequest.ItemDomain itemDomain = new StockoutConfirmRequest.ItemDomain();
                            //        itemDomain.ItemCode = "1000000000203";
                            //        itemDomain.Quantity = 30;
                            //        itemList.Add(itemDomain);
                            //        package.ExpressCode = "012345678905" + i;
                            //        package.LogisticsCode = "SF";
                            //        package.Items = itemList;
                            //        packageList.Add(package);
                            //    }
                            //}
                            //---------------package add test data


                            foreach (var itemDetail in itemHeader.SHIPMENT_DETAIL)
                            {
                                StockoutConfirmRequest.OrderLineDomain orderLine = new StockoutConfirmRequest.OrderLineDomain();

                                orderLine.PlanQty = (int)itemDetail.REQUEST_QTY;
                                orderLine.ItemCode = itemDetail.ITEM;
                                orderLine.ActualQty = (int)itemDetail.REQUEST_QTY;
                                orderLine.OutBizCode = itemDetail.INTERNAL_SHIPMENT_LINE_NUM.ToString();
                                orderLine.InventoryType = itemDetail.INVENTORY_STS == "合格" ? "ZP" : "CC";
                                orderLineList.Add(orderLine);
                            }

                            req.Packages = packageList;
                            req.OrderLines = orderLineList;


                            var rsp = client.Execute(req);

                            QiMen_PushLog log = new QiMen_PushLog();
                            log.InternalOrderID = itemHeader.INTERNAL_SHIPMENT_NUM;
                            log.OrderType = INTERFACE;
                            log.CustomerId = cId;
                            log.Flag = rsp.Flag;
                            log.Message = rsp.Message;
                            log.CreateTime = DateTime.Now;
                            dbSet1.Add(log);

                            if (rsp.Flag == "success")
                            {
                                itemHeader.SHIPMENT_CATEGORY6 = QimenPushStatus.Success.ToString();
                                _logger.Info("出库单:" + itemHeader.SHIPMENT_ID + "确认成功----" + DateTime.Now);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(itemHeader.SHIPMENT_CATEGORY6))
                                {
                                    itemHeader.SHIPMENT_CATEGORY6 = "1";
                                }
                                else
                                {
                                    int parseResult;
                                    if (int.TryParse(itemHeader.SHIPMENT_CATEGORY6, out parseResult))
                                    {
                                        itemHeader.SHIPMENT_CATEGORY6 = (parseResult + 1).ToString();
                                    }
                                }
                                //if (rsp.Message.Length > 50)
                                //{
                                //    pushFlag = false;
                                //}
                                _logger.Info("出库单:" + itemHeader.SHIPMENT_ID + "确认失败:-" + rsp.Message + DateTime.Now);
                            }
                        }
                        //  if (confirmlList.Count > 0 && pushFlag) {
                        //if (confirmlList.Count > 0 && pushFlag)
                        //{
                        //    qmt.ActualShipTime = (DateTime)confirmlList.First().ACTUAL_SHIP_DATE_TIME;
                        //}
                        dbContext.SaveChanges();
                        dbContext1.SaveChanges();
                    }
                }
                _logger.Info("StockoutConfirmJob 执行完成... " + DateTime.Now + "");
            }
            catch (Exception ex)
            {
                _logger.Error("StockoutConfirmJob 异常..." + DateTime.Now + " " + ex.Message);
            }
        }
    }
}
