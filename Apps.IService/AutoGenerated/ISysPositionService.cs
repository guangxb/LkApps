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
namespace Apps.IService.Sys
{
	public partial interface ISysPositionService:IBaseService<Apps.Models.Sys.SysPositionModel>
	{
		List<Apps.Models.Sys.SysPositionModel> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.SysPosition, bool>> where=null);

		List<Apps.Models.Sys.SysPositionModel> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.SysPosition, bool>> where=null);

		List<Apps.Models.Sys.SysPositionModel> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.SysPosition, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.SysPosition, TKey>> orderBy, bool isAsc = true);
	}
}