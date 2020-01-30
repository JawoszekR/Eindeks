namespace EIndeks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setUpDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kod = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ocenas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Kurs_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kurs", t => t.Kurs_Id, cascadeDelete: true)
                .Index(t => t.Kurs_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        NrIndeksu = c.Int(nullable: false),
                        DataUrodzenia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ocenas", "Kurs_Id", "dbo.Kurs");
            DropIndex("dbo.Ocenas", new[] { "Kurs_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Ocenas");
            DropTable("dbo.Kurs");
        }
    }
}
