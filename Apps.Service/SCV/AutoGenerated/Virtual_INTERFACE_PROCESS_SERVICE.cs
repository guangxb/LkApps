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
namespace Apps.Service.SCV.INTERFACE
{
	public class Virtual_INTERFACE_PROCESS_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.INTERFACE.IINTERFACE_PROCESS_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.INTERFACE_PROCESS;
			}
		}
		

		public virtual List<Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL> GetList(Expression<Func<Apps.Models.INTERFACE_PROCESS, bool>> where = null){
		
				IQueryable<Apps.Models.INTERFACE_PROCESS> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.INTERFACE_PROCESS, bool>> where,Expression<Func<Apps.Models.INTERFACE_PROCESS, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.INTERFACE_PROCESS> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.INTERFACE_PROCESS, bool>> where = null)
		{

			IQueryable<Apps.Models.INTERFACE_PROCESS> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.DESCRIPTION.Contains(queryStr)
								|| a.INTERFACE_TYPE.Contains(queryStr)
								|| a.DIRECTION.Contains(queryStr)
								|| a.INTERFACE_MODE.Contains(queryStr)
								|| a.PRE_INTERFACE_ACTION.Contains(queryStr)
								|| a.POST_INTERFACE_ACTION.Contains(queryStr)
								|| a.INTERFACE_ACTION.Contains(queryStr)
								|| a.SAVE_DATA.Contains(queryStr)
								
								|| a.ACTIVE.Contains(queryStr)
								|| a.IN_PROCESS.Contains(queryStr)
								
								
								|| a.USER_STAMP.Contains(queryStr)
								|| a.LAST_RUN_RESULT.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL> CreateModelList(ref IQueryable<Apps.Models.INTERFACE_PROCESS> queryData)
		{

			List<Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													DESCRIPTION = r.DESCRIPTION,
													INTERFACE_TYPE = r.INTERFACE_TYPE,
													DIRECTION = r.DIRECTION,
													INTERFACE_MODE = r.INTERFACE_MODE,
													PRE_INTERFACE_ACTION = r.PRE_INTERFACE_ACTION,
													POST_INTERFACE_ACTION = r.POST_INTERFACE_ACTION,
													INTERFACE_ACTION = r.INTERFACE_ACTION,
													SAVE_DATA = r.SAVE_DATA,
													TRANSACTION_SIZE = r.TRANSACTION_SIZE,
													ACTIVE = r.ACTIVE,
													IN_PROCESS = r.IN_PROCESS,
													LAST_RUN_TIME = r.LAST_RUN_TIME,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													USER_STAMP = r.USER_STAMP,
													LAST_RUN_RESULT = r.LAST_RUN_RESULT,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL model)
		{
				Apps.Models.INTERFACE_PROCESS entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.INTERFACE_PROCESS();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.DESCRIPTION = model.DESCRIPTION;
				entity.INTERFACE_TYPE = model.INTERFACE_TYPE;
				entity.DIRECTION = model.DIRECTION;
				entity.INTERFACE_MODE = model.INTERFACE_MODE;
				entity.PRE_INTERFACE_ACTION = model.PRE_INTERFACE_ACTION;
				entity.POST_INTERFACE_ACTION = model.POST_INTERFACE_ACTION;
				entity.INTERFACE_ACTION = model.INTERFACE_ACTION;
				entity.SAVE_DATA = model.SAVE_DATA;
				entity.TRANSACTION_SIZE = model.TRANSACTION_SIZE;
				entity.ACTIVE = model.ACTIVE;
				entity.IN_PROCESS = model.IN_PROCESS;
				entity.LAST_RUN_TIME = model.LAST_RUN_TIME;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.USER_STAMP = model.USER_STAMP;
				entity.LAST_RUN_RESULT = model.LAST_RUN_RESULT;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL model,params string[] updateProperties)
		{
				Apps.Models.INTERFACE_PROCESS entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.DESCRIPTION = model.DESCRIPTION;
											entity.INTERFACE_TYPE = model.INTERFACE_TYPE;
											entity.DIRECTION = model.DIRECTION;
											entity.INTERFACE_MODE = model.INTERFACE_MODE;
											entity.PRE_INTERFACE_ACTION = model.PRE_INTERFACE_ACTION;
											entity.POST_INTERFACE_ACTION = model.POST_INTERFACE_ACTION;
											entity.INTERFACE_ACTION = model.INTERFACE_ACTION;
											entity.SAVE_DATA = model.SAVE_DATA;
											entity.TRANSACTION_SIZE = model.TRANSACTION_SIZE;
											entity.ACTIVE = model.ACTIVE;
											entity.IN_PROCESS = model.IN_PROCESS;
											entity.LAST_RUN_TIME = model.LAST_RUN_TIME;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.USER_STAMP = model.USER_STAMP;
											entity.LAST_RUN_RESULT = model.LAST_RUN_RESULT;
									}else{
					
						Type type = typeof(Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL);
						Type typeE = typeof(Apps.Models.INTERFACE_PROCESS);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL GetById(string id)
		{
			Apps.Models.INTERFACE_PROCESS entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//INTERFACE_PROCESS entity = m_Rep.GetById(id);
				Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL model = new Apps.Models.SCV.INTERFACE.INTERFACE_PROCESS_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.DESCRIPTION = entity.DESCRIPTION;
				model.INTERFACE_TYPE = entity.INTERFACE_TYPE;
				model.DIRECTION = entity.DIRECTION;
				model.INTERFACE_MODE = entity.INTERFACE_MODE;
				model.PRE_INTERFACE_ACTION = entity.PRE_INTERFACE_ACTION;
				model.POST_INTERFACE_ACTION = entity.POST_INTERFACE_ACTION;
				model.INTERFACE_ACTION = entity.INTERFACE_ACTION;
				model.SAVE_DATA = entity.SAVE_DATA;
				model.TRANSACTION_SIZE = entity.TRANSACTION_SIZE;
				model.ACTIVE = entity.ACTIVE;
				model.IN_PROCESS = entity.IN_PROCESS;
				model.LAST_RUN_TIME = entity.LAST_RUN_TIME;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.USER_STAMP = entity.USER_STAMP;
				model.LAST_RUN_RESULT = entity.LAST_RUN_RESULT;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
