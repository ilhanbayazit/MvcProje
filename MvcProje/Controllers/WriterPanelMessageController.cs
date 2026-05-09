using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator mesagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            string writermailinfo = (string)Session["WriterMail"];
            var messagevalues = mm.GetListInbox(writermailinfo);
            return View(messagevalues);
        }
        public PartialViewResult WriterLeftBarPartial()
        {

            string writermailinfo = (string)Session["WriterMail"];
            ViewBag.ContactCount = cm.GetList().Count;
            ViewBag.InboxCount = mm.GetListInbox(writermailinfo).Count;
            ViewBag.SendboxCount = mm.GetListSendbox(writermailinfo).Count;
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            string writermailinfo = (string)Session["WriterMail"];
            var messagevalue = mm.GetListSendbox(writermailinfo);
            return View(messagevalue);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult result = mesagevalidator.Validate(p);
            if (result.IsValid)
            {
                p.SenderMail = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.AddMessage(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}