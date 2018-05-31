namespace LADOTDash_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAttractionID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Attractions");
            DropColumn("dbo.Attractions", "ID");
            AddColumn("dbo.Attractions", "AttractionID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Attractions", "AttractionID");

        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Attractions");
            DropColumn("dbo.Attractions", "AttractionID");
            AddColumn("dbo.Attractions", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Attractions", "ID");
        }
    }
}
