using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IRepository
{
    public interface IBaseRepository<T>
    {
        int SaveChanges();
        void Create(T model);
        void Modify(T model, params string[] updateProperties);
        void ModifyBy(Expression<Func<T, bool>> where, Dictionary<string, object> dic);
        void Remove(T model);
        void RemoveBy(Expression<Func<T, bool>> where);

        void RemoveByEntities(ICollection<T> entities);
        IQueryable<T> GetList(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> query = null);
        IQueryable<T> GetListSort<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true);
        IQueryable<T> GetListPaged<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T,S>> orderByLambda);
        T GetById(params object[] keyValues);
        void RemoveById(params object[] keyValues);
    }
}
