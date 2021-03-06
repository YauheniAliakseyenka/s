﻿CREATE TABLE [dbo].[Event]
(
	[Id] INT IDENTITY PRIMARY KEY,
	[Title] NVARCHAR(120) NOT NULL,
	[Description] NVARCHAR(max) NOT NULL,
	[LayoutId] INT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    [ImageURL] NVARCHAR(MAX) NOT NULL, 
    [CreatedBy] INT NOT NULL,
)
