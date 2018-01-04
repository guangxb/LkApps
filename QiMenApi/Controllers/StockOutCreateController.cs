﻿using Apps.Models;
using QiMenApi.Models.StockOutCreateModel;
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
    public class StockoutCreateController : ApiController
    {
        // GET: api/StockoutCreate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/StockoutCreate/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StockoutCreate
        public StockOutCreateResponseModel Post([FromBody]StockOutCreateRequestModel model,string customerId)
        {
            if (customerId == "CH1")
            {
                customerId = "CH";
            }
            StockOutCreateResponseModel response = new StockOutCreateResponseModel();

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "StockOutCreate";
                log.Url = Request.RequestUri.AbsoluteUri;
                log.Ip = ip;
                log.CustomerId = customerId;
                log.RequestBody = body;
                context.QiMen_RequestLog.Add(log);
                context.SaveChanges();
            }


            using (SCVDBContainer dbContext = new SCVDBContainer())
            {
                //DbSet<SHIPMENT_HEADER> dbSet0 = dbContext.Set<SHIPMENT_HEADER>();
                //DbSet<SHIPMENT_DETAIL> dbSet1 = dbContext.Set<SHIPMENT_DETAIL>();
                DbSet<ITEM> dbSetItem = dbContext.Set<ITEM>();

                if (dbContext.SHIPMENT_HEADER.Where(h => h.SHIPMENT_ID == model.DeliveryOrder.DeliveryOrderCode && h.COMPANY == customerId).Any())
                {
                    response.Flag = "success";
                    response.Code = "0";
                    response.Message = model.DeliveryOrder.DeliveryOrderCode + ":单号重复";
                    response.DeliveryOrderId = "";
                    return response;
                }

                SHIPMENT_HEADER header = new SHIPMENT_HEADER();
                header.WAREHOUSE = "LK01";
                header.SHIPMENT_TYPE = model.DeliveryOrder.OrderType;
                header.SHIPMENT_ID = model.DeliveryOrder.DeliveryOrderCode;
                header.CREATE_USER = "StockOutCreate";
                DateTime time;
                if (DateTime.TryParse(model.DeliveryOrder.CreateTime,out time)) {
                    header.CREATE_DATE_TIME = time;
                }
                header.COMPANY = customerId;
                header.LEADING_STS = 100;
                header.TRAILING_STS = 100;
                header.SHIP_TO_NAME = model.DeliveryOrder.ReceiverInfo.Name;
                header.SHIP_TO_MOBILE = model.DeliveryOrder.ReceiverInfo.Mobile;
                header.SHIP_TO_DISTRICT = model.DeliveryOrder.ReceiverInfo.Area;
                header.SHIP_TO_CITY = model.DeliveryOrder.ReceiverInfo.City;
                header.SHIP_TO_STATE = model.DeliveryOrder.ReceiverInfo.Province;
                header.SHIPMENT_NOTE = model.DeliveryOrder.ReceiverInfo.Remark;
                header.SHIP_TO_ADDRESS1 = model.DeliveryOrder.ReceiverInfo.DetailAddress;
                header.CARRIER = model.DeliveryOrder.LogisticsCode;
                header.PROCESS_TYPE = "NORMAL";
                header.CREATE_USER = "StockOutCreate";
                header.TOTAL_LINES = model.OrderLines.Count();
                int totalQty = 0;

                foreach (var item in model.OrderLines) {
                    SHIPMENT_DETAIL detail = new SHIPMENT_DETAIL();
                    
                    detail.WAREHOUSE = "LK01";
                    detail.COMPANY = item.OwnerCode;
                    detail.SHIPMENT_ID = model.DeliveryOrder.DeliveryOrderCode;
                    detail.ITEM = item.ItemCode;
                    ITEM sItem = dbSetItem.Where(t => t.ITEM1 == item.ItemCode).FirstOrDefault();
                    if (sItem != null)
                    {
                        detail.ITEM_DESC = sItem.ITEM_DESC;
                    }
                    //detail.ITEM_DESC = item.ItemName;
                    detail.REQUEST_QTY = Convert.ToInt32(item.PlanQty);
                    detail.QUANTITY_UM = "EA";
                    detail.DATE_TIME_STAMP = time;
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
                    //detail.INVENTORY_STS = item.InventoryType;
                    detail.STATUS = 100;
                    totalQty += Convert.ToInt32(item.PlanQty);
                    header.SHIPMENT_DETAIL.Add(detail);
                }
                header.TOTAL_QTY = totalQty;
                dbContext.SHIPMENT_HEADER.Add(header);

                if (dbContext.SaveChanges() > 0)
                {
                    response.Flag = "success";
                    response.Code = "1";
                    response.Message = "入库单:" + model.DeliveryOrder.DeliveryOrderCode + ":创建成功";
                    response.DeliveryOrderId = header.INTERNAL_SHIPMENT_NUM.ToString();
                }
                else
                {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = "入库单:" + model.DeliveryOrder.DeliveryOrderCode + ":创建失败";
                    response.DeliveryOrderId = ""  ;
                }
            }
            return response;
        }

        // PUT: api/StockoutCreate/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/StockoutCreate/5
        public void Delete(int id)
        {
        }
    }
}
