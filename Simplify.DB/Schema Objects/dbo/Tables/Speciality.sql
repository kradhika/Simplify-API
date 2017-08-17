CREATE TABLE [dbo].[Speciality] (
    [SpecialityId]   INT             NOT NULL,
    [SpecialityName] NVARCHAR (2000) NOT NULL,
    [CreatedOn]      DATETIME2 (7)   NOT NULL,
    [CreatedBy]      NVARCHAR (50)   NOT NULL,
    CONSTRAINT [PK_FeedShareSpeciality] PRIMARY KEY CLUSTERED ([SpecialityId] ASC)
);

