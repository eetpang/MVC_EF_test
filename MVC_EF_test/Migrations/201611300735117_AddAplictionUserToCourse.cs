namespace MVC_EF_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAplictionUserToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Description", c => c.String());
            AddColumn("dbo.Courses", "DateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "DateEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "InstructorUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Students", "StudentUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Courses", "InstructorUser_Id");
            CreateIndex("dbo.Students", "StudentUser_Id");
            AddForeignKey("dbo.Courses", "InstructorUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Students", "StudentUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StudentUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "InstructorUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "StudentUser_Id" });
            DropIndex("dbo.Courses", new[] { "InstructorUser_Id" });
            DropColumn("dbo.Students", "StudentUser_Id");
            DropColumn("dbo.Courses", "InstructorUser_Id");
            DropColumn("dbo.Courses", "DateEnd");
            DropColumn("dbo.Courses", "DateStart");
            DropColumn("dbo.Courses", "Description");
        }
    }
}
