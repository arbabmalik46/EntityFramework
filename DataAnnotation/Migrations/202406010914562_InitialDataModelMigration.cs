namespace DataAnnotation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataModelMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(nullable: false, maxLength: 255),
                        Level = c.Int(nullable: false),
                        FullPrice = c.Single(nullable: false),
                        Author_Id = c.Int(),
                        Category_ID = c.Int(),
                        DatePublished = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.__MigrationHistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 150),
                        ContextKey = c.String(nullable: false, maxLength: 300),
                        Model = c.Binary(nullable: false),
                        ProductVersion = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => new { t.MigrationId, t.ContextKey });
            
            CreateTable(
                "dbo.TagCourses",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Tag_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Tag_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Tag_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.TagCourses", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.TagCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Category_ID", "dbo.Categories");
            DropIndex("dbo.TagCourses", new[] { "Tag_Id" });
            DropIndex("dbo.TagCourses", new[] { "Course_Id" });
            DropIndex("dbo.Courses", new[] { "Category_ID" });
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            DropTable("dbo.TagCourses");
            DropTable("dbo.__MigrationHistory");
            DropTable("dbo.Tags");
            DropTable("dbo.Categories");
            DropTable("dbo.Courses");
            DropTable("dbo.Authors");
        }
    }
}
