namespace DbClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Worker_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Worker_Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.Worker_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkTasks", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.WorkTasks", "Worker_Id", "dbo.Users");
            DropIndex("dbo.WorkTasks", new[] { "Owner_Id" });
            DropIndex("dbo.WorkTasks", new[] { "Worker_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.WorkTasks");
        }
    }
}
