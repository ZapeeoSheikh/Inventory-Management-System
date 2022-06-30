namespace Inventory_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Image");
        }
    }
}
