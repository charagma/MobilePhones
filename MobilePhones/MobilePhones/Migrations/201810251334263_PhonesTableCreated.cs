namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhonesTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Dimensions = c.String(maxLength: 100),
                        Weight = c.Int(nullable: false),
                        ScreenSize = c.Int(nullable: false),
                        Resolution = c.String(maxLength: 100),
                        Processor = c.String(maxLength: 100),
                        Memory = c.String(maxLength: 100),
                        OS = c.String(maxLength: 100),
                        Price = c.Int(nullable: false),
                        Video = c.String(maxLength: 100),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "BrandId", "dbo.Brands");
            DropIndex("dbo.Phones", new[] { "BrandId" });
            DropTable("dbo.Phones");
        }
    }
}
