CREATE TABLE [dbo].[Status] (
    [StatusId]          INT            IDENTITY (1, 1) NOT NULL,
    [StatusName]        NVARCHAR (50)  NOT NULL,
    [StatusDescription] NVARCHAR (100) NULL,
    CONSTRAINT [PK_CaseStatus_1] PRIMARY KEY CLUSTERED ([StatusId] ASC)
);

