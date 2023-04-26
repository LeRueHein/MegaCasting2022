CREATE TABLE [dbo].[ContractType] (
    [Identifier] BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (40) NOT NULL,
    [ShortName]  NVARCHAR (5)  NOT NULL,
    CONSTRAINT [PK_ContractType] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

