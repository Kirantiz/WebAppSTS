INSERT INTO [object] (ObjName, Client, Foreman, DateBegin, [Location], [Status]) values 
('Объект','Клиент',N'Сыч', '11.11.2011','адрес','Статус');


SELECT * FROM [Object] WHERE IdObj = 1002

SELECT [object].ObjName, MATOT.Materiadl
FROM MATOT INNER JOIN USEMAT ON MATOT.IdMat = USEMAT. IDMAT INNER JOIN
 [object] ON USEMAT.IDOBJ = [object].IdObj