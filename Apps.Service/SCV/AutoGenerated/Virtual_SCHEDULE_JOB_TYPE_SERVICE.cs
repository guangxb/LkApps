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
namespace Apps.Service.SCV.SCHEDULE
{
	public class Virtual_SCHEDULE_JOB_TYPE_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.SCHEDULE.ISCHEDULE_JOB_TYPE_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.SCHEDULE_JOB_TYPE;
			}
		}
		

		public virtual List<Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL> GetList(Expression<Func<Apps.Models.SCHEDULE_JOB_TYPE, bool>> where = null){
		
				IQueryable<Apps.Models.SCHEDULE_JOB_TYPE> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.SCHEDULE_JOB_TYPE, bool>> where,Expression<Func<Apps.Models.SCHEDULE_JOB_TYPE, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.SCHEDULE_JOB_TYPE> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SCHEDULE_JOB_TYPE, bool>> where = null)
		{

			IQueryable<Apps.Models.SCHEDULE_JOB_TYPE> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.JOB_TYPE.Contains(queryStr)
								|| a.JOB_CLASS.Contains(queryStr)
								|| a.DESCRIPTION.Contains(queryStr)
								|| a.ASSEMBLY.Contains(queryStr)
								|| a.NAMESPACE.Contains(queryStr)
								|| a.CLASS.Contains(queryStr)
								|| a.METHOD.Contains(queryStr)
								|| a.PARA1_NAME.Contains(queryStr)
								|| a.PARA2_NAME.Contains(queryStr)
								|| a.PARA3_NAME.Contains(queryStr)
								|| a.PARA4_NAME.Contains(queryStr)
								|| a.PARA5_NAME.Contains(queryStr)
								|| a.PARA6_NAME.Contains(queryStr)
								|| a.PARA7_NAME.Contains(queryStr)
								|| a.PARA8_NAME.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.SYSTEM_CREATED.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL> CreateModelList(ref IQueryable<Apps.Models.SCHEDULE_JOB_TYPE> queryData)
		{

			List<Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL
											  {
													JOB_TYPE = r.JOB_TYPE,
													JOB_CLASS = r.JOB_CLASS,
													DESCRIPTION = r.DESCRIPTION,
													ASSEMBLY = r.ASSEMBLY,
													NAMESPACE = r.NAMESPACE,
													CLASS = r.CLASS,
													METHOD = r.METHOD,
													PARA1_NAME = r.PARA1_NAME,
													PARA2_NAME = r.PARA2_NAME,
													PARA3_NAME = r.PARA3_NAME,
													PARA4_NAME = r.PARA4_NAME,
													PARA5_NAME = r.PARA5_NAME,
													PARA6_NAME = r.PARA6_NAME,
													PARA7_NAME = r.PARA7_NAME,
													PARA8_NAME = r.PARA8_NAME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													SYSTEM_CREATED = r.SYSTEM_CREATED,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL model)
		{
				Apps.Models.SCHEDULE_JOB_TYPE entity = m_Rep.GetById(model.JOB_TYPE);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.SCHEDULE_JOB_TYPE();
			   				entity.JOB_TYPE = model.JOB_TYPE;
				entity.JOB_CLASS = model.JOB_CLASS;
				entity.DESCRIPTION = model.DESCRIPTION;
				entity.ASSEMBLY = model.ASSEMBLY;
				entity.NAMESPACE = model.NAMESPACE;
				entity.CLASS = model.CLASS;
				entity.METHOD = model.METHOD;
				entity.PARA1_NAME = model.PARA1_NAME;
				entity.PARA2_NAME = model.PARA2_NAME;
				entity.PARA3_NAME = model.PARA3_NAME;
				entity.PARA4_NAME = model.PARA4_NAME;
				entity.PARA5_NAME = model.PARA5_NAME;
				entity.PARA6_NAME = model.PARA6_NAME;
				entity.PARA7_NAME = model.PARA7_NAME;
				entity.PARA8_NAME = model.PARA8_NAME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.SYSTEM_CREATED = model.SYSTEM_CREATED;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL model,params string[] updateProperties)
		{
				Apps.Models.SCHEDULE_JOB_TYPE entity = m_Rep.GetById(model.JOB_TYPE);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.JOB_TYPE = model.JOB_TYPE;
											entity.JOB_CLASS = model.JOB_CLASS;
											entity.DESCRIPTION = model.DESCRIPTION;
											entity.ASSEMBLY = model.ASSEMBLY;
											entity.NAMESPACE = model.NAMESPACE;
											entity.CLASS = model.CLASS;
											entity.METHOD = model.METHOD;
											entity.PARA1_NAME = model.PARA1_NAME;
											entity.PARA2_NAME = model.PARA2_NAME;
											entity.PARA3_NAME = model.PARA3_NAME;
											entity.PARA4_NAME = model.PARA4_NAME;
											entity.PARA5_NAME = model.PARA5_NAME;
											entity.PARA6_NAME = model.PARA6_NAME;
											entity.PARA7_NAME = model.PARA7_NAME;
											entity.PARA8_NAME = model.PARA8_NAME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.SYSTEM_CREATED = model.SYSTEM_CREATED;
									}else{
					
						Type type = typeof(Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL);
						Type typeE = typeof(Apps.Models.SCHEDULE_JOB_TYPE);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL GetById(string id)
		{
			Apps.Models.SCHEDULE_JOB_TYPE entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SCHEDULE_JOB_TYPE entity = m_Rep.GetById(id);
				Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL model = new Apps.Models.SCV.SCHEDULE.SCHEDULE_JOB_TYPE_MODEL();
							  				model.JOB_TYPE = entity.JOB_TYPE;
				model.JOB_CLASS = entity.JOB_CLASS;
				model.DESCRIPTION = entity.DESCRIPTION;
				model.ASSEMBLY = entity.ASSEMBLY;
				model.NAMESPACE = entity.NAMESPACE;
				model.CLASS = entity.CLASS;
				model.METHOD = entity.METHOD;
				model.PARA1_NAME = entity.PARA1_NAME;
				model.PARA2_NAME = entity.PARA2_NAME;
				model.PARA3_NAME = entity.PARA3_NAME;
				model.PARA4_NAME = entity.PARA4_NAME;
				model.PARA5_NAME = entity.PARA5_NAME;
				model.PARA6_NAME = entity.PARA6_NAME;
				model.PARA7_NAME = entity.PARA7_NAME;
				model.PARA8_NAME = entity.PARA8_NAME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.SYSTEM_CREATED = entity.SYSTEM_CREATED;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
