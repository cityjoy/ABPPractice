namespace MyAbpProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Task_Entity1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Tasks");
            AlterColumn("dbo.Tasks", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tasks", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Tasks");
            AlterColumn("dbo.Tasks", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Tasks", "Id");
        }
    }
}
