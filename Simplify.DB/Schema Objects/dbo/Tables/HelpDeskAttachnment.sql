CREATE TABLE [dbo].[HelpDeskAttachnment] (
    [HelpDeskTicketId]  INT IDENTITY (1, 1) NOT NULL,
    [MediaAttachmentId] INT NOT NULL,
    CONSTRAINT [PK_MedicalCaseAttachnment] PRIMARY KEY CLUSTERED ([HelpDeskTicketId] ASC),
    CONSTRAINT [FK_HelpDeskAttachnment_MediaAttachment] FOREIGN KEY ([MediaAttachmentId]) REFERENCES [dbo].[MediaAttachment] ([MediaAttachmentId])
);

