USE [LMS]
GO
/****** Object:  StoredProcedure [dbo].[AddBook]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddBook]
				@Book VARCHAR(256),
				@Category INT,
				@Price DECIMAL,
				@Quantity INT,
				@Author VARCHAR(256)
AS
BEGIN
	DECLARE @BookName INT
	SET @BookName = (SELECT COUNT(Book) FROM Books_Record
					WHERE Book = @Book)
					If(@BookName = 0)
					BEGIN
						INSERT INTO Books_Record(Book, Category, PricePerBook, Quantity, Author)
						VALUES(@Book, @Category, @Price, @Quantity, @Author)
						SET @BookName = 1		-- Record Inserted
					END
				ELSE
				BEGIN
					SET @BookName = 0			-- Record Already Present
				END
		SELECT @BookName
END
GO
