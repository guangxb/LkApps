//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.QiMen
{
	public class Virtual_QiMen_PushLogModel
	{
			public virtual long Id { get; set; }
			public virtual decimal InternalOrderID { get; set; }
			public virtual string OrderType { get; set; }
			public virtual string CustomerId { get; set; }
			public virtual string Flag { get; set; }
			public virtual string Message { get; set; }
			public virtual System.DateTime CreateTime { get; set; }
		}
}
