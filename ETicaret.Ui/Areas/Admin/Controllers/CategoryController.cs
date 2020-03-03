using ETicaret.Bll;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Areas.Admin.Controllers
{
    [Route("Admin")]
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        public ActionResult Ekle()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var result = repo.GetByFilter(x=> x.IsDelete==false).ToList();
                ViewBag.Kategoriler = result;
                return View();

            }
        }

        [HttpPost]
        public ActionResult Ekle(Kategori model)
        {
            model.IsDelete = false;
            model.KayitTarihi = DateTime.Now;
            KategoriRepository repo = new KategoriRepository();
            bool result = repo.Add(model);
            TempData["Mesaj"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Kategori eklendi." } } : new TempDataDictionary { { "class", "alert-danger" }, { "Msg", "Kategori eklenemedi." } };

            return RedirectToAction(nameof(Ekle));
        }

        public ActionResult Listele()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var result = repo.GetByFilter(x => x.IsDelete == false).ToList();
                return View(result);
            }
        }

        public ActionResult Detay(int id)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var result = repo.GetById(id);
                return View(result);
            }
        }

        public ActionResult Duzenle(int id)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                ViewBag.Kategoriler = repo.GetByFilter(x=> x.IsDelete==false);
                var result = repo.GetById(id);
                return View(result);
            }
        }

        [HttpPost]
        public ActionResult Duzenle(Kategori model)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var result = repo.Update(model);
                TempData["Mesaj"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Kategori eklendi." } } : new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Kategori eklendi." } };
                return RedirectToAction(nameof(Listele));

            }
        }

        public ActionResult Sil(int id)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                bool result = repo.SoftDelete(id);
                TempData["Mesaj"] = result ? new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Kategori eklendi." } } : new TempDataDictionary { { "class", "alert-success" }, { "Msg", "Kategori eklendi." } };
                return RedirectToAction(nameof(Listele));

            }
        }
    }
}