using Apps.Models;
using QiMenApi.Models;
using QiMenApi.Models.EntryOrderQueryModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QiMenApi.Controllers
{
    public class EntryorderQueryController : ApiController
    {
        // GET: api/EntryorderQuery
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EntryorderQuery/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EntryorderQuery
        public EntryOrderQueryResponseModel Post([FromBody]EntryOrderQueryRequestModel model)
        {
            EntryOrderQueryResponseModel response = new EntryOrderQueryResponseModel();
            using (SCVDBContainer dbContext = new SCVDBContainer()) {
                DbSet<RECEIPT_HEADER> dbSet0 = dbContext.Set<RECEIPT_HEADER>();
                DbSet<RECEIPT_DETAIL> dbSet1 = dbContext.Set<RECEIPT_DETAIL>();

                RECEIPT_HEADER header = dbSet0.FirstOrDefault(h=>h.RECEIPT_ID == model.EntryOrderCode && h.COMPANY==model.OwnerCode);
                if (header == null) {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = "无此入库单";
                    response.TotalLines = 0;
                    return response;
                }

                EntryOrder entryOrder = new EntryOrder();
                entryOrder.EntryOrderCode = model.EntryOrderCode;
                entryOrder.OwnerCode = header.COMPANY;
                entryOrder.WarehouseCode = "LK01";
                entryOrder.EntryOrderId = header.INTERNAL_RECEIPT_NUM.ToString();
                entryOrder.EntryOrderType = header.RECEIPT_TYPE;
                entryOrder.Status = header.TRAILING_STS.ToString();

                List<OrderLine> orderLines = new List<OrderLine>();
                foreach (var item in header.RECEIPT_DETAIL) {
                    OrderLine orderLine = new OrderLine();
                    orderLine.OrderLineNo = item.INTERNAL_RECEIPT_LINE_NUM.ToString();
                    orderLine.ItemCode = item.ITEM;
                    orderLine.ItemId = item.INTERNAL_RECEIPT_NUM.ToString();
                    orderLine.ItemName = item.ITEM_DESC;
                    orderLine.PlanQty = Convert.ToInt32(item.TOTAL_QTY);
                    orderLine.ActualQty =  Convert.ToInt32(item.OPEN_QTY);
                    orderLines.Add(orderLine);
                }
                response.Flag = "success";
                response.Code = "1";
                response.Message = "查询成功";
                response.TotalLines = header.RECEIPT_DETAIL.Count();
                response.EntryOrder = entryOrder;
                response.OrderLines = orderLines;
            }
            return response;
        }

        // PUT: api/EntryorderQuery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EntryorderQuery/5
        public void Delete(int id)
        {
        }
    }
}
