namespace IdentityReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedPosttousePictureclassasdatatypeforPictures : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Picture_Id", c => c.Int());
            CreateIndex("dbo.Posts", "Picture_Id");
            AddForeignKey("dbo.Posts", "Picture_Id", "dbo.Pictures", "Id");
            DropColumn("dbo.Posts", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Picture", c => c.String());
            DropForeignKey("dbo.Posts", "Picture_Id", "dbo.Pictures");
            DropIndex("dbo.Posts", new[] { "Picture_Id" });
            DropColumn("dbo.Posts", "Picture_Id");
        }
    }
}
