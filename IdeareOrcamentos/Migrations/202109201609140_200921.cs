namespace IdeareOrcamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _200921 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orcamentos", "ValorCusto", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orcamentos", "ValorCusto");
        }
    }
}
