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
namespace Apps.Service.Spl
{
	public class Virtual_Spl_ProductService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Spl.ISpl_ProductRepository m_Rep{
			 get
			{
				return DBSession.Spl_Product;
			}
		}
		

		public virtual List<Apps.Models.Spl.Spl_ProductModel> GetList(Expression<Func<Apps.Models.Spl_Product, bool>> where = null){
		
				IQueryable<Spl_Product> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Spl.Spl_ProductModel> GetListSort<TKey>(Expression<Func<Apps.Models.Spl_Product, bool>> where,Expression<Func<Apps.Models.Spl_Product, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Spl_Product> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Spl.Spl_ProductModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.Spl_Product, bool>> where = null)
		{

			IQueryable<Spl_Product> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.Code.Contains(queryStr)
								
								
								|| a.Color.Contains(queryStr)
								
								|| a.CategoryId.Contains(queryStr)
								
								|| a.CreateBy.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Spl.Spl_ProductModel> CreateModelList(ref IQueryable<Spl_Product> queryData)
		{

			List<Apps.Models.Spl.Spl_ProductModel> modelList = (from r in queryData
											  select new Apps.Models.Spl.Spl_ProductModel
											  {
													Id = r.Id,
													Name = r.Name,
													Code = r.Code,
													Price = r.Price,
													CostPrice = r.CostPrice,
													Color = r.Color,
													Number = r.Number,
													CategoryId = r.CategoryId,
													CreateTime = r.CreateTime,
													CreateBy = r.CreateBy,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Spl.Spl_ProductModel model)
		{
				Spl_Product entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Spl_Product();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.Code = model.Code;
				entity.Price = model.Price;
				entity.CostPrice = model.CostPrice;
				entity.Color = model.Color;
				entity.Number = model.Number;
				entity.CategoryId = model.CategoryId;
				entity.CreateTime = model.CreateTime;
				entity.CreateBy = model.CreateBy;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Spl.Spl_ProductModel model,params string[] updateProperties)
		{
				Spl_Product entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.Name = model.Name;
											entity.Code = model.Code;
											entity.Price = model.Price;
											entity.CostPrice = model.CostPrice;
											entity.Color = model.Color;
											entity.Number = model.Number;
											entity.CategoryId = model.CategoryId;
											entity.CreateTime = model.CreateTime;
											entity.CreateBy = model.CreateBy;
									}else{
					
						Type type = typeof(Apps.Models.Spl.Spl_ProductModel);
						Type typeE = typeof(Apps.Models.Spl_Product);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Spl.Spl_ProductModel GetById(string id)
		{
			Spl_Product entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//Spl_Product entity = m_Rep.GetById(id);
				Apps.Models.Spl.Spl_ProductModel model = new Apps.Models.Spl.Spl_ProductModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.Code = entity.Code;
				model.Price = entity.Price;
				model.CostPrice = entity.CostPrice;
				model.Color = entity.Color;
				model.Number = entity.Number;
				model.CategoryId = entity.CategoryId;
				model.CreateTime = entity.CreateTime;
				model.CreateBy = entity.CreateBy;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
