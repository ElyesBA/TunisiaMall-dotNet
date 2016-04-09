
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace  TunisiaMall.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        // Attributes
        private tunisiamallContext dataContext;
        // Methods
        public UnitOfWork()
        {
            dataContext = DatabaseFactory.getContext();
        }
        public void Commit()
        {
            dataContext.SaveChanges();
        }
        
        public void Dispose()
        {
            dataContext.Dispose();
        }

        public IRepository<T> getRepository<T>() where T : class
        {
            IRepository<T> r = new RepositoryBase<T>();
            return r;
        }
    }
}
