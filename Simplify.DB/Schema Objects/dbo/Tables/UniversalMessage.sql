CREATE TABLE [dbo].[UniversalMessage] (
    [MessageId]              INT           NOT NULL,
    [ContentId]              INT           NOT NULL,
    [MessageLiveDate]        DATETIME2 (7) NULL,
    [MessageDeacitvatedDate] DATETIME2 (7) NULL,
    [CreatedOn]              DATETIME2 (7) NULL,
    [CreatedBy]              DATETIME2 (7) NULL,
    CONSTRAINT [PK_FeedMessage] PRIMARY KEY CLUSTERED ([MessageId] ASC),
    CONSTRAINT [FK_FeedMessage_Content] FOREIGN KEY ([ContentId]) REFERENCES [dbo].[ContentRecord] ([ContentId])
);

