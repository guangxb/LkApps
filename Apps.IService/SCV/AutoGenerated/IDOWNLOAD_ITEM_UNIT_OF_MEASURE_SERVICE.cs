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
namespace Apps.IService.SCV.DOWNLOAD
{
	public partial interface IDOWNLOAD_ITEM_UNIT_OF_MEASURE_SERVICE:IBaseService<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEM_UNIT_OF_MEASURE_MODEL>
	{
		List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEM_UNIT_OF_MEASURE_MODEL> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.DOWNLOAD_ITEM_UNIT_OF_MEASURE, bool>> where=null);

		List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEM_UNIT_OF_MEASURE_MODEL> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.DOWNLOAD_ITEM_UNIT_OF_MEASURE, bool>> where=null);

		List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_ITEM_UNIT_OF_MEASURE_MODEL> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.DOWNLOAD_ITEM_UNIT_OF_MEASURE, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.DOWNLOAD_ITEM_UNIT_OF_MEASURE, TKey>> orderBy, bool isAsc = true);
	}
}