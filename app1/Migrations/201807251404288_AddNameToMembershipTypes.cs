namespace app1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String());
            Sql("UPDATE MembershipTypes Set Name = 'Pay as you go' WHERE DiscountRate = 0");
            Sql("UPDATE MembershipTypes Set Name = 'Monthly' WHERE DiscountRate = 10");
            Sql("UPDATE MembershipTypes Set Name = 'Quarterly' WHERE DiscountRate = 15");
            Sql("UPDATE MembershipTypes Set Name = 'Annually' WHERE DiscountRate = 20");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
