namespace ETicaret.Dal.EntityFramework
{
    using ETicaret.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class ETicaretContext : DbContext
    {
        // Your context has been configured to use a 'ETicaretContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ETicaret.Dal.EntityFramework.ETicaretContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ETicaretContext' 
        // connection string in the application configuration file.
        public ETicaretContext()
            : base("name=ETicaretContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ETicaretContext>(new CreateDatabaseIfNotExists<ETicaretContext>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<BlogYorum> BlogYorum { get; set; }
        public virtual DbSet<Fotograf> Fotograf { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<SepetUrun> SepetUrun { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunYorum> UrunYorum { get; set; }
    }

   
}