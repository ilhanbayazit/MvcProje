using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        [Authorize (Roles ="B")]
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult result = categoryvalidator.Validate(p);
            if (result.IsValid)
            {
                cm.AddCategory(p);
                return RedirectToAction("Index");
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
        public ActionResult DeletCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            cm.DeleteCategory(categoryvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.UpdateCategory(p);
            return RedirectToAction("Index");
        }
       
    }
}