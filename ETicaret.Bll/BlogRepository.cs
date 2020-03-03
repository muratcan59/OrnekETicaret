using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class BlogRepository : BaseRepository<Blog, ETicaretContext>
    public class BlogRepository : BaseRepository<Blog>
    {
        public List<Blog> GetByCategoryId(int id)
        {
            //using (context = new ETicaretContext())
            {
                return context.Set<Blog>().Where(x => x.KategoriId == id).ToList();
            }
        }
    }
}
