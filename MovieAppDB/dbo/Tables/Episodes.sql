CREATE TABLE [dbo].[Episodes]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[feature_id] INT NOT NULL REFERENCES FEATURES(id),
    [season] INT NULL, 
    [episode] INT NULL, 
    [title] INT NULL, 
    [plot] VARCHAR(MAX) NULL, 
    [rating] DECIMAL(4, 2) NULL,
	[imdb_id] VARCHAR(10) NULL, 
)
