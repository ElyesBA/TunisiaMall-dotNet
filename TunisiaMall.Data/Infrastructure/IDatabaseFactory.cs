using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Models;

namespace TunisiaMall.Data.Infrastructure
{
    public interface IDatabaseFactory // fournisseur de context // utilisé pour cacher le context et ne plus le voir dans les constructeurs
    {
        tunisiamallContext DataContext { get; }
    }
}
