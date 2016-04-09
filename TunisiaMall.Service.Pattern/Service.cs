
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;

namespace TunisiaMall.Service.Pattern
{
    public class Service<T> : IService<T> where T : class
    {
        // Attributes
        private IDatabaseFactory dbFactory;
        private IUnitOfWork utfk;
        // Methods
        public Service()
        {
            this.dbFactory = new DatabaseFactory();
            this.utfk = new UnitOfWork(this.dbFactory);
        }

        public void Commit()
        {
            try
            {
                utfk.Commit();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Dispose()
        {
            utfk.Dispose();
        }

        public void Create(T e)
        {
            utfk.getRepository<T>().Create(e);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            utfk.getRepository<T>().Delete(condition);
        }

        public void Delete(T e)
        {
            utfk.getRepository<T>().Delete(e);
        }

        public T FindById(long id)
        {
            return utfk.getRepository<T>().FindById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            return utfk.getRepository<T>().GetMany(condition, orderBy);
        }

        public void Update(T e)
        {
            utfk.getRepository<T>().Update(e);
        }

        public IEnumerable<T> findAll()
        {
            return utfk.getRepository<T>().findAll();
        }
    }
}
