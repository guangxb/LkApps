using Apps.Models;
using Common.Logging;
using log4net.Ext;
using Qimen.Api;
using Qimen.Api.Request;
using Qimen.Api.Response;
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
    public class DeliveryorderConfirmJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const string SHIPMENT = "SHIPMENT";
        private const string INTERFACE = "DeliveryorderConfirm";

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
                _logger.Info("DeliveryorderConfirmJob 开始执行... " + DateTime.Now + "");
                //_logger.Info(1,"Reicept","123", "Success","开始执行");
                //for (int i = 0; i < 5; i++)
                //{
                //    _logger.Info("SimpleQuartzJob start... " + i + " " + DateTime.Now + "");
                //    Console.WriteLine("SimpleQuartzJob running..." + i);
                //}
                using (SCVDBContainer dbContext = new SCVDBContainer())
                using (DBContainer dbContext1 = new DBContainer())
                {
                    DbSet<SHIPMENT_HEADER> header = dbContext.Set<SHIPMENT_HEADER>();
                    DbSet<SHIPMENT_DETAIL> detail = dbContext.Set<SHIPMENT_DETAIL>();
                    //DbSet<SHIPMENT_HEADER_TEMP> headerTemp = dbContext.Set<SHIPMENT_HEADER_TEMP>();
                    //DbSet<QiMen_PushTimeStatus> dbSet0 = dbContext1.Set<QiMen_PushTimeStatus>();
                    DbSet<QiMen_PushLog> dbSet1 = dbContext1.Set<QiMen_PushLog>();
                    //Spm_LastTime sl = dbSet0.Find("1");
                    //DateTime lastTime = ((DateTime)sl.ActualShipDateTime).AddMinutes(-1);

                    IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                    DeliveryorderConfirmRequest req = new DeliveryorderConfirmRequest();

                    foreach (var cId in customerArr)
                    {
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
                        //DateTime lastTime = dbSet0.Where()   //&& !(h.SHIPMENT_TYPE.Equals("LKCK", StringComparison.OrdinalIgnoreCase))
                        //var confirmlList = header.Where(h => h.COMPANY == cId && h.TRAILING_STS == 900 && h.ACTUAL_SHIP_DATE_TIME >= lastTime).OrderByDescending(h => h.ACTUAL_SHIP_DATE_TIME).Include(s => s.SHIPMENT_DETAIL).Include(s => s.SHIPPING_CONTAINER).AsNoTracking().ToList();
                        var confirmlList = header.Where(h => h.COMPANY == cId
                        && (h.SHIPMENT_CATEGORY6 == null || h.SHIPMENT_CATEGORY6 == QimenPushStatus.Failure.ToString()
                        ||  h.SHIPMENT_CATEGORY6 == "1" || h.SHIPMENT_CATEGORY6 == "2" || h.SHIPMENT_CATEGORY6 == "3" || h.SHIPMENT_CATEGORY6 == "4" || h.SHIPMENT_CATEGORY6 == "5")
                        && (h.TRAILING_STS == 800 || h.TRAILING_STS == 850 || h.TRAILING_STS == 900)
                        && (h.PROCESS_TYPE == "NORMAL")
                        ).Include(s => s.SHIPMENT_DETAIL).Include(s => s.SHIPPING_CONTAINER).ToList();

                        req.CustomerId = cId;
                        req.Version = v;
                        req.Timestamp = DateTime.Now;
                        //bool pushFlag = true;

                        foreach (var itemHeader in confirmlList)
                        {
                            DeliveryorderConfirmRequest.DeliveryOrderDomain deliveryOrder = new DeliveryorderConfirmRequest.DeliveryOrderDomain();
                            deliveryOrder.DeliveryOrderCode = itemHeader.SHIPMENT_ID;
                            deliveryOrder.WarehouseCode = itemHeader.WAREHOUSE;
                            deliveryOrder.OrderType = itemHeader.SHIPMENT_TYPE;//"JYCK"
                            deliveryOrder.ConfirmType = 0L;               //仅仅确认最终状态的订单
                            deliveryOrder.OutBizCode = itemHeader.INTERNAL_SHIPMENT_NUM.ToString();
                            deliveryOrder.DeliveryOrderId = itemHeader.INTERNAL_SHIPMENT_NUM.ToString();
                            req.DeliveryOrder = deliveryOrder;


                            List<DeliveryorderConfirmRequest.PackageDomain> packageList = new List<DeliveryorderConfirmRequest.PackageDomain>();
                            List<DeliveryorderConfirmRequest.OrderLineDomain> orderLineList = new List<DeliveryorderConfirmRequest.OrderLineDomain>();

                            foreach (var container in itemHeader.SHIPPING_CONTAINER.Where(t => t.PARENT == 0))
                            {
                                var childContainer = itemHeader.SHIPPING_CONTAINER.Where(c => c.PARENT == container.INTERNAL_CONTAINER_NUM);
                                List<DeliveryorderConfirmRequest.ItemDomain> itemList = new List<DeliveryorderConfirmRequest.ItemDomain>();
                                DeliveryorderConfirmRequest.PackageDomain package = new DeliveryorderConfirmRequest.PackageDomain();

                                foreach (var child in childContainer)
                                {
                                    DeliveryorderConfirmRequest.ItemDomain itemDomain = new DeliveryorderConfirmRequest.ItemDomain();
                                    itemDomain.ItemCode = child.ITEM;
                                    itemDomain.Quantity = (int)child.QUANTITY;
                                    itemList.Add(itemDomain);
                                }

                                package.ExpressCode = container.TRACKING_NUMBER;
                                package.LogisticsCode = itemHeader.CARRIER;
                                package.Items = itemList;
                                packageList.Add(package);
                            }

                            //if (!packageList.Any()) {

                            //    for (int i = 0; i < 5; i++) {
                            //        List<DeliveryorderConfirmRequest.ItemDomain> itemList = new List<DeliveryorderConfirmRequest.ItemDomain>();
                            //        DeliveryorderConfirmRequest.PackageDomain package = new DeliveryorderConfirmRequest.PackageDomain();
                            //        DeliveryorderConfirmRequest.ItemDomain itemDomain = new DeliveryorderConfirmRequest.ItemDomain();
                            //        itemDomain.ItemCode = "love100c2001";
                            //        itemDomain.Quantity = 2;
                            //        itemList.Add(itemDomain);
                            //        package.ExpressCode = "Test123456789" + i;
                            //        package.LogisticsCode = "ZTO";
                            //        package.Items = itemList;
                            //        packageList.Add(package);
                            //    }
                            //}


                            foreach (var itemDetail in itemHeader.SHIPMENT_DETAIL)
                            {
                                DeliveryorderConfirmRequest.OrderLineDomain orderLine = new DeliveryorderConfirmRequest.OrderLineDomain();

                                orderLine.PlanQty = itemDetail.REQUEST_QTY.ToString();
                                orderLine.ItemCode = itemDetail.ITEM;
                                orderLine.ActualQty = itemDetail.REQUEST_QTY.ToString();
                                orderLine.OutBizCode = itemDetail.INTERNAL_SHIPMENT_LINE_NUM.ToString();
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
                                _logger.Info("发货单:" + itemHeader.SHIPMENT_ID + "确认成功----" + DateTime.Now);
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
                                _logger.Info("发货单:" + itemHeader.SHIPMENT_ID + "确认失败:-" + rsp.Message + DateTime.Now);
                            }
                        }

                        //if (confirmlList.Count > 0 && pushFlag)
                        //{
                        //    qmt.ActualShipTime = (DateTime)confirmlList.First().ACTUAL_SHIP_DATE_TIME;
                        //}
                    }
                    dbContext.SaveChanges();
                    dbContext1.SaveChanges();
                }
                _logger.Info("DeliveryorderConfirmJob 执行完成... " + DateTime.Now + "");
            }
            catch (Exception ex)
            {
                _logger.Error("DeliveryorderConfirmJob 异常..." + DateTime.Now + " " + ex.Message);
            }
        }
    }
}
