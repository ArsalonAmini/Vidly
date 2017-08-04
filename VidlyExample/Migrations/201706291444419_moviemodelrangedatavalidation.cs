namespace VidlyExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moviemodelrangedatavalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "StockNumber", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "StockNumber", c => c.Int(nullable: false));
        }
    }
}
