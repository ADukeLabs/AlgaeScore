namespace ASWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Pictures", "ImgURL", c => c.String(nullable: false));
            AddColumn("dbo.Pictures", "Description", c => c.String());
            AddColumn("dbo.Pictures", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pictures", "Updated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pictures", "image_Name");
            DropColumn("dbo.Pictures", "image");
            DropColumn("dbo.Pictures", "image_Description");
            DropColumn("dbo.Pictures", "created_At");
            DropColumn("dbo.Pictures", "updated_At");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pictures", "updated_At", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pictures", "created_At", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pictures", "image_Description", c => c.String());
            AddColumn("dbo.Pictures", "image", c => c.Binary());
            AddColumn("dbo.Pictures", "image_Name", c => c.String());
            DropColumn("dbo.Pictures", "Updated");
            DropColumn("dbo.Pictures", "Created");
            DropColumn("dbo.Pictures", "Description");
            DropColumn("dbo.Pictures", "ImgURL");
            DropColumn("dbo.Pictures", "Name");
        }
    }
}
