using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Track()
        {
            return View();
        }
        public ActionResult Confirmation()
        {
            return View();
        }
    }
}