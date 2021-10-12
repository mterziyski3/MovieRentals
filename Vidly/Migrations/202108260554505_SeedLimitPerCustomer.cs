namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedLimitPerCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET RentedMoviesLimit = 4");
        }
        
        public override void Down()
        {
        }
    }
}
