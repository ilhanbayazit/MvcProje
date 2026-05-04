namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_imagefile_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImageFileID = c.Int(nullable: false, identity: true),
                        ImageFileName = c.String(maxLength: 100),
                        ImageFilePath = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ImageFileID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageFiles");
        }
    }
}
