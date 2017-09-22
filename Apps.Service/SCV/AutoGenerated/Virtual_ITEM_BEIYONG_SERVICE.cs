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
namespace Apps.Service.SCV.ITEM
{
	public class Virtual_ITEM_BEIYONG_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.ITEM.IITEM_BEIYONG_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.ITEM_BEIYONG;
			}
		}
		

		public virtual List<Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL> GetList(Expression<Func<Apps.Models.ITEM_BEIYONG, bool>> where = null){
		
				IQueryable<Apps.Models.ITEM_BEIYONG> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.ITEM_BEIYONG, bool>> where,Expression<Func<Apps.Models.ITEM_BEIYONG, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.ITEM_BEIYONG> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.ITEM_BEIYONG, bool>> where = null)
		{

			IQueryable<Apps.Models.ITEM_BEIYONG> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.huowei.Contains(queryStr)
								|| a.item.Contains(queryStr)
								
								|| a.datab.Contains(queryStr)
								|| a.ndata.Contains(queryStr)
								|| a.ndatab.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL> CreateModelList(ref IQueryable<Apps.Models.ITEM_BEIYONG> queryData)
		{

			List<Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL
											  {
													ID = r.ID,
													huowei = r.huowei,
													item = r.item,
													data = r.data,
													datab = r.datab,
													ndata = r.ndata,
													ndatab = r.ndatab,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL model)
		{
				Apps.Models.ITEM_BEIYONG entity = m_Rep.GetById(model.ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.ITEM_BEIYONG();
			   				entity.ID = model.ID;
				entity.huowei = model.huowei;
				entity.item = model.item;
				entity.data = model.data;
				entity.datab = model.datab;
				entity.ndata = model.ndata;
				entity.ndatab = model.ndatab;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL model,params string[] updateProperties)
		{
				Apps.Models.ITEM_BEIYONG entity = m_Rep.GetById(model.ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.ID = model.ID;
											entity.huowei = model.huowei;
											entity.item = model.item;
											entity.data = model.data;
											entity.datab = model.datab;
											entity.ndata = model.ndata;
											entity.ndatab = model.ndatab;
									}else{
					
						Type type = typeof(Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL);
						Type typeE = typeof(Apps.Models.ITEM_BEIYONG);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL GetById(string id)
		{
			Apps.Models.ITEM_BEIYONG entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//ITEM_BEIYONG entity = m_Rep.GetById(id);
				Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL model = new Apps.Models.SCV.ITEM.ITEM_BEIYONG_MODEL();
							  				model.ID = entity.ID;
				model.huowei = entity.huowei;
				model.item = entity.item;
				model.data = entity.data;
				model.datab = entity.datab;
				model.ndata = entity.ndata;
				model.ndatab = entity.ndatab;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
