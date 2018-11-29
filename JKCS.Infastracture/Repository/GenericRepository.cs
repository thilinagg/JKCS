using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Infastracture.DBConnection;
using JKCS.Infastracture.IRepository;

namespace JKCS.Infastracture.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        internal DbSet<T> EntitySet { get; set; }
        protected EmployeeDBEntities Context { get; set; }

        public GenericRepository(EmployeeDBEntities context)
        {
            Context = context;
            EntitySet = Context.Set<T>();
        }

        public T Insert(T entity)
        {
            EntitySet.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public T Update(Func<T, bool> where, T entity)
        {
            T obj = GetSingle(where);
            Context.Entry(obj).CurrentValues.SetValues(entity);
            Context.SaveChanges();
            return obj;
        }
        public int Delete(Func<T, bool> where, T entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                EntitySet.Attach(entity);
            }

            EntitySet.Remove(entity);
            return Context.SaveChanges();
        }

        public List<T> GetAll()
        {
            List<T> list=new List<T>();
            list = EntitySet.ToList();
            return list;
        }

        public List<T> GetList(Func<T, bool> where)
        {
            List<T> list=new List<T>();
            list = EntitySet.Where(where).ToList();
            return list;
        }

        public T GetSingle(Func<T, bool> where)
        {
            return EntitySet.FirstOrDefault(where);
        }
    }
}
