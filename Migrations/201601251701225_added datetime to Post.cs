namespace IdentityReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddatetimetoPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "CreatedDate");
        }
    }
}
