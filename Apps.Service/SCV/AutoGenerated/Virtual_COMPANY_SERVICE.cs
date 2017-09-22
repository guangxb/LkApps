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
namespace Apps.Service.SCV.Sys
{
	public class Virtual_COMPANY_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.Sys.ICOMPANY_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.COMPANY;
			}
		}
		

		public virtual List<Apps.Models.SCV.Sys.COMPANY_MODEL> GetList(Expression<Func<Apps.Models.COMPANY, bool>> where = null){
		
				IQueryable<Apps.Models.COMPANY> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.COMPANY_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.COMPANY, bool>> where,Expression<Func<Apps.Models.COMPANY, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.COMPANY> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.COMPANY_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.COMPANY, bool>> where = null)
		{

			IQueryable<Apps.Models.COMPANY> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.COMPANY1.Contains(queryStr)
								|| a.NAME.Contains(queryStr)
								|| a.ACTIVE.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								
								|| a.ATTENTION_TO.Contains(queryStr)
								|| a.ADDRESS1.Contains(queryStr)
								|| a.ADDRESS2.Contains(queryStr)
								|| a.DISTRICT.Contains(queryStr)
								|| a.CITY.Contains(queryStr)
								|| a.STATE.Contains(queryStr)
								|| a.COUNTRY.Contains(queryStr)
								|| a.POSTAL_CODE.Contains(queryStr)
								|| a.PHONE_NUM.Contains(queryStr)
								|| a.FAX_NUM.Contains(queryStr)
								|| a.MOBILE.Contains(queryStr)
								|| a.EMAIL_ADDRESS.Contains(queryStr)
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								|| a.SHIPMENT_ID_PREFIX.Contains(queryStr)
								|| a.RECEIPT_ID_PREFIX.Contains(queryStr)
								|| a.NAME_EN.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.Sys.COMPANY_MODEL> CreateModelList(ref IQueryable<Apps.Models.COMPANY> queryData)
		{

			List<Apps.Models.SCV.Sys.COMPANY_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.Sys.COMPANY_MODEL
											  {
													COMPANY1 = r.COMPANY1,
													NAME = r.NAME,
													ACTIVE = r.ACTIVE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													INTERNAL_NUM = r.INTERNAL_NUM,
													ATTENTION_TO = r.ATTENTION_TO,
													ADDRESS1 = r.ADDRESS1,
													ADDRESS2 = r.ADDRESS2,
													DISTRICT = r.DISTRICT,
													CITY = r.CITY,
													STATE = r.STATE,
													COUNTRY = r.COUNTRY,
													POSTAL_CODE = r.POSTAL_CODE,
													PHONE_NUM = r.PHONE_NUM,
													FAX_NUM = r.FAX_NUM,
													MOBILE = r.MOBILE,
													EMAIL_ADDRESS = r.EMAIL_ADDRESS,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													SHIPMENT_ID_PREFIX = r.SHIPMENT_ID_PREFIX,
													RECEIPT_ID_PREFIX = r.RECEIPT_ID_PREFIX,
													NAME_EN = r.NAME_EN,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.Sys.COMPANY_MODEL model)
		{
				Apps.Models.COMPANY entity = m_Rep.GetById(model.COMPANY1);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.COMPANY();
			   				entity.COMPANY1 = model.COMPANY1;
				entity.NAME = model.NAME;
				entity.ACTIVE = model.ACTIVE;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.ATTENTION_TO = model.ATTENTION_TO;
				entity.ADDRESS1 = model.ADDRESS1;
				entity.ADDRESS2 = model.ADDRESS2;
				entity.DISTRICT = model.DISTRICT;
				entity.CITY = model.CITY;
				entity.STATE = model.STATE;
				entity.COUNTRY = model.COUNTRY;
				entity.POSTAL_CODE = model.POSTAL_CODE;
				entity.PHONE_NUM = model.PHONE_NUM;
				entity.FAX_NUM = model.FAX_NUM;
				entity.MOBILE = model.MOBILE;
				entity.EMAIL_ADDRESS = model.EMAIL_ADDRESS;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.SHIPMENT_ID_PREFIX = model.SHIPMENT_ID_PREFIX;
				entity.RECEIPT_ID_PREFIX = model.RECEIPT_ID_PREFIX;
				entity.NAME_EN = model.NAME_EN;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.Sys.COMPANY_MODEL model,params string[] updateProperties)
		{
				Apps.Models.COMPANY entity = m_Rep.GetById(model.COMPANY1);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.COMPANY1 = model.COMPANY1;
											entity.NAME = model.NAME;
											entity.ACTIVE = model.ACTIVE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.ATTENTION_TO = model.ATTENTION_TO;
											entity.ADDRESS1 = model.ADDRESS1;
											entity.ADDRESS2 = model.ADDRESS2;
											entity.DISTRICT = model.DISTRICT;
											entity.CITY = model.CITY;
											entity.STATE = model.STATE;
											entity.COUNTRY = model.COUNTRY;
											entity.POSTAL_CODE = model.POSTAL_CODE;
											entity.PHONE_NUM = model.PHONE_NUM;
											entity.FAX_NUM = model.FAX_NUM;
											entity.MOBILE = model.MOBILE;
											entity.EMAIL_ADDRESS = model.EMAIL_ADDRESS;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.SHIPMENT_ID_PREFIX = model.SHIPMENT_ID_PREFIX;
											entity.RECEIPT_ID_PREFIX = model.RECEIPT_ID_PREFIX;
											entity.NAME_EN = model.NAME_EN;
									}else{
					
						Type type = typeof(Apps.Models.SCV.Sys.COMPANY_MODEL);
						Type typeE = typeof(Apps.Models.COMPANY);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.Sys.COMPANY_MODEL GetById(string id)
		{
			Apps.Models.COMPANY entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//COMPANY entity = m_Rep.GetById(id);
				Apps.Models.SCV.Sys.COMPANY_MODEL model = new Apps.Models.SCV.Sys.COMPANY_MODEL();
							  				model.COMPANY1 = entity.COMPANY1;
				model.NAME = entity.NAME;
				model.ACTIVE = entity.ACTIVE;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.ATTENTION_TO = entity.ATTENTION_TO;
				model.ADDRESS1 = entity.ADDRESS1;
				model.ADDRESS2 = entity.ADDRESS2;
				model.DISTRICT = entity.DISTRICT;
				model.CITY = entity.CITY;
				model.STATE = entity.STATE;
				model.COUNTRY = entity.COUNTRY;
				model.POSTAL_CODE = entity.POSTAL_CODE;
				model.PHONE_NUM = entity.PHONE_NUM;
				model.FAX_NUM = entity.FAX_NUM;
				model.MOBILE = entity.MOBILE;
				model.EMAIL_ADDRESS = entity.EMAIL_ADDRESS;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.SHIPMENT_ID_PREFIX = entity.SHIPMENT_ID_PREFIX;
				model.RECEIPT_ID_PREFIX = entity.RECEIPT_ID_PREFIX;
				model.NAME_EN = entity.NAME_EN;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
