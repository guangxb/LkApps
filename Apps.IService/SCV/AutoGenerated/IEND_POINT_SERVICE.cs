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
namespace Apps.IService.SCV.END
{
	public partial interface IEND_POINT_SERVICE:IBaseService<Apps.Models.SCV.END.END_POINT_MODEL>
	{
		List<Apps.Models.SCV.END.END_POINT_MODEL> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.END_POINT, bool>> where=null);

		List<Apps.Models.SCV.END.END_POINT_MODEL> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.END_POINT, bool>> where=null);

		List<Apps.Models.SCV.END.END_POINT_MODEL> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.END_POINT, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.END_POINT, TKey>> orderBy, bool isAsc = true);
	}
}
