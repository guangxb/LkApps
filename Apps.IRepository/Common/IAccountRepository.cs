using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apps.Models;

namespace Apps.IRepository
{
    public interface IAccountRepository
    {
        SysUser Login(string username, string pwd);
    }
}
