using ETicaret.Bll;
using ETicaret.Filters;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (UrunRepository repo = new UrunRepository())
            {

                var result = repo.GetByFilter(x => x.IsDelete == false);
             if(result.Count>10)
                    result = repo.GetByFilter(x => x.IsDelete == false).Take(10).ToList();
                   ViewBag.TrendUrunler = result;
                return View(); 
            }
        }
        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult KategorileriGetir()
        {
            //TODO : webservisten getir
            ETicaretWebService.ETicaretWebServiceSoapClient service = new ETicaretWebService.ETicaretWebServiceSoapClient();
            var result =   service.KategorileriGetir();
            List<Kategori> model = new List<Kategori>();
            result.ForEach(x => model.Add(new Kategori { Ad = x.Ad, Id = x.Id, UstKategoriId = x.UstKategoriId }));
            return PartialView(model);
        }

    }
}