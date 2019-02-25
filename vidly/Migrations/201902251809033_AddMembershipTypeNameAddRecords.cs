namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeNameAddRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = 'Pay As You Go' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET TypeName = 'Monthly' WHERE id = 2");
            Sql("UPDATE MembershipTypes SET TypeName = 'Quarterly' WHERE id = 3");
            Sql("UPDATE MembershipTypes SET TypeName = 'Annual' WHERE id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
