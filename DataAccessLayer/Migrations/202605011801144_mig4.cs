namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "UserName", c => c.String(maxLength: 50));
            DropColumn("dbo.Contacts", "UserSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "UserSurname", c => c.String(maxLength: 50));
            DropColumn("dbo.Contacts", "UserName");
        }
    }
}
