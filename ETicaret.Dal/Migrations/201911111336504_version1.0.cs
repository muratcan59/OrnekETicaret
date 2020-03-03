namespace ETicaret.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icerik = c.String(nullable: false, maxLength: 100),
                        Baslik = c.String(nullable: false, maxLength: 25),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        Baslik = c.String(nullable: false),
                        Icerik = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UstKategoriId = c.Int(),
                        Ad = c.String(nullable: false, maxLength: 25),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.UstKategoriId)
                .Index(t => t.UstKategoriId);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 25),
                        Soyad = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        Telefon = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BlogYorum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        Baslik = c.String(nullable: false, maxLength: 75),
                        Icerik = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blog", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Fotograf",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(nullable: false, maxLength: 250),
                        UrunId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 25),
                        Fiyati = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                        Marka = c.String(nullable: false),
                        Model = c.String(),
                        Stok = c.String(),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.UrunYorum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunId = c.Int(nullable: false),
                        Baslik = c.String(nullable: false, maxLength: 20),
                        Icerik = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Iletisim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 25),
                        Soyad = c.String(nullable: false),
                        Mesaj = c.String(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sepet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KullaniciId = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.SepetUrun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SepetId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Miktar = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sepet", t => t.SepetId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SepetId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdresId = c.Int(nullable: false),
                        SepetId = c.Int(nullable: false),
                        Tutar = c.String(),
                        TeslimTarihi = c.DateTime(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.AdresId, cascadeDelete: true)
                .ForeignKey("dbo.Sepet", t => t.SepetId, cascadeDelete: true)
                .Index(t => t.AdresId)
                .Index(t => t.SepetId);
            
            CreateTable(
                "dbo.RolKullanici",
                c => new
                    {
                        Rol_Id = c.Int(nullable: false),
                        Kullanici_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rol_Id, t.Kullanici_Id })
                .ForeignKey("dbo.Rol", t => t.Rol_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_Id, cascadeDelete: true)
                .Index(t => t.Rol_Id)
                .Index(t => t.Kullanici_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparis", "SepetId", "dbo.Sepet");
            DropForeignKey("dbo.Siparis", "AdresId", "dbo.Adres");
            DropForeignKey("dbo.SepetUrun", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.SepetUrun", "SepetId", "dbo.Sepet");
            DropForeignKey("dbo.Sepet", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.Fotograf", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.UrunYorum", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.BlogYorum", "BlogId", "dbo.Blog");
            DropForeignKey("dbo.Blog", "KullaniciId", "dbo.Kullanici");
            DropForeignKey("dbo.RolKullanici", "Kullanici_Id", "dbo.Kullanici");
            DropForeignKey("dbo.RolKullanici", "Rol_Id", "dbo.Rol");
            DropForeignKey("dbo.Blog", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Kategori", "UstKategoriId", "dbo.Kategori");
            DropIndex("dbo.RolKullanici", new[] { "Kullanici_Id" });
            DropIndex("dbo.RolKullanici", new[] { "Rol_Id" });
            DropIndex("dbo.Siparis", new[] { "SepetId" });
            DropIndex("dbo.Siparis", new[] { "AdresId" });
            DropIndex("dbo.SepetUrun", new[] { "UrunId" });
            DropIndex("dbo.SepetUrun", new[] { "SepetId" });
            DropIndex("dbo.Sepet", new[] { "KullaniciId" });
            DropIndex("dbo.UrunYorum", new[] { "UrunId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.Fotograf", new[] { "UrunId" });
            DropIndex("dbo.BlogYorum", new[] { "BlogId" });
            DropIndex("dbo.Kategori", new[] { "UstKategoriId" });
            DropIndex("dbo.Blog", new[] { "KullaniciId" });
            DropIndex("dbo.Blog", new[] { "KategoriId" });
            DropTable("dbo.RolKullanici");
            DropTable("dbo.Siparis");
            DropTable("dbo.SepetUrun");
            DropTable("dbo.Sepet");
            DropTable("dbo.Iletisim");
            DropTable("dbo.UrunYorum");
            DropTable("dbo.Urun");
            DropTable("dbo.Fotograf");
            DropTable("dbo.BlogYorum");
            DropTable("dbo.Rol");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Kategori");
            DropTable("dbo.Blog");
            DropTable("dbo.Adres");
        }
    }
}
