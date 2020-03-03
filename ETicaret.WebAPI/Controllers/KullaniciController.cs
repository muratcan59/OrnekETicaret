using ETicaret.Bll;
using ETicaret.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace ETicaret.WebAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class KullaniciController : ApiController
    {
        // GET: api/Kullanici
        public string Get()
        {
            KullaniciRepository repo = new KullaniciRepository();
           List<Kullanici> data= repo.GetAll();
            string veri = JsonConvert.SerializeObject(data);
            return veri;
        }
 

        // GET: api/Kullanici/5
        public Kullanici Get(int id)
        {
            KullaniciRepository repo = new KullaniciRepository();
         return  repo.GetById(id);
        }

        // POST: api/Kullanici
        public bool Post(Kullanici data)
        {
            KullaniciRepository repo = new KullaniciRepository();
            data.KayitTarihi = DateTime.Now;
             return  repo.Add(data);
        }

        // PUT: api/Kullanici/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Kullanici/5
        public void Delete(int id)
        {
        }
    }
}
