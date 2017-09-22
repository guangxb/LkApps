using Apps.Common;
using Apps.Models;
using Apps.Models.Sys;
using Apps.Web.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web.Controllers
{
    public class SysRightController : Apps.Web.Core.BaseController
    {
        // GET: SysRight
        public ActionResult Index()
        {
            return View();
        }

        #region 角色列表
        [HttpPost]
        public JsonResult GetRoleList(GridPager pager)
        {
            List<SysRoleModel> list = OpeCur.ServiceSession.SysRole.GetList(ref pager, "");

            if (list.Count<= 0)
            {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据！");
            }
            var json = new
            {
                total = pager.totalRows,
                rows = (from r in list
                        select new SysRoleModel()
                        {

                            Id = r.Id,
                            Name = r.Name,
                            Description = r.Description,
                            CreateTime = r.CreateTime,
                            CreatePerson = r.CreatePerson

                        }).ToArray()

            };

            return OpeCur.AjaxMsgOK("获取成功！", "", json);
        }
        #endregion 获取模块
        [HttpPost]
        public JsonResult GetModuleList(string id)
        {
            
            if (id == null)
                id = "0";

            List<SysRightModuleModel> list = OpeCur.ServiceSession.SysRight.GetModuleList(id);
            if (list.Count <= 0)
            {
                return OpeCur.AjaxMsgNOOK("没有符合条件的数据！", "", list);
            }

            //List<SysModuleModel> tempList = new List<SysModuleModel>();
            //foreach (var item in list)
            //{
            //    if (item.OperationType == 3)
            //    {
            //        tempList.AddRange(mService.GetListByParentId(item.Id));
            //    }
            //}

            //list.AddRange(tempList);

            return OpeCur.AjaxMsgOK("获取成功！", "", list);
        }

        [HttpPost]
        public JsonResult GetModuleTreeList(string id,string roleId) {

            if (id.IsNullOrEmpty() || roleId.IsNullOrEmpty()) {
                return OpeCur.AjaxMsgNOOK("Id不能为空");
            }

            List<TreeNode> nodes = OpeCur.ServiceSession.SysRight.GetModuleTreeNodes(id,roleId);

            return OpeCur.AjaxMsgOK("获取成功","",nodes);
        }

        #region 根据角色与模块得出权限
        //[HttpPost]
        //public JsonResult GetRightByRoleAndModule(string id, string roleId)
        //{
        //    var right = OpeCur.ServiceSession.SysRight.GetRightByRoleAndModule(roleId, Id);
        //    //var json = new
        //    //{
        //    //    total = right.Count,
        //    //    rows = right,

        //    //};

        //    return OpeCur.AjaxMsgOK("获取成功！", "", right);
        //}
        #endregion
        [HttpPost]
        public JsonResult UpdateRight(List<SysRightUpdateModel> data)
        {
            //data = "[{ 'id': '201704200905260490999d531a42553','checked':true}]";
            //List<TreeNode> datas = JsonConvert.DeserializeObject<List<TreeNode>>(data);
            ValidationErrors errors = new ValidationErrors();
            OpeCur.ServiceSession.SysRight.UpdateRight(ref errors, data);
            if (errors.Count() > 0)
            {
                return OpeCur.AjaxMsgNOOK(errors.Error);
            }

            //if (OpeCur.ServiceSession.SaveChange() > 0)
            //{
                return OpeCur.AjaxMsgOK("操作成功");
            //}
            //else
            //{
            //    return OpeCur.AjaxMsgNOOK("操作失败");
            //}
        }
    }
}