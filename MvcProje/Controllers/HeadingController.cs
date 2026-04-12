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
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecatagory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();

            List<SelectListItem> valuesWriter = (from x in wm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.WriterName + " " + x.WriterSurname,
                                                     Value = x.WriterID.ToString()
                                                 }).ToList();
            ViewBag.vlc = valuecatagory;
            ViewBag.vlw = valuesWriter;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {

            p.HeadingDate = DateTime.Now;
            hm.AddHeading(p);
            return RedirectToAction("Index");

        }
        

    }
}