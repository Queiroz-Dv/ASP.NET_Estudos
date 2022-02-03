CREATE TABLE [dbo].[AuthorBook] (
    [Book_Id]   INT NOT NULL,
    [Author_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.AuthorBook] PRIMARY KEY CLUSTERED ([Author_Id] ASC, [Book_Id] ASC),
    CONSTRAINT [FK_dbo.BookAuthors_dbo.Books_Book_Id] FOREIGN KEY ([Book_Id]) REFERENCES [dbo].[Book] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.BookAuthors_dbo.Authors_Author_Id] FOREIGN KEY ([Author_Id]) REFERENCES [dbo].[Author] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Book_Id]
    ON [dbo].[AuthorBook]([Book_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Author_Id]
    ON [dbo].[AuthorBook]([Author_Id] ASC);

