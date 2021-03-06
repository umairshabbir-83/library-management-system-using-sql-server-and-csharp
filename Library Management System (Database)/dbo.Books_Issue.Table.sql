USE [LMS]
GO
/****** Object:  Table [dbo].[Books_Issue]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Issue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bookname] [varchar](50) NULL,
	[IssuedTo] [varchar](50) NULL,
	[IssuedOn] [date] NULL,
	[ReturnOn] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books_Issue] ADD  DEFAULT (getdate()) FOR [IssuedOn]
GO
ALTER TABLE [dbo].[Books_Issue] ADD  DEFAULT (dateadd(month,(1),getdate())) FOR [ReturnOn]
GO
