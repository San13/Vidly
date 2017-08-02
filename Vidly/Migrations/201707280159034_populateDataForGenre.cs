namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateDataForGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id,Name) values (1,'Comedy')");
            Sql("Insert into Genres (Id,Name) values (2,'Action')");
            Sql("Insert into Genres (Id,Name) values (3,'Family')");
            Sql("Insert into Genres (Id,Name) values (4,'Romance')");
            Sql("Insert into Genres (Id,Name) values (5,'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
