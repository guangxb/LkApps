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
namespace Apps.Service.Sys
{
	public class Virtual_SysUserConfigService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysUserConfigRepository m_Rep{
			 get
			{
				return DBSession.SysUserConfig;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysUserConfigModel> GetList(Expression<Func<Apps.Models.SysUserConfig, bool>> where = null){
		
				IQueryable<SysUserConfig> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysUserConfigModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysUserConfig, bool>> where,Expression<Func<Apps.Models.SysUserConfig, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysUserConfig> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysUserConfigModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysUserConfig, bool>> where = null)
		{

			IQueryable<SysUserConfig> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.Value.Contains(queryStr)
								|| a.Type.Contains(queryStr)
								
								|| a.UserId.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Sys.SysUserConfigModel> CreateModelList(ref IQueryable<SysUserConfig> queryData)
		{

			List<Apps.Models.Sys.SysUserConfigModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysUserConfigModel
											  {
													Id = r.Id,
													Name = r.Name,
													Value = r.Value,
													Type = r.Type,
													State = r.State,
													UserId = r.UserId,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysUserConfigModel model)
		{
				SysUserConfig entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysUserConfig();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.Value = model.Value;
				entity.Type = model.Type;
				entity.State = model.State;
				entity.UserId = model.UserId;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysUserConfigModel model,params string[] updateProperties)
		{
				SysUserConfig entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.Name = model.Name;
											entity.Value = model.Value;
											entity.Type = model.Type;
											entity.State = model.State;
											entity.UserId = model.UserId;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysUserConfigModel);
						Type typeE = typeof(Apps.Models.SysUserConfig);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysUserConfigModel GetById(string id)
		{
			SysUserConfig entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysUserConfig entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysUserConfigModel model = new Apps.Models.Sys.SysUserConfigModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.Value = entity.Value;
				model.Type = entity.Type;
				model.State = entity.State;
				model.UserId = entity.UserId;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
