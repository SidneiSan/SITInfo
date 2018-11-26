namespace MyFactory.SITInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chamados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chamado",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EmailUsuario = c.String(maxLength: 100, unicode: false),
                        DataAbertura = c.DateTime(nullable: false),
                        Prioridade = c.Int(nullable: false),
                        Titulo = c.String(maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        DataFechamento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chamado");
        }
    }
}
