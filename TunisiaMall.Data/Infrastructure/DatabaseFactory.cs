using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace TunisiaMall.Data.Infrastructure
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private tunisiamallContext dataContext;


        public DatabaseFactory()
        {
            dataContext = new tunisiamallContext();
        }
        public tunisiamallContext DataContext
        {
            get
            {
                return dataContext;
            }
        }

        tunisiamallContext IDatabaseFactory.DataContext
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
