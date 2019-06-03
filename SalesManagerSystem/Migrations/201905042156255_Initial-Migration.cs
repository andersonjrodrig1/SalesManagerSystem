namespace SalesManagerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        USER_NAME = c.String(nullable: false, maxLength: 50, unicode: false),
                        USER_LOGIN = c.String(nullable: false, maxLength: 30, unicode: false),
                        USER_PASSWORD = c.String(nullable: false, maxLength: 15, unicode: false),
                        USER_TYPE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.USER_TYPE", t => t.USER_TYPE_ID)
                .Index(t => t.USER_TYPE_ID);
            
            CreateTable(
                "dbo.USER_TYPE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USER", "USER_TYPE_ID", "dbo.USER_TYPE");
            DropIndex("dbo.USER", new[] { "USER_TYPE_ID" });
            DropTable("dbo.USER_TYPE");
            DropTable("dbo.USER");
        }
    }
}
