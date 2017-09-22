using Apps.Models;
using QiMenApi.Models.OrderCancelModel;
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
    public class OrderCancelController : ApiController
    {
        // GET: api/OrderCancel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrderCancel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrderCancel
        public OrderCancelResponseModel Post([FromBody]OrderCancelRequestModel model, string customerId)
        {
            OrderCancelResponseModel response = new OrderCancelResponseModel();

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "OrderCancel";
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
                //DbSet<SHIPMENT_HEADER> dbSet1 = dbContext.Set<SHIPMENT_HEADER>();

                RECEIPT_HEADER rHeader = dbContext.RECEIPT_HEADER.FirstOrDefault(r => r.RECEIPT_ID == model.OrderCode && r.COMPANY == customerId);
                SHIPMENT_HEADER sHeader = dbContext.SHIPMENT_HEADER.FirstOrDefault(r => r.SHIPMENT_ID == model.OrderCode && r.COMPANY == customerId);

                if (sHeader != null)
                {
                    if (sHeader.TRAILING_STS >= 750)
                    {
                        response.Flag = "failure";
                        response.Code = "-1";
                        response.Message = model.OrderCode + ":当前状态不允许取消";
                        return response;
                    }

                    if (sHeader.PROCESS_TYPE.Equals("CANCEL", StringComparison.OrdinalIgnoreCase))
                    {
                        response.Flag = "success";
                        response.Code = "0";
                        response.Message = model.OrderCode + ":该订单已经取消";
                        return response;
                    }
                    else
                    {
                        sHeader.PROCESS_TYPE = "CANCEL";
                        sHeader.SHIPMENT_CATEGORY6 = "Cancel";
                    }
                }
                else if (rHeader != null)
                {

                    //response.Flag = "failure";
                    //response.Code = "-1";
                    //response.Message = model.OrderCode + ":入库单取消,请联系商务";
                    //return response;
                    if (rHeader.LEADING_STS == 100 && rHeader.TRAILING_STS == 100)
                    {
                        rHeader.LEADING_STS = 900;
                        rHeader.TRAILING_STS = 900;
                        rHeader.USER_DEF8 = "Cancel";
                        //rHeader.CLOSE_DATE = DateTime.Now.AddHours(-4);
                    }
                    else {
                        response.Flag = "failure";
                        response.Code = "-1";
                        response.Message = model.OrderCode + "已收货不允许取消";
                        return response;
                    }
                }

                if (dbContext.SaveChanges() >= 0)
                {
                    response.Flag = "success";
                    response.Code = "0";
                    response.Message = model.OrderCode + ":取消成功";
                }
                else
                {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = model.OrderCode + ":取消失败";
                }
            }

            return response;
        }

        // PUT: api/OrderCancel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrderCancel/5
        public void Delete(int id)
        {
        }
    }
}
