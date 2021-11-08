namespace MVCClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Especialidad = c.String(nullable: false, maxLength: 70, unicode: false),
                        NroMatricula = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
