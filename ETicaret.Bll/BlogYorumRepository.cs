using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class BlogYorumRepository : BaseRepository<BlogYorum, ETicaretContext>
    public class BlogYorumRepository : BaseRepository<BlogYorum>
    {
        public List<BlogYorum> GetByBlogId(int id)
        {
            //using (context = new ETicaretContext())
            {
                return context.Set<BlogYorum>().Where(x => x.BlogId == id).ToList();
            }
        }
    }
}
