using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Controllers
{
    public class MessageController : Controller
    {
        private IMessageService messageService = new MessageService();
        private static int idUser = 1;
        // GET: Message
        public ActionResult Index()
        {
            List<message> listMessages = messageService.getMessagesForUser(idUser);
            return View(listMessages);
        }

        // GET: Message/Read/5
        public ActionResult Read(int id)
        {
            return View();
        }

        // GET: Message/Send
        public ActionResult Send()
        {
            return View();
        }

        // POST: Message/Send
        [HttpPost]
        public ActionResult Send(FormCollection collection)
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

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
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
