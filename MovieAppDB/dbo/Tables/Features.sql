CREATE TABLE [dbo].[Features]
(
	[id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[feature_status_id] INT NOT NULL REFERENCES STATUSES(id),
	[type_id] INT NOT NULL REFERENCES TYPES(id),
    [title] VARCHAR(100) NULL, 
    [year] INT NULL, 
    [run_time] VARCHAR(50) NULL, 
    [director] VARCHAR(100) NULL, 
    [plot] VARCHAR(500) NULL, 
    [poster_url] VARCHAR(500) NULL, 
    [rating] DECIMAL(4, 2) NULL, 
    [imdb_id] VARCHAR(10) NULL
)
