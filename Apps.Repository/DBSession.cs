using Apps.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apps.Repository
{
    public partial class DBSession
    {
        /// <summary>
        /// 1.0 调用EF容器 批量 执行 sql语句
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            //从线程中获取EF容器对象
            return EFFatory.GetEFContext().SaveChanges();
        }

        IAccountRepository _Account;
        public IAccountRepository Account
        {
            get
            {
                if (_Account == null)
                    _Account = new AccountRepository();
                return _Account;
            }
        }

        IHomeRepository _Home;
        public IHomeRepository Home
        {
            get
            {
                if (_Home == null)
                    _Home = new HomeRepository();
                return _Home;
            }
        }
    }
}
