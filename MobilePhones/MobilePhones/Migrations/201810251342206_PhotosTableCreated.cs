namespace MobilePhones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotosTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 100),
                        PhoneId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.PhoneId, cascadeDelete: true)
                .Index(t => t.PhoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photos", "PhoneId", "dbo.Phones");
            DropIndex("dbo.Photos", new[] { "PhoneId" });
            DropTable("dbo.Photos");
        }
    }
}
