namespace Estudo.ProjetoMedicinaVet.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ANL_ANIMAIS",
                c => new
                    {
                        ANL_ID = c.Int(nullable: false, identity: true),
                        ANL_NOME = c.String(nullable: false, maxLength: 80),
                        ANL_IDADE = c.Int(),
                        ANL_RACA = c.String(nullable: false, maxLength: 80),
                        ANL_NOMEDONO = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ANL_ID);
            
            CreateTable(
                "dbo.PRO_PRONTUARIO",
                c => new
                    {
                        PRO_ID = c.Int(nullable: false, identity: true),
                        PRO_VETERINARIO = c.String(nullable: false, maxLength: 80),
                        PRO_DATAS = c.String(nullable: false, maxLength: 80),
                        DataAtendimento = c.DateTime(nullable: false),
                        PRO_OBSERVACOES = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.PRO_ID);
            
            CreateTable(
                "dbo.MED_VETERINARIOS",
                c => new
                    {
                        MED_ID = c.Int(nullable: false, identity: true),
                        MED_NOME = c.String(nullable: false, maxLength: 80),
                        MED_NCONSELHO = c.String(nullable: false, maxLength: 50),
                        MED_ESPECIALIDADE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MED_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MED_VETERINARIOS");
            DropTable("dbo.PRO_PRONTUARIO");
            DropTable("dbo.ANL_ANIMAIS");
        }
    }
}
