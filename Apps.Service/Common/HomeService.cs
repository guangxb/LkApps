using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Apps.Models;
using Apps.Models.Sys;
using Apps.IService;
using Apps.IRepository;

namespace Apps.Service
{

    public class HomeService : IHomeService
    {
        public IHomeRepository HomeRepository =  DBSessionFactory.GetDBSession().Home;


        public List<SysModuleModel> GetMenuByPersonId(string personId, string moduleId)
        {
           IQueryable<SysModule> queryData=HomeRepository.GetMenuByPersonId(personId, moduleId);
            return CreateModelList(ref queryData);
        }

        private List<SysModuleModel> CreateModelList(ref IQueryable<SysModule> queryData)
        {
            List<SysModuleModel> modelList = (from r in queryData
                                              select new SysModuleModel
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  EnglishName = r.EnglishName,
                                                  ParentId = r.ParentId,
                                                  AreasName = r.AreasName,
                                                  ControllerName = r.ControllerName,
                                                  Iconic = r.Iconic,
                                                  Sort = r.Sort,
                                                  Remark = r.Remark,
                                                  Enable = r.Enable,
                                                  CreatePerson = r.CreatePerson,
                                                  CreateTime = r.CreateTime,
                                                  IsLast = r.IsLast
                                              }).ToList();
            return modelList;
        }
    }
}
