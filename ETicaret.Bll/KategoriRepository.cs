using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class KategoriRepository : BaseRepository<Kategori, ETicaretContext>
    public class KategoriRepository : BaseRepository<Kategori>
    {
        public bool SoftDelete(int id)
        {
          var data=  context.Kategori.Find(id);
            data.IsDelete = true;
         return   base.Update(data);
        }
    }
}
