using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Service.Services;
using TunisiaMall.Domain.Entities;

namespace TunisiaMallWeb.Controllers
{ 
    public class EventsController : Controller
    {
        EventService e = new EventService();
        // GET: Events
         public ActionResult listEvent(string orderby)
        {
            IEnumerable<Event> events;
            switch (orderby)
            {
                case "me" : events = e.MyEvents(1); ViewBag.selectme = "selected"; break;
                case "futur": events = e.FutureEvents(); ViewBag.selectfutur = "selected";  break;
                case "last": events = e.LastEvents(); ViewBag.selectlast = "selected";  break;
                default : events = e.GetAllEvents(); ViewBag.selectall = "selected";  break;
            }
            
            ViewBag.topEvents = e.GetTopEvent();
            return View(events); 
        }


        // GET: Events/Details/5
        [Route("DetailEvent/{id}")]
        public ActionResult DetailEvent(int id)
        {
            Event evt = e.FindById(id);
            ViewBag.isSubscribe = e.IsSubscribe(id, 1);
            return View(evt);
        }
        // GET: Detail2
        [Route("DetailEventTitle/{titleEvent}")]
        public ActionResult DetailEventTitle(string titleEvent)
        {
            Event et = e.GetEventByTitle(titleEvent);
            return View(et);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Subscribe(FormCollection form)
        {
            int user = Convert.ToInt32(form["id_user"]);
            int events= Convert.ToInt32(form["id_event"]);

            e.Subscribe(events, user);

            return RedirectToAction("DetailEvent", new
            {
                id = events
            });
        }

        [HttpPost]
        public ActionResult NoSubscribe(FormCollection form)
        {
            int user = Convert.ToInt32(form["id_user"]);
            int events = Convert.ToInt32(form["id_event"]);

            e.NoSubscribe(events, user);

            return RedirectToAction("DetailEvent", new
            {
                id = events
            });
        }

        [HttpPost]
        public ActionResult Sorting(FormCollection form)
        {
            string orderby = form["orderby"];

            var events = e.MyEvents(1);

            return View(events);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Events/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Events/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
