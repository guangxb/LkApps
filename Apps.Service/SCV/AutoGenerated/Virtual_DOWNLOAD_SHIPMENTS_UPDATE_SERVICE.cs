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
namespace Apps.Service.SCV.DOWNLOAD
{
	public class Virtual_DOWNLOAD_SHIPMENTS_UPDATE_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENTS_UPDATE_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.DOWNLOAD_SHIPMENTS_UPDATE;
			}
		}
		

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL> GetList(Expression<Func<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE, bool>> where = null){
		
				IQueryable<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE, bool>> where,Expression<Func<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE, bool>> where = null)
		{

			IQueryable<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.INTERFACE_RECORD_ID.Contains(queryStr)
								|| a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								|| a.INTERFACE_GUID.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.SHIPMENT_ID.Contains(queryStr)
								|| a.ERP_ORDER.Contains(queryStr)
								|| a.SHIPMENT_TYPE.Contains(queryStr)
								|| a.SHIP_TO.Contains(queryStr)
								|| a.SHIP_TO_NAME.Contains(queryStr)
								|| a.SHIP_TO_ADDRESS1.Contains(queryStr)
								|| a.SHIP_TO_ADDRESS2.Contains(queryStr)
								|| a.SHIP_TO_DISTRICT.Contains(queryStr)
								|| a.SHIP_TO_CITY.Contains(queryStr)
								|| a.SHIP_TO_STATE.Contains(queryStr)
								|| a.SHIP_TO_COUNTRY.Contains(queryStr)
								|| a.SHIP_TO_POSTAL_CODE.Contains(queryStr)
								|| a.SHIP_TO_ATTENTION_TO.Contains(queryStr)
								|| a.SHIP_TO_PHONE_NUM.Contains(queryStr)
								|| a.SHIP_TO_MOBILE.Contains(queryStr)
								|| a.SHIP_TO_FAX_NUM.Contains(queryStr)
								|| a.SHIP_TO_EMAIL_ADDRESS.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.CARRIER.Contains(queryStr)
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								
								
								|| a.PROCESS_TYPE.Contains(queryStr)
								
								
								
								|| a.ERP_ORDER_LINE_NUM.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								
								|| a.QUANTITY_UM.Contains(queryStr)
								|| a.ATTRIBUTE1.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL> CreateModelList(ref IQueryable<Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE> queryData)
		{

			List<Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													INTERFACE_GUID = r.INTERFACE_GUID,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													SHIPMENT_ID = r.SHIPMENT_ID,
													ERP_ORDER = r.ERP_ORDER,
													SHIPMENT_TYPE = r.SHIPMENT_TYPE,
													SHIP_TO = r.SHIP_TO,
													SHIP_TO_NAME = r.SHIP_TO_NAME,
													SHIP_TO_ADDRESS1 = r.SHIP_TO_ADDRESS1,
													SHIP_TO_ADDRESS2 = r.SHIP_TO_ADDRESS2,
													SHIP_TO_DISTRICT = r.SHIP_TO_DISTRICT,
													SHIP_TO_CITY = r.SHIP_TO_CITY,
													SHIP_TO_STATE = r.SHIP_TO_STATE,
													SHIP_TO_COUNTRY = r.SHIP_TO_COUNTRY,
													SHIP_TO_POSTAL_CODE = r.SHIP_TO_POSTAL_CODE,
													SHIP_TO_ATTENTION_TO = r.SHIP_TO_ATTENTION_TO,
													SHIP_TO_PHONE_NUM = r.SHIP_TO_PHONE_NUM,
													SHIP_TO_MOBILE = r.SHIP_TO_MOBILE,
													SHIP_TO_FAX_NUM = r.SHIP_TO_FAX_NUM,
													SHIP_TO_EMAIL_ADDRESS = r.SHIP_TO_EMAIL_ADDRESS,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													CARRIER = r.CARRIER,
													STOP_SEQ = r.STOP_SEQ,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													USER_DEF9 = r.USER_DEF9,
													USER_DEF10 = r.USER_DEF10,
													PROCESS_TYPE = r.PROCESS_TYPE,
													TOTAL_QTY = r.TOTAL_QTY,
													TOTAL_LINES = r.TOTAL_LINES,
													TOTAL_VALUE = r.TOTAL_VALUE,
													ERP_ORDER_LINE_NUM = r.ERP_ORDER_LINE_NUM,
													ITEM = r.ITEM,
													ITEM_DESC = r.ITEM_DESC,
													REQUEST_QTY = r.REQUEST_QTY,
													QUANTITY_UM = r.QUANTITY_UM,
													ATTRIBUTE1 = r.ATTRIBUTE1,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL model)
		{
				Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.INTERFACE_GUID = model.INTERFACE_GUID;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.SHIPMENT_ID = model.SHIPMENT_ID;
				entity.ERP_ORDER = model.ERP_ORDER;
				entity.SHIPMENT_TYPE = model.SHIPMENT_TYPE;
				entity.SHIP_TO = model.SHIP_TO;
				entity.SHIP_TO_NAME = model.SHIP_TO_NAME;
				entity.SHIP_TO_ADDRESS1 = model.SHIP_TO_ADDRESS1;
				entity.SHIP_TO_ADDRESS2 = model.SHIP_TO_ADDRESS2;
				entity.SHIP_TO_DISTRICT = model.SHIP_TO_DISTRICT;
				entity.SHIP_TO_CITY = model.SHIP_TO_CITY;
				entity.SHIP_TO_STATE = model.SHIP_TO_STATE;
				entity.SHIP_TO_COUNTRY = model.SHIP_TO_COUNTRY;
				entity.SHIP_TO_POSTAL_CODE = model.SHIP_TO_POSTAL_CODE;
				entity.SHIP_TO_ATTENTION_TO = model.SHIP_TO_ATTENTION_TO;
				entity.SHIP_TO_PHONE_NUM = model.SHIP_TO_PHONE_NUM;
				entity.SHIP_TO_MOBILE = model.SHIP_TO_MOBILE;
				entity.SHIP_TO_FAX_NUM = model.SHIP_TO_FAX_NUM;
				entity.SHIP_TO_EMAIL_ADDRESS = model.SHIP_TO_EMAIL_ADDRESS;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.CARRIER = model.CARRIER;
				entity.STOP_SEQ = model.STOP_SEQ;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.USER_DEF9 = model.USER_DEF9;
				entity.USER_DEF10 = model.USER_DEF10;
				entity.PROCESS_TYPE = model.PROCESS_TYPE;
				entity.TOTAL_QTY = model.TOTAL_QTY;
				entity.TOTAL_LINES = model.TOTAL_LINES;
				entity.TOTAL_VALUE = model.TOTAL_VALUE;
				entity.ERP_ORDER_LINE_NUM = model.ERP_ORDER_LINE_NUM;
				entity.ITEM = model.ITEM;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.REQUEST_QTY = model.REQUEST_QTY;
				entity.QUANTITY_UM = model.QUANTITY_UM;
				entity.ATTRIBUTE1 = model.ATTRIBUTE1;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL model,params string[] updateProperties)
		{
				Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
											entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
											entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.INTERFACE_GUID = model.INTERFACE_GUID;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.SHIPMENT_ID = model.SHIPMENT_ID;
											entity.ERP_ORDER = model.ERP_ORDER;
											entity.SHIPMENT_TYPE = model.SHIPMENT_TYPE;
											entity.SHIP_TO = model.SHIP_TO;
											entity.SHIP_TO_NAME = model.SHIP_TO_NAME;
											entity.SHIP_TO_ADDRESS1 = model.SHIP_TO_ADDRESS1;
											entity.SHIP_TO_ADDRESS2 = model.SHIP_TO_ADDRESS2;
											entity.SHIP_TO_DISTRICT = model.SHIP_TO_DISTRICT;
											entity.SHIP_TO_CITY = model.SHIP_TO_CITY;
											entity.SHIP_TO_STATE = model.SHIP_TO_STATE;
											entity.SHIP_TO_COUNTRY = model.SHIP_TO_COUNTRY;
											entity.SHIP_TO_POSTAL_CODE = model.SHIP_TO_POSTAL_CODE;
											entity.SHIP_TO_ATTENTION_TO = model.SHIP_TO_ATTENTION_TO;
											entity.SHIP_TO_PHONE_NUM = model.SHIP_TO_PHONE_NUM;
											entity.SHIP_TO_MOBILE = model.SHIP_TO_MOBILE;
											entity.SHIP_TO_FAX_NUM = model.SHIP_TO_FAX_NUM;
											entity.SHIP_TO_EMAIL_ADDRESS = model.SHIP_TO_EMAIL_ADDRESS;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.CARRIER = model.CARRIER;
											entity.STOP_SEQ = model.STOP_SEQ;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.USER_DEF9 = model.USER_DEF9;
											entity.USER_DEF10 = model.USER_DEF10;
											entity.PROCESS_TYPE = model.PROCESS_TYPE;
											entity.TOTAL_QTY = model.TOTAL_QTY;
											entity.TOTAL_LINES = model.TOTAL_LINES;
											entity.TOTAL_VALUE = model.TOTAL_VALUE;
											entity.ERP_ORDER_LINE_NUM = model.ERP_ORDER_LINE_NUM;
											entity.ITEM = model.ITEM;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.REQUEST_QTY = model.REQUEST_QTY;
											entity.QUANTITY_UM = model.QUANTITY_UM;
											entity.ATTRIBUTE1 = model.ATTRIBUTE1;
									}else{
					
						Type type = typeof(Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL);
						Type typeE = typeof(Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL GetById(string id)
		{
			Apps.Models.DOWNLOAD_SHIPMENTS_UPDATE entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//DOWNLOAD_SHIPMENTS_UPDATE entity = m_Rep.GetById(id);
				Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL model = new Apps.Models.SCV.DOWNLOAD.DOWNLOAD_SHIPMENTS_UPDATE_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.INTERFACE_GUID = entity.INTERFACE_GUID;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.SHIPMENT_ID = entity.SHIPMENT_ID;
				model.ERP_ORDER = entity.ERP_ORDER;
				model.SHIPMENT_TYPE = entity.SHIPMENT_TYPE;
				model.SHIP_TO = entity.SHIP_TO;
				model.SHIP_TO_NAME = entity.SHIP_TO_NAME;
				model.SHIP_TO_ADDRESS1 = entity.SHIP_TO_ADDRESS1;
				model.SHIP_TO_ADDRESS2 = entity.SHIP_TO_ADDRESS2;
				model.SHIP_TO_DISTRICT = entity.SHIP_TO_DISTRICT;
				model.SHIP_TO_CITY = entity.SHIP_TO_CITY;
				model.SHIP_TO_STATE = entity.SHIP_TO_STATE;
				model.SHIP_TO_COUNTRY = entity.SHIP_TO_COUNTRY;
				model.SHIP_TO_POSTAL_CODE = entity.SHIP_TO_POSTAL_CODE;
				model.SHIP_TO_ATTENTION_TO = entity.SHIP_TO_ATTENTION_TO;
				model.SHIP_TO_PHONE_NUM = entity.SHIP_TO_PHONE_NUM;
				model.SHIP_TO_MOBILE = entity.SHIP_TO_MOBILE;
				model.SHIP_TO_FAX_NUM = entity.SHIP_TO_FAX_NUM;
				model.SHIP_TO_EMAIL_ADDRESS = entity.SHIP_TO_EMAIL_ADDRESS;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.CARRIER = entity.CARRIER;
				model.STOP_SEQ = entity.STOP_SEQ;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.USER_DEF9 = entity.USER_DEF9;
				model.USER_DEF10 = entity.USER_DEF10;
				model.PROCESS_TYPE = entity.PROCESS_TYPE;
				model.TOTAL_QTY = entity.TOTAL_QTY;
				model.TOTAL_LINES = entity.TOTAL_LINES;
				model.TOTAL_VALUE = entity.TOTAL_VALUE;
				model.ERP_ORDER_LINE_NUM = entity.ERP_ORDER_LINE_NUM;
				model.ITEM = entity.ITEM;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.REQUEST_QTY = entity.REQUEST_QTY;
				model.QUANTITY_UM = entity.QUANTITY_UM;
				model.ATTRIBUTE1 = entity.ATTRIBUTE1;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
