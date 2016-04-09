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
            user u1 = new user();
            u1.login = "user1";
            u1.password = "user1";
            user u2 = new user();
            u2.login = "user2";
            u2.password = "user2";
            // Create
            userService.Create(u1);
            userService.Create(u2);
            // Commit
            userService.Commit();
            postService.Commit();
            commentService.Commit();
            categoryService.Commit();
            subcatService.Commit();
            gestbookService.Commit();
            storeService.Commit();
            productService.Commit();
        }
    }
}
