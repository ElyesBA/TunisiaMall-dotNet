using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;

namespace TunisiaMall.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory dbFactory = new DatabaseFactory();
            IUnitOfWork work = new UnitOfWork(dbFactory);
            IRepository<category> categoryRep = work.getRepository<category>();
            category c = new category();
            c.idCategory = 5;
            c.libelle = "libelle";
            c.description = "description";
            categoryRep.Create(c);
            work.Commit();
        }
    }
}
