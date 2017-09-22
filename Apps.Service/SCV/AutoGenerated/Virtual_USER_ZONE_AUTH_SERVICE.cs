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
namespace Apps.Service.SCV.USER
{
	public class Virtual_USER_ZONE_AUTH_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.USER.IUSER_ZONE_AUTH_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.USER_ZONE_AUTH;
			}
		}
		

		public virtual List<Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL> GetList(Expression<Func<Apps.Models.USER_ZONE_AUTH, bool>> where = null){
		
				IQueryable<Apps.Models.USER_ZONE_AUTH> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.USER_ZONE_AUTH, bool>> where,Expression<Func<Apps.Models.USER_ZONE_AUTH, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.USER_ZONE_AUTH> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.USER_ZONE_AUTH, bool>> where = null)
		{

			IQueryable<Apps.Models.USER_ZONE_AUTH> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.ZONE.Contains(queryStr)
								|| a.ZONE_NAME.Contains(queryStr)
								|| a.USER_ID.Contains(queryStr)
								|| a.USER_NAME.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL> CreateModelList(ref IQueryable<Apps.Models.USER_ZONE_AUTH> queryData)
		{

			List<Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL
											  {
													ZONE = r.ZONE,
													ZONE_NAME = r.ZONE_NAME,
													USER_ID = r.USER_ID,
													USER_NAME = r.USER_NAME,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL model)
		{
				Apps.Models.USER_ZONE_AUTH entity = m_Rep.GetById(model.ZONE);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.USER_ZONE_AUTH();
			   				entity.ZONE = model.ZONE;
				entity.ZONE_NAME = model.ZONE_NAME;
				entity.USER_ID = model.USER_ID;
				entity.USER_NAME = model.USER_NAME;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL model,params string[] updateProperties)
		{
				Apps.Models.USER_ZONE_AUTH entity = m_Rep.GetById(model.ZONE);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.ZONE = model.ZONE;
											entity.ZONE_NAME = model.ZONE_NAME;
											entity.USER_ID = model.USER_ID;
											entity.USER_NAME = model.USER_NAME;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL);
						Type typeE = typeof(Apps.Models.USER_ZONE_AUTH);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL GetById(string id)
		{
			Apps.Models.USER_ZONE_AUTH entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//USER_ZONE_AUTH entity = m_Rep.GetById(id);
				Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL model = new Apps.Models.SCV.USER.USER_ZONE_AUTH_MODEL();
							  				model.ZONE = entity.ZONE;
				model.ZONE_NAME = entity.ZONE_NAME;
				model.USER_ID = entity.USER_ID;
				model.USER_NAME = entity.USER_NAME;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
