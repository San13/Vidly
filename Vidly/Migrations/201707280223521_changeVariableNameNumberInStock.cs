namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeVariableNameNumberInStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NubmerInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NubmerInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
