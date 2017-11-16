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
    public class InventoryQueryController : ApiController
    {
        public InventoryQueryResponse Post([FromBody]InventoryQueryRequest model, string customerId)
        {
            var response = new InventoryQueryResponse();

            if (customerId == "RB")
            {
                using (SCVDBContainer dbContext = new SCVDBContainer())
                {
                   
                    foreach (var criteria in model.CriteriaList) {
                        if (string.IsNullOrEmpty(criteria.ItemCode)) {
                            continue;
                        }

                      var lis =  dbContext.LOCATION_INVENTORY.Where(l => l.COMPANY == customerId && l.ITEM == criteria.ItemCode);

                        foreach (var li in lis) {
                            InventoryQueryResponse.ItemDomain itemDomain = new InventoryQueryResponse.ItemDomain();
                            itemDomain.WarehouseCode = "LK01";
                            itemDomain.ItemCode = criteria.ItemCode;
                            if (li.INVENTORY_STS == "合格")
                            {
                                itemDomain.InventoryType = "ZP";
                            }
                            else {
                                itemDomain.InventoryType = "CC";
                            }

                            itemDomain.Quantity = Convert.ToInt32(li.ON_HAND_QTY);
                            itemDomain.LockQuantity = Convert.ToInt32(li.IN_TRANSIT_QTY) + Convert.ToInt32(li.ALLOCATED_QTY);
                            if (li.ATTRIBUTE3 != null) {
                                itemDomain.ExpireDate = li.ATTRIBUTE3;
                            }

                            response.Items.Add(itemDomain);
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

            if (response.Items.Any())
            {
                response.Flag = "success";
                response.Code = "1";
                response.Message = "查询成功";
            }
            else {
                response.Flag = "success";
                response.Code = "1";
                response.Message = "无数据";
            }
           
            return response;
        }
    }
}
