namespace IdeareOrcamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190921_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orcamentos", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orcamentos", "DataEntrega", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orcamentos", "ValorTotal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orcamentos", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Orcamentos", "DataEntrega");
            DropColumn("dbo.Orcamentos", "DataCriacao");
        }
    }
}
