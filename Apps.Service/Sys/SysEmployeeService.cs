using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Service.Sys
{
    public class SysEmployeeService
    {
        //#region 1.0 根据用户id查询用户权限集合 +List<MODEL.Permission> GetUserPermission(params object[] keyValues)
        ///// <summary>
        ///// 1.0 根据用户id查询用户权限集合
        ///// </summary>
        ///// <param name="uid">用户id</param>
        ///// <returns></returns>
        //public List<Apps.Models.Sys.SysPermissionModel> GetUserPermission(object uid)
        //{
        //    //一、查询角色权限
        //    //1.根据用户id查询 角色id 集合
        //    List<int> listRoleIds = DBSession.SysEmpRoleRelation.GetList(o => o.erUId == (int)uid).Select(o => o.erRId).ToList();
        //    List<int> listPerIds = DBSession.SysRolePerRelationship.GetList(o => listRoleIds.Contains(o.rprRoleId)).Select(o => o.rprPerId).ToList();
        //    //二、查询特殊权限id 集合
        //    List<int> listVipIds = DBSession.SysVipPermssion.GetList(o => o.vpUId == (int)uid).Select(o => o.vpPId).ToList();
        //    //三、合并 特权和 角色权限
        //    listVipIds.ForEach(vipPerId =>
        //    {
        //        //如果 特权 在 角色权限中不存在，则添加到 角色权限中
        //        if (!listPerIds.Contains(vipPerId))
        //        {
        //            listPerIds.Add(vipPerId);
        //        }
        //    });
        //    return base.DBSession.SysPermission.GetList(o => listPerIds.Contains(o.perId)).ToList().Select(o => o.ToPOCO()).ToList();
        //}
        //#endregion
    }
}
