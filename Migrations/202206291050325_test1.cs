namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyerId = c.Int(nullable: false),
                        OrdersId = c.Int(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.BuyerId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrdersId, cascadeDelete: true)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId, cascadeDelete: true)
                .Index(t => t.BuyerId)
                .Index(t => t.OrdersId)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        phone = c.String(),
                        RoleId = c.Int(nullable: false),
                        email = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        NoOfProducts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.BuyerId, cascadeDelete: true)
                .Index(t => t.BuyerId);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        OrderId = c.Int(nullable: false),
                        Orders_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Orders_Id)
                .Index(t => t.Orders_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        desc = c.String(),
                        price = c.Int(nullable: false),
                        rating = c.Double(nullable: false),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStatus", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderHistories", "OrderStatusId", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderStatus", "Orders_Id", "dbo.Orders");
            DropForeignKey("dbo.OrderHistories", "OrdersId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "BuyerId", "dbo.Users");
            DropForeignKey("dbo.OrderHistories", "BuyerId", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.ProductStatus", new[] { "ProductId" });
            DropIndex("dbo.OrderStatus", new[] { "Orders_Id" });
            DropIndex("dbo.Orders", new[] { "BuyerId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.OrderHistories", new[] { "OrderStatusId" });
            DropIndex("dbo.OrderHistories", new[] { "OrdersId" });
            DropIndex("dbo.OrderHistories", new[] { "BuyerId" });
            DropTable("dbo.ProductStatus");
            DropTable("dbo.Products");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.Orders");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.OrderHistories");
        }
    }
}
