namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneDecimalColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Phones", "Price", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Phones", "ScreenSize", c => c.Double(nullable: false));
            AlterColumn("dbo.Phones", "Name", c => c.String(maxLength: 100));
        }
    }
}
