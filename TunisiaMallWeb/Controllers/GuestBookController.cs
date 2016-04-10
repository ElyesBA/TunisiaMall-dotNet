using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service;

namespace TunisiaMallWeb.Controllers
{
    public class GuestBookController : Controller
    {

        GuestBookService g = new GuestBookService();


        // GET: GuestBook
        public ActionResult Index()
        {
            return View();
        }

        // GET: GuestBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GuestBook/Create
        [Route("CreateGuestBookEntry")]
        public ActionResult CreateTest()
        {
           
            return View();
        }

        // POST: GuestBook/Create
        
        [HttpPost]
       
        public ActionResult CreateGuestBookEntry(FormCollection collection, gestbookentry entry)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GuestBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GuestBook/Edit/5
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

        // GET: GuestBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GuestBook/Delete/5
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
