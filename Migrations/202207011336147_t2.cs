namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AccessToken", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AccessToken");
        }
    }
}
