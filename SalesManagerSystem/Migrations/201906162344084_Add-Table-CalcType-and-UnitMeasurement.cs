namespace SalesManagerSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableCalcTypeandUnitMeasurement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CALC_TYPE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UNIT_MEASUREMENT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KEY_UNIT = c.String(nullable: false, maxLength: 20, unicode: false),
                        DESCRIPTION_UNIT = c.String(nullable: false, maxLength: 50, unicode: false),
                        CALC_TYPE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CALC_TYPE", t => t.CALC_TYPE_ID)
                .Index(t => t.CALC_TYPE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UNIT_MEASUREMENT", "CALC_TYPE_ID", "dbo.CALC_TYPE");
            DropIndex("dbo.UNIT_MEASUREMENT", new[] { "CALC_TYPE_ID" });
            DropTable("dbo.UNIT_MEASUREMENT");
            DropTable("dbo.CALC_TYPE");
        }
    }
}
