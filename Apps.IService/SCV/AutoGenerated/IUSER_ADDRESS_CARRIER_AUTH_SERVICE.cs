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
namespace Apps.IService.SCV.USER
{
	public partial interface IUSER_ADDRESS_CARRIER_AUTH_SERVICE:IBaseService<Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL>
	{
		List<Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL> GetList(ref GridPager pager, string queryStr, System.Linq.Expressions.Expression<Func<Apps.Models.USER_ADDRESS_CARRIER_AUTH, bool>> where=null);

		List<Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL> GetList(System.Linq.Expressions.Expression<Func<Apps.Models.USER_ADDRESS_CARRIER_AUTH, bool>> where=null);

		List<Apps.Models.SCV.USER.USER_ADDRESS_CARRIER_AUTH_MODEL> GetListSort<TKey>(System.Linq.Expressions.Expression<Func<Apps.Models.USER_ADDRESS_CARRIER_AUTH, bool>> where,System.Linq.Expressions.Expression<Func<Apps.Models.USER_ADDRESS_CARRIER_AUTH, TKey>> orderBy, bool isAsc = true);
	}
}
