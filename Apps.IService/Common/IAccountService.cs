using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apps.Models;

namespace Apps.IService
{
   public partial interface IAccountService
    {
        SysUser Login(string username, string pwd);
    }
}
