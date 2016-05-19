using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class GuestBookController : Controller
    {

        IGuestBookService g = new GuestBookService();


        // GET: 
        [Route("GetAllEntries")]
        public ActionResult GetAllEntries()
        {
            IEnumerable<guestbookentry> guestbooklist = g.GetMany();
            List<guestbookentry> guestbooklistfinal = guestbooklist.ToList();
            return View(guestbooklistfinal);
        }

        // GET: 
        [Route("DetailsEntry")]
        public ActionResult DetailsEntry(int id)
        {
            guestbookentry guest = g.FindById(id);

            return View(guest);

        }

        // GET: GuestBook/Create
        [HttpGet]
        [Route("CreateGuestBookEntry")]
        public ActionResult CreateGuestBookEntry()
        {
            guestbookentry gestbookE = new guestbookentry();

            // string userId = Membership.GetUser().ProviderUserKey.ToString();
            gestbookE.idUser = 2;

            return View(gestbookE);
        }


        [HttpPost]
        [Route("CreateGuestBookEntry")]
        public ActionResult CreateGuestBookEntry(guestbookentry entry)
        {
            g.Create(entry);
            g.Commit();
            return Redirect("GetAllEntries");

        }

        // GET: GuestBook/Edit/5
        [HttpGet]
        [Route("EditGuestBookEntry")]
        public ActionResult EditEntry(long id = -1)
        {
            guestbookentry guest = g.FindById(id);

            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // POST: GuestBook/Edit/5
        [HttpPost]
        [Route("EditGuestBookEntry")]
        public ActionResult EditEntry(int id, guestbookentry guest)
        {
            try
            {
                var dbguest = g.FindById(id);
                dbguest.rating = guest.rating;
                dbguest.text = guest.text;
                g.Update(dbguest);
                g.Commit();

                return Redirect("GetAllEntries");

            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Route("DeleteEntry")]
        public ActionResult DeleteEntry(int id)
        {
            guestbookentry e = g.FindById(id);
            return View(e);
        }

        // POST: GuestBook/Delete/5
        [HttpPost]
        [Route("DeleteEntry")]
        public ActionResult DeleteEntry(int id, guestbookentry guest)
        {
            try
            {
                guestbookentry gg = g.FindById(id);
                g.Delete(gg);
                g.Commit();

                return RedirectToAction("GetAllEntries");
            }
            catch
            {
                return View();
            }
        }


        // POST: GuestBook/Edit/5
        [HttpGet]
        [Route("FindGuestBookEntry/{keyword}")]
        public ActionResult FindEntry(string keyword)
        {

               IEnumerable<guestbookentry> listfind= g.GetGuestBookEntryByKeyword(keyword);
                List<guestbookentry> listguest = listfind.ToList();
            return View(listguest);

        }


    }
}
