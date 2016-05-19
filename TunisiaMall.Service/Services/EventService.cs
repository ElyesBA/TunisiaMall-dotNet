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
        public Event GetEventByTitle(string title)
        {
            var res = from Event in dbFactory.DataContext.events
                      where Event.titleEvent == title
                      select Event;
            return res.FirstOrDefault();
        }

        public List<Event> GetTopEvent()
        {
            return work.getRepository<Event>().GetMany(c => c.dateEvent >= DateTime.Now).OrderBy(c => c.dateEvent).ToList();
        }
        public void Subscribe(int idEvent , int idUser) {
            var user=work.getRepository<user>().FindById(idUser);
            var evt = work.getRepository<Event>().FindById(idEvent);
            work.getRepository<subscription>().Create(new subscription() { idUser = user.idUser, user = user, idEvent = idEvent });
            Commit();
        }

        public bool IsSubscribe(int idEvent , int idUser)
        {
           return ((work .getRepository<subscription>()
                        .GetMany(c => c.idUser == idUser && c.idEvent == idEvent)
                        .ToList().Count) > 0);
        }

        public void NoSubscribe(int id_event , int id_user)
        {
            var sub = work.getRepository<subscription>().GetMany(c => c.idEvent == id_event && c.idUser == id_user).First();
            work.getRepository<subscription>().Delete(sub);
            Commit();
        }

        public List<Event> MyEvents(int id_user)
        {
            var sub_list = work.getRepository<user>().FindById(id_user).subscriptions;

            List<Event> events = new List<Event>();

            foreach(var item in sub_list)
            {
                events.Add(work.getRepository<Event>().FindById(item.idEvent));
            }

            return events;
        }

        public List<Event> FutureEvents()
        {
            return work.getRepository<Event>().GetMany(c => c.dateEvent >= DateTime.Now).ToList();
        }

        public List<Event> LastEvents()
        {
            return work.getRepository<Event>().GetMany(c => c.dateEvent < DateTime.Now).ToList();
        }
    }
}
