namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contact_date_ekleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contacts", "UserMessage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "UserMessage", c => c.String(maxLength: 500));
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
