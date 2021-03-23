namespace CF_Console_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToDoItemstableClosedtonullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoItems", "Closed", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToDoItems", "Closed", c => c.DateTime(nullable: false));
        }
    }
}
