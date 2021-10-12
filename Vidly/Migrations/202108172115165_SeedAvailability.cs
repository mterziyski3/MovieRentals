namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAvailability : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET numberAvailable = numberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
