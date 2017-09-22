﻿
 //------------------------------------------------------------------------------
// <auto-generated>
// 业务仓储接口，作用：
// 1.调用数据仓储 SaveChanges 批量 执行 sql语句
// 2.方便通过 子接口属性直接 获取 对应业务子接口对象
// </auto-generated>
//------------------------------------------------------------------------------


namespace Apps.Service
{
    using System;
    public partial class ServiceSession:IService.IServiceSession
    {
    	Apps.IService.Spl.ISpl_PersonService _Spl_Person;
    	public Apps.IService.Spl.ISpl_PersonService Spl_Person 
    	{ 
    		get
    		{
    			if (_Spl_Person == null)
    				_Spl_Person = new Apps.Service.Spl.Spl_PersonService();
    			return _Spl_Person;
    		}
    	}
    
    	Apps.IService.Spl.ISpl_ProductService _Spl_Product;
    	public Apps.IService.Spl.ISpl_ProductService Spl_Product 
    	{ 
    		get
    		{
    			if (_Spl_Product == null)
    				_Spl_Product = new Apps.Service.Spl.Spl_ProductService();
    			return _Spl_Product;
    		}
    	}
    
    	Apps.IService.Spl.ISpl_ProductCategoryService _Spl_ProductCategory;
    	public Apps.IService.Spl.ISpl_ProductCategoryService Spl_ProductCategory 
    	{ 
    		get
    		{
    			if (_Spl_ProductCategory == null)
    				_Spl_ProductCategory = new Apps.Service.Spl.Spl_ProductCategoryService();
    			return _Spl_ProductCategory;
    		}
    	}
    
    	Apps.IService.Spm.ISpm_ExpressInfoService _Spm_ExpressInfo;
    	public Apps.IService.Spm.ISpm_ExpressInfoService Spm_ExpressInfo 
    	{ 
    		get
    		{
    			if (_Spm_ExpressInfo == null)
    				_Spm_ExpressInfo = new Apps.Service.Spm.Spm_ExpressInfoService();
    			return _Spm_ExpressInfo;
    		}
    	}
    
    	Apps.IService.Spm.ISpm_LastTimeService _Spm_LastTime;
    	public Apps.IService.Spm.ISpm_LastTimeService Spm_LastTime 
    	{ 
    		get
    		{
    			if (_Spm_LastTime == null)
    				_Spm_LastTime = new Apps.Service.Spm.Spm_LastTimeService();
    			return _Spm_LastTime;
    		}
    	}
    
    	Apps.IService.Spm.ISpm_TracesInfoService _Spm_TracesInfo;
    	public Apps.IService.Spm.ISpm_TracesInfoService Spm_TracesInfo 
    	{ 
    		get
    		{
    			if (_Spm_TracesInfo == null)
    				_Spm_TracesInfo = new Apps.Service.Spm.Spm_TracesInfoService();
    			return _Spm_TracesInfo;
    		}
    	}
    
    	Apps.IService.Sys.ISysAreasService _SysAreas;
    	public Apps.IService.Sys.ISysAreasService SysAreas 
    	{ 
    		get
    		{
    			if (_SysAreas == null)
    				_SysAreas = new Apps.Service.Sys.SysAreasService();
    			return _SysAreas;
    		}
    	}
    
    	Apps.IService.Sys.ISysExceptionService _SysException;
    	public Apps.IService.Sys.ISysExceptionService SysException 
    	{ 
    		get
    		{
    			if (_SysException == null)
    				_SysException = new Apps.Service.Sys.SysExceptionService();
    			return _SysException;
    		}
    	}
    
    	Apps.IService.Sys.ISysLogService _SysLog;
    	public Apps.IService.Sys.ISysLogService SysLog 
    	{ 
    		get
    		{
    			if (_SysLog == null)
    				_SysLog = new Apps.Service.Sys.SysLogService();
    			return _SysLog;
    		}
    	}
    
    	Apps.IService.Sys.ISysLog4NetService _SysLog4Net;
    	public Apps.IService.Sys.ISysLog4NetService SysLog4Net 
    	{ 
    		get
    		{
    			if (_SysLog4Net == null)
    				_SysLog4Net = new Apps.Service.Sys.SysLog4NetService();
    			return _SysLog4Net;
    		}
    	}
    
    	Apps.IService.Sys.ISysModuleService _SysModule;
    	public Apps.IService.Sys.ISysModuleService SysModule 
    	{ 
    		get
    		{
    			if (_SysModule == null)
    				_SysModule = new Apps.Service.Sys.SysModuleService();
    			return _SysModule;
    		}
    	}
    
    	Apps.IService.Sys.ISysPositionService _SysPosition;
    	public Apps.IService.Sys.ISysPositionService SysPosition 
    	{ 
    		get
    		{
    			if (_SysPosition == null)
    				_SysPosition = new Apps.Service.Sys.SysPositionService();
    			return _SysPosition;
    		}
    	}
    
    	Apps.IService.Sys.ISysRightService _SysRight;
    	public Apps.IService.Sys.ISysRightService SysRight 
    	{ 
    		get
    		{
    			if (_SysRight == null)
    				_SysRight = new Apps.Service.Sys.SysRightService();
    			return _SysRight;
    		}
    	}
    
    	Apps.IService.Sys.ISysRoleService _SysRole;
    	public Apps.IService.Sys.ISysRoleService SysRole 
    	{ 
    		get
    		{
    			if (_SysRole == null)
    				_SysRole = new Apps.Service.Sys.SysRoleService();
    			return _SysRole;
    		}
    	}
    
    	Apps.IService.Sys.ISysSampleService _SysSample;
    	public Apps.IService.Sys.ISysSampleService SysSample 
    	{ 
    		get
    		{
    			if (_SysSample == null)
    				_SysSample = new Apps.Service.Sys.SysSampleService();
    			return _SysSample;
    		}
    	}
    
    	Apps.IService.Sys.ISysStructService _SysStruct;
    	public Apps.IService.Sys.ISysStructService SysStruct 
    	{ 
    		get
    		{
    			if (_SysStruct == null)
    				_SysStruct = new Apps.Service.Sys.SysStructService();
    			return _SysStruct;
    		}
    	}
    
    	Apps.IService.Sys.ISysUserService _SysUser;
    	public Apps.IService.Sys.ISysUserService SysUser 
    	{ 
    		get
    		{
    			if (_SysUser == null)
    				_SysUser = new Apps.Service.Sys.SysUserService();
    			return _SysUser;
    		}
    	}
    
    	Apps.IService.Sys.ISysUserConfigService _SysUserConfig;
    	public Apps.IService.Sys.ISysUserConfigService SysUserConfig 
    	{ 
    		get
    		{
    			if (_SysUserConfig == null)
    				_SysUserConfig = new Apps.Service.Sys.SysUserConfigService();
    			return _SysUserConfig;
    		}
    	}
    
    	Apps.IService.Sys.ISysUserMerchantCodeService _SysUserMerchantCode;
    	public Apps.IService.Sys.ISysUserMerchantCodeService SysUserMerchantCode 
    	{ 
    		get
    		{
    			if (_SysUserMerchantCode == null)
    				_SysUserMerchantCode = new Apps.Service.Sys.SysUserMerchantCodeService();
    			return _SysUserMerchantCode;
    		}
    	}
    
    }
}
