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
	public class Virtual_AR_DOWNLOAD_ITEM_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.AR.IAR_DOWNLOAD_ITEM_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.AR_DOWNLOAD_ITEM;
			}
		}
		

		public virtual List<Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL> GetList(Expression<Func<Apps.Models.AR_DOWNLOAD_ITEM, bool>> where = null){
		
				IQueryable<Apps.Models.AR_DOWNLOAD_ITEM> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.AR_DOWNLOAD_ITEM, bool>> where,Expression<Func<Apps.Models.AR_DOWNLOAD_ITEM, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.AR_DOWNLOAD_ITEM> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.AR_DOWNLOAD_ITEM, bool>> where = null)
		{

			IQueryable<Apps.Models.AR_DOWNLOAD_ITEM> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.INTERFACE_RECORD_ID.Contains(queryStr)
								|| a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								|| a.STORAGE_TEMPLATE.Contains(queryStr)
								|| a.ITEM_CLASS.Contains(queryStr)
								|| a.PACKING_CLASS.Contains(queryStr)
								|| a.ATTRIBUTE_TRACK.Contains(queryStr)
								
								|| a.LOCATING_RULE.Contains(queryStr)
								|| a.ALLOCATION_RULE.Contains(queryStr)
								|| a.REPLENISHMENT_RULE.Contains(queryStr)
								|| a.EMPTY_LOC_RULE.Contains(queryStr)
								|| a.ITEM_CATEGORY1.Contains(queryStr)
								|| a.ITEM_CATEGORY2.Contains(queryStr)
								|| a.ITEM_CATEGORY3.Contains(queryStr)
								|| a.ITEM_CATEGORY4.Contains(queryStr)
								|| a.ITEM_CATEGORY5.Contains(queryStr)
								|| a.ITEM_CATEGORY6.Contains(queryStr)
								|| a.ITEM_CATEGORY7.Contains(queryStr)
								|| a.ITEM_CATEGORY8.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.ACTIVE.Contains(queryStr)
								|| a.ATTRIBUTE_TEMPLATE_NAME.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								
								|| a.SERIAL_NUM_TEMPLATE_NAME.Contains(queryStr)
								|| a.BRAND.Contains(queryStr)
								|| a.DIVISION.Contains(queryStr)
								|| a.DEPARTMENT.Contains(queryStr)
								
								|| a.ITEM_SIZE.Contains(queryStr)
								|| a.ITEM_COLOR.Contains(queryStr)
								|| a.ITEM_STYLE.Contains(queryStr)
								
								
								|| a.PLACE_OF_ORIGIN.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE1.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE2.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE3.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE4.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE5.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE6.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE7.Contains(queryStr)
								|| a.ITEM_ATTRIBUTE8.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL> CreateModelList(ref IQueryable<Apps.Models.AR_DOWNLOAD_ITEM> queryData)
		{

			List<Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													ITEM = r.ITEM,
													COMPANY = r.COMPANY,
													ITEM_DESC = r.ITEM_DESC,
													STORAGE_TEMPLATE = r.STORAGE_TEMPLATE,
													ITEM_CLASS = r.ITEM_CLASS,
													PACKING_CLASS = r.PACKING_CLASS,
													ATTRIBUTE_TRACK = r.ATTRIBUTE_TRACK,
													DAYS_TO_EXPIRE = r.DAYS_TO_EXPIRE,
													LOCATING_RULE = r.LOCATING_RULE,
													ALLOCATION_RULE = r.ALLOCATION_RULE,
													REPLENISHMENT_RULE = r.REPLENISHMENT_RULE,
													EMPTY_LOC_RULE = r.EMPTY_LOC_RULE,
													ITEM_CATEGORY1 = r.ITEM_CATEGORY1,
													ITEM_CATEGORY2 = r.ITEM_CATEGORY2,
													ITEM_CATEGORY3 = r.ITEM_CATEGORY3,
													ITEM_CATEGORY4 = r.ITEM_CATEGORY4,
													ITEM_CATEGORY5 = r.ITEM_CATEGORY5,
													ITEM_CATEGORY6 = r.ITEM_CATEGORY6,
													ITEM_CATEGORY7 = r.ITEM_CATEGORY7,
													ITEM_CATEGORY8 = r.ITEM_CATEGORY8,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													ACTIVE = r.ACTIVE,
													ATTRIBUTE_TEMPLATE_NAME = r.ATTRIBUTE_TEMPLATE_NAME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													SERIAL_NUM_TRACK = r.SERIAL_NUM_TRACK,
													SERIAL_NUM_TEMPLATE_NAME = r.SERIAL_NUM_TEMPLATE_NAME,
													BRAND = r.BRAND,
													DIVISION = r.DIVISION,
													DEPARTMENT = r.DEPARTMENT,
													COST = r.COST,
													ITEM_SIZE = r.ITEM_SIZE,
													ITEM_COLOR = r.ITEM_COLOR,
													ITEM_STYLE = r.ITEM_STYLE,
													LIST_PRICE = r.LIST_PRICE,
													NET_PRICE = r.NET_PRICE,
													PLACE_OF_ORIGIN = r.PLACE_OF_ORIGIN,
													ITEM_ATTRIBUTE1 = r.ITEM_ATTRIBUTE1,
													ITEM_ATTRIBUTE2 = r.ITEM_ATTRIBUTE2,
													ITEM_ATTRIBUTE3 = r.ITEM_ATTRIBUTE3,
													ITEM_ATTRIBUTE4 = r.ITEM_ATTRIBUTE4,
													ITEM_ATTRIBUTE5 = r.ITEM_ATTRIBUTE5,
													ITEM_ATTRIBUTE6 = r.ITEM_ATTRIBUTE6,
													ITEM_ATTRIBUTE7 = r.ITEM_ATTRIBUTE7,
													ITEM_ATTRIBUTE8 = r.ITEM_ATTRIBUTE8,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL model)
		{
				Apps.Models.AR_DOWNLOAD_ITEM entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.AR_DOWNLOAD_ITEM();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.ITEM = model.ITEM;
				entity.COMPANY = model.COMPANY;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.STORAGE_TEMPLATE = model.STORAGE_TEMPLATE;
				entity.ITEM_CLASS = model.ITEM_CLASS;
				entity.PACKING_CLASS = model.PACKING_CLASS;
				entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
				entity.DAYS_TO_EXPIRE = model.DAYS_TO_EXPIRE;
				entity.LOCATING_RULE = model.LOCATING_RULE;
				entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
				entity.REPLENISHMENT_RULE = model.REPLENISHMENT_RULE;
				entity.EMPTY_LOC_RULE = model.EMPTY_LOC_RULE;
				entity.ITEM_CATEGORY1 = model.ITEM_CATEGORY1;
				entity.ITEM_CATEGORY2 = model.ITEM_CATEGORY2;
				entity.ITEM_CATEGORY3 = model.ITEM_CATEGORY3;
				entity.ITEM_CATEGORY4 = model.ITEM_CATEGORY4;
				entity.ITEM_CATEGORY5 = model.ITEM_CATEGORY5;
				entity.ITEM_CATEGORY6 = model.ITEM_CATEGORY6;
				entity.ITEM_CATEGORY7 = model.ITEM_CATEGORY7;
				entity.ITEM_CATEGORY8 = model.ITEM_CATEGORY8;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.ACTIVE = model.ACTIVE;
				entity.ATTRIBUTE_TEMPLATE_NAME = model.ATTRIBUTE_TEMPLATE_NAME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.SERIAL_NUM_TRACK = model.SERIAL_NUM_TRACK;
				entity.SERIAL_NUM_TEMPLATE_NAME = model.SERIAL_NUM_TEMPLATE_NAME;
				entity.BRAND = model.BRAND;
				entity.DIVISION = model.DIVISION;
				entity.DEPARTMENT = model.DEPARTMENT;
				entity.COST = model.COST;
				entity.ITEM_SIZE = model.ITEM_SIZE;
				entity.ITEM_COLOR = model.ITEM_COLOR;
				entity.ITEM_STYLE = model.ITEM_STYLE;
				entity.LIST_PRICE = model.LIST_PRICE;
				entity.NET_PRICE = model.NET_PRICE;
				entity.PLACE_OF_ORIGIN = model.PLACE_OF_ORIGIN;
				entity.ITEM_ATTRIBUTE1 = model.ITEM_ATTRIBUTE1;
				entity.ITEM_ATTRIBUTE2 = model.ITEM_ATTRIBUTE2;
				entity.ITEM_ATTRIBUTE3 = model.ITEM_ATTRIBUTE3;
				entity.ITEM_ATTRIBUTE4 = model.ITEM_ATTRIBUTE4;
				entity.ITEM_ATTRIBUTE5 = model.ITEM_ATTRIBUTE5;
				entity.ITEM_ATTRIBUTE6 = model.ITEM_ATTRIBUTE6;
				entity.ITEM_ATTRIBUTE7 = model.ITEM_ATTRIBUTE7;
				entity.ITEM_ATTRIBUTE8 = model.ITEM_ATTRIBUTE8;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL model,params string[] updateProperties)
		{
				Apps.Models.AR_DOWNLOAD_ITEM entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
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
											entity.ITEM = model.ITEM;
											entity.COMPANY = model.COMPANY;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.STORAGE_TEMPLATE = model.STORAGE_TEMPLATE;
											entity.ITEM_CLASS = model.ITEM_CLASS;
											entity.PACKING_CLASS = model.PACKING_CLASS;
											entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
											entity.DAYS_TO_EXPIRE = model.DAYS_TO_EXPIRE;
											entity.LOCATING_RULE = model.LOCATING_RULE;
											entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
											entity.REPLENISHMENT_RULE = model.REPLENISHMENT_RULE;
											entity.EMPTY_LOC_RULE = model.EMPTY_LOC_RULE;
											entity.ITEM_CATEGORY1 = model.ITEM_CATEGORY1;
											entity.ITEM_CATEGORY2 = model.ITEM_CATEGORY2;
											entity.ITEM_CATEGORY3 = model.ITEM_CATEGORY3;
											entity.ITEM_CATEGORY4 = model.ITEM_CATEGORY4;
											entity.ITEM_CATEGORY5 = model.ITEM_CATEGORY5;
											entity.ITEM_CATEGORY6 = model.ITEM_CATEGORY6;
											entity.ITEM_CATEGORY7 = model.ITEM_CATEGORY7;
											entity.ITEM_CATEGORY8 = model.ITEM_CATEGORY8;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.ACTIVE = model.ACTIVE;
											entity.ATTRIBUTE_TEMPLATE_NAME = model.ATTRIBUTE_TEMPLATE_NAME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.SERIAL_NUM_TRACK = model.SERIAL_NUM_TRACK;
											entity.SERIAL_NUM_TEMPLATE_NAME = model.SERIAL_NUM_TEMPLATE_NAME;
											entity.BRAND = model.BRAND;
											entity.DIVISION = model.DIVISION;
											entity.DEPARTMENT = model.DEPARTMENT;
											entity.COST = model.COST;
											entity.ITEM_SIZE = model.ITEM_SIZE;
											entity.ITEM_COLOR = model.ITEM_COLOR;
											entity.ITEM_STYLE = model.ITEM_STYLE;
											entity.LIST_PRICE = model.LIST_PRICE;
											entity.NET_PRICE = model.NET_PRICE;
											entity.PLACE_OF_ORIGIN = model.PLACE_OF_ORIGIN;
											entity.ITEM_ATTRIBUTE1 = model.ITEM_ATTRIBUTE1;
											entity.ITEM_ATTRIBUTE2 = model.ITEM_ATTRIBUTE2;
											entity.ITEM_ATTRIBUTE3 = model.ITEM_ATTRIBUTE3;
											entity.ITEM_ATTRIBUTE4 = model.ITEM_ATTRIBUTE4;
											entity.ITEM_ATTRIBUTE5 = model.ITEM_ATTRIBUTE5;
											entity.ITEM_ATTRIBUTE6 = model.ITEM_ATTRIBUTE6;
											entity.ITEM_ATTRIBUTE7 = model.ITEM_ATTRIBUTE7;
											entity.ITEM_ATTRIBUTE8 = model.ITEM_ATTRIBUTE8;
									}else{
					
						Type type = typeof(Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL);
						Type typeE = typeof(Apps.Models.AR_DOWNLOAD_ITEM);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL GetById(string id)
		{
			Apps.Models.AR_DOWNLOAD_ITEM entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//AR_DOWNLOAD_ITEM entity = m_Rep.GetById(id);
				Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL model = new Apps.Models.SCV.AR.AR_DOWNLOAD_ITEM_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.ITEM = entity.ITEM;
				model.COMPANY = entity.COMPANY;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.STORAGE_TEMPLATE = entity.STORAGE_TEMPLATE;
				model.ITEM_CLASS = entity.ITEM_CLASS;
				model.PACKING_CLASS = entity.PACKING_CLASS;
				model.ATTRIBUTE_TRACK = entity.ATTRIBUTE_TRACK;
				model.DAYS_TO_EXPIRE = entity.DAYS_TO_EXPIRE;
				model.LOCATING_RULE = entity.LOCATING_RULE;
				model.ALLOCATION_RULE = entity.ALLOCATION_RULE;
				model.REPLENISHMENT_RULE = entity.REPLENISHMENT_RULE;
				model.EMPTY_LOC_RULE = entity.EMPTY_LOC_RULE;
				model.ITEM_CATEGORY1 = entity.ITEM_CATEGORY1;
				model.ITEM_CATEGORY2 = entity.ITEM_CATEGORY2;
				model.ITEM_CATEGORY3 = entity.ITEM_CATEGORY3;
				model.ITEM_CATEGORY4 = entity.ITEM_CATEGORY4;
				model.ITEM_CATEGORY5 = entity.ITEM_CATEGORY5;
				model.ITEM_CATEGORY6 = entity.ITEM_CATEGORY6;
				model.ITEM_CATEGORY7 = entity.ITEM_CATEGORY7;
				model.ITEM_CATEGORY8 = entity.ITEM_CATEGORY8;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.ACTIVE = entity.ACTIVE;
				model.ATTRIBUTE_TEMPLATE_NAME = entity.ATTRIBUTE_TEMPLATE_NAME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.SERIAL_NUM_TRACK = entity.SERIAL_NUM_TRACK;
				model.SERIAL_NUM_TEMPLATE_NAME = entity.SERIAL_NUM_TEMPLATE_NAME;
				model.BRAND = entity.BRAND;
				model.DIVISION = entity.DIVISION;
				model.DEPARTMENT = entity.DEPARTMENT;
				model.COST = entity.COST;
				model.ITEM_SIZE = entity.ITEM_SIZE;
				model.ITEM_COLOR = entity.ITEM_COLOR;
				model.ITEM_STYLE = entity.ITEM_STYLE;
				model.LIST_PRICE = entity.LIST_PRICE;
				model.NET_PRICE = entity.NET_PRICE;
				model.PLACE_OF_ORIGIN = entity.PLACE_OF_ORIGIN;
				model.ITEM_ATTRIBUTE1 = entity.ITEM_ATTRIBUTE1;
				model.ITEM_ATTRIBUTE2 = entity.ITEM_ATTRIBUTE2;
				model.ITEM_ATTRIBUTE3 = entity.ITEM_ATTRIBUTE3;
				model.ITEM_ATTRIBUTE4 = entity.ITEM_ATTRIBUTE4;
				model.ITEM_ATTRIBUTE5 = entity.ITEM_ATTRIBUTE5;
				model.ITEM_ATTRIBUTE6 = entity.ITEM_ATTRIBUTE6;
				model.ITEM_ATTRIBUTE7 = entity.ITEM_ATTRIBUTE7;
				model.ITEM_ATTRIBUTE8 = entity.ITEM_ATTRIBUTE8;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
