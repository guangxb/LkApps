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
using Apps.Common;
using System.Linq.Expressions;
using Apps.Models;

namespace Apps.IService.Spm
{
	public partial interface ISpm_ExpressInfoService:IBaseService<Apps.Models.Spm.Spm_ExpressInfoModel>
	{
	
		List<Apps.Models.Spm.ExViewModel> GetViewList(ref GridPager pager, string queryStr, Expression<Func<Apps.Models.Spm_ExpressInfo, bool>> where = null);
        System.Data.DataTable GetViewDataTable(Expression<Func<Spm_ExpressInfo, bool>> where = null);


    }
}
