namespace IdeareOrcamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _200921_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orcamentos", "NomeProjeto", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orcamentos", "NomeProjeto", c => c.Int(nullable: false));
        }
    }
}
