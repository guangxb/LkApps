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
namespace Apps.IService.Spl
{
	public partial interface ISpl_PersonService:IBaseService<Apps.Models.Spl.Spl_PersonModel>
	{
		List<Apps.Models.Spl.Spl_PersonModel> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.Spl_Person, bool>> where=null);

		List<Apps.Models.Spl.Spl_PersonModel> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.Spl_Person, bool>> where=null);

		List<Apps.Models.Spl.Spl_PersonModel> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.Spl_Person, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.Spl_Person, TKey>> orderBy, bool isAsc = true);
	}
}
