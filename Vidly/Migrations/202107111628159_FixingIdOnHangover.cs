namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingIdOnHangover : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Id = 1 WHERE Name = 'Hangover'");
        }
        
        public override void Down()
        {
        }
    }
}
