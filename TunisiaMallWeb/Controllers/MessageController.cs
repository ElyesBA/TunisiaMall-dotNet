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
        private static int idCurrentUser = 1;
        // GET: Message
        [Route("Inbox")]
        public ActionResult Index()
        {
            List<message> listMessages = messageService.getMessagesForUser(idCurrentUser);
            return View(listMessages);
        }

        // GET: Message/Read/5
        [Route("Inbox/{idUser}")]
        public ActionResult Discussion(int idUser)
        {
            List<message> messagesList = messageService.getConversation(idCurrentUser, idUser);
            if (messagesList.Count > 0)
            {
                ViewBag.idReceiver = idUser;
                return View(messagesList);
            }
            else
            {
                return RedirectToAction("Index");
            }
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
            int idUser = int.Parse(collection["idUser"]);
            string text = collection["messageText"];
            messageService.sendMessage(idCurrentUser, idUser, text);
            return RedirectToAction("Discussion", new { idUser = idUser });
        }

        // POST: Message/Delete/5
        [HttpPost]
        [Route("Message/Delete/{idUser}")]
        public ActionResult Delete(int idUser)
        {
            messageService.deleteConversation(idCurrentUser, idUser);
            return RedirectToAction("Index");
        }
    }
}
