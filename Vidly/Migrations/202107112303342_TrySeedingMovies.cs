namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrySeedingMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, numberInStock) VALUES ('Hangover', 3, 07/04/2019, 07/04/2019, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
