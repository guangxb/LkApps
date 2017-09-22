using Apps.Models;
using QiMenApi.Models;
using QiMenApi.Models.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QiMenApi.Controllers
{
    public class DeliveryorderQueryController : ApiController
    {
        // GET: api/DeliveryorderQuery
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DeliveryorderQuery/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DeliveryorderQuery
        public DeliveryorderQueryResponseModel Post([FromBody]DeliveryorderQueryRequestModel model)
        {
            DeliveryorderQueryResponseModel response = new DeliveryorderQueryResponseModel();
            using (SCVDBContainer dbContext = new SCVDBContainer())
            {
                DbSet<SHIPMENT_HEADER> dbSet0 = dbContext.Set<SHIPMENT_HEADER>();
                DbSet<SHIPMENT_DETAIL> dbSet1 = dbContext.Set<SHIPMENT_DETAIL>();
                SHIPMENT_HEADER header = dbSet0.FirstOrDefault(h => h.SHIPMENT_ID == model.OrderCode && h.COMPANY == model.OwnerCode);
                if (header == null)
                {
                    response.Flag = "failure";
                    response.Code = "-1";
                    response.Message = "无此出库单";
                    response.TotalLines = 0;
                    return response;
                }
                int page = (int)model.Page;
                int pageSize = (int)model.PageSize;

                response.Flag = "success";
                response.Code = "1";
                response.Message = "查询成功";
                response.TotalLines = header.SHIPMENT_DETAIL.Count();
                DeliveryorderQueryResponseModel.DeliveryOrderDomain deliveryOrder = new DeliveryorderQueryResponseModel.DeliveryOrderDomain();
                DeliveryorderQueryResponseModel.PackageDomain package = new DeliveryorderQueryResponseModel.PackageDomain();
                List<DeliveryorderQueryResponseModel.PackageDomain> packages = new List<DeliveryorderQueryResponseModel.PackageDomain>();
                DeliveryorderQueryResponseModel.OrderLineDomain orderLine = new DeliveryorderQueryResponseModel.OrderLineDomain();
                List<DeliveryorderQueryResponseModel.OrderLineDomain> orderLines = new List<DeliveryorderQueryResponseModel.OrderLineDomain>();

                deliveryOrder.DeliveryOrderCode = header.SHIPMENT_ID;
                deliveryOrder.DeliveryOrderId = header.INTERNAL_SHIPMENT_NUM.ToString();
                deliveryOrder.WarehouseCode = header.WAREHOUSE;
                deliveryOrder.OrderType = header.SHIPMENT_TYPE;
                if (header.LEADING_STS == 900 && header.TRAILING_STS == 900) {
                    deliveryOrder.Status = DeliveryorderQueryStatusEnum.DELIVERED.ToString();
                }
                

            }
            return response;
        }

        // PUT: api/DeliveryorderQuery/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DeliveryorderQuery/5
        public void Delete(int id)
        {
        }
    }
}
