namespace WinFormQuanLyNhaHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Full_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        BillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .Index(t => t.BillId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        Total = c.Single(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        CustomerName = c.String(),
                        UserId = c.Int(nullable: false),
                        TableId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tables", t => t.TableId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Image = c.String(),
                        Count = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goods", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BillDetails", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "UserId", "dbo.Users");
            DropForeignKey("dbo.Bills", "TableId", "dbo.Tables");
            DropIndex("dbo.Goods", new[] { "CategoryId" });
            DropIndex("dbo.Bills", new[] { "TableId" });
            DropIndex("dbo.Bills", new[] { "UserId" });
            DropIndex("dbo.BillDetails", new[] { "BillId" });
            DropTable("dbo.Goods");
            DropTable("dbo.Categories");
            DropTable("dbo.Tables");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
        }
    }
}
