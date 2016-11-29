namespace MVC_EF_test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLengthConstraint : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "Id", c => c.Short(nullable: false, identity: true));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 255));
            AddPrimaryKey("dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "Id");
        }
    }
}
