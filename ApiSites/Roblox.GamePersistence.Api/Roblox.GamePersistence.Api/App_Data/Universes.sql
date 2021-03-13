CREATE TABLE [dbo].[Universes]
(
	[UniverseId] INT NOT NULL PRIMARY KEY, 
    [Created] DATETIME NOT NULL, 
    [Updated] DATETIME NULL, 
    [StoreCount] INT NOT NULL DEFAULT 0
)
