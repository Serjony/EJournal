﻿CREATE PROCEDURE [dbo].[SearchStudentAgreementNumber]
@AgreementNumber NVARCHAR(50)
AS
	SELECT [Id]
	,[Name]
	,[Surname]
	,[Email]
	,[Phone]
	,[Git]
	,[City]
	,[Ranking]
	,[AgreementNumber]
FROM [dbo].[Students]
WHERE IsDelete = 0
	AND AgreementNumber = @AgreementNumber