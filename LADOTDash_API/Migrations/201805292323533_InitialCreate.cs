namespace LADOTDash_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusStops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BusStopID = c.Int(nullable: false),
                        StopLocation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusStops");
        }
    }
}
