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
namespace Apps.IService.SCV.Sys
{
	public partial interface IVIEWER_SERVICE:IBaseService<Apps.Models.SCV.Sys.VIEWER_MODEL>
	{
		List<Apps.Models.SCV.Sys.VIEWER_MODEL> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.VIEWER, bool>> where=null);

		List<Apps.Models.SCV.Sys.VIEWER_MODEL> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.VIEWER, bool>> where=null);

		List<Apps.Models.SCV.Sys.VIEWER_MODEL> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.VIEWER, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.VIEWER, TKey>> orderBy, bool isAsc = true);
	}
}
