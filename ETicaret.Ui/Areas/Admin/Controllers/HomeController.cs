using ETicaret.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [AdminLoginFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}