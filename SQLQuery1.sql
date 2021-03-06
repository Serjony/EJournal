CREATE TYPE [dbo].[StudentsComment] AS TABLE 
(
    [IdStudent] INT NULL,
    [IdComment] INT NULL
);
Go
CREATE PROCEDURE [dbo].[CreateStudentComments]
    @IdCommentType INT,
    @Comment nvarchar(255),
	@StudentCommentVarible as [dbo].[StudentsComment] READONLY
AS
	DECLARE @IdComment INT
	DECLARE @StudentsComment as [dbo].[StudentsComment]

	Insert into @StudentsComment
	Select *
	from @StudentCommentVarible 

    Insert INTO [dbo].Comments( Comment, IdCommentType  )
    Values(@Comment,@IdCommentType )

	Set @IdComment= SCOPE_IDENTITY()

	InSERT INTO [dbo].StudentsComments(IdStudent, IdComment)
 Select IdStudent, IdComment
 from @StudentsComment