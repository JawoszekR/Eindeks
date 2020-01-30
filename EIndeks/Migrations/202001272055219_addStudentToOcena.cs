namespace EIndeks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentToOcena : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ocenas", "Student_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Ocenas", "Student_Id");
            AddForeignKey("dbo.Ocenas", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ocenas", "Student_Id", "dbo.Students");
            DropIndex("dbo.Ocenas", new[] { "Student_Id" });
            DropColumn("dbo.Ocenas", "Student_Id");
        }
    }
}
