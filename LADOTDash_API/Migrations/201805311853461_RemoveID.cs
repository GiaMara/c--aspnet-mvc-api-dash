namespace LADOTDash_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BusStops", "BusStopID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Attractions", "BusStopID", "dbo.BusStops");
            DropPrimaryKey("dbo.BusStops");
            DropColumn("dbo.BusStops", "ID");
            AddPrimaryKey("dbo.BusStops", "BusStopID");
            AddForeignKey("dbo.Attractions", "BusStopID", "dbo.BusStops", "BusStopID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BusStops", "BusStopID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Attractions", "BusStopID", "dbo.BusStops");
            DropPrimaryKey("dbo.BusStops");
            AddColumn("dbo.BusStops", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BusStops", "ID");
            AddForeignKey("dbo.Attractions", "BusStopID", "dbo.BusStops", "ID", cascadeDelete: true);
        }
    }
}
