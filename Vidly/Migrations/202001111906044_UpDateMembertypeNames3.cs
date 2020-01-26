namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDateMembertypeNames3 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'One Time' WHERE Id=1");
        }

        public override void Down()
        {
        }
    }
}
