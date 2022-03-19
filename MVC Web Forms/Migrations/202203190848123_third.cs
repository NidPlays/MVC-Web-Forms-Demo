namespace MVC_Web_Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        appointDate = c.DateTime(nullable: false),
                        ptID = c.Int(nullable: false),
                        docID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Doctors", t => t.docID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.ptID, cascadeDelete: true)
                .Index(t => t.ptID)
                .Index(t => t.docID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "ptID", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "docID", "dbo.Doctors");
            DropIndex("dbo.Appointments", new[] { "docID" });
            DropIndex("dbo.Appointments", new[] { "ptID" });
            DropTable("dbo.Appointments");
        }
    }
}
