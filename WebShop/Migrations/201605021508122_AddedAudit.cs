namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAudit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAudit",
                c => new
                    {
                        LogID = c.Int(nullable: false, identity: true),
                        LogMsg = c.String(),
                    })
                .PrimaryKey(t => t.LogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblAudit");
        }
    }
}
