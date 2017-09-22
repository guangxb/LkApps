//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Microsoft.Practices.Unity;
using System.Transactions;
using Apps.Locale;
using Apps.Models.Sys;

namespace Apps.Service.Sys
{
	public partial class SysModuleService: Virtual_SysModuleService,Apps.IService.Sys.ISysModuleService
	{
        public List<SysModuleModel> GetListByParentId(string parentId)
        {
            IQueryable<SysModule> queryData = null;
            queryData = m_Rep.GetList(a => a.ParentId == parentId&&a.Enable==true).OrderBy(a => a.Sort);
            return CreateModelList(ref queryData);
        }


        public List<SysModule> GetModuleBySystem(string parentId)
        {

            return m_Rep.GetModuleBySystem(parentId).ToList();
        }

        public void DeleteAndClear(ref ValidationErrors errors, string id)
        {
    
                if (m_Rep.GetChildrenCount(id) > 0)
                {
                    errors.Add("有下属关联，请先删除下属！");
                    return;
                }

                m_Rep.RemoveById(id);
                DBSession.SysRight.RemoveBy(r=>r.ModuleId == id);
            }
        }
}
