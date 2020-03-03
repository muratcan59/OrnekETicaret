using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class UrunRepository : BaseRepository<Urun, ETicaretContext>
    public class UrunRepository : BaseRepository<Urun>
    {
        public List<Urun> SearchByCategoryId(int categoryId)
        {
            //using (context = new ETicaretContext())
            {
                return context.Urun.Where(x => x.KategoriId == categoryId).ToList();
            }
        }

  
    }
}
