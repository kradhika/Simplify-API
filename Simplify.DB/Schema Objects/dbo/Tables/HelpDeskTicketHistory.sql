CREATE TABLE [dbo].[HelpDeskTicketHistory] (
    [HelpDeskTicketHistoryId] INT            NOT NULL,
    [HelpDeskTicketId]        INT            NOT NULL,
    [RemedyDescription]       TEXT           NULL,
    [RemedyStatus]            NVARCHAR (200) NULL
);

