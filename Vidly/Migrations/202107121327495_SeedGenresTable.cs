namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, TypeOfGenre) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, TypeOfGenre) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, TypeOfGenre) VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
