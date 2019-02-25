namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGenreTypeToMovieAndMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreTypeId = c.Byte(nullable: false),
                        GenreTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GenreTypes", t => t.GenreTypes_Id)
                .Index(t => t.GenreTypes_Id);
            
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypes_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypes_Id" });
            DropTable("dbo.GenreTypes");
            DropTable("dbo.Movies");
        }
    }
}
