namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLimitRentedMoviesForCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RentedMoviesLimit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RentedMoviesLimit");
        }
    }
}
