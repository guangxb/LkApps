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
using Apps.IRepository.Sys;
using System;
using System.Linq;

namespace Apps.Repository.Sys
{
	public partial class SysUserRepository:BaseRepository<SysUser>,ISysUserRepository
	{
        public IQueryable<SysModule> GetUserPermission(string userId)
        {
            var modules =
            (
                from m in Context.SysModule
                join rl in Context.SysRight
                on m.Id equals rl.ModuleId
                join r in
                    (from r in Context.SysRole
                     from u in r.SysUser
                     where u.Id == userId
                     select r)
                on rl.RoleId equals r.Id
                where rl.Rightflag == true
                where m.Enable == true
                //where m.Id != "0"
                select m
                      ).Distinct().OrderBy(a => a.Sort);
            return modules;
        }

        public IQueryable<P_Sys_GetUserByDepId_Result> GetUserByDepId(string depId)
        {
            return Context.P_Sys_GetUserByDepId(depId).AsQueryable();
        }

        public int GetUserCountByDepId(string depId)
        {
            return Context.P_Sys_GetUserCountByDepId(depId).Cast<int>().First();
        }

        public IQueryable<P_Sys_GetRoleByUserId_Result> GetRoleByUserId(string userId)
        {
            return Context.P_Sys_GetRoleByUserId(userId).AsQueryable();
        }
    }
}
