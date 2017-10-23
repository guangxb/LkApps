using Apps.Models;
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
    public class ReturnorderConfirmJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const string RECEIPT = "RECEIPT";
        private const string INTERFACE = "ReturnorderConfirm";
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
                _logger.Info("ReturnorderConfirm 开始执行... " + DateTime.Now + "");
                foreach (var cId in customerArr)
                {
                    using (SCVDBContainer dbContext0 = new SCVDBContainer())
                    using (DBContainer dbContext1 = new DBContainer())
                    {
                        DbSet<RECEIPT_HEADER> header = dbContext0.Set<RECEIPT_HEADER>();
                        DbSet<RECEIPT_DETAIL> detail = dbContext0.Set<RECEIPT_DETAIL>();

                        //DbSet<QiMen_PushTimeStatus> dbSet0 = dbContext1.Set<QiMen_PushTimeStatus>();
                        DbSet<QiMen_PushLog> dbSet1 = dbContext1.Set<QiMen_PushLog>();

                        IQimenClient client = new DefaultQimenClient(url, appkey, secret);
                        ReturnorderConfirmRequest req = new ReturnorderConfirmRequest();


                        //DateTime lastTime;
                        //QiMen_PushTimeStatus qmt = dbSet0.Where(q => q.CustomerId == cId && q.OrderType == RECEIPT && q.Interface == INTERFACE).FirstOrDefault();
                        //if (qmt == null)
                        //{
                        //    qmt = new QiMen_PushTimeStatus() { CustomerId = cId, ActualArriveTime = DateTime.Now, OrderType = RECEIPT, Interface = INTERFACE };
                        //    dbSet0.Add(qmt);
                        //    lastTime = DateTime.Now.AddMinutes(-1);
                        //}
                        //else
                        //{
                        //    lastTime = ((DateTime)qmt.ActualArriveTime).AddMinutes(-1);
                        //}

                        //var confirmlList = header.Where(h => h.COMPANY == cId && h.TRAILING_STS == 900 && (h.RECEIPT_TYPE).Equals("THRK",StringComparison.OrdinalIgnoreCase) && h.CLOSE_DATE >= lastTime).Include(r => r.RECEIPT_DETAIL).OrderByDescending(h => h.CLOSE_DATE).ToList();
                        var confirmlList = header.Where(h => h.COMPANY == cId
                        //&& h.CREATE_USER == "ReturnorderCreate"
                        && (h.USER_DEF8 == null || h.USER_DEF8 == QimenPushStatus.Failure.ToString()
                        || h.USER_DEF8 == "1" || h.USER_DEF8 == "2" || h.USER_DEF8 == "3" || h.USER_DEF8 == "4" || h.USER_DEF8 == "5")
                        && (h.TRAILING_STS == 800 || h.TRAILING_STS == 850 || h.TRAILING_STS == 900)
                        && h.RECEIPT_TYPE.Equals("THRK", StringComparison.OrdinalIgnoreCase)
                        ).Include(s => s.RECEIPT_DETAIL).ToList();

                        if (cId == "XGQQG")
                        {
                            confirmlList.Clear();
                        }

                        if (cId == "CQHGE")
                        {
                            confirmlList = confirmlList.Where(l => l.CREATE_USER == "ReturnorderCreate").ToList();
                        }

                        req.CustomerId = cId;
                        req.Version = v;
                        req.Timestamp = DateTime.Now;
                        //bool pushFlag = true;

                        foreach (var itemHeader in confirmlList)
                        {
                            ReturnorderConfirmRequest.ReturnOrderDomain returnOrder = new ReturnorderConfirmRequest.ReturnOrderDomain();
                            returnOrder.ReturnOrderCode = itemHeader.RECEIPT_ID;//"R1234";//item.ERP_ORDER_ID;
                            returnOrder.WarehouseCode = itemHeader.WAREHOUSE;
                            returnOrder.LogisticsCode = ""; //"SF";//item.CARRER;
                            returnOrder.OutBizCode = itemHeader.INTERNAL_RECEIPT_NUM.ToString();
                            returnOrder.OrderType = itemHeader.RECEIPT_TYPE;

                            ReturnorderConfirmRequest.SenderInfoDomain senderInfo = new ReturnorderConfirmRequest.SenderInfoDomain();
                            senderInfo.Name = itemHeader.SHIP_FROM_NAME;//"老王";//
                            senderInfo.Mobile = itemHeader.SHIP_FROM_PHONE_NUM;//"13214567869";//
                            senderInfo.Province = itemHeader.SHIP_FROM_COUNTRY;//"浙江省";//
                            senderInfo.City = itemHeader.SHIP_FROM_CITY; //"杭州"; //
                            senderInfo.DetailAddress = itemHeader.SHIP_FROM_ADDRESS1 != null ? itemHeader.SHIP_FROM_ADDRESS1 : itemHeader.SHIP_FROM_ADDRESS2;//"杭州市余杭区989号";//
                            returnOrder.SenderInfo = senderInfo;
                            req.ReturnOrder = returnOrder;

                            List<ReturnorderConfirmRequest.OrderLineDomain> orderLineList = new List<ReturnorderConfirmRequest.OrderLineDomain>();

                            foreach (var itemDetail in itemHeader.RECEIPT_DETAIL)
                            {
                                ReturnorderConfirmRequest.OrderLineDomain orderLine = new ReturnorderConfirmRequest.OrderLineDomain();
                                orderLine.ItemId = itemDetail.INTERNAL_RECEIPT_LINE_NUM.ToString();
                                orderLine.ItemName = itemDetail.ITEM_DESC;
                                orderLine.OwnerCode = itemDetail.COMPANY;
                                orderLine.ItemCode = itemDetail.ITEM;
                                orderLine.PlanQty = (long)itemDetail.TOTAL_QTY;
                                orderLine.ActualQty = (itemDetail.TOTAL_QTY - itemDetail.OPEN_QTY).ToString();
                                orderLine.OutBizCode = itemDetail.INTERNAL_RECEIPT_LINE_NUM.ToString();

                                orderLineList.Add(orderLine);
                            }
                            req.OrderLines = orderLineList;

                            var rsp = client.Execute(req);

                            QiMen_PushLog log = new QiMen_PushLog();
                            log.InternalOrderID = itemHeader.INTERNAL_RECEIPT_NUM;
                            log.OrderType = INTERFACE;
                            log.CustomerId = cId;
                            log.Flag = rsp.Flag;
                            log.Message = rsp.Message;
                            log.CreateTime = DateTime.Now;
                            dbSet1.Add(log);

                            if (rsp.Flag == "success")
                            {
                                itemHeader.USER_DEF8 = QimenPushStatus.Success.ToString();
                                _logger.Info("入库单:" + itemHeader.RECEIPT_ID + "确认成功----" + DateTime.Now);
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(itemHeader.USER_DEF8))
                                {
                                    itemHeader.USER_DEF8 = "1";
                                }
                                else
                                {
                                    int parseResult;
                                    if (int.TryParse(itemHeader.USER_DEF8, out parseResult))
                                    {
                                        itemHeader.USER_DEF8 = (parseResult + 1).ToString();
                                    }
                                }
                                //if (rsp.Message.Length > 50)
                                //{
                                //    pushFlag = false;
                                //}
                                _logger.Info("入库单:" + itemHeader.RECEIPT_ID + "确认失败:-" + rsp.Message + DateTime.Now);
                            }
                        }
                        //if (confirmlList.Count > 0 && pushFlag)
                        //{
                        //    qmt.ActualArriveTime = (DateTime)confirmlList.First().CLOSE_DATE;
                        //}
                        dbContext0.SaveChanges();
                        dbContext1.SaveChanges();
                    }
                }

                _logger.Info("ReturnorderConfirm 执行完成... " + DateTime.Now + "");
            }
            catch (Exception ex)
            {
                _logger.Error("ReturnorderConfirm 异常..." + DateTime.Now + " " + ex.Message);
            }
        }
    }
}
