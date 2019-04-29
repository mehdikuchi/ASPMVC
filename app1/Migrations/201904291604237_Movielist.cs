namespace app1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Movielist : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name) VALUES ('Shrek')");
            Sql("INSERT INTO Movies (Name) VALUES ('harry potter')");
        }
        
        public override void Down()
        {
        }
    }
}
