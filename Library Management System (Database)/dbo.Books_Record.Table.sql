USE [LMS]
GO
/****** Object:  Table [dbo].[Books_Record]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Record](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Book] [varchar](50) NULL,
	[Category] [int] NULL,
	[PricePerBook] [decimal](18, 0) NULL,
	[Quantity] [bigint] NULL,
	[Author] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books_Record] ADD  DEFAULT ((0)) FOR [PricePerBook]
GO
ALTER TABLE [dbo].[Books_Record] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Books_Record]  WITH CHECK ADD FOREIGN KEY([Category])
REFERENCES [dbo].[Books_Category] ([ID])
GO
ALTER TABLE [dbo].[Books_Record]  WITH CHECK ADD FOREIGN KEY([Category])
REFERENCES [dbo].[Books_Category] ([ID])
GO
