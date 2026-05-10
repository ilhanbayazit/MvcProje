namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_image_description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ImageFiles", "ImageDescription", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ImageFiles", "ImageDescription");
        }
    }
}
