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
namespace Apps.Service.SCV.AR
{
	public class Virtual_AR_UPLOAD_ORDER_STATUS_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.AR.IAR_UPLOAD_ORDER_STATUS_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.AR_UPLOAD_ORDER_STATUS;
			}
		}
		

		public virtual List<Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL> GetList(Expression<Func<Apps.Models.AR_UPLOAD_ORDER_STATUS, bool>> where = null){
		
				IQueryable<Apps.Models.AR_UPLOAD_ORDER_STATUS> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.AR_UPLOAD_ORDER_STATUS, bool>> where,Expression<Func<Apps.Models.AR_UPLOAD_ORDER_STATUS, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.AR_UPLOAD_ORDER_STATUS> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.AR_UPLOAD_ORDER_STATUS, bool>> where = null)
		{

			IQueryable<Apps.Models.AR_UPLOAD_ORDER_STATUS> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.INTERFACE_ERROR.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.SHIPMENT_ID.Contains(queryStr)
								
								
								|| a.PROCESS_TYPE.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								
								|| a.USER_STAMP.Contains(queryStr)
								|| a.TRACKING_NUMBER.Contains(queryStr)
								|| a.CONTAINER_ID.Contains(queryStr)
								|| a.CARRIER.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL> CreateModelList(ref IQueryable<Apps.Models.AR_UPLOAD_ORDER_STATUS> queryData)
		{

			List<Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													INTERFACE_ERROR = r.INTERFACE_ERROR,
													COMPANY = r.COMPANY,
													WAREHOUSE = r.WAREHOUSE,
													SHIPMENT_ID = r.SHIPMENT_ID,
													LEADING_STS = r.LEADING_STS,
													TRAILING_STS = r.TRAILING_STS,
													PROCESS_TYPE = r.PROCESS_TYPE,
													PROCESS_STAMP = r.PROCESS_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													USER_STAMP = r.USER_STAMP,
													TRACKING_NUMBER = r.TRACKING_NUMBER,
													CONTAINER_ID = r.CONTAINER_ID,
													CARRIER = r.CARRIER,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL model)
		{
				Apps.Models.AR_UPLOAD_ORDER_STATUS entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.AR_UPLOAD_ORDER_STATUS();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.INTERFACE_ERROR = model.INTERFACE_ERROR;
				entity.COMPANY = model.COMPANY;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.SHIPMENT_ID = model.SHIPMENT_ID;
				entity.LEADING_STS = model.LEADING_STS;
				entity.TRAILING_STS = model.TRAILING_STS;
				entity.PROCESS_TYPE = model.PROCESS_TYPE;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.USER_STAMP = model.USER_STAMP;
				entity.TRACKING_NUMBER = model.TRACKING_NUMBER;
				entity.CONTAINER_ID = model.CONTAINER_ID;
				entity.CARRIER = model.CARRIER;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL model,params string[] updateProperties)
		{
				Apps.Models.AR_UPLOAD_ORDER_STATUS entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
											entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
											entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
											entity.INTERFACE_ERROR = model.INTERFACE_ERROR;
											entity.COMPANY = model.COMPANY;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.SHIPMENT_ID = model.SHIPMENT_ID;
											entity.LEADING_STS = model.LEADING_STS;
											entity.TRAILING_STS = model.TRAILING_STS;
											entity.PROCESS_TYPE = model.PROCESS_TYPE;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.USER_STAMP = model.USER_STAMP;
											entity.TRACKING_NUMBER = model.TRACKING_NUMBER;
											entity.CONTAINER_ID = model.CONTAINER_ID;
											entity.CARRIER = model.CARRIER;
									}else{
					
						Type type = typeof(Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL);
						Type typeE = typeof(Apps.Models.AR_UPLOAD_ORDER_STATUS);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL GetById(string id)
		{
			Apps.Models.AR_UPLOAD_ORDER_STATUS entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//AR_UPLOAD_ORDER_STATUS entity = m_Rep.GetById(id);
				Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL model = new Apps.Models.SCV.AR.AR_UPLOAD_ORDER_STATUS_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.INTERFACE_ERROR = entity.INTERFACE_ERROR;
				model.COMPANY = entity.COMPANY;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.SHIPMENT_ID = entity.SHIPMENT_ID;
				model.LEADING_STS = entity.LEADING_STS;
				model.TRAILING_STS = entity.TRAILING_STS;
				model.PROCESS_TYPE = entity.PROCESS_TYPE;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.USER_STAMP = entity.USER_STAMP;
				model.TRACKING_NUMBER = entity.TRACKING_NUMBER;
				model.CONTAINER_ID = entity.CONTAINER_ID;
				model.CARRIER = entity.CARRIER;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
