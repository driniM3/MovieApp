CREATE TABLE [dbo].[FeatureGenresLookup]
(
	[movie_id] INT NOT NULL REFERENCES FEATURES(id), 
    [genre_id] INT NOT NULL REFERENCES GENRES(id), 
    PRIMARY KEY ([genre_id], [movie_id])
)
