//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using Apps.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apps.IRepository.Sys
{
	public partial interface ISysRoleRepository:IBaseRepository<SysRole>
	{
        IQueryable<SysUser> GetRefSysUser(string id);
        IQueryable<P_Sys_GetUserByRoleId_Result> GetUserByRoleId(string roleId, string depId);
        //List<P_Sys_GetUserByRoleId_Result> GetUserByRoleId(string roleId, string depId);
        //void UpdateSysRoleSysUser(string roleId, string[] userIds);
        void UpdateSysRoleSysUser(string roleId, List<AssignUserModel> users);

    }
}
