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
namespace Apps.Service.SCV.INVENTORY
{
	public class Virtual_INVENTORY_TRANSACTION_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.INVENTORY.IINVENTORY_TRANSACTION_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.INVENTORY_TRANSACTION;
			}
		}
		

		public virtual List<Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL> GetList(Expression<Func<Apps.Models.INVENTORY_TRANSACTION, bool>> where = null){
		
				IQueryable<Apps.Models.INVENTORY_TRANSACTION> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.INVENTORY_TRANSACTION, bool>> where,Expression<Func<Apps.Models.INVENTORY_TRANSACTION, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.INVENTORY_TRANSACTION> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.INVENTORY_TRANSACTION, bool>> where = null)
		{

			IQueryable<Apps.Models.INVENTORY_TRANSACTION> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.TRANSACTION_TYPE.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.ATTRIBUTE_NUM.Contains(queryStr)
								|| a.ATTRIBUTE1.Contains(queryStr)
								|| a.ATTRIBUTE2.Contains(queryStr)
								|| a.ATTRIBUTE3.Contains(queryStr)
								|| a.ATTRIBUTE4.Contains(queryStr)
								|| a.ATTRIBUTE5.Contains(queryStr)
								|| a.ATTRIBUTE6.Contains(queryStr)
								|| a.ATTRIBUTE7.Contains(queryStr)
								|| a.ATTRIBUTE8.Contains(queryStr)
								
								|| a.QUANTITY_UM.Contains(queryStr)
								|| a.LOCATION.Contains(queryStr)
								|| a.LPN.Contains(queryStr)
								|| a.TASK_ID.Contains(queryStr)
								|| a.TASK_TYPE.Contains(queryStr)
								|| a.REFERENCE_ID.Contains(queryStr)
								
								|| a.REFERENCE_TYPE.Contains(queryStr)
								
								
								
								
								|| a.BEFORE_STS.Contains(queryStr)
								
								
								
								|| a.AFTER_STS.Contains(queryStr)
								|| a.USER_NAME.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL> CreateModelList(ref IQueryable<Apps.Models.INVENTORY_TRANSACTION> queryData)
		{

			List<Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL
											  {
													INTERNAL_INV_TRAN_ID = r.INTERNAL_INV_TRAN_ID,
													TRANSACTION_TYPE = r.TRANSACTION_TYPE,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													ITEM = r.ITEM,
													ATTRIBUTE_NUM = r.ATTRIBUTE_NUM,
													ATTRIBUTE1 = r.ATTRIBUTE1,
													ATTRIBUTE2 = r.ATTRIBUTE2,
													ATTRIBUTE3 = r.ATTRIBUTE3,
													ATTRIBUTE4 = r.ATTRIBUTE4,
													ATTRIBUTE5 = r.ATTRIBUTE5,
													ATTRIBUTE6 = r.ATTRIBUTE6,
													ATTRIBUTE7 = r.ATTRIBUTE7,
													ATTRIBUTE8 = r.ATTRIBUTE8,
													QUANTITY = r.QUANTITY,
													QUANTITY_UM = r.QUANTITY_UM,
													LOCATION = r.LOCATION,
													LPN = r.LPN,
													TASK_ID = r.TASK_ID,
													TASK_TYPE = r.TASK_TYPE,
													REFERENCE_ID = r.REFERENCE_ID,
													REFERENCE_NUM = r.REFERENCE_NUM,
													REFERENCE_TYPE = r.REFERENCE_TYPE,
													REFERENCE_LINE_NUM = r.REFERENCE_LINE_NUM,
													BEFORE_ON_HAND_QTY = r.BEFORE_ON_HAND_QTY,
													BEFORE_IN_TRANSIT_QTY = r.BEFORE_IN_TRANSIT_QTY,
													BEFORE_ALLOC_QTY = r.BEFORE_ALLOC_QTY,
													BEFORE_STS = r.BEFORE_STS,
													AFTER_ON_HAND_QTY = r.AFTER_ON_HAND_QTY,
													AFTER_IN_TRANSIT_QTY = r.AFTER_IN_TRANSIT_QTY,
													AFTER_ALLOC_QTY = r.AFTER_ALLOC_QTY,
													AFTER_STS = r.AFTER_STS,
													USER_NAME = r.USER_NAME,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL model)
		{
				Apps.Models.INVENTORY_TRANSACTION entity = m_Rep.GetById(model.INTERNAL_INV_TRAN_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.INVENTORY_TRANSACTION();
			   				entity.INTERNAL_INV_TRAN_ID = model.INTERNAL_INV_TRAN_ID;
				entity.TRANSACTION_TYPE = model.TRANSACTION_TYPE;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.ITEM = model.ITEM;
				entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
				entity.ATTRIBUTE1 = model.ATTRIBUTE1;
				entity.ATTRIBUTE2 = model.ATTRIBUTE2;
				entity.ATTRIBUTE3 = model.ATTRIBUTE3;
				entity.ATTRIBUTE4 = model.ATTRIBUTE4;
				entity.ATTRIBUTE5 = model.ATTRIBUTE5;
				entity.ATTRIBUTE6 = model.ATTRIBUTE6;
				entity.ATTRIBUTE7 = model.ATTRIBUTE7;
				entity.ATTRIBUTE8 = model.ATTRIBUTE8;
				entity.QUANTITY = model.QUANTITY;
				entity.QUANTITY_UM = model.QUANTITY_UM;
				entity.LOCATION = model.LOCATION;
				entity.LPN = model.LPN;
				entity.TASK_ID = model.TASK_ID;
				entity.TASK_TYPE = model.TASK_TYPE;
				entity.REFERENCE_ID = model.REFERENCE_ID;
				entity.REFERENCE_NUM = model.REFERENCE_NUM;
				entity.REFERENCE_TYPE = model.REFERENCE_TYPE;
				entity.REFERENCE_LINE_NUM = model.REFERENCE_LINE_NUM;
				entity.BEFORE_ON_HAND_QTY = model.BEFORE_ON_HAND_QTY;
				entity.BEFORE_IN_TRANSIT_QTY = model.BEFORE_IN_TRANSIT_QTY;
				entity.BEFORE_ALLOC_QTY = model.BEFORE_ALLOC_QTY;
				entity.BEFORE_STS = model.BEFORE_STS;
				entity.AFTER_ON_HAND_QTY = model.AFTER_ON_HAND_QTY;
				entity.AFTER_IN_TRANSIT_QTY = model.AFTER_IN_TRANSIT_QTY;
				entity.AFTER_ALLOC_QTY = model.AFTER_ALLOC_QTY;
				entity.AFTER_STS = model.AFTER_STS;
				entity.USER_NAME = model.USER_NAME;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL model,params string[] updateProperties)
		{
				Apps.Models.INVENTORY_TRANSACTION entity = m_Rep.GetById(model.INTERNAL_INV_TRAN_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_INV_TRAN_ID = model.INTERNAL_INV_TRAN_ID;
											entity.TRANSACTION_TYPE = model.TRANSACTION_TYPE;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.ITEM = model.ITEM;
											entity.ATTRIBUTE_NUM = model.ATTRIBUTE_NUM;
											entity.ATTRIBUTE1 = model.ATTRIBUTE1;
											entity.ATTRIBUTE2 = model.ATTRIBUTE2;
											entity.ATTRIBUTE3 = model.ATTRIBUTE3;
											entity.ATTRIBUTE4 = model.ATTRIBUTE4;
											entity.ATTRIBUTE5 = model.ATTRIBUTE5;
											entity.ATTRIBUTE6 = model.ATTRIBUTE6;
											entity.ATTRIBUTE7 = model.ATTRIBUTE7;
											entity.ATTRIBUTE8 = model.ATTRIBUTE8;
											entity.QUANTITY = model.QUANTITY;
											entity.QUANTITY_UM = model.QUANTITY_UM;
											entity.LOCATION = model.LOCATION;
											entity.LPN = model.LPN;
											entity.TASK_ID = model.TASK_ID;
											entity.TASK_TYPE = model.TASK_TYPE;
											entity.REFERENCE_ID = model.REFERENCE_ID;
											entity.REFERENCE_NUM = model.REFERENCE_NUM;
											entity.REFERENCE_TYPE = model.REFERENCE_TYPE;
											entity.REFERENCE_LINE_NUM = model.REFERENCE_LINE_NUM;
											entity.BEFORE_ON_HAND_QTY = model.BEFORE_ON_HAND_QTY;
											entity.BEFORE_IN_TRANSIT_QTY = model.BEFORE_IN_TRANSIT_QTY;
											entity.BEFORE_ALLOC_QTY = model.BEFORE_ALLOC_QTY;
											entity.BEFORE_STS = model.BEFORE_STS;
											entity.AFTER_ON_HAND_QTY = model.AFTER_ON_HAND_QTY;
											entity.AFTER_IN_TRANSIT_QTY = model.AFTER_IN_TRANSIT_QTY;
											entity.AFTER_ALLOC_QTY = model.AFTER_ALLOC_QTY;
											entity.AFTER_STS = model.AFTER_STS;
											entity.USER_NAME = model.USER_NAME;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL);
						Type typeE = typeof(Apps.Models.INVENTORY_TRANSACTION);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL GetById(string id)
		{
			Apps.Models.INVENTORY_TRANSACTION entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//INVENTORY_TRANSACTION entity = m_Rep.GetById(id);
				Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL model = new Apps.Models.SCV.INVENTORY.INVENTORY_TRANSACTION_MODEL();
							  				model.INTERNAL_INV_TRAN_ID = entity.INTERNAL_INV_TRAN_ID;
				model.TRANSACTION_TYPE = entity.TRANSACTION_TYPE;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.ITEM = entity.ITEM;
				model.ATTRIBUTE_NUM = entity.ATTRIBUTE_NUM;
				model.ATTRIBUTE1 = entity.ATTRIBUTE1;
				model.ATTRIBUTE2 = entity.ATTRIBUTE2;
				model.ATTRIBUTE3 = entity.ATTRIBUTE3;
				model.ATTRIBUTE4 = entity.ATTRIBUTE4;
				model.ATTRIBUTE5 = entity.ATTRIBUTE5;
				model.ATTRIBUTE6 = entity.ATTRIBUTE6;
				model.ATTRIBUTE7 = entity.ATTRIBUTE7;
				model.ATTRIBUTE8 = entity.ATTRIBUTE8;
				model.QUANTITY = entity.QUANTITY;
				model.QUANTITY_UM = entity.QUANTITY_UM;
				model.LOCATION = entity.LOCATION;
				model.LPN = entity.LPN;
				model.TASK_ID = entity.TASK_ID;
				model.TASK_TYPE = entity.TASK_TYPE;
				model.REFERENCE_ID = entity.REFERENCE_ID;
				model.REFERENCE_NUM = entity.REFERENCE_NUM;
				model.REFERENCE_TYPE = entity.REFERENCE_TYPE;
				model.REFERENCE_LINE_NUM = entity.REFERENCE_LINE_NUM;
				model.BEFORE_ON_HAND_QTY = entity.BEFORE_ON_HAND_QTY;
				model.BEFORE_IN_TRANSIT_QTY = entity.BEFORE_IN_TRANSIT_QTY;
				model.BEFORE_ALLOC_QTY = entity.BEFORE_ALLOC_QTY;
				model.BEFORE_STS = entity.BEFORE_STS;
				model.AFTER_ON_HAND_QTY = entity.AFTER_ON_HAND_QTY;
				model.AFTER_IN_TRANSIT_QTY = entity.AFTER_IN_TRANSIT_QTY;
				model.AFTER_ALLOC_QTY = entity.AFTER_ALLOC_QTY;
				model.AFTER_STS = entity.AFTER_STS;
				model.USER_NAME = entity.USER_NAME;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}