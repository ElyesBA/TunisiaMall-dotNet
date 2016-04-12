using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service.Services
{
    public class ProductService : Service<product> , IProductService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public ProductService() : base(work){ }

        public IEnumerable<product> getAll()
        {
            return GetMany();
        }

        public product getProdByID(int id)
        {
            return FindById(id);
        }
    }

}

