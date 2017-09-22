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
	public class Virtual_SysAreasService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysAreasRepository m_Rep{
			 get
			{
				return DBSession.SysAreas;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysAreasModel> GetList(Expression<Func<Apps.Models.SysAreas, bool>> where = null){
		
				IQueryable<SysAreas> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysAreasModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysAreas, bool>> where,Expression<Func<Apps.Models.SysAreas, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysAreas> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysAreasModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysAreas, bool>> where = null)
		{

			IQueryable<SysAreas> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.ParentId.Contains(queryStr)
								
								
								
								
								
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Sys.SysAreasModel> CreateModelList(ref IQueryable<SysAreas> queryData)
		{

			List<Apps.Models.Sys.SysAreasModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysAreasModel
											  {
													Id = r.Id,
													Name = r.Name,
													ParentId = r.ParentId,
													Sort = r.Sort,
													Enable = r.Enable,
													CreateTime = r.CreateTime,
													IsMunicipality = r.IsMunicipality,
													IsHKMT = r.IsHKMT,
													IsOther = r.IsOther,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysAreasModel model)
		{
				SysAreas entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysAreas();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.ParentId = model.ParentId;
				entity.Sort = model.Sort;
				entity.Enable = model.Enable;
				entity.CreateTime = model.CreateTime;
				entity.IsMunicipality = model.IsMunicipality;
				entity.IsHKMT = model.IsHKMT;
				entity.IsOther = model.IsOther;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysAreasModel model,params string[] updateProperties)
		{
				SysAreas entity = m_Rep.GetById(model.Id);
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
											entity.Enable = model.Enable;
											entity.CreateTime = model.CreateTime;
											entity.IsMunicipality = model.IsMunicipality;
											entity.IsHKMT = model.IsHKMT;
											entity.IsOther = model.IsOther;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysAreasModel);
						Type typeE = typeof(Apps.Models.SysAreas);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysAreasModel GetById(string id)
		{
			SysAreas entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysAreas entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysAreasModel model = new Apps.Models.Sys.SysAreasModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.ParentId = entity.ParentId;
				model.Sort = entity.Sort;
				model.Enable = entity.Enable;
				model.CreateTime = entity.CreateTime;
				model.IsMunicipality = entity.IsMunicipality;
				model.IsHKMT = entity.IsHKMT;
				model.IsOther = entity.IsOther;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}