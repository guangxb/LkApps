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
namespace Apps.Service.SCV.STATUS
{
	public class Virtual_STATUS_FLOW_HEADER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.STATUS.ISTATUS_FLOW_HEADER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.STATUS_FLOW_HEADER;
			}
		}
		

		public virtual List<Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL> GetList(Expression<Func<Apps.Models.STATUS_FLOW_HEADER, bool>> where = null){
		
				IQueryable<Apps.Models.STATUS_FLOW_HEADER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.STATUS_FLOW_HEADER, bool>> where,Expression<Func<Apps.Models.STATUS_FLOW_HEADER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.STATUS_FLOW_HEADER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.STATUS_FLOW_HEADER, bool>> where = null)
		{

			IQueryable<Apps.Models.STATUS_FLOW_HEADER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.STATUS_FLOW.Contains(queryStr)
								|| a.STATUS_FLOW_NAME.Contains(queryStr)
								|| a.STATUS_FLOW_TYPE.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.CREATE_USER.Contains(queryStr)
								
								|| a.LAST_MODIFY_USER.Contains(queryStr)
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL> CreateModelList(ref IQueryable<Apps.Models.STATUS_FLOW_HEADER> queryData)
		{

			List<Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													STATUS_FLOW = r.STATUS_FLOW,
													STATUS_FLOW_NAME = r.STATUS_FLOW_NAME,
													STATUS_FLOW_TYPE = r.STATUS_FLOW_TYPE,
													ACTIVE = r.ACTIVE,
													CREATE_USER = r.CREATE_USER,
													CREATE_DATE_TIME = r.CREATE_DATE_TIME,
													LAST_MODIFY_USER = r.LAST_MODIFY_USER,
													LAST_MODIFY_DATE_TIME = r.LAST_MODIFY_DATE_TIME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL model)
		{
				Apps.Models.STATUS_FLOW_HEADER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.STATUS_FLOW_HEADER();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.STATUS_FLOW = model.STATUS_FLOW;
				entity.STATUS_FLOW_NAME = model.STATUS_FLOW_NAME;
				entity.STATUS_FLOW_TYPE = model.STATUS_FLOW_TYPE;
				entity.ACTIVE = model.ACTIVE;
				entity.CREATE_USER = model.CREATE_USER;
				entity.CREATE_DATE_TIME = model.CREATE_DATE_TIME;
				entity.LAST_MODIFY_USER = model.LAST_MODIFY_USER;
				entity.LAST_MODIFY_DATE_TIME = model.LAST_MODIFY_DATE_TIME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.STATUS_FLOW_HEADER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.STATUS_FLOW = model.STATUS_FLOW;
											entity.STATUS_FLOW_NAME = model.STATUS_FLOW_NAME;
											entity.STATUS_FLOW_TYPE = model.STATUS_FLOW_TYPE;
											entity.ACTIVE = model.ACTIVE;
											entity.CREATE_USER = model.CREATE_USER;
											entity.CREATE_DATE_TIME = model.CREATE_DATE_TIME;
											entity.LAST_MODIFY_USER = model.LAST_MODIFY_USER;
											entity.LAST_MODIFY_DATE_TIME = model.LAST_MODIFY_DATE_TIME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
									}else{
					
						Type type = typeof(Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL);
						Type typeE = typeof(Apps.Models.STATUS_FLOW_HEADER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL GetById(string id)
		{
			Apps.Models.STATUS_FLOW_HEADER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//STATUS_FLOW_HEADER entity = m_Rep.GetById(id);
				Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL model = new Apps.Models.SCV.STATUS.STATUS_FLOW_HEADER_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.STATUS_FLOW = entity.STATUS_FLOW;
				model.STATUS_FLOW_NAME = entity.STATUS_FLOW_NAME;
				model.STATUS_FLOW_TYPE = entity.STATUS_FLOW_TYPE;
				model.ACTIVE = entity.ACTIVE;
				model.CREATE_USER = entity.CREATE_USER;
				model.CREATE_DATE_TIME = entity.CREATE_DATE_TIME;
				model.LAST_MODIFY_USER = entity.LAST_MODIFY_USER;
				model.LAST_MODIFY_DATE_TIME = entity.LAST_MODIFY_DATE_TIME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
