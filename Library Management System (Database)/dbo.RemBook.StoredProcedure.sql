USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[RemBook]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemBook]
				@BookName VARCHAR(256),
				@Quantity INT
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT Quantity FROM Books_Record
					WHERE Book = @BookName)
				IF(@result > @Quantity)
				BEGIN
					UPDATE Books_Record
					SET Quantity = (@result - @Quantity)
					WHERE Book = @BookName
					SET @result = 1					-- Record Updated
				END
				ELSE IF(@result = @Quantity)
				BEGIN
					DELETE FROM Books_Record
					WHERE Book = @BookName
					SET @result = 0					-- Record Deleted
				END
				ELSE
				BEGIN
					SET @result = -1				-- Record Error
				END
	SELECT @result
END
GO
