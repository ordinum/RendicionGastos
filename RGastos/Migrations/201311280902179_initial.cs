namespace RGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudad",
                c => new
                    {
                        CiudadID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        PaisID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CiudadID)
                .ForeignKey("dbo.Pais", t => t.PaisID)
                .Index(t => t.PaisID);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        PaisID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PaisID);
            
            CreateTable(
                "dbo.Rendicion",
                c => new
                    {
                        RendicionID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Gasto = c.Double(nullable: false),
                        Observacion = c.String(nullable: false),
                        VisitaID = c.Int(nullable: false),
                        AprobadorID = c.Int(nullable: false),
                        RendicionStatusID = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Pais_PaisID = c.Int(),
                    })
                .PrimaryKey(t => t.RendicionID)
                .ForeignKey("dbo.Aprobador", t => t.AprobadorID)
                .ForeignKey("dbo.RendicionStatus", t => t.RendicionStatusID)
                .ForeignKey("dbo.UserProfile", t => t.UserId)
                .ForeignKey("dbo.Pais", t => t.Pais_PaisID)
                .Index(t => t.AprobadorID)
                .Index(t => t.RendicionStatusID)
                .Index(t => t.UserId)
                .Index(t => t.Pais_PaisID);
            
            CreateTable(
                "dbo.Aprobador",
                c => new
                    {
                        AprobadorID = c.Int(nullable: false, identity: true),
                        ApproverName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AprobadorID);
            
            CreateTable(
                "dbo.RendicionStatus",
                c => new
                    {
                        RendicionStatusID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RendicionStatusID);
            
         
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaID = c.Int(nullable: false, identity: true),
                        NumeroFactura = c.String(nullable: false),
                        RutEmisor = c.String(nullable: false),
                        NombreEmisor = c.String(nullable: false),
                        FechaEmision = c.DateTime(nullable: false),
                        ValorNeto = c.Double(nullable: false),
                        RendicionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacturaID)
                .ForeignKey("dbo.Rendicion", t => t.RendicionID)
                .Index(t => t.RendicionID);
            
            CreateTable(
                "dbo.Moneda",
                c => new
                    {
                        MonedaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        ValorCLP = c.Double(nullable: false),
                        PaisID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonedaID)
                .ForeignKey("dbo.Pais", t => t.PaisID)
                .Index(t => t.PaisID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Moneda", new[] { "PaisID" });
            DropIndex("dbo.Factura", new[] { "RendicionID" });
            DropIndex("dbo.Rendicion", new[] { "Pais_PaisID" });
            DropIndex("dbo.Rendicion", new[] { "UserId" });
            DropIndex("dbo.Rendicion", new[] { "RendicionStatusID" });
            DropIndex("dbo.Rendicion", new[] { "AprobadorID" });
            DropIndex("dbo.Ciudad", new[] { "PaisID" });
            DropForeignKey("dbo.Moneda", "PaisID", "dbo.Pais");
            DropForeignKey("dbo.Factura", "RendicionID", "dbo.Rendicion");
            DropForeignKey("dbo.Rendicion", "Pais_PaisID", "dbo.Pais");
            DropForeignKey("dbo.Rendicion", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.Rendicion", "RendicionStatusID", "dbo.RendicionStatus");
            DropForeignKey("dbo.Rendicion", "AprobadorID", "dbo.Aprobador");
            DropForeignKey("dbo.Ciudad", "PaisID", "dbo.Pais");
            DropTable("dbo.Moneda");
            DropTable("dbo.Factura");
            DropTable("dbo.UserProfile");
            DropTable("dbo.RendicionStatus");
            DropTable("dbo.Aprobador");
            DropTable("dbo.Rendicion");
            DropTable("dbo.Pais");
            DropTable("dbo.Ciudad");
        }
    }
}
