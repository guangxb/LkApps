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
	public class Virtual_UPLOAD_INVENTORY_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.UPLOAD.IUPLOAD_INVENTORY_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.UPLOAD_INVENTORY;
			}
		}
		

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL> GetList(Expression<Func<Apps.Models.UPLOAD_INVENTORY, bool>> where = null){
		
				IQueryable<Apps.Models.UPLOAD_INVENTORY> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.UPLOAD_INVENTORY, bool>> where,Expression<Func<Apps.Models.UPLOAD_INVENTORY, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.UPLOAD_INVENTORY> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.UPLOAD_INVENTORY, bool>> where = null)
		{

			IQueryable<Apps.Models.UPLOAD_INVENTORY> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								
								|| a.INVENTORY_STS.Contains(queryStr)
								|| a.LOT.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
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
		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL> CreateModelList(ref IQueryable<Apps.Models.UPLOAD_INVENTORY> queryData)
		{

			List<Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													WAREHOUSE = r.WAREHOUSE,
													ITEM = r.ITEM,
													COMPANY = r.COMPANY,
													QUANTITY = r.QUANTITY,
													INVENTORY_STS = r.INVENTORY_STS,
													LOT = r.LOT,
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
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL model)
		{
				Apps.Models.UPLOAD_INVENTORY entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.UPLOAD_INVENTORY();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.ITEM = model.ITEM;
				entity.COMPANY = model.COMPANY;
				entity.QUANTITY = model.QUANTITY;
				entity.INVENTORY_STS = model.INVENTORY_STS;
				entity.LOT = model.LOT;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL model,params string[] updateProperties)
		{
				Apps.Models.UPLOAD_INVENTORY entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
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
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.ITEM = model.ITEM;
											entity.COMPANY = model.COMPANY;
											entity.QUANTITY = model.QUANTITY;
											entity.INVENTORY_STS = model.INVENTORY_STS;
											entity.LOT = model.LOT;
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
									}else{
					
						Type type = typeof(Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL);
						Type typeE = typeof(Apps.Models.UPLOAD_INVENTORY);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL GetById(string id)
		{
			Apps.Models.UPLOAD_INVENTORY entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//UPLOAD_INVENTORY entity = m_Rep.GetById(id);
				Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL model = new Apps.Models.SCV.UPLOAD.UPLOAD_INVENTORY_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.ITEM = entity.ITEM;
				model.COMPANY = entity.COMPANY;
				model.QUANTITY = entity.QUANTITY;
				model.INVENTORY_STS = entity.INVENTORY_STS;
				model.LOT = entity.LOT;
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
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}