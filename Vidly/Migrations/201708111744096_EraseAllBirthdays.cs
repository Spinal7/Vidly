namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EraseAllBirthdays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '' WHERE Id = 1 OR Id = 2 OR Id = 3 OR Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
