namespace MVC_EF_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentId", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "StudentId");
        }
    }
}
