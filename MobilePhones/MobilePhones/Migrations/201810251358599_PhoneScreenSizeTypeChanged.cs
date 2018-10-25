namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneScreenSizeTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Int(nullable: false));
        }
    }
}
