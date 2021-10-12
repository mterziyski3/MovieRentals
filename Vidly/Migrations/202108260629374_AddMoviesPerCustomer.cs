namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesPerCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MoviesAdded", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MoviesAdded");
        }
    }
}
