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
    public class EventService : Service<Event>, IEventService
    {
        // Attributes
        private static IDatabaseFactory dbFactory = new DatabaseFactory();
        private static IUnitOfWork work = new UnitOfWork(dbFactory);
        // Methods
        public EventService() : base(work) { }
        public IEnumerable<Event> GetAllEvents()
        {
            return work.getRepository<Event>().GetMany().OrderByDescending(e => e.dateEvent);

        }
        public IEnumerable<Event> GetEventsByStore(string nom) {
             var s = from entry in dbFactory.DataContext.stores
                       where entry.name == nom
                     select entry.events;
            return (IEnumerable<Event>) s;
        }
        
    }
}
