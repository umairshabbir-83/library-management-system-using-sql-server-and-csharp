USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCategory]
				@Book_Category VARCHAR(256)
AS
BEGIN
	DECLARE @result INT
	SET @result = (SELECT COUNT(Category) FROM Books_Category
					WHERE Category = @Book_Category)
					If(@result > 0)
					BEGIN
						SET @result = 0		-- Book Category already present
					END
					ELSE
					BEGIN
						INSERT INTO Books_Category(Category) VALUES(@Book_Category)
						SET @result = 1		-- book Category insert
					END
	SELECT @result
END
GO
