using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory dbFactory = new DatabaseFactory();
            IUnitOfWork work = new UnitOfWork(dbFactory);
            // Services
            IService<user> userService = new Service<user>(work);
            IService<post> postService = new Service<post>(work);

            user u1 = new user { login = "user1", password = "user1"};
            userService.Create(u1);
            userService.Commit();
            post p1 = new post { title = "post 1", postDate = DateTime.Now, user = u1};
            postService.Create(p1);
            postService.Commit();
            Console.WriteLine(p1.user.idUser);
            Console.ReadKey();
        }
    }
}
