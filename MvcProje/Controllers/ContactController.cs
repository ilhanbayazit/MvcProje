using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        MessageManager mm = new MessageManager(new EfMessageDal());
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        //public PartialViewResult LeftBarPartial()
        //{
        //    return PartialView();
        //}
        public PartialViewResult LeftBarPartial()
        {
            ViewBag.ContactCount = cm.GetList().Count;
            ViewBag.InboxCount = mm.GetListInbox().Count;
            ViewBag.SendboxCount = mm.GetListSendbox().Count;

            return PartialView();
        }
    }
}