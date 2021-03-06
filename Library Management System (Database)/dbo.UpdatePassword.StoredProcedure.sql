USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePassword]
				@Username VARCHAR(256),
				@Password VARCHAR(256)
AS
BEGIN
	DECLARE @User INT
	SET @User = (SELECT COUNT(Username) FROM User_Register
				WHERE Username = @Username)
				If(@User > 0)
				BEGIN
					UPDATE User_Register
					SET Password = @Password
					WHERE Username = @Username
					SET @User = 1			-- Password Changes
				END
				ELSE
				BEGIN
					SET @User = 0			-- Password not updated
				END
	SELECT @User
END
GO
