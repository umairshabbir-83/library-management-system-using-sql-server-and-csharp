USE [LMS]
GO
/****** Object:  View [dbo].[ReadLibraryData]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ReadLibraryData]
AS
SELECT r.Id AS [Book Id], r.Book AS [Book Name], c.Category AS [Category Name], 
r.Author AS [Author Name], r.Quantity, r.PricePerBook AS [Book Price]
FROM Books_Category c
INNER JOIN
Books_Record r
ON
c.Id = r.Category
GO
