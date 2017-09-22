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
namespace Apps.Service.SCV.EX
{
	public class Virtual_EX_MENU_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.EX.IEX_MENU_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.EX_MENU;
			}
		}
		

		public virtual List<Apps.Models.SCV.EX.EX_MENU_MODEL> GetList(Expression<Func<Apps.Models.EX_MENU, bool>> where = null){
		
				IQueryable<Apps.Models.EX_MENU> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.EX.EX_MENU_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.EX_MENU, bool>> where,Expression<Func<Apps.Models.EX_MENU, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.EX_MENU> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.EX.EX_MENU_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.EX_MENU, bool>> where = null)
		{

			IQueryable<Apps.Models.EX_MENU> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.MENU_TEXT.Contains(queryStr)
								
								
								|| a.ASSEMBLY.Contains(queryStr)
								|| a.NAMESPACE.Contains(queryStr)
								|| a.CLASS.Contains(queryStr)
								|| a.INIT_METHOD.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.EX.EX_MENU_MODEL> CreateModelList(ref IQueryable<Apps.Models.EX_MENU> queryData)
		{

			List<Apps.Models.SCV.EX.EX_MENU_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.EX.EX_MENU_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													MENU_TEXT = r.MENU_TEXT,
													PARENT = r.PARENT,
													SEQUENCE = r.SEQUENCE,
													ASSEMBLY = r.ASSEMBLY,
													NAMESPACE = r.NAMESPACE,
													CLASS = r.CLASS,
													INIT_METHOD = r.INIT_METHOD,
													ACTIVE = r.ACTIVE,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.EX.EX_MENU_MODEL model)
		{
				Apps.Models.EX_MENU entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.EX_MENU();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.MENU_TEXT = model.MENU_TEXT;
				entity.PARENT = model.PARENT;
				entity.SEQUENCE = model.SEQUENCE;
				entity.ASSEMBLY = model.ASSEMBLY;
				entity.NAMESPACE = model.NAMESPACE;
				entity.CLASS = model.CLASS;
				entity.INIT_METHOD = model.INIT_METHOD;
				entity.ACTIVE = model.ACTIVE;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.EX.EX_MENU_MODEL model,params string[] updateProperties)
		{
				Apps.Models.EX_MENU entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.MENU_TEXT = model.MENU_TEXT;
											entity.PARENT = model.PARENT;
											entity.SEQUENCE = model.SEQUENCE;
											entity.ASSEMBLY = model.ASSEMBLY;
											entity.NAMESPACE = model.NAMESPACE;
											entity.CLASS = model.CLASS;
											entity.INIT_METHOD = model.INIT_METHOD;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
									}else{
					
						Type type = typeof(Apps.Models.SCV.EX.EX_MENU_MODEL);
						Type typeE = typeof(Apps.Models.EX_MENU);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.EX.EX_MENU_MODEL GetById(string id)
		{
			Apps.Models.EX_MENU entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//EX_MENU entity = m_Rep.GetById(id);
				Apps.Models.SCV.EX.EX_MENU_MODEL model = new Apps.Models.SCV.EX.EX_MENU_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.MENU_TEXT = entity.MENU_TEXT;
				model.PARENT = entity.PARENT;
				model.SEQUENCE = entity.SEQUENCE;
				model.ASSEMBLY = entity.ASSEMBLY;
				model.NAMESPACE = entity.NAMESPACE;
				model.CLASS = entity.CLASS;
				model.INIT_METHOD = entity.INIT_METHOD;
				model.ACTIVE = entity.ACTIVE;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}