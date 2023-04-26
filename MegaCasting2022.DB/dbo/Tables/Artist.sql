CREATE TABLE [dbo].[Artist] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

