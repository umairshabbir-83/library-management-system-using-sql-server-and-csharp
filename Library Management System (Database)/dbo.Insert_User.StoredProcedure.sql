USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[Insert_User]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Insert_User]
				@Username VARCHAR(256),
				@Password VARCHAR(256)
AS
BEGIN
	DECLARE @Result INT
	If(@Username = 'admin')
	BEGIN
		SELECT 'User not Register'
		SET @Result = 0		-- User not register
	END
	ELSE
	BEGIN
		SET @Result = (SELECT COUNT(Username) FROM User_Register
						WHERE Username = @Username)
		IF(@Result > 0)
		BEGIN
			SET @Result = 2	-- User already registered
		END
		ELSE
		BEGIN
			INSERT INTO User_Register(Username, Password)
			VALUES(@Username, @Password)
			SET @Result = 1		-- User Register
		END
	END
	SELECT @Result
END
GO
