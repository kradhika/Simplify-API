CREATE TABLE [dbo].[TermsOfService] (
    [TermsOfServiceId] INT           IDENTITY (1, 1) NOT NULL,
    [Description]      TEXT          NOT NULL,
    [Version]          NVARCHAR (50) NULL,
    CONSTRAINT [PK_TermsOfService] PRIMARY KEY CLUSTERED ([TermsOfServiceId] ASC)
);

