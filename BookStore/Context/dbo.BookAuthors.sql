CREATE TABLE [dbo].[BookAuthors] (
    [Book_Id]   INT NOT NULL,
    [Author_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.BookAuthors] PRIMARY KEY CLUSTERED ([Book_Id] ASC, [Author_Id] ASC),
    CONSTRAINT [FK_dbo.BookAuthors_dbo.Books_Book_Id] FOREIGN KEY ([Book_Id]) REFERENCES [dbo].[Books] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.BookAuthors_dbo.Authors_Author_Id] FOREIGN KEY ([Author_Id]) REFERENCES [dbo].[Authors] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Book_Id]
    ON [dbo].[BookAuthors]([Book_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Author_Id]
    ON [dbo].[BookAuthors]([Author_Id] ASC);

