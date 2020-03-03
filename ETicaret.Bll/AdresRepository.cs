using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
  //public  class AdresRepository : BaseRepository<Adres, ETicaretContext>
  public  class AdresRepository : BaseRepository<Adres>
    {
        public List<Adres>  SearchByTitle(string baslik)
        {
            //using (context = new ETicaretContext())
            {
                return context.Adres.Where(x => x.Baslik == baslik).ToList();
            }
        }
    }
}
