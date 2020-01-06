namespace Project_san_giao_dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeChangeDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Coins", "CreateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coins", "UpdateAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Markets", "CreatedAt", c => c.DateTime());
            AlterColumn("dbo.Markets", "UpdatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Markets", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Markets", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Coins", "UpdateAt", c => c.DateTime());
            AlterColumn("dbo.Coins", "CreateAt", c => c.DateTime());
        }
    }
}
