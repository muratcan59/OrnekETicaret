using ETicaret.Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detail(int idsi)
        {
            using (UrunRepository repo = new UrunRepository())
            {
                return View(repo.GetById(idsi));
            }
        }
    }
}