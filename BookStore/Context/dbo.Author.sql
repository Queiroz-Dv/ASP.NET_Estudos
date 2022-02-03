CREATE TABLE [dbo].[Author] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (60) NOT NULL,
    CONSTRAINT [PK_dbo.Author] PRIMARY KEY CLUSTERED ([Id] ASC)
);

