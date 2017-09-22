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
namespace Apps.Service.SCV.TASK
{
	public class Virtual_TASK_HANDLING_OPTION_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.TASK.ITASK_HANDLING_OPTION_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.TASK_HANDLING_OPTION;
			}
		}
		

		public virtual List<Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL> GetList(Expression<Func<Apps.Models.TASK_HANDLING_OPTION, bool>> where = null){
		
				IQueryable<Apps.Models.TASK_HANDLING_OPTION> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.TASK_HANDLING_OPTION, bool>> where,Expression<Func<Apps.Models.TASK_HANDLING_OPTION, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.TASK_HANDLING_OPTION> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.TASK_HANDLING_OPTION, bool>> where = null)
		{

			IQueryable<Apps.Models.TASK_HANDLING_OPTION> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.TASK_TYPE.Contains(queryStr)
								|| a.ZONE.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.VERIFY_ITEM.Contains(queryStr)
								|| a.VERIFY_LOT.Contains(queryStr)
								|| a.VERIFY_LOC.Contains(queryStr)
								|| a.VERIFY_LPN.Contains(queryStr)
								|| a.VERIFY_QTY.Contains(queryStr)
								|| a.VERIFY_SHIP_CONT.Contains(queryStr)
								|| a.ALLOW_OVERPICK.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL> CreateModelList(ref IQueryable<Apps.Models.TASK_HANDLING_OPTION> queryData)
		{

			List<Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													TASK_TYPE = r.TASK_TYPE,
													ZONE = r.ZONE,
													ITEM = r.ITEM,
													COMPANY = r.COMPANY,
													VERIFY_ITEM = r.VERIFY_ITEM,
													VERIFY_LOT = r.VERIFY_LOT,
													VERIFY_LOC = r.VERIFY_LOC,
													VERIFY_LPN = r.VERIFY_LPN,
													VERIFY_QTY = r.VERIFY_QTY,
													VERIFY_SHIP_CONT = r.VERIFY_SHIP_CONT,
													ALLOW_OVERPICK = r.ALLOW_OVERPICK,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													ACTIVE = r.ACTIVE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL model)
		{
				Apps.Models.TASK_HANDLING_OPTION entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.TASK_HANDLING_OPTION();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.TASK_TYPE = model.TASK_TYPE;
				entity.ZONE = model.ZONE;
				entity.ITEM = model.ITEM;
				entity.COMPANY = model.COMPANY;
				entity.VERIFY_ITEM = model.VERIFY_ITEM;
				entity.VERIFY_LOT = model.VERIFY_LOT;
				entity.VERIFY_LOC = model.VERIFY_LOC;
				entity.VERIFY_LPN = model.VERIFY_LPN;
				entity.VERIFY_QTY = model.VERIFY_QTY;
				entity.VERIFY_SHIP_CONT = model.VERIFY_SHIP_CONT;
				entity.ALLOW_OVERPICK = model.ALLOW_OVERPICK;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.ACTIVE = model.ACTIVE;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL model,params string[] updateProperties)
		{
				Apps.Models.TASK_HANDLING_OPTION entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.TASK_TYPE = model.TASK_TYPE;
											entity.ZONE = model.ZONE;
											entity.ITEM = model.ITEM;
											entity.COMPANY = model.COMPANY;
											entity.VERIFY_ITEM = model.VERIFY_ITEM;
											entity.VERIFY_LOT = model.VERIFY_LOT;
											entity.VERIFY_LOC = model.VERIFY_LOC;
											entity.VERIFY_LPN = model.VERIFY_LPN;
											entity.VERIFY_QTY = model.VERIFY_QTY;
											entity.VERIFY_SHIP_CONT = model.VERIFY_SHIP_CONT;
											entity.ALLOW_OVERPICK = model.ALLOW_OVERPICK;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
									}else{
					
						Type type = typeof(Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL);
						Type typeE = typeof(Apps.Models.TASK_HANDLING_OPTION);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL GetById(string id)
		{
			Apps.Models.TASK_HANDLING_OPTION entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//TASK_HANDLING_OPTION entity = m_Rep.GetById(id);
				Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL model = new Apps.Models.SCV.TASK.TASK_HANDLING_OPTION_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.TASK_TYPE = entity.TASK_TYPE;
				model.ZONE = entity.ZONE;
				model.ITEM = entity.ITEM;
				model.COMPANY = entity.COMPANY;
				model.VERIFY_ITEM = entity.VERIFY_ITEM;
				model.VERIFY_LOT = entity.VERIFY_LOT;
				model.VERIFY_LOC = entity.VERIFY_LOC;
				model.VERIFY_LPN = entity.VERIFY_LPN;
				model.VERIFY_QTY = entity.VERIFY_QTY;
				model.VERIFY_SHIP_CONT = entity.VERIFY_SHIP_CONT;
				model.ALLOW_OVERPICK = entity.ALLOW_OVERPICK;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.ACTIVE = entity.ACTIVE;
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