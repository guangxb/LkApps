using Apps.Common;
using Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Apps.Web.CoreApps.Web.Helper
{
    public class BaseController:Controller
    {
        public OperationContext OpeCur
        {
            get
            {
                return OperationContext.Current;
            }
        }

        /// <summary>
        /// 获取当前页或操作访问权限
        /// </summary>
        /// <returns>权限列表</returns>
        //public List<permModel> GetPermission()
        //{
        //    string filePath = HttpContext.Request.FilePath;

        //    List<permModel> perm = (List<permModel>)Session[filePath];
        //    return perm;
        //}
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new ToJsonResult
            {
                Data = data,
                ContentEncoding = contentEncoding,
                ContentType = contentType,
                JsonRequestBehavior = behavior,
                FormateStr = "yyyy-MM-dd HH:mm:ss"
            };
        }
        /// <summary>
        /// 返回JsonResult.24         /// </summary>
        /// <param name="data">数据</param>
        /// <param name="behavior">行为</param>
        /// <param name="format">json中dateTime类型的格式</param>
        /// <returns>Json</returns>
        //protected JsonResult MyJson(object data, JsonRequestBehavior behavior, string format)
        //{
        //    return new ToJsonResult
        //    {
        //        Data = data,
        //        JsonRequestBehavior = behavior,
        //        FormateStr = format
        //    };
        //}

        /// <summary>
        /// 检查SQL语句合法性
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ValidateSQL(string sql, ref string msg)
        {
            if (sql.ToLower().IndexOf("delete") > 0)
            {
                msg = "查询参数中含有非法语句DELETE";
                return false;
            }
            if (sql.ToLower().IndexOf("update") > 0)
            {
                msg = "查询参数中含有非法语句UPDATE";
                return false;
            }

            if (sql.ToLower().IndexOf("insert") > 0)
            {
                msg = "查询参数中含有非法语句INSERT";
                return false;
            }

            if (sql.ToLower().IndexOf("drop") > 0)
            {
                msg = "查询参数中含有非法语句drop";
                return false;
            }
            return true;
        }
        //无分页获取
        //public GridPager setNoPagerAscBySort = new GridPager()
        //{
        //    page = 1,
        //    rows = 10000,
        //    sort = "Sort",
        //    order = "asc"
        //};

        //public GridPager setNoPagerDescBySort = new GridPager()
        //{
        //    page = 1,
        //    rows = 10000,
        //    sort = "Sort",
        //    order = "desc"
        //};

        public GridPager setNoPagerDescByCreateTime = new GridPager()
        {
            page = 1,
            rows = 10000,
            sort = "CreateTime",
            order = "desc"
        };
        //public GridPager setNoPagerAscById = new GridPager()
        //{
        //    page = 1,
        //    rows = 10000,
        //    sort = "Id",
        //    order = "asc"
        //};
        //public GridPager setNoPagerDescById = new GridPager()
        //{
        //    page = 1,
        //    rows = 10000,
        //    sort = "Id",
        //    order = "desc"
        //};
    }
}
