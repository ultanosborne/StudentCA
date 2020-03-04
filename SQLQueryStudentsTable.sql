CREATE TABLE [dbo].[Students] (
    [StudentNumber] INT          NOT NULL,
    [FirstName]     VARCHAR (20) NULL,
    [LastName]      VARCHAR (20) NULL,
    [Email]         VARCHAR (50) NULL,
    [Phone]         VARCHAR (10) NULL,
    [AddressLine1]  VARCHAR (50) NULL,
    [AddressLine2]  VARCHAR (50) NULL,
    [City]          VARCHAR (20) NULL,
    [Country]       VARCHAR (50) NULL,
    [GradLevel]     BIT          NULL,
    [Course]        VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([StudentNumber] ASC)
);
