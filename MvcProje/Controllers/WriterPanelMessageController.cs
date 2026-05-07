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
            var messagevalues = mm.GetListInbox();
            return View(messagevalues);
        }
        public PartialViewResult WriterLeftBarPartial()
        {
            ViewBag.ContactCount = cm.GetList().Count;
            ViewBag.InboxCount = mm.GetListInbox().Count;
            ViewBag.SendboxCount = mm.GetListSendbox().Count;
            return PartialView();
        }
        public ActionResult Sendbox()
        {
            var messagevalue = mm.GetListSendbox();
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
            ValidationResult result = mesagevalidator.Validate(p);
            if (result.IsValid)
            {
                p.SenderMail = "aliyildiz@gmail.com";
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