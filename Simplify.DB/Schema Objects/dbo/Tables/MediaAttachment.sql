CREATE TABLE [dbo].[MediaAttachment] (
    [MediaAttachmentId]      INT            IDENTITY (1, 1) NOT NULL,
    [AttachmentThumbnail]    IMAGE          NULL,
    [AttachmentSourceId]     NVARCHAR (50)  NULL,
    [AttachmentSourceSystem] NVARCHAR (50)  NULL,
    [AttachmentURL]          NVARCHAR (500) NULL,
    CONSTRAINT [PK_MediaAttachment] PRIMARY KEY CLUSTERED ([MediaAttachmentId] ASC)
);

