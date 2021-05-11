CREATE TABLE [dbo].[object]
(
	[IdObj] INT NOT NULL PRIMARY KEY identity(1000,1), 
    [ObjName] NVARCHAR(50) NULL, 
    [Client] NVARCHAR(50) NULL, 
    [Foreman] NVARCHAR(50) NULL, 
    [DateBegin] DATE NULL, 
    [Location] NVARCHAR(50) NULL, 
    [Status] NVARCHAR(50) NULL
)
