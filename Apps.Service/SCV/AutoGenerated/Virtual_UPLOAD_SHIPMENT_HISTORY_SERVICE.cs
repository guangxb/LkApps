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
namespace Apps.Service.SCV.UPLOAD
{
	public class Virtual_UPLOAD_SHIPMENT_HISTORY_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.UPLOAD.IUPLOAD_SHIPMENT_HISTORY_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.UPLOAD_SHIPMENT_HISTORY;
			}
		}
		

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL> GetList(Expression<Func<Apps.Models.UPLOAD_SHIPMENT_HISTORY, bool>> where = null){
		
				IQueryable<Apps.Models.UPLOAD_SHIPMENT_HISTORY> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.UPLOAD_SHIPMENT_HISTORY, bool>> where,Expression<Func<Apps.Models.UPLOAD_SHIPMENT_HISTORY, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.UPLOAD_SHIPMENT_HISTORY> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.UPLOAD_SHIPMENT_HISTORY, bool>> where = null)
		{

			IQueryable<Apps.Models.UPLOAD_SHIPMENT_HISTORY> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.INTERFACE_RECORD_ID.Contains(queryStr)
								|| a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								
								|| a.SHIPMENT_ID.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								
								
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.UPLOAD_FLAG.Contains(queryStr)
								
								|| a.UPLOAD_STATUS.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL> CreateModelList(ref IQueryable<Apps.Models.UPLOAD_SHIPMENT_HISTORY> queryData)
		{

			List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													INTERNAL_SHIPMENT_NUM = r.INTERNAL_SHIPMENT_NUM,
													SHIPMENT_ID = r.SHIPMENT_ID,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													LEADING_STS = r.LEADING_STS,
													TRAILING_STS = r.TRAILING_STS,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													UPLOAD_FLAG = r.UPLOAD_FLAG,
													UPLOAD_TIME = r.UPLOAD_TIME,
													UPLOAD_STATUS = r.UPLOAD_STATUS,
													CALL_BACK_TIME = r.CALL_BACK_TIME,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL model)
		{
				Apps.Models.UPLOAD_SHIPMENT_HISTORY entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.UPLOAD_SHIPMENT_HISTORY();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.INTERNAL_SHIPMENT_NUM = model.INTERNAL_SHIPMENT_NUM;
				entity.SHIPMENT_ID = model.SHIPMENT_ID;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.LEADING_STS = model.LEADING_STS;
				entity.TRAILING_STS = model.TRAILING_STS;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.UPLOAD_FLAG = model.UPLOAD_FLAG;
				entity.UPLOAD_TIME = model.UPLOAD_TIME;
				entity.UPLOAD_STATUS = model.UPLOAD_STATUS;
				entity.CALL_BACK_TIME = model.CALL_BACK_TIME;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL model,params string[] updateProperties)
		{
				Apps.Models.UPLOAD_SHIPMENT_HISTORY entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
											entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
											entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.INTERNAL_SHIPMENT_NUM = model.INTERNAL_SHIPMENT_NUM;
											entity.SHIPMENT_ID = model.SHIPMENT_ID;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.LEADING_STS = model.LEADING_STS;
											entity.TRAILING_STS = model.TRAILING_STS;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.UPLOAD_FLAG = model.UPLOAD_FLAG;
											entity.UPLOAD_TIME = model.UPLOAD_TIME;
											entity.UPLOAD_STATUS = model.UPLOAD_STATUS;
											entity.CALL_BACK_TIME = model.CALL_BACK_TIME;
									}else{
					
						Type type = typeof(Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL);
						Type typeE = typeof(Apps.Models.UPLOAD_SHIPMENT_HISTORY);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL GetById(string id)
		{
			Apps.Models.UPLOAD_SHIPMENT_HISTORY entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//UPLOAD_SHIPMENT_HISTORY entity = m_Rep.GetById(id);
				Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL model = new Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_HISTORY_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.INTERNAL_SHIPMENT_NUM = entity.INTERNAL_SHIPMENT_NUM;
				model.SHIPMENT_ID = entity.SHIPMENT_ID;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.LEADING_STS = entity.LEADING_STS;
				model.TRAILING_STS = entity.TRAILING_STS;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.UPLOAD_FLAG = entity.UPLOAD_FLAG;
				model.UPLOAD_TIME = entity.UPLOAD_TIME;
				model.UPLOAD_STATUS = entity.UPLOAD_STATUS;
				model.CALL_BACK_TIME = entity.CALL_BACK_TIME;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
