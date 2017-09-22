using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apps.Models;
using Apps.Models.Sys;

namespace Apps.IService
{
   public partial interface IHomeService
    {
        List<SysModuleModel> GetMenuByPersonId(string personId, string moduleId);
    }
}
