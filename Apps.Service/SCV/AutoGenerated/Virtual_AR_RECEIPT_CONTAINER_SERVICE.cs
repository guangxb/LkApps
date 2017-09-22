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
	public class Virtual_AR_RECEIPT_CONTAINER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.AR.IAR_RECEIPT_CONTAINER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.AR_RECEIPT_CONTAINER;
			}
		}
		

		public virtual List<Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL> GetList(Expression<Func<Apps.Models.AR_RECEIPT_CONTAINER, bool>> where = null){
		
				IQueryable<Apps.Models.AR_RECEIPT_CONTAINER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.AR_RECEIPT_CONTAINER, bool>> where,Expression<Func<Apps.Models.AR_RECEIPT_CONTAINER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.AR_RECEIPT_CONTAINER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.AR_RECEIPT_CONTAINER, bool>> where = null)
		{

			IQueryable<Apps.Models.AR_RECEIPT_CONTAINER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								
								
								,a=>a.RECEIPT_ID.Contains(queryStr)
								|| a.RECEIPT_TYPE.Contains(queryStr)
								|| a.CONTAINER_ID.Contains(queryStr)
								|| a.CONTAINER_TYPE.Contains(queryStr)
								
								|| a.COMPANY.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								|| a.ITEM_CLASS.Contains(queryStr)
								
								|| a.QUANTITY_UM.Contains(queryStr)
								
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.LOCATING_RULE.Contains(queryStr)
								|| a.FROM_LOCATION.Contains(queryStr)
								|| a.TO_LOCATION.Contains(queryStr)
								
								
								|| a.ATTRIBUTE1.Contains(queryStr)
								|| a.ATTRIBUTE2.Contains(queryStr)
								|| a.ATTRIBUTE3.Contains(queryStr)
								|| a.ATTRIBUTE4.Contains(queryStr)
								|| a.ATTRIBUTE5.Contains(queryStr)
								|| a.ATTRIBUTE6.Contains(queryStr)
								|| a.ATTRIBUTE7.Contains(queryStr)
								|| a.ATTRIBUTE8.Contains(queryStr)
								|| a.INVENTORY_STS.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								|| a.TASK_CREATED.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.UPLOAD_INTERFACE_FLAG.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL> CreateModelList(ref IQueryable<Apps.Models.AR_RECEIPT_CONTAINER> queryData)
		{

			List<Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL
											  {
													INTERNAL_CONTAINER_NUM = r.INTERNAL_CONTAINER_NUM,
													INTERNAL_RECEIPT_NUM = r.INTERNAL_RECEIPT_NUM,
													INTERNAL_RECEIPT_LINE_NUM = r.INTERNAL_RECEIPT_LINE_NUM,
													RECEIPT_ID = r.RECEIPT_ID,
													RECEIPT_TYPE = r.RECEIPT_TYPE,
													CONTAINER_ID = r.CONTAINER_ID,
													CONTAINER_TYPE = r.CONTAINER_TYPE,
													PARENT = r.PARENT,
													COMPANY = r.COMPANY,
													ITEM = r.ITEM,
													ITEM_DESC = r.ITEM_DESC,
													ITEM_CLASS = r.ITEM_CLASS,
													QUANTITY = r.QUANTITY,
													QUANTITY_UM = r.QUANTITY_UM,
													STATUS = r.STATUS,
													WAREHOUSE = r.WAREHOUSE,
													LOCATING_RULE = r.LOCATING_RULE,
													FROM_LOCATION = r.FROM_LOCATION,
													TO_LOCATION = r.TO_LOCATION,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													ATTRIBUTE_NUM = r.ATTRIBUTE_NUM,
													ATTRIBUTE1 = r.ATTRIBUTE1,
													ATTRIBUTE2 = r.ATTRIBUTE2,
													ATTRIBUTE3 = r.ATTRIBUTE3,
													ATTRIBUTE4 = r.ATTRIBUTE4,
													ATTRIBUTE5 = r.ATTRIBUTE5,
													ATTRIBUTE6 = r.ATTRIBUTE6,
													ATTRIBUTE7 = r.ATTRIBUTE7,
													ATTRIBUTE8 = r.ATTRIBUTE8,
													INVENTORY_STS = r.INVENTORY_STS,
													USER_STAMP = r.USER_STAMP,
													TASK_CREATED = r.TASK_CREATED,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													UPLOAD_INTERFACE_FLAG = r.UPLOAD_INTERFACE_FLAG,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL model)
		{
				Apps.Models.AR_RECEIPT_CONTAINER entity = m_Rep.GetById(model.INTERNAL_CONTAINER_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.AR_RECEIPT_CONTAINER();
			   				entity.INTERNAL_CONTAINER_NUM = model.INTERNAL_CONTAINER_NUM;
				entity.INTERNAL_RECEIPT_NUM = model.INTERNAL_RECEIPT_NUM;
				entity.INTERNAL_RECEIPT_LINE_NUM = model.INTERNAL_RECEIPT_LINE_NUM;
				entity.RECEIPT_ID = model.RECEIPT_ID;
				entity.RECEIPT_TYPE = model.RECEIPT_TYPE;
				entity.CONTAINER_ID = model.CONTAINER_ID;
				entity.CONTAINER_TYPE = model.CONTAINER_TYPE;
				entity.PARENT = model.PARENT;
				entity.COMPANY = model.COMPANY;
				entity.ITEM = model.ITEM;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.ITEM_CLASS = model.ITEM_CLASS;
				entity.QUANTITY = model.QUANTITY;
				entity.QUANTITY_UM = model.QUANTITY_UM;
				entity.STATUS = model.STATUS;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.LOCATING_RULE = model.LOCATING_RULE;
				entity.FROM_LOCATION = model.FROM_LOCATION;
				entity.TO_LOCATION = model.TO_LOCATION;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
				entity.ATTRIBUTE1 = model.ATTRIBUTE1;
				entity.ATTRIBUTE2 = model.ATTRIBUTE2;
				entity.ATTRIBUTE3 = model.ATTRIBUTE3;
				entity.ATTRIBUTE4 = model.ATTRIBUTE4;
				entity.ATTRIBUTE5 = model.ATTRIBUTE5;
				entity.ATTRIBUTE6 = model.ATTRIBUTE6;
				entity.ATTRIBUTE7 = model.ATTRIBUTE7;
				entity.ATTRIBUTE8 = model.ATTRIBUTE8;
				entity.INVENTORY_STS = model.INVENTORY_STS;
				entity.USER_STAMP = model.USER_STAMP;
				entity.TASK_CREATED = model.TASK_CREATED;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.UPLOAD_INTERFACE_FLAG = model.UPLOAD_INTERFACE_FLAG;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.AR_RECEIPT_CONTAINER entity = m_Rep.GetById(model.INTERNAL_CONTAINER_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_CONTAINER_NUM = model.INTERNAL_CONTAINER_NUM;
											entity.INTERNAL_RECEIPT_NUM = model.INTERNAL_RECEIPT_NUM;
											entity.INTERNAL_RECEIPT_LINE_NUM = model.INTERNAL_RECEIPT_LINE_NUM;
											entity.RECEIPT_ID = model.RECEIPT_ID;
											entity.RECEIPT_TYPE = model.RECEIPT_TYPE;
											entity.CONTAINER_ID = model.CONTAINER_ID;
											entity.CONTAINER_TYPE = model.CONTAINER_TYPE;
											entity.PARENT = model.PARENT;
											entity.COMPANY = model.COMPANY;
											entity.ITEM = model.ITEM;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.ITEM_CLASS = model.ITEM_CLASS;
											entity.QUANTITY = model.QUANTITY;
											entity.QUANTITY_UM = model.QUANTITY_UM;
											entity.STATUS = model.STATUS;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.LOCATING_RULE = model.LOCATING_RULE;
											entity.FROM_LOCATION = model.FROM_LOCATION;
											entity.TO_LOCATION = model.TO_LOCATION;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
											entity.ATTRIBUTE1 = model.ATTRIBUTE1;
											entity.ATTRIBUTE2 = model.ATTRIBUTE2;
											entity.ATTRIBUTE3 = model.ATTRIBUTE3;
											entity.ATTRIBUTE4 = model.ATTRIBUTE4;
											entity.ATTRIBUTE5 = model.ATTRIBUTE5;
											entity.ATTRIBUTE6 = model.ATTRIBUTE6;
											entity.ATTRIBUTE7 = model.ATTRIBUTE7;
											entity.ATTRIBUTE8 = model.ATTRIBUTE8;
											entity.INVENTORY_STS = model.INVENTORY_STS;
											entity.USER_STAMP = model.USER_STAMP;
											entity.TASK_CREATED = model.TASK_CREATED;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.UPLOAD_INTERFACE_FLAG = model.UPLOAD_INTERFACE_FLAG;
									}else{
					
						Type type = typeof(Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL);
						Type typeE = typeof(Apps.Models.AR_RECEIPT_CONTAINER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL GetById(string id)
		{
			Apps.Models.AR_RECEIPT_CONTAINER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//AR_RECEIPT_CONTAINER entity = m_Rep.GetById(id);
				Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL model = new Apps.Models.SCV.AR.AR_RECEIPT_CONTAINER_MODEL();
							  				model.INTERNAL_CONTAINER_NUM = entity.INTERNAL_CONTAINER_NUM;
				model.INTERNAL_RECEIPT_NUM = entity.INTERNAL_RECEIPT_NUM;
				model.INTERNAL_RECEIPT_LINE_NUM = entity.INTERNAL_RECEIPT_LINE_NUM;
				model.RECEIPT_ID = entity.RECEIPT_ID;
				model.RECEIPT_TYPE = entity.RECEIPT_TYPE;
				model.CONTAINER_ID = entity.CONTAINER_ID;
				model.CONTAINER_TYPE = entity.CONTAINER_TYPE;
				model.PARENT = entity.PARENT;
				model.COMPANY = entity.COMPANY;
				model.ITEM = entity.ITEM;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.ITEM_CLASS = entity.ITEM_CLASS;
				model.QUANTITY = entity.QUANTITY;
				model.QUANTITY_UM = entity.QUANTITY_UM;
				model.STATUS = entity.STATUS;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.LOCATING_RULE = entity.LOCATING_RULE;
				model.FROM_LOCATION = entity.FROM_LOCATION;
				model.TO_LOCATION = entity.TO_LOCATION;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.ATTRIBUTE_NUM = entity.ATTRIBUTE_NUM;
				model.ATTRIBUTE1 = entity.ATTRIBUTE1;
				model.ATTRIBUTE2 = entity.ATTRIBUTE2;
				model.ATTRIBUTE3 = entity.ATTRIBUTE3;
				model.ATTRIBUTE4 = entity.ATTRIBUTE4;
				model.ATTRIBUTE5 = entity.ATTRIBUTE5;
				model.ATTRIBUTE6 = entity.ATTRIBUTE6;
				model.ATTRIBUTE7 = entity.ATTRIBUTE7;
				model.ATTRIBUTE8 = entity.ATTRIBUTE8;
				model.INVENTORY_STS = entity.INVENTORY_STS;
				model.USER_STAMP = entity.USER_STAMP;
				model.TASK_CREATED = entity.TASK_CREATED;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.UPLOAD_INTERFACE_FLAG = entity.UPLOAD_INTERFACE_FLAG;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
