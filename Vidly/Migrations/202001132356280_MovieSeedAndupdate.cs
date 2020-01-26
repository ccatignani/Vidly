namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieSeedAndupdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Genre_Id = 1 WHERE Id=1");
            Sql("UPDATE Movies SET Genre_Id = 1 WHERE Id=2");
            Sql("UPDATE Movies SET Genre_Id = 2 WHERE Id=3");
            Sql("UPDATE Movies SET Genre_Id = 3 WHERE Id=4");
            Sql("UPDATE Movies SET Genre_Id = 4 WHERE Id=5");
            Sql("UPDATE Movies SET Genre_Id = 5 WHERE Id=6");
            Sql("UPDATE Movies SET Genre_Id = 5 WHERE Id=7");
        }

        public override void Down()
        {
        }
    }
}
