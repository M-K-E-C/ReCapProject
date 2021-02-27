CREATE TABLE [dbo].[Cars] (
    [Id]          INT PRIMARY KEY         NOT NULL,
    [ModelYear]   INT          NULL,
    [DailyPrice]  DECIMAL (18) NULL,
    [Description] VARCHAR (50) NULL,
    [BrandId]     INT          NULL,
    [ColorId]     INT          NULL
);

