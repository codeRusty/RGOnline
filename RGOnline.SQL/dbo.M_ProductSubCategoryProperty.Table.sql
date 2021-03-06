USE [RGOnline]
GO
/****** Object:  Table [dbo].[M_ProductSubCategoryProperty]    Script Date: 03-06-2020 22:36:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_ProductSubCategoryProperty](
	[Id] [int] NOT NULL,
	[ProductSubCategoryID] [bigint] NOT NULL,
	[PropertyName] [nvarchar](50) NOT NULL,
	[DisplayOrder] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_M_ProductSubCategoryProperty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[M_ProductSubCategoryProperty]  WITH CHECK ADD  CONSTRAINT [FK_M_ProductSubCategoryProperty_M_ProductSubCategory] FOREIGN KEY([ProductSubCategoryID])
REFERENCES [dbo].[M_ProductSubCategory] ([Id])
GO
ALTER TABLE [dbo].[M_ProductSubCategoryProperty] CHECK CONSTRAINT [FK_M_ProductSubCategoryProperty_M_ProductSubCategory]
GO
