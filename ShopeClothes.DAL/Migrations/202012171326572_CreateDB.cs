namespace ShopeClothes.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(),
                        ProductCode = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 2000),
                        Category_Id = c.Int(),
                        Color_Id = c.Int(),
                        Manufacturer_Id = c.Int(),
                        Style_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .ForeignKey("dbo.Color", t => t.Color_Id)
                .ForeignKey("dbo.Manufacturer", t => t.Manufacturer_Id)
                .ForeignKey("dbo.Style", t => t.Style_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Manufacturer_Id)
                .Index(t => t.Style_Id);
            
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoodsComposition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Percent = c.Double(),
                        Composition_Id = c.Int(),
                        Goods_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Composition", t => t.Composition_Id)
                .ForeignKey("dbo.Goods", t => t.Goods_Id)
                .Index(t => t.Composition_Id)
                .Index(t => t.Goods_Id);
            
            CreateTable(
                "dbo.Composition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoodsImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Goods_Id = c.Int(),
                        ImageSRC_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Goods_Id)
                .ForeignKey("dbo.ImageSRC", t => t.ImageSRC_Id)
                .Index(t => t.Goods_Id)
                .Index(t => t.ImageSRC_Id);
            
            CreateTable(
                "dbo.ImageSRC",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Binary(nullable: false),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GoodsSize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Goods_Id = c.Int(),
                        Size_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Goods_Id)
                .ForeignKey("dbo.Size", t => t.Size_Id)
                .Index(t => t.Goods_Id)
                .Index(t => t.Size_Id);
            
            CreateTable(
                "dbo.Size",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(),
                        Goods_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Goods_Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .Index(t => t.Goods_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DeliveryAddress = c.String(maxLength: 500),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Style",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goods", "Style_Id", "dbo.Style");
            DropForeignKey("dbo.Order", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.OrderList", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.OrderList", "Goods_Id", "dbo.Goods");
            DropForeignKey("dbo.Goods", "Manufacturer_Id", "dbo.Manufacturer");
            DropForeignKey("dbo.GoodsSize", "Size_Id", "dbo.Size");
            DropForeignKey("dbo.GoodsSize", "Goods_Id", "dbo.Goods");
            DropForeignKey("dbo.GoodsImage", "ImageSRC_Id", "dbo.ImageSRC");
            DropForeignKey("dbo.GoodsImage", "Goods_Id", "dbo.Goods");
            DropForeignKey("dbo.GoodsComposition", "Goods_Id", "dbo.Goods");
            DropForeignKey("dbo.GoodsComposition", "Composition_Id", "dbo.Composition");
            DropForeignKey("dbo.Goods", "Color_Id", "dbo.Color");
            DropForeignKey("dbo.Goods", "Category_Id", "dbo.Category");
            DropIndex("dbo.Order", new[] { "Status_Id" });
            DropIndex("dbo.OrderList", new[] { "Order_Id" });
            DropIndex("dbo.OrderList", new[] { "Goods_Id" });
            DropIndex("dbo.GoodsSize", new[] { "Size_Id" });
            DropIndex("dbo.GoodsSize", new[] { "Goods_Id" });
            DropIndex("dbo.GoodsImage", new[] { "ImageSRC_Id" });
            DropIndex("dbo.GoodsImage", new[] { "Goods_Id" });
            DropIndex("dbo.GoodsComposition", new[] { "Goods_Id" });
            DropIndex("dbo.GoodsComposition", new[] { "Composition_Id" });
            DropIndex("dbo.Goods", new[] { "Style_Id" });
            DropIndex("dbo.Goods", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Goods", new[] { "Color_Id" });
            DropIndex("dbo.Goods", new[] { "Category_Id" });
            DropTable("dbo.Style");
            DropTable("dbo.Status");
            DropTable("dbo.Order");
            DropTable("dbo.OrderList");
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Size");
            DropTable("dbo.GoodsSize");
            DropTable("dbo.ImageSRC");
            DropTable("dbo.GoodsImage");
            DropTable("dbo.Composition");
            DropTable("dbo.GoodsComposition");
            DropTable("dbo.Color");
            DropTable("dbo.Goods");
            DropTable("dbo.Category");
        }
    }
}
