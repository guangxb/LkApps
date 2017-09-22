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
using System.Linq.Expressions;
namespace Apps.Service.SCV.GENERIC
{
	public class Virtual_GENERIC_CONFIG_DETAIL_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.GENERIC.IGENERIC_CONFIG_DETAIL_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.GENERIC_CONFIG_DETAIL;
			}
		}
		

		public virtual List<Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL> GetList(Expression<Func<Apps.Models.GENERIC_CONFIG_DETAIL, bool>> where = null){
		
				IQueryable<Apps.Models.GENERIC_CONFIG_DETAIL> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.GENERIC_CONFIG_DETAIL, bool>> where,Expression<Func<Apps.Models.GENERIC_CONFIG_DETAIL, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.GENERIC_CONFIG_DETAIL> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.GENERIC_CONFIG_DETAIL, bool>> where = null)
		{

			IQueryable<Apps.Models.GENERIC_CONFIG_DETAIL> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.RECORD_TYPE.Contains(queryStr)
								|| a.IDENTIFIER.Contains(queryStr)
								
								|| a.DESCRIPTION.Contains(queryStr)
								|| a.SYSTEM_CREATED.Contains(queryStr)
								|| a.VALUE1.Contains(queryStr)
								|| a.VALUE2.Contains(queryStr)
								|| a.VALUE3.Contains(queryStr)
								|| a.VALUE4.Contains(queryStr)
								|| a.VALUE5.Contains(queryStr)
								|| a.VALUE6.Contains(queryStr)
								|| a.VALUE7.Contains(queryStr)
								|| a.VALUE8.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL> CreateModelList(ref IQueryable<Apps.Models.GENERIC_CONFIG_DETAIL> queryData)
		{

			List<Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL
											  {
													RECORD_TYPE = r.RECORD_TYPE,
													IDENTIFIER = r.IDENTIFIER,
													SEQUENCE = r.SEQUENCE,
													DESCRIPTION = r.DESCRIPTION,
													SYSTEM_CREATED = r.SYSTEM_CREATED,
													VALUE1 = r.VALUE1,
													VALUE2 = r.VALUE2,
													VALUE3 = r.VALUE3,
													VALUE4 = r.VALUE4,
													VALUE5 = r.VALUE5,
													VALUE6 = r.VALUE6,
													VALUE7 = r.VALUE7,
													VALUE8 = r.VALUE8,
													ACTIVE = r.ACTIVE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													OBJECT_ID = r.OBJECT_ID,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL model)
		{
				Apps.Models.GENERIC_CONFIG_DETAIL entity = m_Rep.GetById(model.RECORD_TYPE);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.GENERIC_CONFIG_DETAIL();
			   				entity.RECORD_TYPE = model.RECORD_TYPE;
				entity.IDENTIFIER = model.IDENTIFIER;
				entity.SEQUENCE = model.SEQUENCE;
				entity.DESCRIPTION = model.DESCRIPTION;
				entity.SYSTEM_CREATED = model.SYSTEM_CREATED;
				entity.VALUE1 = model.VALUE1;
				entity.VALUE2 = model.VALUE2;
				entity.VALUE3 = model.VALUE3;
				entity.VALUE4 = model.VALUE4;
				entity.VALUE5 = model.VALUE5;
				entity.VALUE6 = model.VALUE6;
				entity.VALUE7 = model.VALUE7;
				entity.VALUE8 = model.VALUE8;
				entity.ACTIVE = model.ACTIVE;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.OBJECT_ID = model.OBJECT_ID;
  
				m_Rep.Create(entity);
		}



		 public virtual void RemoveById(ref ValidationErrors errors, string id)
		{
			
				m_Rep.RemoveById(id);
			
		}

		public virtual void RemoveByIds(ref ValidationErrors errors, string[] deleteCollection)
		{
				if (deleteCollection != null)
				{
				   //事务批量删除
				   // using (TransactionScope transactionScope = new TransactionScope())
				   // {
				   //     if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
				   //     {
				   //         transactionScope.Complete();
				   //         return true;
				   //     }
				   //    else
				   //     {
				   //         Transaction.Current.Rollback();
				   //         return false;
				   //     }
				   // }
				   m_Rep.RemoveById(deleteCollection);
				}
		}

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL model,params string[] updateProperties)
		{
				Apps.Models.GENERIC_CONFIG_DETAIL entity = m_Rep.GetById(model.RECORD_TYPE);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.RECORD_TYPE = model.RECORD_TYPE;
											entity.IDENTIFIER = model.IDENTIFIER;
											entity.SEQUENCE = model.SEQUENCE;
											entity.DESCRIPTION = model.DESCRIPTION;
											entity.SYSTEM_CREATED = model.SYSTEM_CREATED;
											entity.VALUE1 = model.VALUE1;
											entity.VALUE2 = model.VALUE2;
											entity.VALUE3 = model.VALUE3;
											entity.VALUE4 = model.VALUE4;
											entity.VALUE5 = model.VALUE5;
											entity.VALUE6 = model.VALUE6;
											entity.VALUE7 = model.VALUE7;
											entity.VALUE8 = model.VALUE8;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.OBJECT_ID = model.OBJECT_ID;
									}else{
					
						Type type = typeof(Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL);
						Type typeE = typeof(Apps.Models.GENERIC_CONFIG_DETAIL);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL GetById(string id)
		{
			Apps.Models.GENERIC_CONFIG_DETAIL entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//GENERIC_CONFIG_DETAIL entity = m_Rep.GetById(id);
				Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL model = new Apps.Models.SCV.GENERIC.GENERIC_CONFIG_DETAIL_MODEL();
							  				model.RECORD_TYPE = entity.RECORD_TYPE;
				model.IDENTIFIER = entity.IDENTIFIER;
				model.SEQUENCE = entity.SEQUENCE;
				model.DESCRIPTION = entity.DESCRIPTION;
				model.SYSTEM_CREATED = entity.SYSTEM_CREATED;
				model.VALUE1 = entity.VALUE1;
				model.VALUE2 = entity.VALUE2;
				model.VALUE3 = entity.VALUE3;
				model.VALUE4 = entity.VALUE4;
				model.VALUE5 = entity.VALUE5;
				model.VALUE6 = entity.VALUE6;
				model.VALUE7 = entity.VALUE7;
				model.VALUE8 = entity.VALUE8;
				model.ACTIVE = entity.ACTIVE;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.OBJECT_ID = entity.OBJECT_ID;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
