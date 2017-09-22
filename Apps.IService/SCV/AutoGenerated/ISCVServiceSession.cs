﻿
 //------------------------------------------------------------------------------
// <auto-generated>
// 业务仓储接口，作用：
// 1.调用数据仓储 SaveChanges 批量 执行 sql语句
// 2.方便通过 子接口属性直接 获取 对应业务子接口对象
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.IService.SCV
{
    using System;
    public partial interface ISCVServiceSession
    {
    	Apps.IService.SCV.ALLOCATION.IALLOCATION_RULE_DETAIL_SERVICE ALLOCATION_RULE_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ALLOCATION.IALLOCATION_RULE_HEADER_SERVICE ALLOCATION_RULE_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IAPPOINTMENT_SERVICE APPOINTMENT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_RECEIPT_CONTAINER_SERVICE AR_RECEIPT_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_RECEIPT_DETAIL_SERVICE AR_RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_RECEIPT_HEADER_SERVICE AR_RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_TASK_DETAIL_SERVICE AR_TASK_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_TASK_HEADER_SERVICE AR_TASK_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_TRANSACTION_HISTORY_SERVICE AR_TRANSACTION_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IAREAS_SERVICE AREAS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IATTRIBUTE_SERVICE ATTRIBUTE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ATTRIBUTE.IATTRIBUTE_TEMPLATE_SERVICE ATTRIBUTE_TEMPLATE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AUDIT.IAUDIT_LOG_SERVICE AUDIT_LOG
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.BOM.IBOM_DETAIL_SERVICE BOM_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.BOM.IBOM_HEADER_SERVICE BOM_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CART.ICART_DETAIL_SERVICE CART_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CART.ICART_HEADER_SERVICE CART_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.ICOMPANY_SERVICE COMPANY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.ICOMPANYSTATE_SERVICE COMPANYSTATE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CONFIG.ICONFIG_VALUE_SERVICE CONFIG_VALUE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CONTAINER.ICONTAINER_TYPE_SERVICE CONTAINER_TYPE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CUSTOM.ICUSTOM_RESOURCE_SERVICE CUSTOM_RESOURCE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.ICUSTOMER_SERVICE CUSTOMER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CYCLE.ICYCLE_COUNT_DETAIL_SERVICE CYCLE_COUNT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CYCLE.ICYCLE_COUNT_HEADER_SERVICE CYCLE_COUNT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CYCLE.ICYCLE_COUNT_MASTER_SERVICE CYCLE_COUNT_MASTER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOCUMENT.IDOCUMENT_ROUTING_SERVICE DOCUMENT_ROUTING
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_COMPANY_SERVICE DOWNLOAD_COMPANY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_ITEM_SERVICE DOWNLOAD_ITEM
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_ITEM_BARCODE_SERVICE DOWNLOAD_ITEM_BARCODE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_ITEM_UNIT_OF_MEASURE_SERVICE DOWNLOAD_ITEM_UNIT_OF_MEASURE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_ITEMS_SERVICE DOWNLOAD_ITEMS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_RECEIPT_DETAIL_SERVICE DOWNLOAD_RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_RECEIPT_HEADER_SERVICE DOWNLOAD_RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_RECEIPTS_SERVICE DOWNLOAD_RECEIPTS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENT_DETAIL_SERVICE DOWNLOAD_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENT_HEADER_SERVICE DOWNLOAD_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENTS_SERVICE DOWNLOAD_SHIPMENTS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENTS_UPDATE_SERVICE DOWNLOAD_SHIPMENTS_UPDATE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DYNAMIC.IDYNAMIC_CALLING_DETAIL_SERVICE DYNAMIC_CALLING_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DYNAMIC.IDYNAMIC_CALLING_HEADER_SERVICE DYNAMIC_CALLING_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.EX.IEX_MENU_SERVICE EX_MENU
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.FILTER.IFILTER_CONFIG_DETAIL_SERVICE FILTER_CONFIG_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.FILTER.IFILTER_GROUP_BY_SERVICE FILTER_GROUP_BY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.FILTER.IFILTER_ORDER_BY_SERVICE FILTER_ORDER_BY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.FILTER.IFILTER_STATEMENT_SERVICE FILTER_STATEMENT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.GENERIC.IGENERIC_CONFIG_DETAIL_SERVICE GENERIC_CONFIG_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.GENERIC.IGENERIC_CONFIG_HEADER_SERVICE GENERIC_CONFIG_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INTERFACE.IINTERFACE_FAILURE_SERVICE INTERFACE_FAILURE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INTERFACE.IINTERFACE_PROCESS_SERVICE INTERFACE_PROCESS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INTERFACE.IINTERFACE_SESSION_SERVICE INTERFACE_SESSION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INTERFACE.IINTERFACE_TABLE_STATISTIC_SERVICE INTERFACE_TABLE_STATISTIC
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INVENTORY.IINVENTORY_TRANSACTION_SERVICE INVENTORY_TRANSACTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IITEM_SERVICE ITEM
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_BARCODE_SERVICE ITEM_BARCODE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_BEIYONG_SERVICE ITEM_BEIYONG
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_BEIYONG1_SERVICE ITEM_BEIYONG1
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_LOCATION_CAPACITY_SERVICE ITEM_LOCATION_CAPACITY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_UNIT_OF_MEASURE_SERVICE ITEM_UNIT_OF_MEASURE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_WEIGHT_HIS_SERVICE ITEM_WEIGHT_HIS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.ITEM.IITEM_ZONE_CAPACITY_SERVICE ITEM_ZONE_CAPACITY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATING.ILOCATING_RULE_DETAIL_SERVICE LOCATING_RULE_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATING.ILOCATING_RULE_HEADER_SERVICE LOCATING_RULE_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.ILOCATION_SERVICE LOCATION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATION.ILOCATION_CARRIER_SERVICE LOCATION_CARRIER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATION.ILOCATION_INVENTORY_SERVICE LOCATION_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATION.ILOCATION_SELECTION_SERVICE LOCATION_SELECTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.MISC.IMISC_INVENTORY_HANDLING_SERVICE MISC_INVENTORY_HANDLING
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.NEXT.INEXT_NUMBER_SERVICE NEXT_NUMBER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PACKING.IPACKING_CLASS_SERVICE PACKING_CLASS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PACKING.IPACKING_PREFERENCE_SERVICE PACKING_PREFERENCE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PROCESS.IPROCESS_HISTORY_SERVICE PROCESS_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PURCHASE.IPURCHASE_ORDER_DETAIL_SERVICE PURCHASE_ORDER_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PURCHASE.IPURCHASE_ORDER_HEADER_SERVICE PURCHASE_ORDER_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.QUEUE.IQUEUE_TASK_IN_CONFIRM_SERVICE QUEUE_TASK_IN_CONFIRM
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_CONTAINER_SERVICE RECEIPT_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_DETAIL_SERVICE RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_HEADER_SERVICE RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_HEADER_TEMP_SERVICE RECEIPT_HEADER_TEMP
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_LOCATE_REQUEST_SERVICE RECEIPT_LOCATE_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIVING.IRECEIVING_PREFERENCE_SERVICE RECEIVING_PREFERENCE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IREPLENISHMENT_SERVICE REPLENISHMENT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.REPLENISHMENT.IREPLENISHMENT_MASTER_SERVICE REPLENISHMENT_MASTER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.REPLENISHMENT.IREPLENISHMENT_REQUEST_SERVICE REPLENISHMENT_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.REPORT.IREPORT_CONNECTION_SERVICE REPORT_CONNECTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RETURNED.IRETURNED_PACKAGE_SERVICE RETURNED_PACKAGE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RULE.IRULE_ASSIGNMENT_DETAIL_SERVICE RULE_ASSIGNMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RULE.IRULE_ASSIGNMENT_HEADER_SERVICE RULE_ASSIGNMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SCHEDULE.ISCHEDULE_JOB_SERVICE SCHEDULE_JOB
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SCHEDULE.ISCHEDULE_JOB_HISTORY_SERVICE SCHEDULE_JOB_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SCHEDULE.ISCHEDULE_JOB_TYPE_SERVICE SCHEDULE_JOB_TYPE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SECURITY.ISECURITY_FUNCTION_SERVICE SECURITY_FUNCTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SECURITY.ISECURITY_ROLE_DETAIL_SERVICE SECURITY_ROLE_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SECURITY.ISECURITY_ROLE_HEADER_SERVICE SECURITY_ROLE_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SERIAL.ISERIAL_NUMBER_SERVICE SERIAL_NUMBER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_ALLOC_REQUEST_SERVICE SHIPMENT_ALLOC_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_CARRIER_EDITRULE_SERVICE SHIPMENT_CARRIER_EDITRULE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_DETAIL_SERVICE SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_EXPRESS_SERVICE SHIPMENT_EXPRESS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_HEADER_SERVICE SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_HEADER_TEMP_SERVICE SHIPMENT_HEADER_TEMP
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_HEADER_TEMP1_SERVICE SHIPMENT_HEADER_TEMP1
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_INVOICE_SERVICE SHIPMENT_INVOICE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_SERIAL_NUMBER_SERVICE SHIPMENT_SERIAL_NUMBER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_TRACKING_NUMBER_SERVICE SHIPMENT_TRACKING_NUMBER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPPING.ISHIPPING_CART_DETAIL_SERVICE SHIPPING_CART_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPPING.ISHIPPING_CART_HEADER_SERVICE SHIPPING_CART_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPPING.ISHIPPING_CONTAINER_SERVICE SHIPPING_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPPING.ISHIPPING_CONTAINER_HIS_SERVICE SHIPPING_CONTAINER_HIS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPPING.ISHIPPING_LOAD_SERVICE SHIPPING_LOAD
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.STATISTICS.ISTATISTICS_REPORT_SERVICE STATISTICS_REPORT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.STATUS.ISTATUS_FLOW_DETAIL_SERVICE STATUS_FLOW_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.STATUS.ISTATUS_FLOW_HEADER_SERVICE STATUS_FLOW_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_CREATION_MASTER_SERVICE TASK_CREATION_MASTER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_DETAIL_SERVICE TASK_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_HANDLING_OPTION_SERVICE TASK_HANDLING_OPTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_HEADER_SERVICE TASK_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_PREF_USER_AUTH_SERVICE TASK_PREF_USER_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TASK.ITASK_PREFERENCE_SERVICE TASK_PREFERENCE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TRANSACTION.ITRANSACTION_HISTORY_SERVICE TRANSACTION_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TRANSFER.ITRANSFER_LOCATE_REQUEST_SERVICE TRANSFER_LOCATE_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TRANSFER.ITRANSFER_ORDER_DETAIL_SERVICE TRANSFER_ORDER_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.TRANSFER.ITRANSFER_ORDER_HEADER_SERVICE TRANSFER_ORDER_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_INVENTORY_SERVICE UPLOAD_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_INVENTORY_TRANS_SERVICE UPLOAD_INVENTORY_TRANS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_LOCATION_INVENTORY_SERVICE UPLOAD_LOCATION_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_OBJECT_SERVICE UPLOAD_OBJECT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_ORDER_STATUS_SERVICE UPLOAD_ORDER_STATUS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_RECEIPT_CONTAINER_SERVICE UPLOAD_RECEIPT_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_RECEIPT_DETAIL_SERVICE UPLOAD_RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_RECEIPT_HEADER_SERVICE UPLOAD_RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_RECEIPTS_SERVICE UPLOAD_RECEIPTS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_SHIPMENT_DETAIL_SERVICE UPLOAD_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_SHIPMENT_HEADER_SERVICE UPLOAD_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_SHIPPING_CONTAINER_SERVICE UPLOAD_SHIPPING_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IUSER_SERVICE USER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.USER.IUSER_COMPANY_AUTH_SERVICE USER_COMPANY_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.USER.IUSER_WAREHOUSE_AUTH_SERVICE USER_WAREHOUSE_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.USER.IUSER_ZONE_AUTH_SERVICE USER_ZONE_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IVENDOR_SERVICE VENDOR
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IVIEWER_SERVICE VIEWER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IWAREHOUSE_SERVICE WAREHOUSE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAREHOUSE.IWAREHOUSE_ACTIVITY_SERVICE WAREHOUSE_ACTIVITY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IWAVE_SERVICE WAVE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAVE.IWAVE_FLOW_DETAIL_SERVICE WAVE_FLOW_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAVE.IWAVE_FLOW_HEADER_SERVICE WAVE_FLOW_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAVE.IWAVE_MASTER_SERVICE WAVE_MASTER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAYBILL.IWAYBILL_INFO_SERVICE WAYBILL_INFO
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WORK.IWORK_OPTION_SERVICE WORK_OPTION
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WORK.IWORK_ORDER_DETAIL_SERVICE WORK_ORDER_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WORK.IWORK_ORDER_HEADER_SERVICE WORK_ORDER_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IZONE_SERVICE ZONE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_ITEM_SERVICE AR_DOWNLOAD_ITEM
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_ITEM_BARCODE_SERVICE AR_DOWNLOAD_ITEM_BARCODE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_ITEM_UNIT_OF_MEASURE_SERVICE AR_DOWNLOAD_ITEM_UNIT_OF_MEASURE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_RECEIPT_DETAIL_SERVICE AR_DOWNLOAD_RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_RECEIPT_HEADER_SERVICE AR_DOWNLOAD_RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_SHIPMENT_DETAIL_SERVICE AR_DOWNLOAD_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_DOWNLOAD_SHIPMENT_HEADER_SERVICE AR_DOWNLOAD_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_LOCATION_INVENTORY_SERVICE AR_LOCATION_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_PROCESS_HISTORY_SERVICE AR_PROCESS_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_RECEIPT_LOCATE_REQUEST_SERVICE AR_RECEIPT_LOCATE_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPMENT_ALLOC_REQUEST_SERVICE AR_SHIPMENT_ALLOC_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPMENT_DETAIL_SERVICE AR_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPMENT_HEADER_SERVICE AR_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPMENT_HISTORY_SERVICE AR_SHIPMENT_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPPING_CONTAINER_SERVICE AR_SHIPPING_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_SHIPPING_LOAD_SERVICE AR_SHIPPING_LOAD
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_INVENTORY_SERVICE AR_UPLOAD_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_INVENTORY_TRANS_SERVICE AR_UPLOAD_INVENTORY_TRANS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_LOCATION_INVENTORY_SERVICE AR_UPLOAD_LOCATION_INVENTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_ORDER_STATUS_SERVICE AR_UPLOAD_ORDER_STATUS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_RECEIPT_CONTAINER_SERVICE AR_UPLOAD_RECEIPT_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_RECEIPT_DETAIL_SERVICE AR_UPLOAD_RECEIPT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_RECEIPT_HEADER_SERVICE AR_UPLOAD_RECEIPT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_SHIPMENT_DETAIL_SERVICE AR_UPLOAD_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_SHIPMENT_HEADER_SERVICE AR_UPLOAD_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.AR.IAR_UPLOAD_SHIPPING_CONTAINER_SERVICE AR_UPLOAD_SHIPPING_CONTAINER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CHART.ICHART_CONFIG_SERVICE CHART_CONFIG
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CONSOLIDATE.ICONSOLIDATE_SHIPMENT_HEADER_SERVICE CONSOLIDATE_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.CYCLE.ICYCLE_COUNT_PREFERENCE_SERVICE CYCLE_COUNT_PREFERENCE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DELETED.IDELETED_SHIPMENT_DETAIL_SERVICE DELETED_SHIPMENT_DETAIL
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DELETED.IDELETED_SHIPMENT_HEADER_SERVICE DELETED_SHIPMENT_HEADER
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_RECEIPT_HEADER_FAILED_SERVICE DOWNLOAD_RECEIPT_HEADER_FAILED
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.DOWNLOAD.IDOWNLOAD_SHIPMENT_HEADER_FAILED_SERVICE DOWNLOAD_SHIPMENT_HEADER_FAILED
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.END.IEND_POINT_SERVICE END_POINT
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.g.Ig_login_history_SERVICE g_login_history
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.g.Ig_user_SERVICE g_user
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.GENERIC.IGENERIC_USER_AUTH_SERVICE GENERIC_USER_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.GSP.IGSP_CODE_SERVICE GSP_CODE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.INTERFACE.IINTERFACE_REQUEST_SERVICE INTERFACE_REQUEST
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATION.ILOCATION_INVENTORY_HIS_SERVICE LOCATION_INVENTORY_HIS
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.LOCATION.ILOCATION_INVENTORY_TEMP_SERVICE LOCATION_INVENTORY_TEMP
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.Sys.IMESSAGE_SERVICE MESSAGE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.MESSAGE.IMESSAGE_ROUTE_SERVICE MESSAGE_ROUTE
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.PT.IPT_QTY_SERVICE PT_QTY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIPT.IRECEIPT_HISTORY_SERVICE RECEIPT_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.RECEIVING.IRECEIVING_CART_SERVICE RECEIVING_CART
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SECURITY.ISECURITY_FUNCTION_bak_SERVICE SECURITY_FUNCTION_bak
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.SHIPMENT.ISHIPMENT_HISTORY_SERVICE SHIPMENT_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.test.Itest_LOC_V_SERVICE test_LOC_V
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.UPLOAD.IUPLOAD_SHIPMENT_HISTORY_SERVICE UPLOAD_SHIPMENT_HISTORY
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.USER.IUSER_ADDRESS_CARRIER_AUTH_SERVICE USER_ADDRESS_CARRIER_AUTH
    	{ 
    		get;
    	}
    
    	Apps.IService.SCV.WAREHOUSE.IWAREHOUSE_ISSUE_SERVICE WAREHOUSE_ISSUE
    	{ 
    		get;
    	}
    
    }
}