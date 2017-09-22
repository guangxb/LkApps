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
namespace Apps.Service.SCV.WAREHOUSE
{
	public class Virtual_WAREHOUSE_ACTIVITY_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.WAREHOUSE.IWAREHOUSE_ACTIVITY_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.WAREHOUSE_ACTIVITY;
			}
		}
		

		public virtual List<Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL> GetList(Expression<Func<Apps.Models.WAREHOUSE_ACTIVITY, bool>> where = null){
		
				IQueryable<Apps.Models.WAREHOUSE_ACTIVITY> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.WAREHOUSE_ACTIVITY, bool>> where,Expression<Func<Apps.Models.WAREHOUSE_ACTIVITY, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.WAREHOUSE_ACTIVITY> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.WAREHOUSE_ACTIVITY, bool>> where = null)
		{

			IQueryable<Apps.Models.WAREHOUSE_ACTIVITY> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.ACTIVITY_TYPE.Contains(queryStr)
								|| a.ACTIVITY_NAME.Contains(queryStr)
								
								|| a.REFERENCE_ID1.Contains(queryStr)
								|| a.REFERENCE_TYPE1.Contains(queryStr)
								
								|| a.REFERENCE_ID2.Contains(queryStr)
								|| a.REFERENCE_TYPE2.Contains(queryStr)
								
								|| a.REFERENCE_ID3.Contains(queryStr)
								|| a.REFERENCE_TYPE3.Contains(queryStr)
								
								|| a.REFERENCE_ID4.Contains(queryStr)
								|| a.REFERENCE_TYPE4.Contains(queryStr)
								|| a.REFERENCE_STATUS.Contains(queryStr)
								
								
								|| a.COMPLETED_USER.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL> CreateModelList(ref IQueryable<Apps.Models.WAREHOUSE_ACTIVITY> queryData)
		{

			List<Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													ACTIVITY_TYPE = r.ACTIVITY_TYPE,
													ACTIVITY_NAME = r.ACTIVITY_NAME,
													REFERENCE_NUM1 = r.REFERENCE_NUM1,
													REFERENCE_ID1 = r.REFERENCE_ID1,
													REFERENCE_TYPE1 = r.REFERENCE_TYPE1,
													REFERENCE_NUM2 = r.REFERENCE_NUM2,
													REFERENCE_ID2 = r.REFERENCE_ID2,
													REFERENCE_TYPE2 = r.REFERENCE_TYPE2,
													REFERENCE_NUM3 = r.REFERENCE_NUM3,
													REFERENCE_ID3 = r.REFERENCE_ID3,
													REFERENCE_TYPE3 = r.REFERENCE_TYPE3,
													REFERENCE_NUM4 = r.REFERENCE_NUM4,
													REFERENCE_ID4 = r.REFERENCE_ID4,
													REFERENCE_TYPE4 = r.REFERENCE_TYPE4,
													REFERENCE_STATUS = r.REFERENCE_STATUS,
													START_DATE_TIME = r.START_DATE_TIME,
													END_DATE_TIME = r.END_DATE_TIME,
													COMPLETED_USER = r.COMPLETED_USER,
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

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL model)
		{
				Apps.Models.WAREHOUSE_ACTIVITY entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.WAREHOUSE_ACTIVITY();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.ACTIVITY_TYPE = model.ACTIVITY_TYPE;
				entity.ACTIVITY_NAME = model.ACTIVITY_NAME;
				entity.REFERENCE_NUM1 = model.REFERENCE_NUM1;
				entity.REFERENCE_ID1 = model.REFERENCE_ID1;
				entity.REFERENCE_TYPE1 = model.REFERENCE_TYPE1;
				entity.REFERENCE_NUM2 = model.REFERENCE_NUM2;
				entity.REFERENCE_ID2 = model.REFERENCE_ID2;
				entity.REFERENCE_TYPE2 = model.REFERENCE_TYPE2;
				entity.REFERENCE_NUM3 = model.REFERENCE_NUM3;
				entity.REFERENCE_ID3 = model.REFERENCE_ID3;
				entity.REFERENCE_TYPE3 = model.REFERENCE_TYPE3;
				entity.REFERENCE_NUM4 = model.REFERENCE_NUM4;
				entity.REFERENCE_ID4 = model.REFERENCE_ID4;
				entity.REFERENCE_TYPE4 = model.REFERENCE_TYPE4;
				entity.REFERENCE_STATUS = model.REFERENCE_STATUS;
				entity.START_DATE_TIME = model.START_DATE_TIME;
				entity.END_DATE_TIME = model.END_DATE_TIME;
				entity.COMPLETED_USER = model.COMPLETED_USER;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL model,params string[] updateProperties)
		{
				Apps.Models.WAREHOUSE_ACTIVITY entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.ACTIVITY_TYPE = model.ACTIVITY_TYPE;
											entity.ACTIVITY_NAME = model.ACTIVITY_NAME;
											entity.REFERENCE_NUM1 = model.REFERENCE_NUM1;
											entity.REFERENCE_ID1 = model.REFERENCE_ID1;
											entity.REFERENCE_TYPE1 = model.REFERENCE_TYPE1;
											entity.REFERENCE_NUM2 = model.REFERENCE_NUM2;
											entity.REFERENCE_ID2 = model.REFERENCE_ID2;
											entity.REFERENCE_TYPE2 = model.REFERENCE_TYPE2;
											entity.REFERENCE_NUM3 = model.REFERENCE_NUM3;
											entity.REFERENCE_ID3 = model.REFERENCE_ID3;
											entity.REFERENCE_TYPE3 = model.REFERENCE_TYPE3;
											entity.REFERENCE_NUM4 = model.REFERENCE_NUM4;
											entity.REFERENCE_ID4 = model.REFERENCE_ID4;
											entity.REFERENCE_TYPE4 = model.REFERENCE_TYPE4;
											entity.REFERENCE_STATUS = model.REFERENCE_STATUS;
											entity.START_DATE_TIME = model.START_DATE_TIME;
											entity.END_DATE_TIME = model.END_DATE_TIME;
											entity.COMPLETED_USER = model.COMPLETED_USER;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
									}else{
					
						Type type = typeof(Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL);
						Type typeE = typeof(Apps.Models.WAREHOUSE_ACTIVITY);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL GetById(string id)
		{
			Apps.Models.WAREHOUSE_ACTIVITY entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//WAREHOUSE_ACTIVITY entity = m_Rep.GetById(id);
				Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL model = new Apps.Models.SCV.WAREHOUSE.WAREHOUSE_ACTIVITY_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.ACTIVITY_TYPE = entity.ACTIVITY_TYPE;
				model.ACTIVITY_NAME = entity.ACTIVITY_NAME;
				model.REFERENCE_NUM1 = entity.REFERENCE_NUM1;
				model.REFERENCE_ID1 = entity.REFERENCE_ID1;
				model.REFERENCE_TYPE1 = entity.REFERENCE_TYPE1;
				model.REFERENCE_NUM2 = entity.REFERENCE_NUM2;
				model.REFERENCE_ID2 = entity.REFERENCE_ID2;
				model.REFERENCE_TYPE2 = entity.REFERENCE_TYPE2;
				model.REFERENCE_NUM3 = entity.REFERENCE_NUM3;
				model.REFERENCE_ID3 = entity.REFERENCE_ID3;
				model.REFERENCE_TYPE3 = entity.REFERENCE_TYPE3;
				model.REFERENCE_NUM4 = entity.REFERENCE_NUM4;
				model.REFERENCE_ID4 = entity.REFERENCE_ID4;
				model.REFERENCE_TYPE4 = entity.REFERENCE_TYPE4;
				model.REFERENCE_STATUS = entity.REFERENCE_STATUS;
				model.START_DATE_TIME = entity.START_DATE_TIME;
				model.END_DATE_TIME = entity.END_DATE_TIME;
				model.COMPLETED_USER = entity.COMPLETED_USER;
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