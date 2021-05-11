CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1000,1), 
    [Material] NVARCHAR(50) NOT NULL, 
    [Quantity] INT NULL, 
    [Cost] MONEY NULL
)
