namespace LADOTDash_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusStopAttractionVM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusStopAttractionVMs",
                c => new
                    {
                        BusStopID = c.Int(nullable: false, identity: true),
                        StopLocation = c.String(),
                        ImgSrc = c.String(),
                        ImgDescription = c.String(),
                    })
                .PrimaryKey(t => t.BusStopID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusStopAttractionVMs");
        }
    }
}
