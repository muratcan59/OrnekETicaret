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
 //public   class KullaniciRepository : BaseRepository<Kullanici, ETicaretContext>
 public   class KullaniciRepository : BaseRepository<Kullanici>
    {
        public Kullanici Login(string email, string sifre)
        {

            //using (context = new ETicaretContext())
            {

                return context.Set<Kullanici>().Where(x => x.Email == email && x.Sifre == sifre).FirstOrDefault();




            }

        }

        public bool AddRole(int userId, int roleId)
        {
            SqlParameter[] parameters = { new SqlParameter("userId",userId), new SqlParameter("rolId", roleId) };
          int result =  context.Database.ExecuteSqlCommand("insert into RolKullanici (Kullanici_Id, Rol_Id) values (@userId,@rolId)", parameters);
            return result > 0 ? true : false;
        }
    }
}
