namespace MVC_Web_Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foruth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "ptEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "ptEmail");
        }
    }
}
