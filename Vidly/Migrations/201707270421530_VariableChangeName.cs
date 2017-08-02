namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariableChangeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Genres", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Type", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Genres", "Name");
        }
    }
}
