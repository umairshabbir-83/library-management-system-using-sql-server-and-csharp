USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[Show_Issued]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Show_Issued]
	@User varchar(256)
AS
BEGIN
	select *FROM Books_Issue where IssuedTo = @User

END
GO
