using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apps.Models;
using Apps.IRepository;

namespace Apps.Repository
{
    public class AccountRepository : IAccountRepository
    {
        DBContainer db = EFFatory.GetEFContext();

        public DBContainer Context
        {
            get { return db; }
        }
        public SysUser Login(string username, string pwd)
        {
              SysUser user = Context.SysUser.SingleOrDefault(a => a.UserName == username && a.Password == pwd);
              return user;
        }
    }
}
