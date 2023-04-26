CREATE TABLE [dbo].[Activity] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

