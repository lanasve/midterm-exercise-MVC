namespace DotNetAssesment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Movie1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BillingAddress = c.String(),
                        BillingZip = c.Int(nullable: false),
                        BillingCity = c.String(),
                        DelieveryAddress = c.String(),
                        DelieveryZip = c.Int(nullable: false),
                        DelieveryCity = c.String(),
                        EmailAddress = c.String(),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderRow",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Director = c.String(),
                        ReleaseYear = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderRow", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderRow", "MovieId", "dbo.Movie");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropIndex("dbo.OrderRow", new[] { "MovieId" });
            DropIndex("dbo.OrderRow", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropTable("dbo.Movie");
            DropTable("dbo.OrderRow");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
