using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class UrunYorumRepository : BaseRepository<UrunYorum, ETicaretContext>
    public class UrunYorumRepository : BaseRepository<UrunYorum>
    {

        public List<UrunYorum> GetByProductId(int id)
        {
            //using (context = new ETicaretContext())
            {
                return context.Set<UrunYorum>().Where(x => x.UrunId == id).ToList();
            }
        }

    }
}
