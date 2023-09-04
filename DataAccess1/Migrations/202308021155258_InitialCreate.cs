namespace DataAccess1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.stocks",
                c => new
                    {
                        p_code = c.Int(nullable: false, identity: true),
                        p_name = c.String(),
                        p_price = c.Int(nullable: false),
                        p_category = c.String(),
                        p_stok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.p_code);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.stocks");
        }
    }
}
