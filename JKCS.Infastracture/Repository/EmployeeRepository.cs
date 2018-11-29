using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Core.Entities;
using JKCS.Infastracture.DBConnection;
using JKCS.Infastracture.IRepository;

namespace JKCS.Infastracture.Repository
{
    public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeDBEntities context)
            : base(context)
        {

        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }
                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
