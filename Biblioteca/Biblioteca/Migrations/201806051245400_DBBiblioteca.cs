namespace Biblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBBiblioteca : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        VendedorID = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.VendedorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendedor");
        }
    }
}
