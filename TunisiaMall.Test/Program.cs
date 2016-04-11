using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;
using TunisiaMall.Service.Services;

namespace TunisiaMall.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory dbFactory = new DatabaseFactory();
            IUnitOfWork work = new UnitOfWork(dbFactory);
            // Services
            IMessageService messageService = new MessageService();
            IUserService userService = new UserService();

            List<message> ls = messageService.getMessagesForUser(4);
            Console.WriteLine(ls.Count());
            foreach(var m in ls)
            {
                Console.WriteLine("{0} {1}",m.idMessage, m.text);
            }
            /*user u1 = new user { login = "user1", password = "user1"};
            userService.Create(u1);
            userService.Commit();*/

            Console.ReadKey();
        }
    }
}
