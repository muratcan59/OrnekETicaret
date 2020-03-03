using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class FotografRepository : BaseRepository<Fotograf, ETicaretContext>
    public class FotografRepository : BaseRepository<Fotograf>
    {

        public List<Fotograf> GetByProductId(int id)
        {
            //using (context = new ETicaretContext())
            {

                return context.Set<Fotograf>().Where(x => x.UrunId == id).ToList();
            }
        }
    }
}
