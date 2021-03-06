USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[IssueBook]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[IssueBook]
				@user VARCHAR(256),
				@Bookname VARCHAR(256)
AS
BEGIN
	DECLARE @bookissue INT
	DECLARE @book INT
	DECLARE @bookPrice INT
	DECLARE @UserAmount INT
	SET @bookissue = (SELECT BooksIssued FROM User_Register
						WHERE Username = @user)
	SET @UserAmount = (SELECT SecurityAmount FROM User_Register
						WHERE Username = @user)
			IF(@bookissue = '3')
			BEGIN
				PRINT 'You have already issued 3 Books'
				SET @bookissue = 0
			END
			ELSE IF(@bookissue < 3)
			BEGIN
				SET @bookPrice = (SELECT PricePerBook FROM Books_Record
									WHERE Book = @Bookname)SELECT * FROM Books_Record
				SET @book = (SELECT COUNT(Bookname) FROM Books_Issue
								WHERE Bookname = @Bookname AND IssuedTo = @user)
				IF(@UserAmount > @bookPrice * 2 AND @book <> 0)
				BEGIN
					PRINT 'Book is Already Issued'
					SET @bookissue = 1
				END
				ELSE
				BEGIN
						UPDATE User_Register
						SET BooksIssued = BooksIssued + 1
						WHERE Username = @user
							
						INSERT INTO Books_Issue(Bookname, IssuedTo)
						VALUES(@Bookname, @user)

						INSERT INTO Books_Return_Charges(Bookname, IssuedTo, BookPrice)
						VALUES(@Bookname, @user, @bookPrice)
							
						UPDATE Books_Record
						SET Quantity = Quantity - 1
						WHERE Book = @Bookname
							
						SET @bookissue = 2
				END

			END
			ELSE
			BEGIN
				PRINT 'User does not have sufficient amount left'
				SET @bookissue = -1
			END
	SELECT @bookissue
END
GO
