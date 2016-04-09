using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace TunisiaMall.Data.Infrastructure
{
    public class DatabaseFactory : Disposable
    {
        // Attributes
        private static tunisiamallContext DataContext = null;
        // Methods
        private DatabaseFactory()
        {
        }
        public static tunisiamallContext getContext()
        {
            if (DataContext == null)
            {
                DataContext = new tunisiamallContext();
            }
            return DataContext;
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
