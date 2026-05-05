using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        AdminManager adm =new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            return View();
        }
    }
}