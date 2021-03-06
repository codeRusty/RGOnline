USE [RGOnline]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 03-06-2020 22:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Season](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Season] ([Id], [Name], [Description], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (1, N'Summer', N'http://localhost:62181/Products/Create', CAST(N'2018-05-07T10:36:00.000' AS DateTime), N'Admin', CAST(N'2018-04-07T10:36:00.000' AS DateTime), N'Admin', 1)
