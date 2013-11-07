namespace RGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class funcionazure : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ciudad", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Rendicion", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Factura", "RendicionID", "dbo.Rendicion");
            DropForeignKey("dbo.Moneda", "PaisID", "dbo.Pais");
            DropIndex("dbo.Ciudad", new[] { "PaisID" });
            DropIndex("dbo.Rendicion", new[] { "UserId" });
            DropIndex("dbo.Factura", new[] { "RendicionID" });
            DropIndex("dbo.Moneda", new[] { "PaisID" });
            AddForeignKey("dbo.Ciudad", "PaisID", "dbo.Pais", "PaisID");
            AddForeignKey("dbo.Rendicion", "UserId", "dbo.UserProfile", "UserId");
            AddForeignKey("dbo.Factura", "RendicionID", "dbo.Rendicion", "RendicionID");
            AddForeignKey("dbo.Moneda", "PaisID", "dbo.Pais", "PaisID");
            CreateIndex("dbo.Ciudad", "PaisID");
            CreateIndex("dbo.Rendicion", "UserId");
            CreateIndex("dbo.Factura", "RendicionID");
            CreateIndex("dbo.Moneda", "PaisID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Moneda", new[] { "PaisID" });
            DropIndex("dbo.Factura", new[] { "RendicionID" });
            DropIndex("dbo.Rendicion", new[] { "UserId" });
            DropIndex("dbo.Ciudad", new[] { "PaisID" });
            DropForeignKey("dbo.Moneda", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Factura", "RendicionID", "dbo.Rendicion");
            DropForeignKey("dbo.Rendicion", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Ciudad", "PaisID", "dbo.Pais");
            CreateIndex("dbo.Moneda", "PaisID");
            CreateIndex("dbo.Factura", "RendicionID");
            CreateIndex("dbo.Rendicion", "UserId");
            CreateIndex("dbo.Ciudad", "PaisID");
            AddForeignKey("dbo.Moneda", "PaisID", "dbo.Pais", "PaisID", cascadeDelete: true);
            AddForeignKey("dbo.Factura", "RendicionID", "dbo.Rendicion", "RendicionID", cascadeDelete: true);
            AddForeignKey("dbo.Rendicion", "UserId", "dbo.UserProfile", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Ciudad", "PaisID", "dbo.Pais", "PaisID", cascadeDelete: true);
        }
    }
}
