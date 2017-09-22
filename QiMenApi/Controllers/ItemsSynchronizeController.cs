using Apps.Models;
using QiMenApi.Models.ItemsSynchronizeModel;
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
using System.Web.Http.Controllers;

namespace QiMenApi.Controllers
{
    public class ItemsSynchronizeController : ApiController
    {
        // GET: api/ItemsSynchronize
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ItemsSynchronize/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ItemsSynchronize
        public ItemsSynchronizeResponseModel Post([FromBody]ItemsSynchronizeRequestModel model, string customerId)
        {
            ItemsSynchronizeResponseModel reponse = new ItemsSynchronizeResponseModel();
            //BatchItemSynItem synItem = new BatchItemSynItem();
            //List<BatchItemSynItem> list = new List<BatchItemSynItem>();

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "ItemsSynchronize";
                log.Url = Request.RequestUri.AbsoluteUri;
                log.Ip = ip;
                log.CustomerId = customerId;
                log.RequestBody = body;
                context.QiMen_RequestLog.Add(log);
                context.SaveChanges();
            }

            using (SCVDBContainer dbContext = new SCVDBContainer())
            {
                DbSet<ITEM> dbSet = dbContext.Set<ITEM>();
                if (model.ActionType == "update")
                {
                    foreach (var mi in model.Items)
                    {
                        Apps.Models.ITEM scvItem  = dbSet.FirstOrDefault(i => i.ITEM1 == mi.ItemCode && i.COMPANY == customerId);
                        if (scvItem != null)
                        {
                            scvItem.COMPANY = customerId;
                            scvItem.ITEM1 = mi.ItemCode;
                            scvItem.ITEM_DESC = mi.ItemName;
                            scvItem.STORAGE_TEMPLATE = "三层模板";
                            scvItem.ACTIVE = "Y";
                            scvItem.DATE_TIME_STAMP = DateTime.Now;
                            scvItem.ATTRIBUTE_TRACK = "N";
                        }
                    }

                }
                if (model.ActionType == "add")
                {
                    foreach (var mi in model.Items)
                    {
                        Apps.Models.ITEM scvItem = new Apps.Models.ITEM();

                        scvItem = new Apps.Models.ITEM();
                        scvItem.COMPANY = model.OwnerCode;
                        scvItem.ITEM1 = mi.ItemCode;
                        scvItem.ITEM_DESC = mi.ItemName;
                        scvItem.STORAGE_TEMPLATE = "三层模板";
                        scvItem.ACTIVE = "Y";
                        scvItem.DATE_TIME_STAMP = DateTime.Now;
                        scvItem.ATTRIBUTE_TRACK = "N";
                        dbSet.Add(scvItem);
                    }
                }

                if (dbContext.SaveChanges() > 0)
                {
                    reponse.Code = "0";
                    reponse.Flag = "success";
                    reponse.Message = "商品同步成功";
                }
                else {
                    reponse.Code = "-1";
                    reponse.Flag = "failure";
                    reponse.Message = "商品同步失败，请重试";
                }
            }

            //synItem.ItemCode = "123";
            //synItem.Message = "错误";
            //list.Add(synItem);
            //reponse.Items = list;

            return reponse;
        }

        // PUT: api/ItemsSynchronize/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ItemsSynchronize/5
        public void Delete(int id)
        {
        }
    }
}
