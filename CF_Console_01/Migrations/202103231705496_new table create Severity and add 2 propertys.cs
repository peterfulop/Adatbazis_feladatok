namespace CF_Console_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtablecreateSeverityandadd2propertys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Severities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.ToDoItems", "Severity_id", c => c.Int());
            CreateIndex("dbo.ToDoItems", "Severity_id");
            AddForeignKey("dbo.ToDoItems", "Severity_id", "dbo.Severities", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoItems", "Severity_id", "dbo.Severities");
            DropIndex("dbo.ToDoItems", new[] { "Severity_id" });
            DropColumn("dbo.ToDoItems", "Severity_id");
            DropTable("dbo.Severities");
        }
    }
}
