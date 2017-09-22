using Apps.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IService
{
    public interface IBaseService<T>
    {
        //List<T> GetList(ref GridPager pager, string queryStr, Expression<Func<object, bool>> where);
        void Create(ref ValidationErrors errors, T model);
        void RemoveById(ref ValidationErrors errors, string id);
        void RemoveByIds(ref ValidationErrors errors, string[] deleteCollection);
        void Modify(ref ValidationErrors errors, T model,params string[] updateProperties);
        T GetById(string id);

        
    }
}
