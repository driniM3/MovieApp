CREATE TABLE [dbo].[FeatureActorsLookup]
(
    [movie_id] INT NOT NULL REFERENCES FEATURES(id), 
    [actor_id] INT NOT NULL REFERENCES ACTORS(id), 
    PRIMARY KEY ([actor_id], [movie_id])
)
