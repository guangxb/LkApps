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
namespace Apps.Service.SCV.RULE
{
	public class Virtual_RULE_ASSIGNMENT_HEADER_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.RULE.IRULE_ASSIGNMENT_HEADER_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.RULE_ASSIGNMENT_HEADER;
			}
		}
		

		public virtual List<Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL> GetList(Expression<Func<Apps.Models.RULE_ASSIGNMENT_HEADER, bool>> where = null){
		
				IQueryable<Apps.Models.RULE_ASSIGNMENT_HEADER> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.RULE_ASSIGNMENT_HEADER, bool>> where,Expression<Func<Apps.Models.RULE_ASSIGNMENT_HEADER, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.RULE_ASSIGNMENT_HEADER> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.RULE_ASSIGNMENT_HEADER, bool>> where = null)
		{

			IQueryable<Apps.Models.RULE_ASSIGNMENT_HEADER> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.RULE_ASSIGN_NAME.Contains(queryStr)
								|| a.RULE_ASSIGN_TYPE.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.ALWASY_OVERRIDE.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
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
		public virtual List<Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL> CreateModelList(ref IQueryable<Apps.Models.RULE_ASSIGNMENT_HEADER> queryData)
		{

			List<Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													RULE_ASSIGN_NAME = r.RULE_ASSIGN_NAME,
													RULE_ASSIGN_TYPE = r.RULE_ASSIGN_TYPE,
													WAREHOUSE = r.WAREHOUSE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													ALWASY_OVERRIDE = r.ALWASY_OVERRIDE,
													ACTIVE = r.ACTIVE,
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

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL model)
		{
				Apps.Models.RULE_ASSIGNMENT_HEADER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.RULE_ASSIGNMENT_HEADER();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.RULE_ASSIGN_NAME = model.RULE_ASSIGN_NAME;
				entity.RULE_ASSIGN_TYPE = model.RULE_ASSIGN_TYPE;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.ALWASY_OVERRIDE = model.ALWASY_OVERRIDE;
				entity.ACTIVE = model.ACTIVE;
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL model,params string[] updateProperties)
		{
				Apps.Models.RULE_ASSIGNMENT_HEADER entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.RULE_ASSIGN_NAME = model.RULE_ASSIGN_NAME;
											entity.RULE_ASSIGN_TYPE = model.RULE_ASSIGN_TYPE;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.ALWASY_OVERRIDE = model.ALWASY_OVERRIDE;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
									}else{
					
						Type type = typeof(Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL);
						Type typeE = typeof(Apps.Models.RULE_ASSIGNMENT_HEADER);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL GetById(string id)
		{
			Apps.Models.RULE_ASSIGNMENT_HEADER entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//RULE_ASSIGNMENT_HEADER entity = m_Rep.GetById(id);
				Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL model = new Apps.Models.SCV.RULE.RULE_ASSIGNMENT_HEADER_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.RULE_ASSIGN_NAME = entity.RULE_ASSIGN_NAME;
				model.RULE_ASSIGN_TYPE = entity.RULE_ASSIGN_TYPE;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.ALWASY_OVERRIDE = entity.ALWASY_OVERRIDE;
				model.ACTIVE = entity.ACTIVE;
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
