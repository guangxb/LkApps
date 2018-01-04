using Apps.Models;
using QiMenApi.Models;
using QiMenApi.Models.EntryorderCreateModel;
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
    public class EntryorderCreateController : ApiController
    {
        // GET: api/EntryorderCreate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EntryorderCreate/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EntryorderCreate
        public EntryorderCreateResponseModel Post([FromBody]EntryorderCreateRequestModel model, string customerId)
        {
            EntryorderCreateResponseModel response = new EntryorderCreateResponseModel();
            if (customerId == "CH1")
            {
                customerId = "CH";
            }

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "EntryorderCreate";
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
                //DbSet<RECEIPT_DETAIL> dbSet1 = dbContext.Set<RECEIPT_DETAIL> ();
                DbSet<ITEM> dbSetItem = dbContext.Set<ITEM>();

                if (dbContext.RECEIPT_HEADER.Where(h => h.RECEIPT_ID == model.EntryOrder.EntryOrderCode && h.COMPANY == customerId).Any())
                {
                    response.Flag = "success";
                    response.Code = "0";
                    response.Message = model.EntryOrder.EntryOrderCode + ":单号重复";
                    response.EntryOrderId = "";
                    return response;
                }

                RECEIPT_HEADER header = new RECEIPT_HEADER();
                header.COMPANY = customerId;
                header.RECEIPT_ID = model.EntryOrder.EntryOrderCode;
                header.WAREHOUSE = "LK01";
                header.LEADING_STS = 100;
                header.TRAILING_STS = 100;
                header.RECEIPT_TYPE =model.EntryOrder.OrderType;
                header.CREATE_USER = "EntryorderCreate";
                DateTime orderCreateTime;
                if (DateTime.TryParse(model.EntryOrder.OrderCreateTime, out orderCreateTime)) {
                    header.CREATE_DATE = orderCreateTime;
                }
                //int totalLines = Convert.ToInt32(model.EntryOrder.TotalOrderLines);
                int totalLines = model.OrderLines.Count();
                int totalQty=0;
                header.TOTAL_LINES = totalLines;

                foreach (var item in model.OrderLines) {
                    RECEIPT_DETAIL detail = new RECEIPT_DETAIL();
                    detail.RECEIPT_ID = model.EntryOrder.EntryOrderCode;
                    detail.WAREHOUSE = "LK01";
                    detail.COMPANY = item.OwnerCode;
                    detail.ITEM = item.ItemCode;
                    ITEM sItem = dbSetItem.Where(t => t.ITEM1 == item.ItemCode && t.COMPANY == customerId).FirstOrDefault();
                    if (sItem != null)
                    {
                        detail.ITEM_DESC = sItem.ITEM_DESC;
                    }
                    //detail.ITEM_DESC = item.ItemName;
                    detail.TOTAL_QTY = item.PlanQty;
                    detail.OPEN_QTY = item.PlanQty;
                    detail.QUANTITY_UM = "EA";
                    totalQty += item.PlanQty;
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

                    header.RECEIPT_DETAIL.Add(detail);
                }

                header.TOTAL_QTY = totalQty;
                dbContext.RECEIPT_HEADER.Add(header);
                
                if (dbContext.SaveChanges() > 0)
                {
                    response.Flag = "success";
                    response.Code = "1";
                    response.Message = "入库单:"+ model.EntryOrder.EntryOrderCode + ":创建成功";
                    response.EntryOrderId = header.INTERNAL_RECEIPT_NUM.ToString();
                }
                else {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = "入库单:" + model.EntryOrder.EntryOrderCode + ":创建失败";
                    response.EntryOrderId ="";
                }
            }
            return response;
        }

        // PUT: api/EntryorderCreate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EntryorderCreate/5
        public void Delete(int id)
        {
        }
    }
}
