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
namespace Apps.Service.SCV.g
{
	public class Virtual_g_login_history_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.g.Ig_login_history_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.g_login_history;
			}
		}
		

		public virtual List<Apps.Models.SCV.g.g_login_history_MODEL> GetList(Expression<Func<Apps.Models.g_login_history, bool>> where = null){
		
				IQueryable<Apps.Models.g_login_history> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.g.g_login_history_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.g_login_history, bool>> where,Expression<Func<Apps.Models.g_login_history, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.g_login_history> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.g.g_login_history_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.g_login_history, bool>> where = null)
		{

			IQueryable<Apps.Models.g_login_history> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.g_username.Contains(queryStr)
								|| a.g_ip.Contains(queryStr)
								
								|| a.g_type.Contains(queryStr)
								|| a.g_category1.Contains(queryStr)
								|| a.g_category2.Contains(queryStr)
								|| a.g_category3.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.g.g_login_history_MODEL> CreateModelList(ref IQueryable<Apps.Models.g_login_history> queryData)
		{

			List<Apps.Models.SCV.g.g_login_history_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.g.g_login_history_MODEL
											  {
													ID = r.ID,
													g_username = r.g_username,
													g_ip = r.g_ip,
													g_date = r.g_date,
													g_type = r.g_type,
													g_category1 = r.g_category1,
													g_category2 = r.g_category2,
													g_category3 = r.g_category3,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.g.g_login_history_MODEL model)
		{
				Apps.Models.g_login_history entity = m_Rep.GetById(model.ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.g_login_history();
			   				entity.ID = model.ID;
				entity.g_username = model.g_username;
				entity.g_ip = model.g_ip;
				entity.g_date = model.g_date;
				entity.g_type = model.g_type;
				entity.g_category1 = model.g_category1;
				entity.g_category2 = model.g_category2;
				entity.g_category3 = model.g_category3;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.g.g_login_history_MODEL model,params string[] updateProperties)
		{
				Apps.Models.g_login_history entity = m_Rep.GetById(model.ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.ID = model.ID;
											entity.g_username = model.g_username;
											entity.g_ip = model.g_ip;
											entity.g_date = model.g_date;
											entity.g_type = model.g_type;
											entity.g_category1 = model.g_category1;
											entity.g_category2 = model.g_category2;
											entity.g_category3 = model.g_category3;
									}else{
					
						Type type = typeof(Apps.Models.SCV.g.g_login_history_MODEL);
						Type typeE = typeof(Apps.Models.g_login_history);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.g.g_login_history_MODEL GetById(string id)
		{
			Apps.Models.g_login_history entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//g_login_history entity = m_Rep.GetById(id);
				Apps.Models.SCV.g.g_login_history_MODEL model = new Apps.Models.SCV.g.g_login_history_MODEL();
							  				model.ID = entity.ID;
				model.g_username = entity.g_username;
				model.g_ip = entity.g_ip;
				model.g_date = entity.g_date;
				model.g_type = entity.g_type;
				model.g_category1 = entity.g_category1;
				model.g_category2 = entity.g_category2;
				model.g_category3 = entity.g_category3;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
