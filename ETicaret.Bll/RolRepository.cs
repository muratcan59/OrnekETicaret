using ETicaret.Dal.EntityFramework;
using ETicaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Bll
{
    //public class RolRepository : BaseRepository<Rol, ETicaretContext>
    public class RolRepository : BaseRepository<Rol>
    {
        public List<Rol> GetRolesByUserId(int id)
        {
            //using (context = new ETicaretContext())
            {
                return context.Set<Rol>().Where(x => x.Kullanicilari.Contains(new Kullanici { Id = id })).ToList();
            }
        }
    }
}
