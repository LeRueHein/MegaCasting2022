CREATE TABLE [dbo].[ActivityArtist] (
    [Identifier]         BIGINT NOT NULL,
    [IdentifierArtist]   BIGINT NOT NULL,
    [IdentifierActivity] BIGINT NOT NULL,
    CONSTRAINT [PK_ActivityArtist] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_ActivityArtist_Activity] FOREIGN KEY ([IdentifierActivity]) REFERENCES [dbo].[Activity] ([Identifier]),
    CONSTRAINT [FK_ActivityArtist_Artist] FOREIGN KEY ([IdentifierArtist]) REFERENCES [dbo].[Artist] ([Identifier])
);

