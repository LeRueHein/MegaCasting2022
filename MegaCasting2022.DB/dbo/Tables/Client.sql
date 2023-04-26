CREATE TABLE [dbo].[Client] (
    [Identifier]        BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (50)   NOT NULL,
    [AddressRoad]       NVARCHAR (50)   NOT NULL,
    [AddressCity]       NVARCHAR (50)   NOT NULL,
    [AddressZipCode]    NVARCHAR (50)   NOT NULL,
    [AddressComplement] NVARCHAR (50)   NOT NULL,
    [Description]       NVARCHAR (3000) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

