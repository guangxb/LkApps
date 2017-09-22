
using Apps.Common;
using Apps.Models;
using Apps.Models.SCV.LOCATION;
using Apps.Models.Sys;
using Apps.Web.Areas.Query.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Areas.Query.Controllers
{
    public class QueryController : Apps.Web.Core.BaseController
    {
        ValidationErrors errors = new ValidationErrors();
        string searchNo;
        string gidPager;
        // GET: Query/Query
        public ActionResult Index()
        {

            if (OpeCur.AccountNow != null)
            {
                SysConfigModel siteConfig = OpeCur.ServiceSession.SysConfig.LoadConfig(Utils.GetXmlMapPath("Configpath"));
                //获取是否开启WEBIM
                ViewBag.IsEnable = siteConfig.webimstatus;
                //获取信息间隔时间
                ViewBag.NewMesTime = siteConfig.refreshnewmessage;
                //系统名称
                ViewBag.WebName = siteConfig.webname;
                //公司名称
                ViewBag.ComName = siteConfig.webcompany;
                //版权
                ViewBag.CopyRight = siteConfig.webcopyright;

                return View(OpeCur.AccountNow);
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetList(GridPager pager, string queryStr)
        {
            var queryList = await FilterData(pager, queryStr);
            if (queryList == null)
            {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据！");
            }

            List<QueryViewModel> GetList = new List<QueryViewModel>();
            QueryViewModel modelItem = new QueryViewModel();


            pager.totalRows = queryList.Count();
            queryList = queryList.Skip((pager.page - 1) * pager.rows).Take(pager.rows).ToList();

            foreach (var item in queryList)
            {
                modelItem = await Task.Run(() => { return GetDataOfExpiry(item); });
                GetList.Add(modelItem);
            }

            GridRows<QueryViewModel> grs = new GridRows<QueryViewModel>();

            #region 排序
            if (pager.order == "asc")
            {
                if (pager.sort == "ITEM")
                {
                    GetList = GetList.OrderBy(t => t.ITEM).ToList();
                }
                if (pager.sort == "COMPANY")
                {
                    GetList = GetList.OrderBy(t => t.COMPANY).ToList();
                }
                if (pager.sort == "ATTRIBUTE_NUM")
                {
                    GetList = GetList.OrderBy(t => t.ATTRIBUTE_NUM).ToList();
                }
                if (pager.sort == "ON_HAND_QTY")
                {
                    GetList = GetList.OrderBy(t => t.ON_HAND_QTY).ToList();
                }
                if (pager.sort == "IsQualified")
                {
                    GetList = GetList.OrderBy(t => t.IsQualified).ToList();
                }
                if (pager.sort == "IsNotQualified")
                {
                    GetList = GetList.OrderBy(t => t.IsNotQualified).ToList();
                }
                if (pager.sort == "DaysToExpire")
                {
                    GetList = GetList.OrderBy(t => t.DaysToExpire).ToList();
                }
                if (pager.sort == "DateOfProduction")
                {
                    GetList = GetList.OrderBy(t => t.DateOfProduction).ToList();
                }
                if (pager.sort == "DateOfExpiry")
                {
                    GetList = GetList.OrderBy(t => t.DateOfExpiry).ToList();
                }
            }
            else
            {
                if (pager.sort == "ITEM")
                {
                    GetList = GetList.OrderByDescending(t => t.ITEM).ToList();
                }
                if (pager.sort == "COMPANY")
                {
                    GetList = GetList.OrderByDescending(t => t.COMPANY).ToList();
                }
                if (pager.sort == "ATTRIBUTE_NUM")
                {
                    GetList = GetList.OrderByDescending(t => t.ATTRIBUTE_NUM).ToList();
                }
                if (pager.sort == "ON_HAND_QTY")
                {
                    GetList = GetList.OrderByDescending(t => t.ON_HAND_QTY).ToList();
                }
                if (pager.sort == "IsQualified")
                {
                    GetList = GetList.OrderByDescending(t => t.IsQualified).ToList();
                }
                if (pager.sort == "IsNotQualified")
                {
                    GetList = GetList.OrderByDescending(t => t.IsNotQualified).ToList();
                }
                if (pager.sort == "DaysToExpire")
                {
                    GetList = GetList.OrderByDescending(t => t.DaysToExpire).ToList();
                }
                if (pager.sort == "DateOfProduction")
                {
                    GetList = GetList.OrderByDescending(t => t.DateOfProduction).ToList();
                }
                if (pager.sort == "DateOfExpiry")
                {
                    GetList = GetList.OrderByDescending(t => t.DateOfExpiry).ToList();
                }
            }
            #endregion
            grs.rows = GetList;
            grs.total = pager.totalRows;

            return Json(grs);
        }

        private async Task<List<QueryViewModel>> FilterData(GridPager pager, string queryStr)
        {
            var Datalist = OpeCur.SCVServiceSession.LOCATION_INVENTORY.GetList().ToList();//获取所有数据
            if ((!string.IsNullOrEmpty(queryStr)) && queryStr != "")
            {
                Datalist = Datalist.Where(t => t.ITEM.ToLower().Contains(queryStr.Trim().ToLower())).ToList();

                if (Datalist == null)
                {
                    return null;
                }
            }
            string userID = OpeCur.AccountNow.Id;
            //整合所属商家数据
            List<SysUserMerchantCodeModel> companyList = OpeCur.ServiceSession.SysUserMerchantCode.GetList().Where(t => t.UserId == userID).ToList();

            #region 整合所属商户的数据
            //整合多个公司的数据
            List<LOCATION_INVENTORY_MODEL> listSource = new List<LOCATION_INVENTORY_MODEL>();
            List<LOCATION_INVENTORY_MODEL> companyItem = new List<LOCATION_INVENTORY_MODEL>();

            foreach (var company in companyList)
            {
                companyItem = Datalist.Where(L => L.COMPANY.ToLower() == company.MerchantCode.ToLower()).ToList();
                listSource = listSource.Concat(companyItem).ToList();
            }
            #endregion
            searchNo = userID + "ID";
            gidPager = userID + "Pager";

            Core.CacheHelper.SetCache(searchNo, queryStr, 1200);//搜索条件置入缓存
            Core.CacheHelper.SetCache(gidPager, pager, 1200);

            var cacheSearchNo = Core.CacheHelper.GetCache(searchNo);
            var cachePager = Core.CacheHelper.GetCache(gidPager);

            List<QueryViewModel> queryList = await CacheData(listSource, queryStr);
            List<QueryViewModel> GetList = new List<QueryViewModel>();
            QueryViewModel modelItem = new QueryViewModel();
            if (!string.IsNullOrWhiteSpace(pager.filterRules))
            {
                List<DataFilterModel> dataFilterList = JsonHandler.Deserialize<List<DataFilterModel>>(pager.filterRules).Where(f => !string.IsNullOrWhiteSpace(f.value)).ToList();
                queryList = LinqHelper.DataFilter<QueryViewModel>((queryList.AsEnumerable()).AsQueryable(), dataFilterList).ToList();
            }

            #region 排序
            if (pager.order == "asc")
            {
                if (pager.sort == "ITEM")
                {
                    queryList = queryList.OrderBy(t => t.ITEM).ToList();
                }
                else if (pager.sort == "COMPANY")
                {
                    queryList = queryList.OrderBy(t => t.COMPANY).ToList();
                }
                else if (pager.sort == "ATTRIBUTE_NUM")
                {
                    queryList = queryList.OrderBy(t => t.ATTRIBUTE_NUM).ToList();
                }
                else if (pager.sort == "ON_HAND_QTY")
                {
                    queryList = queryList.OrderBy(t => t.ON_HAND_QTY).ToList();
                }
                else if (pager.sort == "IsQualified")
                {
                    queryList = queryList.OrderBy(t => t.IsQualified).ToList();
                }
                else if (pager.sort == "IsNotQualified")
                {
                    queryList = queryList.OrderBy(t => t.IsNotQualified).ToList();
                }
                else if (pager.sort == "DaysToExpire")
                {
                    queryList = queryList.OrderBy(t => t.DaysToExpire).ToList();
                }
                else if (pager.sort == "DateOfProduction")
                {
                    queryList = queryList.OrderBy(t => t.DateOfProduction).ToList();
                }
                else if (pager.sort == "DateOfExpiry")
                {
                    queryList = queryList.OrderBy(t => t.DateOfExpiry).ToList();
                }
            }
            else
            {
                if (pager.sort == "ITEM")
                {
                    queryList = queryList.OrderByDescending(t => t.ITEM).ToList();
                }
                else if (pager.sort == "COMPANY")
                {
                    queryList = queryList.OrderByDescending(t => t.COMPANY).ToList();
                }
                else if (pager.sort == "ATTRIBUTE_NUM")
                {
                    queryList = queryList.OrderByDescending(t => t.ATTRIBUTE_NUM).ToList();
                }
                else if (pager.sort == "ON_HAND_QTY")
                {
                    queryList = queryList.OrderByDescending(t => t.ON_HAND_QTY).ToList();
                }
                else if (pager.sort == "IsQualified")
                {
                    queryList = queryList.OrderByDescending(t => t.IsQualified).ToList();
                }
                else if (pager.sort == "IsNotQualified")
                {
                    queryList = queryList.OrderByDescending(t => t.IsNotQualified).ToList();
                }
                else if (pager.sort == "DaysToExpire")
                {
                    queryList = queryList.OrderByDescending(t => t.DaysToExpire).ToList();
                }
                else if (pager.sort == "DateOfProduction")
                {
                    queryList = queryList.OrderByDescending(t => t.DateOfProduction).ToList();
                }
                else if (pager.sort == "DateOfExpiry")
                {
                    queryList = queryList.OrderByDescending(t => t.DateOfExpiry).ToList();
                }
            }
            #endregion

            return queryList;

        }

        [HttpPost]
        public JsonResult GetListByComTree(string id)
        {
            Apps.IService.IServiceSession serviceSession = OpeCur.ServiceSession;
            List<SysStructModel> list = serviceSession.SysStruct.GetList(id);
            var json = from r in list
                       select new SysStructEditModel()
                       {
                           id = r.Id,
                           text = r.Name,
                           state = (serviceSession.SysStruct.GetList(r.Id).Count > 0) ? "closed" : "open"
                       };


            return Json(json);
        }

        [HttpPost]
        public JsonResult GetAllCompanyOfAccount()
        {
            string userId = OpeCur.AccountNow.Id;
            List<SysUserMerchantCodeModel> companyList = OpeCur.ServiceSession.SysUserMerchantCode.GetList().Where(t => t.UserId == userId).ToList();

            var json = (from r in companyList
                        select new SysUserMerchantCodeModel()
                        {
                            UserId = r.UserId,
                            MerchantCode = r.MerchantCode
                        }).ToArray();

            return Json(json);
        }

        /// <summary>
        /// 整合同一批次商品相关信息，并检索数据
        /// </summary>
        /// <param name="listSource">所有商品信息</param>
        /// <param name="searchString">检索条件</param>
        /// <returns></returns>
        private async Task<List<QueryViewModel>> CacheData(List<LOCATION_INVENTORY_MODEL> listSource, string searchString)
        {
            string userID = OpeCur.AccountNow.Id;
            string cacheItemParm = userID + "cache";
            List<Apps.Models.SCV.Sys.ITEM_MODEL> itemList = new List<Apps.Models.SCV.Sys.ITEM_MODEL>();
            var itemCache = Core.CacheHelper.GetCache(cacheItemParm);
            if (itemCache == null)
            {
                itemList = OpeCur.SCVServiceSession.ITEM.GetList();//??置于缓存中？？？
                Core.CacheHelper.SetCache(cacheItemParm, itemList);
            }
            else
            {
                itemList = (List<Apps.Models.SCV.Sys.ITEM_MODEL>)itemCache;//调用缓存数据
            }

            #region 数据映射 LOCATION_INVENTORY--》QueryViewModel
            List<QueryViewModel> listView = new List<QueryViewModel>();
            //过滤数据
            if ((!string.IsNullOrEmpty(searchString)) && searchString != "null" && searchString != "")
            {   //filter
                listSource = listSource.Where(p => p.ITEM.ToLower().Contains(searchString.ToLower())).ToList();
            }
            var list = listSource.GroupBy(
                                                            p => new { p.ITEM, p.WAREHOUSE, p.COMPANY, p.ATTRIBUTE2, p.ATTRIBUTE3 }
                                                        ).ToList();

            //同编号商品有多批次生产产品---每一批次的商品合格状态、失效期、处理数量展示出

            foreach (var item in list)
            {
                listView = await Task.Run(() =>
                {
                    if (item.Count() > 1)
                    {

                        listView.Add(new QueryViewModel()
                        {
                            UserId = userID,
                            ATTRIBUTE_NUM = item.Select(t => new { t.INVENTORY_STS, t.ON_HAND_QTY }).Select(f => f.ON_HAND_QTY).Sum(),
                            WAREHOUSE = "重庆空港仓",
                            ITEM = item.FirstOrDefault().ITEM,
                            ITEM_DESC = item.FirstOrDefault().ITEM_DESC,
                            COMPANY = item.FirstOrDefault().COMPANY,
                            IsQualified = item.Any(t => t.INVENTORY_STS.Contains("合格")) ? int.Parse(item.Select(t => new { t.INVENTORY_STS, t.ON_HAND_QTY }).Where(t => t.INVENTORY_STS == "合格").Select(f => f.ON_HAND_QTY).Sum().ToString()) : 0,
                            IsNotQualified = item.Any(t => t.INVENTORY_STS.Contains("不合格")) ? int.Parse(item.Select(t => new { t.INVENTORY_STS, t.ON_HAND_QTY }).Where(t => t.INVENTORY_STS == "不合格").Select(f => f.ON_HAND_QTY).Sum().ToString()) : 0,
                            ON_HAND_QTY = item.Select(p => p.ALLOCATED_QTY).Sum(),
                            DateOfProduction = item.Key.ATTRIBUTE2 != null ? GetStringToDate(item.Key.ATTRIBUTE2) : null,
                            DateOfExpiry = item.Key.ATTRIBUTE3 != null ? GetStringToDate(item.Key.ATTRIBUTE3) : null
                            //DaysToExpire= itemCache!=null? ((List<Apps.Models.SCV.Sys.ITEM_MODEL>)itemCache).Where(t => t.ITEM1.ToString() == item.FirstOrDefault().ITEM).Select(t => t.DAYS_TO_EXPIRE).FirstOrDefault() : null
                        });
                    }
                    else
                    {
                        listView.Add(new QueryViewModel()
                        {
                            UserId = userID,
                            ATTRIBUTE_NUM = item.Select(t => new { t.INVENTORY_STS, t.ON_HAND_QTY }).Select(f => f.ON_HAND_QTY).Sum(),
                            WAREHOUSE = "重庆空港仓",
                            ITEM = item.FirstOrDefault().ITEM,
                            ITEM_DESC = item.FirstOrDefault().ITEM_DESC,
                            COMPANY = item.FirstOrDefault().COMPANY,
                            IsQualified = item.Any(t => t.INVENTORY_STS.Contains("合格")) ? int.Parse(item.Where(t => t.INVENTORY_STS == "合格").Select(f => f.ON_HAND_QTY).Sum().ToString()) : 0,
                            IsNotQualified = item.Any(t => t.INVENTORY_STS.Contains("不合格")) ? int.Parse(item.Where(t => t.INVENTORY_STS == "不合格").Select(f => f.ON_HAND_QTY).Sum().ToString()) : 0,
                            ON_HAND_QTY = item.FirstOrDefault().ALLOCATED_QTY,
                            DateOfProduction = item.Key.ATTRIBUTE2 != null ? GetStringToDate(item.Key.ATTRIBUTE2) : null,
                            DateOfExpiry = item.Key.ATTRIBUTE3 != null ? GetStringToDate(item.Key.ATTRIBUTE3) : null
                            //DaysToExpire = itemCache != null ? ((List<Apps.Models.SCV.Sys.ITEM_MODEL>)itemCache).Where(t => t.ITEM1.ToString() == item.FirstOrDefault().ITEM).Select(t => t.DAYS_TO_EXPIRE).FirstOrDefault() : null
                        });
                    }
                    return listView;

                });

            }
            #endregion

            return listView;
        }

        /// <summary>
        /// 获取没有失效期商品的失效期
        /// </summary>
        /// <param name="item">商品</param>
        /// <returns>返回处理失效日期的数据</returns>
        private QueryViewModel GetDataOfExpiry(QueryViewModel item)
        {
            string cacheItemParm = "cache";
            var itemList = new List<Apps.Models.SCV.Sys.ITEM_MODEL>();
            var itemCache = Core.CacheHelper.GetCache(cacheItemParm);
            if (itemCache == null)
            {
                itemList = OpeCur.SCVServiceSession.ITEM.GetList();//??置于缓存中？？？
                Core.CacheHelper.SetCache(cacheItemParm, itemList);
                itemCache = Core.CacheHelper.GetCache(cacheItemParm);
            }
            else
            {
                itemList = (List<Apps.Models.SCV.Sys.ITEM_MODEL>)itemCache;//调用缓存数据                
            }
            #region MyRegion
            var isRight = itemList != null ? (itemList.Where(t => t.ITEM1 == item.ITEM && t.COMPANY == item.COMPANY).ToList()) : null;//item表中有商品数据---若是没有？？？每一条数据都检索
            var hasItem = isRight != null ? (isRight.Where(t => t.DAYS_TO_EXPIRE != null).ToList()) : null;//item商品表中拥有商品保质期的数据
            try
            {
                if (item.DateOfExpiry == null)
                {
                    if (item.DateOfProduction != null)
                    {

                        if (isRight != null && isRight.Count() > 0 && hasItem.Count() > 0)
                        {

                            item.DaysToExpire = isRight.Where(t => t.DAYS_TO_EXPIRE != null)
                    .Select(t => t.DAYS_TO_EXPIRE).FirstOrDefault().Value;
                            //???怎么获取item.DaysToExpire 保质期？？？？
                            item.DateOfExpiry = (item.DateOfProduction).Value.AddDays(
                                double.Parse(item.DaysToExpire.ToString()));
                        }

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            if (isRight != null && isRight.Count() > 0 && hasItem.Count() > 0 && (string.IsNullOrEmpty(item.DaysToExpire.ToString()) | item.DaysToExpire == 0))
            {
                item.DaysToExpire = int.Parse(isRight.Where(t => t.DAYS_TO_EXPIRE != null)
                    .Select(t => t.DAYS_TO_EXPIRE).FirstOrDefault().Value.ToString());
            }

            #endregion

            return item;
        }

        /// <summary>
        /// 时间字符串转为“**年**月**日”
        /// </summary>
        /// <param name="item">时间字符串</param>
        /// <returns>正常日期格式可以处理，异常数据原字符返回</returns>
        private DateTime? GetStringToDate(string item)
        {
            string dateString = item.Trim().Substring(0, 8);
            DateTime dd = Convert.ToDateTime("2001/1/1");
            int monthString = int.Parse(dateString.Substring(4, 2));
            int dayString = int.Parse(dateString.Substring(6, 2));
            if (monthString == 2 && dayString > 28)
            {
                monthString = 3;
                dayString = 1;
                dateString = dateString.Substring(0, 4) + "0" + monthString + "0" + dayString;
                dd = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                //item = dd.ToString("yyyy年MM月dd日");
            }
            else if (monthString > 12 | monthString < 1)
            {
                return null;
            }
            else if (monthString == 1 | monthString == 3 | monthString == 5 | monthString == 7 | monthString == 8 | monthString == 10 | monthString == 12)
            {
                if (monthString < 10)
                {
                    if (dayString > 31)
                    {
                        dayString = 31;
                        dateString = dateString.Substring(0, 4) + "0" + monthString + dayString;
                    }
                    if (dayString < 10)
                    {
                        dateString = dateString.Substring(0, 4) + "0" + monthString + "0" + dayString;
                    }
                    else
                    {
                        dateString = dateString.Substring(0, 4) + "0" + monthString + dayString;
                    }
                }
                else
                {
                    if (dayString > 31)
                    {
                        dayString = 31;
                        dateString = dateString.Substring(0, 4) + monthString + dayString;
                    }
                    if (dayString < 10)
                    {
                        dateString = dateString.Substring(0, 4) + monthString + "0" + dayString;
                    }
                    else
                    {
                        dateString = dateString.Substring(0, 4) + monthString + dayString;
                    }

                }
                dd = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                //item = dd.ToString("yyyy年MM月dd日");

            }
            else if (monthString == 4 | monthString == 6 | monthString == 9 | monthString == 11)
            {
                if (monthString < 10)
                {
                    if (dayString < 10)
                    {
                        dateString = dateString = dateString.Substring(0, 4) + "0" + monthString + "0" + dayString;
                    }
                    else if (dayString > 30)
                    {
                        dayString = 30;
                        dateString = dateString = dateString.Substring(0, 4) + "0" + monthString + dayString;
                    }
                    else
                    {
                        dateString = dateString = dateString.Substring(0, 4) + "0" + monthString + dayString;
                    }

                }
                else
                {
                    if (dayString < 10)
                    {
                        dateString = dateString = dateString.Substring(0, 4) + monthString + "0" + dayString;
                    }
                    else if (dayString > 30)
                    {
                        dayString = 30;
                        dateString = dateString = dateString.Substring(0, 4) + monthString + dayString;
                    }
                    else
                    {
                        dateString = dateString = dateString.Substring(0, 4) + monthString + dayString;
                    }

                }
                dd = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                //item = dd.ToString("yyyy年MM月dd日");
            }
            else
            {
                try
                {
                    dateString = dateString.Substring(0, 8);
                    dd = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    //item = dd.ToString("yyyy年MM月dd日");
                }
                catch (Exception)
                {
                    return null;  //月份超过12-----视为异常数据，置为空
                    throw;
                }


            }
            return dd;
        }

        /// <summary>
        /// 所有数据导出excel文档
        /// </summary>
        /// <param name="searchNo"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<FileResult> Excel()
        {
            string userID = OpeCur.AccountNow.Id;
            searchNo = userID + "ID";
            gidPager = userID + "Pager";
            var cacheSearchNo = Core.CacheHelper.GetCache(searchNo);
            var cachePager = Core.CacheHelper.GetCache(gidPager);
            string queryStr = (string)cacheSearchNo;
            GridPager pager = (GridPager)cachePager;
            List<QueryViewModel> listView = await FilterData(pager, queryStr);

            if (!string.IsNullOrWhiteSpace(pager.filterRules))
            {
                List<DataFilterModel> dataFilterList = JsonHandler.Deserialize<List<DataFilterModel>>(pager.filterRules).Where(f => !string.IsNullOrWhiteSpace(f.value)).ToList();
                listView = LinqHelper.DataFilter<QueryViewModel>((listView.AsEnumerable()).AsQueryable(), dataFilterList).ToList();
            }

            #region 获取失效日期并转换"yyyy年MM月dd日"
            foreach (var item in listView)
            {
                await Task.Run<QueryViewModel>(() => { return GetDataOfExpiry(item); });
            }
            #endregion
            //整合代码
            //string title = new { "param":[{"WAREHOUSE":"仓库","ITEM":"编码","ITEM_DESC":"描述","COMPANY":"所属公司","ATTRIBUTE_NUM":"库存数量","ON_HAND_QTY":"处理数量"}] };
            //string[] tt = { "WAREHOUSE", "ITEM", "ITEM_DESC", "COMPANY", "ATTRIBUTE_NUM", "ON_HAND_QTY" };
            //DataTable tt1 = Commons.DataTableExtensions.ToDataTable<QueryViewModel>(listView, tt);//list数据转为Table类型
            //NPOIHelper.WriteToDownLoad("临空" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xls", "sheet1", tt1);//写入excel

            #region 创建Excel表格
            //创建Excel文件的对象
            HSSFWorkbook book = new HSSFWorkbook();
            //添加一个sheet
            ISheet sheet1 = book.CreateSheet("Sheet1");

            sheet1.SetColumnWidth(0, 15 * 256);
            sheet1.SetColumnWidth(1, 15 * 256);
            sheet1.SetColumnWidth(2, 35 * 256);
            sheet1.SetColumnWidth(3, 15 * 256);
            sheet1.SetColumnWidth(4, 15 * 256);
            sheet1.SetColumnWidth(5, 15 * 256);
            sheet1.SetColumnWidth(6, 15 * 256);
            sheet1.SetColumnWidth(7, 15 * 256);
            sheet1.SetColumnWidth(8, 10 * 256);
            sheet1.SetColumnWidth(9, 10 * 256);


            //给sheet1添加第一行的头部标题
            NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
            row1.CreateCell(0).SetCellValue("仓库");
            row1.CreateCell(1).SetCellValue("编号");
            row1.CreateCell(2).SetCellValue("描述");
            row1.CreateCell(3).SetCellValue("所属公司");
            row1.CreateCell(4).SetCellValue("生产日期");
            row1.CreateCell(5).SetCellValue("失效日期");
            row1.CreateCell(6).SetCellValue("合格");
            row1.CreateCell(7).SetCellValue("不合格");
            row1.CreateCell(8).SetCellValue("库存数量");
            row1.CreateCell(9).SetCellValue("处理数量");
            //将数据逐步写入sheet1各个行
            for (int i = 0; i < listView.Count; i++)
            {
                NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                rowtemp.CreateCell(0).SetCellValue(listView[i].WAREHOUSE);
                rowtemp.CreateCell(1).SetCellValue(listView[i].ITEM);
                rowtemp.CreateCell(2).SetCellValue(listView[i].ITEM_DESC);
                rowtemp.CreateCell(3).SetCellValue(listView[i].COMPANY);
                rowtemp.CreateCell(4).SetCellValue(listView[i].DateOfProduction == null ? null : listView[i].DateOfProduction.ToString());
                rowtemp.CreateCell(5).SetCellValue(listView[i].DateOfExpiry == null ? null : (listView[i].DateOfExpiry).ToString());
                rowtemp.CreateCell(6).SetCellValue(listView[i].IsQualified.ToString());
                rowtemp.CreateCell(7).SetCellValue(listView[i].IsNotQualified.ToString());
                rowtemp.CreateCell(8).SetCellValue(listView[i].ATTRIBUTE_NUM.ToString());
                rowtemp.CreateCell(9).SetCellValue(listView[i].ON_HAND_QTY.ToString());
            }
            // 写入到客户端 
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            book.Write(ms);
            ms.Seek(0, SeekOrigin.Begin);
            #endregion
            #region Excel 保存路径
            // 输出Excel文件
            #endregion

            return await Task.Run<FileResult>(() => { return File(ms, "application/vnd.ms-excel", "临空" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xls"); });
        }



    }
}