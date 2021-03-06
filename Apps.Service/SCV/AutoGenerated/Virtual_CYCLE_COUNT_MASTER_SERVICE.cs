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
namespace Apps.Service.SCV.CYCLE
{
	public class Virtual_CYCLE_COUNT_MASTER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.CYCLE.ICYCLE_COUNT_MASTER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.CYCLE_COUNT_MASTER;
			}
		}
		

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL> GetList(Expression<Func<Apps.Models.CYCLE_COUNT_MASTER, bool>> where = null){
		
				IQueryable<Apps.Models.CYCLE_COUNT_MASTER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.CYCLE_COUNT_MASTER, bool>> where,Expression<Func<Apps.Models.CYCLE_COUNT_MASTER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.CYCLE_COUNT_MASTER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.CYCLE_COUNT_MASTER, bool>> where = null)
		{

			IQueryable<Apps.Models.CYCLE_COUNT_MASTER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.MASTER_ID.Contains(queryStr)
								|| a.MASTER_NAME.Contains(queryStr)
								|| a.ITEM_SELECTION.Contains(queryStr)
								|| a.LOCATION_SELECTION.Contains(queryStr)
								|| a.TRANSACTION_SELECTION.Contains(queryStr)
								|| a.COUNT_TYPE.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								
								
								|| a.CREATED_USER.Contains(queryStr)
								
								|| a.LAST_MODIFIED_USER.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL> CreateModelList(ref IQueryable<Apps.Models.CYCLE_COUNT_MASTER> queryData)
		{

			List<Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL
											  {
													INTERNAL_MASTER_NUM = r.INTERNAL_MASTER_NUM,
													MASTER_ID = r.MASTER_ID,
													MASTER_NAME = r.MASTER_NAME,
													ITEM_SELECTION = r.ITEM_SELECTION,
													LOCATION_SELECTION = r.LOCATION_SELECTION,
													TRANSACTION_SELECTION = r.TRANSACTION_SELECTION,
													COUNT_TYPE = r.COUNT_TYPE,
													ACTIVE = r.ACTIVE,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													CREATED_USER = r.CREATED_USER,
													CREATED_DATE_TIME = r.CREATED_DATE_TIME,
													LAST_MODIFIED_USER = r.LAST_MODIFIED_USER,
													LAST_MODIFIED_DATE_TIME = r.LAST_MODIFIED_DATE_TIME,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL model)
		{
				Apps.Models.CYCLE_COUNT_MASTER entity = m_Rep.GetById(model.INTERNAL_MASTER_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.CYCLE_COUNT_MASTER();
			   				entity.INTERNAL_MASTER_NUM = model.INTERNAL_MASTER_NUM;
				entity.MASTER_ID = model.MASTER_ID;
				entity.MASTER_NAME = model.MASTER_NAME;
				entity.ITEM_SELECTION = model.ITEM_SELECTION;
				entity.LOCATION_SELECTION = model.LOCATION_SELECTION;
				entity.TRANSACTION_SELECTION = model.TRANSACTION_SELECTION;
				entity.COUNT_TYPE = model.COUNT_TYPE;
				entity.ACTIVE = model.ACTIVE;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.CREATED_USER = model.CREATED_USER;
				entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
				entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
				entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.CYCLE_COUNT_MASTER entity = m_Rep.GetById(model.INTERNAL_MASTER_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_MASTER_NUM = model.INTERNAL_MASTER_NUM;
											entity.MASTER_ID = model.MASTER_ID;
											entity.MASTER_NAME = model.MASTER_NAME;
											entity.ITEM_SELECTION = model.ITEM_SELECTION;
											entity.LOCATION_SELECTION = model.LOCATION_SELECTION;
											entity.TRANSACTION_SELECTION = model.TRANSACTION_SELECTION;
											entity.COUNT_TYPE = model.COUNT_TYPE;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.CREATED_USER = model.CREATED_USER;
											entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
											entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
											entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
									}else{
					
						Type type = typeof(Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL);
						Type typeE = typeof(Apps.Models.CYCLE_COUNT_MASTER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL GetById(string id)
		{
			Apps.Models.CYCLE_COUNT_MASTER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//CYCLE_COUNT_MASTER entity = m_Rep.GetById(id);
				Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL model = new Apps.Models.SCV.CYCLE.CYCLE_COUNT_MASTER_MODEL();
							  				model.INTERNAL_MASTER_NUM = entity.INTERNAL_MASTER_NUM;
				model.MASTER_ID = entity.MASTER_ID;
				model.MASTER_NAME = entity.MASTER_NAME;
				model.ITEM_SELECTION = entity.ITEM_SELECTION;
				model.LOCATION_SELECTION = entity.LOCATION_SELECTION;
				model.TRANSACTION_SELECTION = entity.TRANSACTION_SELECTION;
				model.COUNT_TYPE = entity.COUNT_TYPE;
				model.ACTIVE = entity.ACTIVE;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.CREATED_USER = entity.CREATED_USER;
				model.CREATED_DATE_TIME = entity.CREATED_DATE_TIME;
				model.LAST_MODIFIED_USER = entity.LAST_MODIFIED_USER;
				model.LAST_MODIFIED_DATE_TIME = entity.LAST_MODIFIED_DATE_TIME;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
