USE [RGOnline]
GO
/****** Object:  Table [dbo].[Size]    Script Date: 03-06-2020 22:36:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Length] [decimal](18, 0) NULL,
	[Breath] [decimal](18, 0) NULL,
	[Weight] [decimal](18, 0) NULL,
	[Number] [decimal](18, 0) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Size] ([Id], [Name], [Description], [Length], [Breath], [Weight], [Number], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (1, N'32', N'Size 32', CAST(22 AS Decimal(18, 0)), CAST(22 AS Decimal(18, 0)), CAST(22 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), CAST(N'2018-04-07T10:34:00.000' AS DateTime), N'Admin', CAST(N'2018-08-07T10:34:00.000' AS DateTime), N'Admin', 1)
INSERT [dbo].[Size] ([Id], [Name], [Description], [Length], [Breath], [Weight], [Number], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (2, N'34', N'Size 34', CAST(24 AS Decimal(18, 0)), CAST(24 AS Decimal(18, 0)), CAST(220 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), CAST(N'2018-04-07T10:35:00.000' AS DateTime), N'Admin', CAST(N'2018-04-07T10:35:00.000' AS DateTime), N'Admin', 1)
