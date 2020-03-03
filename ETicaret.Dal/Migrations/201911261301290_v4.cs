namespace ETicaret.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urun", "Modeli", c => c.String());
            DropColumn("dbo.Urun", "Model");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urun", "Model", c => c.String());
            DropColumn("dbo.Urun", "Modeli");
        }
    }
}
