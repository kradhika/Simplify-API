CREATE TABLE [dbo].[ProviderAcceptedTOS] (
    [TermsOfServiceId] INT NOT NULL,
    [ProviderId]       INT NOT NULL,
    CONSTRAINT [PK_ProviderAcceptedTOS] PRIMARY KEY CLUSTERED ([TermsOfServiceId] ASC),
    CONSTRAINT [FK_ProviderAcceptedTOS_Provider] FOREIGN KEY ([ProviderId]) REFERENCES [dbo].[Provider] ([ProviderId]),
    CONSTRAINT [FK_ProviderAcceptedTOS_TermsOfService] FOREIGN KEY ([TermsOfServiceId]) REFERENCES [dbo].[TermsOfService] ([TermsOfServiceId])
);

