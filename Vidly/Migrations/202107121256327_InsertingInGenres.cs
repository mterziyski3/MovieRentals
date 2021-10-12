namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingInGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, TypeOfGenre) VALUES (1, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
