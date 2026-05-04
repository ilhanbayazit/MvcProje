using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManeger ifm = new ImageFileManeger(new EfImageFileDal());
        public ActionResult Index()
        {
            var files =ifm.GetList();
            return View(files);
        }
    }
}