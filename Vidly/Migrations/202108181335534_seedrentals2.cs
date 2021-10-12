namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedrentals2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Rentals (Id, DateRented, Customer_Id, Movie_Id) VALUES (1, 07/04/2019, 5, 48)");
        }
        
        public override void Down()
        {
        }
    }
}
