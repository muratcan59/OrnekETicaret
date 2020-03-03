using ETicaret.Bll;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ETicaret.WebService
{
    /// <summary>
    /// Summary description for ETicaretWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ETicaretWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<KategorilerResult> KategorileriGetir()
        {
            KategoriRepository repo = new KategoriRepository();
            var data = repo.GetAll();
            List<KategorilerResult> kategoriler = new List<KategorilerResult>();
            data.ForEach(x => kategoriler.Add(new KategorilerResult { Id = x.Id, Ad = x.Ad, UstKategoriId = x.UstKategoriId }));
            return kategoriler;
            //return new List<Kategori>();
        }
        public class KategorilerResult
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public int? UstKategoriId { get; set; }
        }
    }
}
