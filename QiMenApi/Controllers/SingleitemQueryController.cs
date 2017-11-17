using Apps.Models;
using Qimen.Api.Request;
using Qimen.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QiMenApi.Controllers
{
    public class SingleitemQueryController : ApiController
    {
        public SingleitemQueryResponse Post([FromBody]SingleitemQueryRequest model, string customerId)
        {
            var response = new SingleitemQueryResponse();
            response.Item = new SingleitemQueryResponse.ItemDomain();
            if (customerId == "RB")
            {
                using (SCVDBContainer dbContext = new SCVDBContainer())
                {
                    if (string.IsNullOrEmpty(model.ItemCode))
                    {
                        response.Flag = "failure";
                        response.Code = "-1";
                        response.Message = "查询条件错误";
                    }
                    else
                    {
                        var result = dbContext.ITEM.FirstOrDefault(i => i.COMPANY == customerId && i.ITEM1 == model.ItemCode);
                        if (result == null)
                        {
                            response.Flag = "failure";
                            response.Code = "-1";
                            response.Message = "无此商品";
                        }
                        else {
                            response.Flag = "success";
                            response.Code = "1";
                            response.Message = "查询成功";
                            response.Item.ItemCode = result.ITEM1;
                            response.Item.ItemName = result.ITEM_DESC;
                            response.Item.SkuProperty = result.ITEM_SIZE;
                            response.Item.Color = result.ITEM_COLOR;
                            response.Item.GoodsCode = result.ITEM_STYLE;
                        }
                    }
                }
            }
            else
            {
                response.Flag = "failure";
                response.Code = "-1";
                response.Message = "无数据";
            }
            return response;
        }
    }
}
