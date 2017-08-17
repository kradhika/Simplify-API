CREATE TABLE [dbo].[ContentRecord] (
    [ContentId]   INT             NOT NULL,
    [Title]       NVARCHAR (2000) NOT NULL,
    [Description] TEXT            NOT NULL,
    [URL]         NVARCHAR (2000) NULL,
    [CreatedOn]   DATETIME2 (7)   NULL,
    [CreatedBy]   NVARCHAR (50)   NULL,
    CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED ([ContentId] ASC)
);

