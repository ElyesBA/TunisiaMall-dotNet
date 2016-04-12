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
    public class UserService : Service<user> , IUserService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public UserService() : base(work){ }

        public int getUserIdByUsername(string name)
        {
            // return work.getRepository<user>().GetMany(u => u.login == name).First().idUser ;
            return 1;
        }

    }
}
