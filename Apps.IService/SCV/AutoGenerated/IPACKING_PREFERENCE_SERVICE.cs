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
namespace Apps.IService.SCV.PACKING
{
	public partial interface IPACKING_PREFERENCE_SERVICE:IBaseService<Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL>
	{
		List<Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.PACKING_PREFERENCE, bool>> where=null);

		List<Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.PACKING_PREFERENCE, bool>> where=null);

		List<Apps.Models.SCV.PACKING.PACKING_PREFERENCE_MODEL> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.PACKING_PREFERENCE, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.PACKING_PREFERENCE, TKey>> orderBy, bool isAsc = true);
	}
}
