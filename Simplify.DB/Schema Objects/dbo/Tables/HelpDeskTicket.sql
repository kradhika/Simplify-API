CREATE TABLE [dbo].[HelpDeskTicket] (
    [HelpDeskTicketId]   INT              IDENTITY (1, 1) NOT NULL,
    [HelpDeskTicketGuid] UNIQUEIDENTIFIER NOT NULL,
    [Title]              NVARCHAR (2000)  NOT NULL,
    [Description]        TEXT             NULL,
    [ProviderId]         INT              NOT NULL,
    [CreatedOn]          DATETIME2 (7)    NOT NULL,
    [UpdatedOn]          DATETIME2 (7)    NOT NULL,
    [StatusId]           INT              NOT NULL,
    CONSTRAINT [PK_HelpDeskTicket] PRIMARY KEY CLUSTERED ([HelpDeskTicketId] ASC),
    CONSTRAINT [FK_HelpDeskTicket_HelpDeskAttachnment] FOREIGN KEY ([HelpDeskTicketId]) REFERENCES [dbo].[HelpDeskAttachnment] ([HelpDeskTicketId]),
    CONSTRAINT [FK_HelpDeskTicket_Provider] FOREIGN KEY ([ProviderId]) REFERENCES [dbo].[Provider] ([ProviderId]),
    CONSTRAINT [FK_HelpDeskTicket_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Status] ([StatusId])
);

