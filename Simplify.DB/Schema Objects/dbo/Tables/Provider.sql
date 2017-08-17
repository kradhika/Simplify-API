CREATE TABLE [dbo].[Provider] (
    [ProviderId]           INT              IDENTITY (1, 1) NOT NULL,
    [FirstName]            NVARCHAR (100)   NOT NULL,
    [LastName]             NVARCHAR (100)   NOT NULL,
    [BIO]                  NVARCHAR (2000)  NULL,
    [Speciality]           NVARCHAR (500)   NULL,
    [Picture]              IMAGE            NULL,
    [Phone]                NVARCHAR (20)    NOT NULL,
    [Email]                NVARCHAR (100)   NOT NULL,
    [LoginUserName]        NVARCHAR (50)    NULL,
    [LoginSourceId]        NVARCHAR (50)    NULL,
    [LoginSourceSystem]    NVARCHAR (50)    NOT NULL,
    [LoginDeactivatedDate] DATETIME2 (7)    NULL,
    [CreatedOn]            DATETIME2 (7)    NULL,
    [UpdatedOn]            DATETIME2 (7)    NULL,
    [ProviderGuid]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Provider_1] PRIMARY KEY CLUSTERED ([ProviderId] ASC)
);

