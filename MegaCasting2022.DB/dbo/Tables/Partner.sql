CREATE TABLE [dbo].[Partner] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

