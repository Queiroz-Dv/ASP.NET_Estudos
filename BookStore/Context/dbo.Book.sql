CREATE TABLE [dbo].[Book] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (60) NOT NULL,
    [ISBN]         NVARCHAR (32) NOT NULL,
    [ReleasedDate] DATETIME      NOT NULL,
    [CategoryId]   INT           NOT NULL,
    CONSTRAINT [PK_dbo.Book] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Books_dbo.Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CategoryId]
    ON [dbo].[Book]([CategoryId] ASC);

