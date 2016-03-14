namespace MagicReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        name = c.String(nullable: false),
                        conManaCost = c.Int(nullable: false),
                        manaCost = c.String(nullable: false),
                        rulesText = c.String(),
                        flavorText = c.String(),
                        isLegendary = c.Boolean(),
                        isLegendary1 = c.Boolean(),
                        isArtifact = c.Boolean(),
                        isEnchantment = c.Boolean(),
                        power = c.Int(),
                        toughness = c.Int(),
                        isLegendary2 = c.Boolean(),
                        isInstant = c.Boolean(),
                        isLegendary3 = c.Boolean(),
                        isBasic = c.Boolean(),
                        planeswalkerType = c.Int(),
                        loyaltyCounters = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        cardID = c.String(maxLength: 128),
                        userID = c.Int(nullable: false),
                        reviewText = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cards", t => t.cardID)
                .ForeignKey("dbo.Users", t => t.userID, cascadeDelete: true)
                .Index(t => t.cardID)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "userID", "dbo.Users");
            DropForeignKey("dbo.Reviews", "cardID", "dbo.Cards");
            DropIndex("dbo.Reviews", new[] { "userID" });
            DropIndex("dbo.Reviews", new[] { "cardID" });
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.Cards");
        }
    }
}
