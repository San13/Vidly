namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateBirthDateOnCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set Birthdate='1/1/1989' where Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
