USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[ReturnBook]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReturnBook]
	@User varchar(256),
	@BookName varchar(256)
AS
BEGIN
	delete FROM Books_Issue where IssuedTo = @User and Bookname = @BookName

END
GO
