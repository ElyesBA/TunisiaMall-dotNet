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
            // Services
            IService<user> userService = new Service<user>();
            IService<post> postService = new Service<post>();
            IService<comment> commentService = new Service<comment>();
            IService<category> categoryService = new Service<category>();
            IService<subcategory> subcatService = new Service<subcategory>();
            IService<gestbookentry> gestbookService = new Service<gestbookentry>();
            IService<store> storeService = new Service<store>();
            IService<product> productService = new Service<product>();
            // Objects
            user u1 = new user { login = "user1", password = "user1"};
            userService.Create(u1);
            userService.Commit();
            post p1 = new post { title = "post 1", postDate = DateTime.Now, user = u1};
            postService.Create(p1);
            postService.Commit();
            Console.ReadKey();
        }
    }
}
