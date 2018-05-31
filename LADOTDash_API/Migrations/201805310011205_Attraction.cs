namespace LADOTDash_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Attraction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attractions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BusStopID = c.Int(nullable: false),
                        ImgSrc = c.String(),
                        ImgDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BusStops", t => t.BusStopID, cascadeDelete: true)
                .Index(t => t.BusStopID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attractions", "BusStopID", "dbo.BusStops");
            DropIndex("dbo.Attractions", new[] { "BusStopID" });
            DropTable("dbo.Attractions");
        }
    }
}
