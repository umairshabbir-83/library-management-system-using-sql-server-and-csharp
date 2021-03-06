USE [LMS]
GO
/****** Object:  Table [dbo].[User_Register]    Script Date: 7/29/2021 4:10:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Register](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](256) NULL,
	[Password] [varchar](256) NULL,
	[UserCreatedOn] [datetime] NULL,
	[User_Active] [bit] NULL,
	[BooksIssued] [int] NULL,
	[SecurityAmount] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User_Register] ADD  DEFAULT (getdate()) FOR [UserCreatedOn]
GO
ALTER TABLE [dbo].[User_Register] ADD  DEFAULT ((1)) FOR [User_Active]
GO
ALTER TABLE [dbo].[User_Register] ADD  DEFAULT ((0)) FOR [BooksIssued]
GO
ALTER TABLE [dbo].[User_Register] ADD  DEFAULT ((1000)) FOR [SecurityAmount]
GO
