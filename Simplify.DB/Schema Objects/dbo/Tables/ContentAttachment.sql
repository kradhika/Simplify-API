CREATE TABLE [dbo].[ContentAttachment] (
    [ContentId]         INT NOT NULL,
    [MediaAttachmentId] INT NOT NULL,
    CONSTRAINT [PK_ContentAttachment] PRIMARY KEY CLUSTERED ([ContentId] ASC, [MediaAttachmentId] ASC),
    CONSTRAINT [FK_ContentAttachment_Content] FOREIGN KEY ([ContentId]) REFERENCES [dbo].[ContentRecord] ([ContentId]),
    CONSTRAINT [FK_ContentAttachment_MediaAttachment] FOREIGN KEY ([MediaAttachmentId]) REFERENCES [dbo].[MediaAttachment] ([MediaAttachmentId])
);

