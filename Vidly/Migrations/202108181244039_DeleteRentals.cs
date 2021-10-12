namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteRentals : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Rentals");
        }
        
        public override void Down()
        {
        }
    }
}
