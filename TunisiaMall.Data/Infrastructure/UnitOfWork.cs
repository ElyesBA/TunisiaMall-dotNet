
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
        private tunisiamallContext dataContext;
        protected tunisiamallContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

       

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }


         

        
        public void Dispose()
        {
            DataContext.Dispose();
        }

        public IRepository<T> getRepository<T>() where T : class
        {
            IRepository<T> r = new RepositoryBase<T>(dbFactory); // remplace 3 instances de classe 
            return r;
        }
    }
}
