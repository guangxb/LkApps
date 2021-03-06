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
	public class Virtual_SysStructService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysStructRepository m_Rep{
			 get
			{
				return DBSession.SysStruct;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysStructModel> GetList(Expression<Func<Apps.Models.SysStruct, bool>> where = null){
		
				IQueryable<SysStruct> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysStructModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysStruct, bool>> where,Expression<Func<Apps.Models.SysStruct, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysStruct> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysStructModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysStruct, bool>> where = null)
		{

			IQueryable<SysStruct> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.ParentId.Contains(queryStr)
								
								|| a.Higher.Contains(queryStr)
								
								|| a.Remark.Contains(queryStr)
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Sys.SysStructModel> CreateModelList(ref IQueryable<SysStruct> queryData)
		{

			List<Apps.Models.Sys.SysStructModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysStructModel
											  {
													Id = r.Id,
													Name = r.Name,
													ParentId = r.ParentId,
													Sort = r.Sort,
													Higher = r.Higher,
													Enable = r.Enable,
													Remark = r.Remark,
													CreateTime = r.CreateTime,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysStructModel model)
		{
				SysStruct entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysStruct();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.ParentId = model.ParentId;
				entity.Sort = model.Sort;
				entity.Higher = model.Higher;
				entity.Enable = model.Enable;
				entity.Remark = model.Remark;
				entity.CreateTime = model.CreateTime;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysStructModel model,params string[] updateProperties)
		{
				SysStruct entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.Name = model.Name;
											entity.ParentId = model.ParentId;
											entity.Sort = model.Sort;
											entity.Higher = model.Higher;
											entity.Enable = model.Enable;
											entity.Remark = model.Remark;
											entity.CreateTime = model.CreateTime;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysStructModel);
						Type typeE = typeof(Apps.Models.SysStruct);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysStructModel GetById(string id)
		{
			SysStruct entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysStruct entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysStructModel model = new Apps.Models.Sys.SysStructModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.ParentId = entity.ParentId;
				model.Sort = entity.Sort;
				model.Higher = entity.Higher;
				model.Enable = entity.Enable;
				model.Remark = entity.Remark;
				model.CreateTime = entity.CreateTime;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
