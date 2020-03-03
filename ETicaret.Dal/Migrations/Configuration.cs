namespace ETicaret.Dal.Migrations
{
    using ETicaret.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ETicaret.Dal.EntityFramework.ETicaretContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ETicaret.Dal.EntityFramework.ETicaretContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Kategori.AddOrUpdate(new Kategori { Ad = "Elektronik", IsDelete = false, KayitTarihi = DateTime.Now });
            context.Kategori.AddOrUpdate(new Kategori { Ad = "Mobilya", IsDelete = false, KayitTarihi = DateTime.Now });
            context.Kategori.AddOrUpdate(new Kategori { Ad = "Kitap", IsDelete = false, KayitTarihi = DateTime.Now });
            context.Rol.Add(new Rol { Ad = "Admin", IsDelete = false, KayitTarihi = DateTime.Now });
            context.SaveChanges();
        }
    }
}
