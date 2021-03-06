USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[RemCategory]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemCategory]
				@Category INT
AS
BEGIN
	DECLARE @Cat INT
	SET @Cat = (SELECT COUNT(Category) FROM Books_Category
				WHERE Id = @Category)
				If(@Cat > 0)
				BEGIN
					DELETE FROM Books_Category
					WHERE Id = @Category
					SET @Cat = 1				-- Record Deleted
				END
				ELSE
				BEGIN
					SET @Cat = 0
				END
	SELECT @Cat
END
GO
