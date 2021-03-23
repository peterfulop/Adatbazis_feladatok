namespace CF_Console_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setFKTodoItemtableanddefaultproperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDoItems", "Severity_id", "dbo.Severities");
            DropIndex("dbo.ToDoItems", new[] { "Severity_id" });
            RenameColumn(table: "dbo.ToDoItems", name: "Severity_id", newName: "SeverityID");
            AlterColumn("dbo.ToDoItems", "SeverityID", c => c.Int(nullable: false));
            CreateIndex("dbo.ToDoItems", "SeverityID");
            AddForeignKey("dbo.ToDoItems", "SeverityID", "dbo.Severities", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoItems", "SeverityID", "dbo.Severities");
            DropIndex("dbo.ToDoItems", new[] { "SeverityID" });
            AlterColumn("dbo.ToDoItems", "SeverityID", c => c.Int());
            RenameColumn(table: "dbo.ToDoItems", name: "SeverityID", newName: "Severity_id");
            CreateIndex("dbo.ToDoItems", "Severity_id");
            AddForeignKey("dbo.ToDoItems", "Severity_id", "dbo.Severities", "id");
        }
    }
}
