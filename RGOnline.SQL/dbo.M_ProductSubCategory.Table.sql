USE [RGOnline]
GO
/****** Object:  Table [dbo].[M_ProductSubCategory]    Script Date: 03-06-2020 22:36:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_ProductSubCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[ProductSubCategory] [nvarchar](max) NULL,
	[UpdatedBy] [nvarchar](max) NULL,
	[UpdatedOn] [datetime2](7) NOT NULL,
	[ProductCategoryID] [bigint] NOT NULL,
 CONSTRAINT [PK_M_ProductSubCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[M_ProductSubCategory] ON 

INSERT [dbo].[M_ProductSubCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductSubCategory], [UpdatedBy], [UpdatedOn], [ProductCategoryID]) VALUES (1, N'Admin', CAST(N'2018-04-01T17:15:00.0000000' AS DateTime2), N'This category is for DPS Summer T-Shirts', 1, N' DPS Summer T-Shirts', N'Admin', CAST(N'2018-04-01T17:15:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[M_ProductSubCategory] OFF
ALTER TABLE [dbo].[M_ProductSubCategory]  WITH CHECK ADD  CONSTRAINT [FK_M_ProductSubCategory_M_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[M_ProductCategory] ([Id])
GO
ALTER TABLE [dbo].[M_ProductSubCategory] CHECK CONSTRAINT [FK_M_ProductSubCategory_M_ProductCategory]
GO
