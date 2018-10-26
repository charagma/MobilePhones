namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandAndPhotoRequiredColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Photos", "FileName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "FileName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Brands", "Name", c => c.String(maxLength: 100));
        }
    }
}
