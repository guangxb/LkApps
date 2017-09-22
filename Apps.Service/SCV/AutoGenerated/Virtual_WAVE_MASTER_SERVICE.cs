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
namespace Apps.Service.SCV.WAVE
{
	public class Virtual_WAVE_MASTER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.WAVE.IWAVE_MASTER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.WAVE_MASTER;
			}
		}
		

		public virtual List<Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL> GetList(Expression<Func<Apps.Models.WAVE_MASTER, bool>> where = null){
		
				IQueryable<Apps.Models.WAVE_MASTER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.WAVE_MASTER, bool>> where,Expression<Func<Apps.Models.WAVE_MASTER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.WAVE_MASTER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.WAVE_MASTER, bool>> where = null)
		{

			IQueryable<Apps.Models.WAVE_MASTER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.MASTER_NAME.Contains(queryStr)
								
								|| a.SHIPMENT_FILTER.Contains(queryStr)
								|| a.WAVE_MODE.Contains(queryStr)
								|| a.AUTO_RUN.Contains(queryStr)
								|| a.AUTO_RELEASE.Contains(queryStr)
								|| a.WAVE_FLOW.Contains(queryStr)
								|| a.CREATE_TASK.Contains(queryStr)
								|| a.SHORT_MODE.Contains(queryStr)
								
								
								
								
								
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.ACTIVE.Contains(queryStr)
								|| a.CONTAINER_CREATION_CRITERIA.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL> CreateModelList(ref IQueryable<Apps.Models.WAVE_MASTER> queryData)
		{

			List<Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													MASTER_NAME = r.MASTER_NAME,
													PRIORITY = r.PRIORITY,
													SHIPMENT_FILTER = r.SHIPMENT_FILTER,
													WAVE_MODE = r.WAVE_MODE,
													AUTO_RUN = r.AUTO_RUN,
													AUTO_RELEASE = r.AUTO_RELEASE,
													WAVE_FLOW = r.WAVE_FLOW,
													CREATE_TASK = r.CREATE_TASK,
													SHORT_MODE = r.SHORT_MODE,
													MAX_SHIPMENTS = r.MAX_SHIPMENTS,
													MAX_LINES = r.MAX_LINES,
													MAX_ITEMS = r.MAX_ITEMS,
													MAX_QTY = r.MAX_QTY,
													MAX_WEIGHT = r.MAX_WEIGHT,
													MAX_VOLUME = r.MAX_VOLUME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													ACTIVE = r.ACTIVE,
													CONTAINER_CREATION_CRITERIA = r.CONTAINER_CREATION_CRITERIA,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL model)
		{
				Apps.Models.WAVE_MASTER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.WAVE_MASTER();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.MASTER_NAME = model.MASTER_NAME;
				entity.PRIORITY = model.PRIORITY;
				entity.SHIPMENT_FILTER = model.SHIPMENT_FILTER;
				entity.WAVE_MODE = model.WAVE_MODE;
				entity.AUTO_RUN = model.AUTO_RUN;
				entity.AUTO_RELEASE = model.AUTO_RELEASE;
				entity.WAVE_FLOW = model.WAVE_FLOW;
				entity.CREATE_TASK = model.CREATE_TASK;
				entity.SHORT_MODE = model.SHORT_MODE;
				entity.MAX_SHIPMENTS = model.MAX_SHIPMENTS;
				entity.MAX_LINES = model.MAX_LINES;
				entity.MAX_ITEMS = model.MAX_ITEMS;
				entity.MAX_QTY = model.MAX_QTY;
				entity.MAX_WEIGHT = model.MAX_WEIGHT;
				entity.MAX_VOLUME = model.MAX_VOLUME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.ACTIVE = model.ACTIVE;
				entity.CONTAINER_CREATION_CRITERIA = model.CONTAINER_CREATION_CRITERIA;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.WAVE_MASTER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.MASTER_NAME = model.MASTER_NAME;
											entity.PRIORITY = model.PRIORITY;
											entity.SHIPMENT_FILTER = model.SHIPMENT_FILTER;
											entity.WAVE_MODE = model.WAVE_MODE;
											entity.AUTO_RUN = model.AUTO_RUN;
											entity.AUTO_RELEASE = model.AUTO_RELEASE;
											entity.WAVE_FLOW = model.WAVE_FLOW;
											entity.CREATE_TASK = model.CREATE_TASK;
											entity.SHORT_MODE = model.SHORT_MODE;
											entity.MAX_SHIPMENTS = model.MAX_SHIPMENTS;
											entity.MAX_LINES = model.MAX_LINES;
											entity.MAX_ITEMS = model.MAX_ITEMS;
											entity.MAX_QTY = model.MAX_QTY;
											entity.MAX_WEIGHT = model.MAX_WEIGHT;
											entity.MAX_VOLUME = model.MAX_VOLUME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.ACTIVE = model.ACTIVE;
											entity.CONTAINER_CREATION_CRITERIA = model.CONTAINER_CREATION_CRITERIA;
									}else{
					
						Type type = typeof(Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL);
						Type typeE = typeof(Apps.Models.WAVE_MASTER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL GetById(string id)
		{
			Apps.Models.WAVE_MASTER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//WAVE_MASTER entity = m_Rep.GetById(id);
				Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL model = new Apps.Models.SCV.WAVE.WAVE_MASTER_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.MASTER_NAME = entity.MASTER_NAME;
				model.PRIORITY = entity.PRIORITY;
				model.SHIPMENT_FILTER = entity.SHIPMENT_FILTER;
				model.WAVE_MODE = entity.WAVE_MODE;
				model.AUTO_RUN = entity.AUTO_RUN;
				model.AUTO_RELEASE = entity.AUTO_RELEASE;
				model.WAVE_FLOW = entity.WAVE_FLOW;
				model.CREATE_TASK = entity.CREATE_TASK;
				model.SHORT_MODE = entity.SHORT_MODE;
				model.MAX_SHIPMENTS = entity.MAX_SHIPMENTS;
				model.MAX_LINES = entity.MAX_LINES;
				model.MAX_ITEMS = entity.MAX_ITEMS;
				model.MAX_QTY = entity.MAX_QTY;
				model.MAX_WEIGHT = entity.MAX_WEIGHT;
				model.MAX_VOLUME = entity.MAX_VOLUME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.ACTIVE = entity.ACTIVE;
				model.CONTAINER_CREATION_CRITERIA = entity.CONTAINER_CREATION_CRITERIA;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
