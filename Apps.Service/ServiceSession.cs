using Apps.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps.Service
{
    /// <summary>
    /// 业务仓储 接口
    /// 目的：1.封装 各个业务子接口属性 方便外部调用
    ///      2.调用 数据仓储接口的 SaveChanges 帮数据层完成 数据批量提交
    /// </summary>
    public partial class ServiceSession: IService.IServiceSession
    {
        /// <summary>
        /// 调用 数据仓储接口的 SaveChanges 帮数据层完成 数据批量提交
        /// </summary>
        /// <returns></returns>
        public int SaveChange()
        {
            return DBSessionFactory.GetDBSession().SaveChanges();
        }

        ISysConfigService _SysConfig;
        public ISysConfigService SysConfig
        {
            get
            {
                if (_SysConfig == null)
                    _SysConfig = new SysConfigService();
                return _SysConfig;
            }
        }

        IAccountService _Account;
        public IAccountService Account
        {
            get
            {
                if (_Account == null)
                    _Account = new AccountService();
                return _Account;
            }
        }

        IHomeService _Home;
        public IHomeService Home
        {
            get
            {
                if (_Home == null)
                    _Home = new HomeService();
                return _Home;
            }
        }


    }
}
