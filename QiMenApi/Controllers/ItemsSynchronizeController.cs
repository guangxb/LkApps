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
            //测试相关
            //if (customerId == "c1515046170643")
            //{
            //    customerId = "HPH";
            //}
            //---------------------------------
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
                DbSet<ITEM_UNIT_OF_MEASURE> dbSet1 = dbContext.Set<ITEM_UNIT_OF_MEASURE>();

                if (model.ActionType == "update")
                {
                    foreach (var mi in model.Items)
                    {
                        Apps.Models.ITEM scvItem = dbSet.FirstOrDefault(i => i.ITEM1 == mi.ItemCode && i.COMPANY == customerId);

                        if (scvItem != null)
                        {
                            scvItem.COMPANY = model.OwnerCode;
                            scvItem.ITEM1 = mi.ItemCode;
                            scvItem.ITEM_DESC = mi.ItemName;
                            scvItem.STORAGE_TEMPLATE = "三层模板";
                            scvItem.ACTIVE = "Y";
                            scvItem.DATE_TIME_STAMP = DateTime.Now;
                            scvItem.ATTRIBUTE_TRACK = "N";
                            scvItem.ITEM_SIZE = mi.SkuProperty;
                            scvItem.ITEM_COLOR = mi.Color;
                            scvItem.ITEM_STYLE = mi.GoodsCode;
                        }

                        if (model.ActionType == "add")
                        {
                            scvItem = new Apps.Models.ITEM();
                            scvItem.COMPANY = model.OwnerCode;
                            scvItem.ITEM1 = mi.ItemCode;
                            scvItem.ITEM_DESC = mi.ItemName;
                            scvItem.STORAGE_TEMPLATE = "三层模板";
                            scvItem.ACTIVE = "Y";
                            scvItem.DATE_TIME_STAMP = DateTime.Now;
                            scvItem.ATTRIBUTE_TRACK = "N";
                            scvItem.ITEM_SIZE = mi.SkuProperty;
                            scvItem.ITEM_COLOR = mi.Color;
                            scvItem.ITEM_STYLE = mi.GoodsCode;
                            var scvItemUnit = dbSet1.FirstOrDefault(u => u.ITEM == mi.ItemCode && u.COMPANY == customerId);
                            if (scvItemUnit == null)
                            {
                                scvItemUnit = new Apps.Models.ITEM_UNIT_OF_MEASURE();
                                scvItemUnit.ITEM = mi.ItemCode;
                                scvItemUnit.COMPANY = customerId;
                                scvItemUnit.SEQUENCE = 1;
                                scvItemUnit.QUANTITY_UM = "EA";
                                scvItemUnit.CONVERSION_QTY = 1;
                                scvItemUnit.LENGTH = mi.Length;
                                scvItemUnit.WIDTH = mi.Width;
                                scvItemUnit.HEIGHT = mi.Height;
                                scvItemUnit.DIMENSION_UM = "CM";
                                scvItemUnit.WEIGHT = mi.GrossWeight;
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
                    }

                }

                if (dbContext.SaveChanges() > 0)
                {
                    reponse.Code = "0";
                    reponse.Flag = "success";
                    reponse.Message = "商品同步成功";
                }
                else
                {
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
