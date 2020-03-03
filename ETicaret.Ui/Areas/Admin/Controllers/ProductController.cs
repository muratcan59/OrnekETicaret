using ETicaret.Bll;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Ekle()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var result = repo.GetByFilter(x => x.IsDelete == false).ToList();
                ViewBag.Kategoriler = result;
                return View();

            }
        }
        [HttpPost]
        public ActionResult Ekle(Urun model, HttpPostedFileBase foto)
        {
            model.IsDelete = false;
            model.KayitTarihi = DateTime.Now;
            using (UrunRepository repo = new UrunRepository())
            {
                var result = repo.Add(model);
                TempData["Mesaj"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Ürün eklendi." } } : new TempDataDictionary { { "class", "alert-danger" }, { "Msg", "Ürün eklenemedi." } };
                if (foto != null)
                {
                    string yol = Guid.NewGuid().ToString().Replace("-", "") + "." + foto.FileName.Split('.')[1];
                    string path = Path.Combine(Server.MapPath("~/Files"), Path.GetFileName(yol));
                    foto.SaveAs(path);
                    FotografRepository fRepo = new FotografRepository();
                    fRepo.Add(new Fotograf { IsDelete = false, KayitTarihi = DateTime.Now, Url = "~/Files/"+ yol, UrunId = model.Id });
                }
                return RedirectToAction(nameof(Ekle));
            }
        }
    }
}