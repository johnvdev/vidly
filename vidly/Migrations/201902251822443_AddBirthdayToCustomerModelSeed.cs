namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToCustomerModelSeed : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '1996/06/06' WHERE id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
