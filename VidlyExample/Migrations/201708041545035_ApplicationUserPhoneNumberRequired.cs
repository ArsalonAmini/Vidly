namespace VidlyExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationUserPhoneNumberRequired : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}
