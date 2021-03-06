USE [LMS]
GO
/****** Object:  Table [dbo].[Books_Return_Charges]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Return_Charges](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bookname] [varchar](50) NULL,
	[IssuedTo] [varchar](50) NULL,
	[IssuedOn] [date] NULL,
	[ReturnOn] [date] NULL,
	[BookPrice] [int] NULL,
	[BookIssueDay]  AS (datediff(day,[IssuedOn],[ReturnOn])),
	[AmountPaid]  AS ([BookPrice]*datediff(day,[IssuedOn],[ReturnOn])),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books_Return_Charges] ADD  DEFAULT (getdate()) FOR [IssuedOn]
GO
ALTER TABLE [dbo].[Books_Return_Charges] ADD  DEFAULT (getdate()) FOR [ReturnOn]
GO
ALTER TABLE [dbo].[Books_Return_Charges] ADD  DEFAULT ((0)) FOR [BookPrice]
GO
