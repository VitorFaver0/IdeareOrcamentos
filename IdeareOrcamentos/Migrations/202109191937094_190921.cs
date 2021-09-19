namespace IdeareOrcamentos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190921 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ListaMateriaisOrcamentoes", newName: "ListaMateriaisOrcamentos");
            RenameTable(name: "dbo.Orcamentoes", newName: "Orcamentos");
            AddColumn("dbo.Orcamentos", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orcamentos", "ValorTotal");
            RenameTable(name: "dbo.Orcamentos", newName: "Orcamentoes");
            RenameTable(name: "dbo.ListaMateriaisOrcamentos", newName: "ListaMateriaisOrcamentoes");
        }
    }
}
