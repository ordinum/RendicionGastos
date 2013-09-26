namespace RGastos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rendicion", "VisitaID", "dbo.Visita");
            DropIndex("dbo.Rendicion", new[] { "VisitaID" });
            DropTable("dbo.Visita");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Visita",
                c => new
                    {
                        VisitaID = c.Int(nullable: false, identity: true),
                        FechaIngreso = c.DateTime(nullable: false),
                        FechaPlanificada = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        EstadoVisitaID = c.Int(nullable: false),
                        LineaProductoID = c.Int(nullable: false),
                        TipoVisitaID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaID);
            
            CreateIndex("dbo.Rendicion", "VisitaID");
            AddForeignKey("dbo.Rendicion", "VisitaID", "dbo.Visita", "VisitaID", cascadeDelete: true);
        }
    }
}
