using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKCS.Infastracture.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T entity);
        T Update(Func<T, bool> where, T entity);
        List<T> GetAll();
        List<T> GetList(Func<T, bool> where);
        T GetSingle(Func<T, bool> where);
        int Delete(Func<T, bool> where, T entity);
    }
}
