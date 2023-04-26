CREATE TABLE [dbo].[Offer] (
    [Identifier]              BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]                    NVARCHAR (50)   NOT NULL,
    [Description]             NVARCHAR (3000) NOT NULL,
    [ParutionDateTime]        DATETIME2 (7)   NOT NULL,
    [IndentifierContractType] BIGINT          NOT NULL,
    [IdentifierClient]        BIGINT          NOT NULL,
    CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Offer_Client] FOREIGN KEY ([IdentifierClient]) REFERENCES [dbo].[Client] ([Identifier]),
    CONSTRAINT [FK_Offer_ContractType] FOREIGN KEY ([IndentifierContractType]) REFERENCES [dbo].[ContractType] ([Identifier])
);

