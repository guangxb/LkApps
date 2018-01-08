using Apps.Models;
using QiMenApi.Models.SingleitemSynchronizeModel;
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
    public class SingleitemSynchronizeController : ApiController
    {

        // GET: api/SingleitemSynchronize
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SingleitemSynchronize/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SingleitemSynchronize
        public SingleitemSynchronizeResponseModel Post([FromBody]SingleitemSynchronizeRequestModel model, string customerId)
        {
            //测试相关
            //if (customerId == "c1515046170643")
            //{
            //    customerId = "HPH";
            //}
            //---------------------------------
            if (customerId == "CH1")
            {
                customerId = "CH";
            }
            SingleitemSynchronizeResponseModel response = new SingleitemSynchronizeResponseModel();

            using (DBContainer context = new DBContainer())
            {
                QiMen_RequestLog log = new QiMen_RequestLog();
                HttpContextBase ctx = (HttpContextBase)Request.Properties["MS_HttpContext"];
                string body = ApiUtils.GetStreamAsString(ctx.Request.InputStream, new UTF8Encoding(false));
                string ip = ctx.Request.UserHostAddress;

                log.Interface = "SingleitemSynchronize";
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
                DbSet<ITEM_UNIT_OF_MEASURE> dbSet1 = dbContext.Set<ITEM_UNIT_OF_MEASURE>();
                Apps.Models.ITEM scvItem=null;
                if (model.ActionType == "update")
                {
                    scvItem = dbSet.FirstOrDefault(i => i.ITEM1 == model.Item.ItemCode && i.COMPANY == customerId);
                    
                    if (scvItem != null)
                    {
                        scvItem.COMPANY = model.OwnerCode;
                        scvItem.ITEM1 = model.Item.ItemCode;
                        scvItem.ITEM_DESC = model.Item.ItemName;
                        scvItem.STORAGE_TEMPLATE = "三层模板";
                        scvItem.ACTIVE = "Y";
                        scvItem.DATE_TIME_STAMP = DateTime.Now;
                        scvItem.ATTRIBUTE_TRACK = "N";
                        scvItem.ITEM_SIZE = model.Item.SkuProperty;
                        scvItem.ITEM_COLOR = model.Item.Color;
                        scvItem.ITEM_STYLE = model.Item.GoodsCode;
                    }
                }
                if (model.ActionType == "add")
                {
                    scvItem = new Apps.Models.ITEM();
                    scvItem.COMPANY = model.OwnerCode;
                    scvItem.ITEM1 = model.Item.ItemCode;
                    scvItem.ITEM_DESC = model.Item.ItemName;
                    scvItem.STORAGE_TEMPLATE = "三层模板";
                    scvItem.ACTIVE = "Y";
                    scvItem.DATE_TIME_STAMP = DateTime.Now;
                    scvItem.ATTRIBUTE_TRACK = "N";
                    scvItem.ITEM_SIZE = model.Item.SkuProperty;
                    scvItem.ITEM_COLOR = model.Item.Color;
                    scvItem.ITEM_STYLE = model.Item.GoodsCode;
                    var scvItemUnit = dbSet1.FirstOrDefault(u => u.ITEM == model.Item.ItemCode && u.COMPANY == customerId);
                    if (scvItemUnit == null) {
                        scvItemUnit = new Apps.Models.ITEM_UNIT_OF_MEASURE();
                        scvItemUnit.ITEM = model.Item.ItemCode;
                        scvItemUnit.COMPANY = customerId;
                        scvItemUnit.SEQUENCE = 1;
                        scvItemUnit.QUANTITY_UM = "EA";
                        scvItemUnit.CONVERSION_QTY = 1;
                        scvItemUnit.LENGTH = model.Item.Length;
                        scvItemUnit.WIDTH = model.Item.Width;
                        scvItemUnit.HEIGHT = model.Item.Height;
                        scvItemUnit.DIMENSION_UM = "CM";
                        scvItemUnit.WEIGHT = model.Item.GrossWeight;
                        scvItemUnit.WEIGHT_UM = "KG";
                        scvItemUnit.USER_STAMP = "Interface";
                        scvItemUnit.DATE_TIME_STAMP = DateTime.Now;
                        scvItemUnit.TREAT_FULL_PCT = 100;
                        scvItemUnit.TREAT_AS_LOOSE = "Y";
                        scvItemUnit.GROUP_DURING_CHECKIN = "Y";
                        scvItemUnit.USER_DEF7 = "0";
                        scvItemUnit.USER_DEF8 = "0";
                        dbSet1.Add(scvItemUnit);
                    }

                    dbSet.Add(scvItem);
                }

                if (dbContext.SaveChanges() >= 0)
                {
                    response.Code = "0";
                    response.Flag = "success";
                    response.Message = "商品同步成功";
                    response.ItemId = scvItem.INTERNAL_ITEM_NUM.ToString();
                }
                else
                {
                    response.Code = "-1";
                    response.Flag = "failure";
                    response.Message = "商品同步失败，请重试";
                }
            }


            return response;
        }

        // PUT: api/SingleitemSynchronize/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SingleitemSynchronize/5
        public void Delete(int id)
        {
        }
    }
}
