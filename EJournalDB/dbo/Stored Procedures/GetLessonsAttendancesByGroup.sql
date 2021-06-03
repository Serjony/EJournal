﻿CREATE PROCEDURE [dbo].[GetLessonsAttendancesByGroup]
	@GroupId int
AS
	SELECT 
L.[Id]
,L.DateLesson
,L.Topic
,L.IdTeacher
,S.Id IdStudent
,S.Name
,S.Surname
,A.IsPresence
  FROM [EJournalDB].[dbo].[Lessons] L 
  join [EJournalDB].[dbo].[Groups] G on G.Id = L.IdGroup
  join [EJournalDB].[dbo].Attendances A on A.IdLesson = L.Id
  join [EJournalDB].[dbo].Students S on A.IdStudent = S.Id
  where G.Id = @GroupId
  order by L.Id