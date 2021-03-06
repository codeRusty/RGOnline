USE [RGOnline]
GO
/****** Object:  Table [dbo].[M_ProductCategory]    Script Date: 03-06-2020 22:36:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_ProductCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[ProductCategory] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[UpdatedOn] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_M_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[M_ProductCategory] ON 

INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2), N'This category is for School Uniforms', 1, N'School Uniforms', N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2))
INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (2, N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2), N'This category is for Men', 1, N'Men', N'Admin', CAST(N'2018-04-01T17:13:00.0000000' AS DateTime2))
INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (3, N'Admin', CAST(N'2018-04-01T17:13:00.0000000' AS DateTime2), N'This category is for Women', 1, N'Women', N'Admin', CAST(N'2018-04-01T17:14:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[M_ProductCategory] OFF
