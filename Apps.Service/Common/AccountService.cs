using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Apps.Models;
using Apps.Common;
using Apps.IRepository;
using Apps.IService;

namespace Apps.Service
{
    public class AccountService : IAccountService
    {
        public IAccountRepository m_Rep = DBSessionFactory.GetDBSession().Account;
        public SysUser Login(string username, string pwd)
        {
            return m_Rep.Login(username, pwd);
         
        }
    }
}
