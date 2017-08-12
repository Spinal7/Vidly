namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditBirthdays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = NULL WHERE Id = 1");
            Sql("UPDATE Customers SET Birthday = NULL WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
