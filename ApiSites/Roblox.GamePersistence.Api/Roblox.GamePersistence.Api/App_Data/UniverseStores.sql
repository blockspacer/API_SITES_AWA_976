CREATE TABLE [dbo].[UniverseStores]
(
	[Id] INT NOT NULL PRIMARY KEY ,
	[UniverseId] int FOREIGN KEY REFERENCES Universes(UniverseId) NOT NULL DEFAULT 0, 
    [ScopeCount] INT NOT NULL DEFAULT 0, 
    [Created] DATETIME NOT NULL , 
    [Updated] DATETIME NULL, 
    [Name] NVARCHAR(MAX) NOT NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The universeId for this Store',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'UniverseStores',
    @level2type = N'COLUMN',
    @level2name = N'UniverseId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The name of this store',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'UniverseStores',
    @level2type = N'COLUMN',
    @level2name = 'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The count of scopes in the current store',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'UniverseStores',
    @level2type = N'COLUMN',
    @level2name = N'ScopeCount'