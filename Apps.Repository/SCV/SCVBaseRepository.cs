using Apps.IRepository;
using Apps.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Repository.SCV
{
    public abstract class SCVBaseRepository<T> : IBaseRepository<T> where T:class
    {
        SCVDBContainer db = SCVEFFatory.GetEFContext();

        DbSet<T> dbSet;
        public SCVDBContainer Context
        {
            get { return db; }
        }
        public SCVBaseRepository()
        {
            //关闭 EF容器的 为空检查
            db.Configuration.ValidateOnSaveEnabled = false;
            //在构造函数中 实例化 dbSet
            //2.通过EF容器对象 获取 一个 DbSet<T> 用来操作 和 TEntity实体类 对应的数据表
            dbSet = db.Set<T>();
        }

        #region 1.1 新增 实体对象 +void Create(T model)

        /// <summary>
        /// 新增 实体对象
        /// </summary>
        /// <param name="model"></param>
        public virtual void Create(T model)
        {
            dbSet.Add(model);
        }
        #endregion

        #region 2.0 根据实体修改 已弃用 bool Edit(T model)

        //public virtual bool Edit(T model)
        //{
        //    if (db.Entry<T>(model).State == EntityState.Modified)
        //    {
        //        return db.SaveChanges() > 0;
        //    }
        //    else if (db.Entry<T>(model).State == EntityState.Detached)
        //    {
        //        try
        //        {
        //            db.Set<T>().Attach(model);
        //            db.Entry<T>(model).State = EntityState.Modified;
        //        }
        //        catch (InvalidOperationException)
        //        {
        //            //T old = Find(model._ID);
        //            //db.Entry<old>.CurrentValues.SetValues(model);
        //            return false;
        //        }
        //        return db.SaveChanges() > 0;
        //    }
        //    return false;
        //}

        #endregion

        #region 2.1 修改 指定实体 的 指定 属性 +void Modify(T model, params string[] updateProperties)
        /// <summary>
        /// 修改 指定实体 的 指定 属性
        /// </summary>
        /// <param name="model">要修改的实体对象</param>
        /// <param name="updateProperties">要修改的属性名数组</param>
        public virtual void Modify(T model, params string[] updateProperties)
        {
            ////3.1 将 实体对象 添加到 EF容器中，并返回 代理类对象的 一个 指示器对象！
            //DbEntityEntry<T> entry = db.Entry<T>(model);
            ////3.2 手动将 代理对象里的State状态 改为 Unchanged，因为默认是 Detached，不能直接修改 IsModified属性！
            //entry.State = EntityState.Unchanged;
            ////3.3 循环 要修改的 实体类属性名
            //foreach (string propertyName in updateProperties)
            //{
            //    //3.3设置 实体类对象的属性 为已修改状态 注意：实体对象的 第一次属性被修改时， State属性 被自动设置成 Modified
            //    entry.Property(propertyName).IsModified = true;
            //}
        }
        #endregion

        #region 2.1 根据条件 批量修改 +void ModifyBy(Expression<Func<T, bool>> where,Dictionary<string,object> dic)
        /// <summary>
        ///  根据条件 批量修改
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="propertyNames">要修改的 属性名</param>
        /// <param name="values">要设置的新的 属性值</param>
        public void ModifyBy(Expression<Func<T, bool>> where,Dictionary<string,object> dic)
        {
            if (dic.Count<=0) throw new ArgumentException("属性名和属性值都不能为null!");

            //查询要修改的实体对象集合
            var list = dbSet.Where(where);
            //获取要修改的实体类的 类型对象
            Type type = typeof(T);

            //循环要修改的 实体对象
            foreach (var model in list)
            {
                foreach (var item in dic) {
                    //获取要修改的 属性对象
                    PropertyInfo pi = type.GetProperty(item.Key);
                    //item.Name ="123"      pi.SetValue(item,"123");
                    //修改 item实体对象 里 pi属性 的值 为 values[i]  ： item.pi=values[i]
                    pi.SetValue(model, item.Value, null);
                }
            }
        }
        #endregion

        #region 3.1 删除 指定的实体对象 +void Remove(T model)
        /// <summary>
        /// 删除 指定的实体对象
        /// </summary>
        /// <param name="model"></param>
        public virtual void Remove(T model)
        {
            //dbSet.Attach(model);
            dbSet.Remove(model);
        }
        #endregion

        #region 3.1 根据实体批量删除 void RemoveByEntities(params object[] keyValues)
        public virtual void RemoveByEntities(ICollection<T> entities)
        {
            int len = entities.Count;
            for (int i = 0; i < len; i++)
            {
                dbSet.Remove(entities.First());
            }
        }
        #endregion

        #region 3.1 根据条件删除实体 +void RemoveBy(Expression<Func<T, bool>> where)
        /// <summary>
        /// 2.1 根据条件删除实体
        /// </summary>
        /// <param name="where">查询条件表达式</param>
        public void RemoveBy(Expression<Func<T, bool>> where)
        {
            //1.先查询出 要删除的集合
            var list = dbSet.Where(where);//查询出的对象已经存入EF容器了，但State都是 UnChanged
            //2.循环
            foreach (var item in list)
            {
                dbSet.Remove(item);//将 EF容器里的 对象的 State 都改成 Deleted
            }
        }
        #endregion

        #region 3.1 根据主键Id批量删除 void RemoveById(params object[] keyValues)
        public virtual void RemoveById(params object[] keyValues)
        {
            foreach (var item in keyValues)
            {
                T model = GetById(item);
                if (model != null)
                {
                    dbSet.Remove(model);
                }
            }
        } 
        #endregion

        public virtual T GetById(params object[] keyValues)
        {
            return dbSet.Find(keyValues);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        #region 4.1  根据条件查询 IQueryable<T> GetList(Expression<Func<T, bool>> where=null, Expression<Func<T, bool>> query=null)
        /// <summary>
        /// 4.0 根据条件查询
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns></returns>
        public IQueryable<T> GetList(Expression<Func<T, bool>> where=null, Expression<Func<T, bool>> query=null)
        {
            if (where == null && query==null) {
                return dbSet;
            }
            if (query == null) {
                return dbSet.Where(where);
            }

            if (where == null) {
                return dbSet.Where(query);
            }

            return dbSet.Where(where).Where(query);
        }
        #endregion

        #region 4.1 根据条件查询 并且 排序 +IEnumerable<TEntity> GetListSort<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> orderBy)
        /// <summary>
        /// 4.1 根据条件查询 并且 排序
        /// </summary>
        /// <typeparam name="TKey">排序字段类型（可以不写，通过编译器类型推断出来）</typeparam>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">第一个排序条件</param>
        /// <returns></returns>
        public IQueryable<T> GetListSort<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, bool isAsc = true)
        {
            if (isAsc)
            {
                return dbSet.Where(where).OrderBy(orderBy);
            }
            else
            {
                return dbSet.Where(where).OrderByDescending(orderBy);
            }
        }
        #endregion

        #region 4.1分页查询 IQueryable<T> GetListPaged(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, object>> orderByLambda)

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="total"></param>
        /// <param name="whereLambda"></param>
        /// <param name="isAsc"></param>
        /// <param name="orderByLambda"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetListPaged<S>(int pageSize, int pageIndex, out int total
            , Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderByLambda)
        {
            var queryable = db.Set<T>().Where(whereLambda);
            total = queryable.Count();
            if (isAsc)
            {
                queryable = queryable.OrderBy(orderByLambda).Skip<T>(pageSize * (pageIndex - 1)).Take<T>(pageSize);
            }
            else
            {
                queryable = queryable.OrderByDescending(orderByLambda).Skip<T>(pageSize * (pageIndex - 1)).Take<T>(pageSize);
            }
            return queryable;
        }
        #endregion

        #region 5.1 执行Sql语句
        /// <summary>
        /// 执行一条SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteSqlCommand(string sql)
        {
            return db.Database.ExecuteSqlCommand(sql);
        }
        /// <summary>
        /// 异步执行一条SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public Task<int> ExecuteSqlCommandAsync(string sql)
        {
            return db.Database.ExecuteSqlCommandAsync(sql);
        }

        public DbRawSqlQuery<T> SqlQuery(string sql)
        {
            return db.Database.SqlQuery<T>(sql);
        }
        /// <summary>
        /// 查询一条语句返回结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DbRawSqlQuery<T> SqlQuery(string sql, params object[] paras)
        {
            return db.Database.SqlQuery<T>(sql, paras);
        } 
        #endregion
    }
}
