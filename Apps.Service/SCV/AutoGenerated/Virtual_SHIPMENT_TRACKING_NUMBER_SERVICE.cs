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
namespace Apps.Service.SCV.SHIPMENT
{
	public class Virtual_SHIPMENT_TRACKING_NUMBER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.SHIPMENT.ISHIPMENT_TRACKING_NUMBER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.SHIPMENT_TRACKING_NUMBER;
			}
		}
		

		public virtual List<Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL> GetList(Expression<Func<Apps.Models.SHIPMENT_TRACKING_NUMBER, bool>> where = null){
		
				IQueryable<Apps.Models.SHIPMENT_TRACKING_NUMBER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.SHIPMENT_TRACKING_NUMBER, bool>> where,Expression<Func<Apps.Models.SHIPMENT_TRACKING_NUMBER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.SHIPMENT_TRACKING_NUMBER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SHIPMENT_TRACKING_NUMBER, bool>> where = null)
		{

			IQueryable<Apps.Models.SHIPMENT_TRACKING_NUMBER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.CARRIER.Contains(queryStr)
								|| a.TRACKING_NUMBER.Contains(queryStr)
								
								|| a.SHIPMENT_ID.Contains(queryStr)
								|| a.CONTAINER_ID.Contains(queryStr)
								|| a.BATCH_ID.Contains(queryStr)
								|| a.CREATED_USER.Contains(queryStr)
								
								|| a.LAST_MODIFIED_USER.Contains(queryStr)
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL> CreateModelList(ref IQueryable<Apps.Models.SHIPMENT_TRACKING_NUMBER> queryData)
		{

			List<Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													CARRIER = r.CARRIER,
													TRACKING_NUMBER = r.TRACKING_NUMBER,
													STATUS = r.STATUS,
													SHIPMENT_ID = r.SHIPMENT_ID,
													CONTAINER_ID = r.CONTAINER_ID,
													BATCH_ID = r.BATCH_ID,
													CREATED_USER = r.CREATED_USER,
													CREATED_DATE_TIME = r.CREATED_DATE_TIME,
													LAST_MODIFIED_USER = r.LAST_MODIFIED_USER,
													LAST_MODIFIED_DATE_TIME = r.LAST_MODIFIED_DATE_TIME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL model)
		{
				Apps.Models.SHIPMENT_TRACKING_NUMBER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.SHIPMENT_TRACKING_NUMBER();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.CARRIER = model.CARRIER;
				entity.TRACKING_NUMBER = model.TRACKING_NUMBER;
				entity.STATUS = model.STATUS;
				entity.SHIPMENT_ID = model.SHIPMENT_ID;
				entity.CONTAINER_ID = model.CONTAINER_ID;
				entity.BATCH_ID = model.BATCH_ID;
				entity.CREATED_USER = model.CREATED_USER;
				entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
				entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
				entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.SHIPMENT_TRACKING_NUMBER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.CARRIER = model.CARRIER;
											entity.TRACKING_NUMBER = model.TRACKING_NUMBER;
											entity.STATUS = model.STATUS;
											entity.SHIPMENT_ID = model.SHIPMENT_ID;
											entity.CONTAINER_ID = model.CONTAINER_ID;
											entity.BATCH_ID = model.BATCH_ID;
											entity.CREATED_USER = model.CREATED_USER;
											entity.CREATED_DATE_TIME = model.CREATED_DATE_TIME;
											entity.LAST_MODIFIED_USER = model.LAST_MODIFIED_USER;
											entity.LAST_MODIFIED_DATE_TIME = model.LAST_MODIFIED_DATE_TIME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
									}else{
					
						Type type = typeof(Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL);
						Type typeE = typeof(Apps.Models.SHIPMENT_TRACKING_NUMBER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL GetById(string id)
		{
			Apps.Models.SHIPMENT_TRACKING_NUMBER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SHIPMENT_TRACKING_NUMBER entity = m_Rep.GetById(id);
				Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL model = new Apps.Models.SCV.SHIPMENT.SHIPMENT_TRACKING_NUMBER_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.CARRIER = entity.CARRIER;
				model.TRACKING_NUMBER = entity.TRACKING_NUMBER;
				model.STATUS = entity.STATUS;
				model.SHIPMENT_ID = entity.SHIPMENT_ID;
				model.CONTAINER_ID = entity.CONTAINER_ID;
				model.BATCH_ID = entity.BATCH_ID;
				model.CREATED_USER = entity.CREATED_USER;
				model.CREATED_DATE_TIME = entity.CREATED_DATE_TIME;
				model.LAST_MODIFIED_USER = entity.LAST_MODIFIED_USER;
				model.LAST_MODIFIED_DATE_TIME = entity.LAST_MODIFIED_DATE_TIME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
