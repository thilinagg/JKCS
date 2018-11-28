using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JKCS.Core.Entities;
using JKCS.Core.IRepository;
using JKCS.Infastracture.DBConnection;

namespace JKCS.Infastracture.Repository
{
    public class EmployeeRepository: GenericRepository<EmployeeEntity>, IEmployeeRepository
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
