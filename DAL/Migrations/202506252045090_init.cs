namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        TargetAmount = c.Double(nullable: false),
                        RaisedAmount = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        DonationDate = c.DateTime(nullable: false),
                        DonerId = c.Int(nullable: false),
                        CampaignId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campaigns", t => t.CampaignId, cascadeDelete: true)
                .ForeignKey("dbo.Doners", t => t.DonerId, cascadeDelete: true)
                .Index(t => t.DonerId)
                .Index(t => t.CampaignId);
            
            CreateTable(
                "dbo.Doners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DName = c.String(nullable: false),
                        DPass = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        TotalDonatedAmount = c.Double(nullable: false),
                        LastDonationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donations", "DonerId", "dbo.Doners");
            DropForeignKey("dbo.Donations", "CampaignId", "dbo.Campaigns");
            DropIndex("dbo.Donations", new[] { "CampaignId" });
            DropIndex("dbo.Donations", new[] { "DonerId" });
            DropTable("dbo.Doners");
            DropTable("dbo.Donations");
            DropTable("dbo.Campaigns");
        }
    }
}
