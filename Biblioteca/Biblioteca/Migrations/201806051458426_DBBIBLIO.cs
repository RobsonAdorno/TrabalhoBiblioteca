namespace Biblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBBIBLIO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
