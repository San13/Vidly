namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleasedDate,NubmerInStock) values ('Hangover',1,'1/1/2017','1/1/2017',10 )");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleasedDate,NubmerInStock) values ('Die Hard',2,'4/5/2017','1/1/2017',20 )");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleasedDate,NubmerInStock) values ('The Terminator',2,'4/5/2017','1/1/2017',4 )");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleasedDate,NubmerInStock) values ('Toy Story',3,'1/1/2017','2/5/2017',5 )");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleasedDate,NubmerInStock) values ('Titanic',4,'1/1/2017','1/4/2017',1 )");
        }
        
        public override void Down()
        {
        }
    }
}
