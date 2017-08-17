CREATE TABLE [dbo].[ContentShare] (
    [ContentShareId] INT           NOT NULL,
    [ContentId]      INT           NOT NULL,
    [SpecialityId]   INT           NOT NULL,
    [CreatedOn]      DATETIME2 (7) NOT NULL,
    [CreatedBy]      NVARCHAR (50) NOT NULL,
    CONSTRAINT [FK_FeedMessageShare_Speciality] FOREIGN KEY ([SpecialityId]) REFERENCES [dbo].[Speciality] ([SpecialityId])
);

