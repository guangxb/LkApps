using Apps.Models;
using QiMenApi.Models.ReturnorderCreateModel;
using QiMenApi.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace QiMenApi.Controllers
{
    public class ReturnorderCreateController : ApiController
    {
        // GET: api/ReturnorderCreate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ReturnorderCreate/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ReturnorderCreate
        public ReturnorderCreateResponseModel Post([FromBody]ReturnorderCreateRequestModel model, [FromUri]string customerId)
        {
            ReturnorderCreateResponseModel response = new ReturnorderCreateResponseModel();

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "ReturnorderCreate";
                log.Url = Request.RequestUri.AbsoluteUri;
                log.Ip = ip;
                log.CustomerId = customerId;
                log.RequestBody = body;
                context.QiMen_RequestLog.Add(log);
                context.SaveChanges();
            }

            using (SCVDBContainer dbContext = new SCVDBContainer())
            {
                //DbSet<RECEIPT_HEADER> dbSet0 = dbContext.Set<RECEIPT_HEADER>();
                //DbSet<RECEIPT_DETAIL> dbSet1 = dbContext.Set<RECEIPT_DETAIL>();
                DbSet<ITEM> dbSetItem = dbContext.Set<ITEM>();

                if (dbContext.RECEIPT_HEADER.Where(h => h.RECEIPT_ID == model.ReturnOrder.ReturnOrderCode && h.COMPANY == customerId).Any())
                {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = model.ReturnOrder.ReturnOrderCode + ":创建失败:单号重复";
                    response.ReturnOrderId = "";
                    return response;
                }

                RECEIPT_HEADER header = new RECEIPT_HEADER();
                header.COMPANY = customerId;
                header.RECEIPT_ID = model.ReturnOrder.ReturnOrderCode;
                header.WAREHOUSE = "LK01";
                header.LEADING_STS = 100;
                header.TRAILING_STS = 100;
                header.RECEIPT_TYPE = model.ReturnOrder.OrderType;

                if (!string.IsNullOrEmpty(model.ReturnOrder.ExpressCode))
                    header.ERP_ORDER_ID = model.ReturnOrder.ExpressCode;
                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.DetailAddress))
                    header.SHIP_FROM_ADDRESS1 = model.ReturnOrder.SenderInfo.DetailAddress;
                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.City))
                    header.SHIP_FROM_CITY = model.ReturnOrder.SenderInfo.City;
                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.Province))
                    header.SHIP_FROM_STATE = model.ReturnOrder.SenderInfo.Province;
                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.ZipCode))
                    header.SHIP_FROM_POSTAL_CODE = model.ReturnOrder.SenderInfo.ZipCode;
                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.Name)) {
                    header.SHIP_FROM = model.ReturnOrder.SenderInfo.Name;
                    header.SHIP_FROM_NAME = model.ReturnOrder.SenderInfo.Name;
                    header.SHIP_FROM_ATTENTION_TO = model.ReturnOrder.SenderInfo.Name;
                }

                if (!string.IsNullOrEmpty(model.ReturnOrder.SenderInfo.Mobile))
                    header.SHIP_FROM_FAX_NUM = model.ReturnOrder.SenderInfo.Mobile;
                header.USER_STAMP = "Interface";
                header.SHIP_FROM_COUNTRY = "CN";

                //DateTime orderCreateTime;
                //if (DateTime.TryParse(model.ReturnOrder.OrderCreateTime, out orderCreateTime))
                //{
                header.CREATE_DATE = DateTime.Now;
                //}
                //int totalLines = Convert.ToInt32(model.EntryOrder.TotalOrderLines);

                int totalLines = model.OrderLines.Count();
                int totalQty = 0;
                header.TOTAL_LINES = totalLines;

                foreach (var item in model.OrderLines)
                {
                    RECEIPT_DETAIL detail = new RECEIPT_DETAIL();
                    detail.RECEIPT_ID = model.ReturnOrder.ReturnOrderCode;
                    detail.WAREHOUSE = "LK01";
                    detail.COMPANY = item.OwnerCode;
                    detail.ITEM = item.ItemCode;

                    ITEM sItem = dbSetItem.Where(t => t.ITEM1 == item.ItemCode).FirstOrDefault();
                    if (sItem != null)
                    {
                        detail.ITEM_DESC = sItem.ITEM_DESC;
                    }
                    detail.TOTAL_QTY = item.PlanQty;
                    detail.OPEN_QTY = item.PlanQty;
                    detail.QUANTITY_UM = "EA";
                    totalQty += Convert.ToInt32(item.PlanQty);
                    header.RECEIPT_DETAIL.Add(detail);
                    //if (string.Equals("ZP", item.InventoryType, StringComparison.CurrentCultureIgnoreCase))
                    //{
                    //    detail.INVENTORY_STS = "合格";
                    //}
                    //else
                    //{
                    //    detail.INVENTORY_STS = "不合格";
                    //}

                    if (item.InventoryType == null)
                    {
                        detail.INVENTORY_STS = "合格";
                    }
                    else
                    {
                        if (string.Equals("ZP", item.InventoryType, StringComparison.CurrentCultureIgnoreCase))
                        {
                            detail.INVENTORY_STS = "合格";
                        }
                        else
                        {
                            detail.INVENTORY_STS = "不合格";
                        }
                    }
                }

                header.TOTAL_QTY = totalQty;
                dbContext.RECEIPT_HEADER.Add(header);

                if (dbContext.SaveChanges() > 0)
                {
                    response.Flag = "success";
                    response.Code = "0";
                    response.Message = "入库单:" + model.ReturnOrder.ReturnOrderCode + ":创建成功";
                    response.ReturnOrderId = header.INTERNAL_RECEIPT_NUM.ToString();
                }
                else
                {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = "入库单:" + model.ReturnOrder.ReturnOrderCode + ":创建失败";
                    response.ReturnOrderId = "";
                }
            }
            return response;
        }

        // PUT: api/ReturnorderCreate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ReturnorderCreate/5
        public void Delete(int id)
        {
        }
    }
}
