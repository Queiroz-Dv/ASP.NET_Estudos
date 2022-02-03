namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Authors", newName: "Author");
            RenameTable(name: "dbo.Books", newName: "Book");
            RenameTable(name: "dbo.Categories", newName: "Category");
            RenameTable(name: "dbo.BookAuthors", newName: "AuthorBook");
            DropPrimaryKey("dbo.AuthorBook");
            AlterColumn("dbo.Author", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Book", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Book", "ISBN", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, maxLength: 30));
            AddPrimaryKey("dbo.AuthorBook", new[] { "Author_Id", "Book_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AuthorBook");
            AlterColumn("dbo.Category", "Name", c => c.String());
            AlterColumn("dbo.Book", "ISBN", c => c.String());
            AlterColumn("dbo.Book", "Name", c => c.String());
            AlterColumn("dbo.Author", "Name", c => c.String());
            AddPrimaryKey("dbo.AuthorBook", new[] { "Book_Id", "Author_Id" });
            RenameTable(name: "dbo.AuthorBook", newName: "BookAuthors");
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Book", newName: "Books");
            RenameTable(name: "dbo.Author", newName: "Authors");
        }
    }
}
