USE [RGOnline]
GO
/****** Object:  Table [dbo].[ProductLookDetails]    Script Date: 03-06-2020 22:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLookDetails](
	[Id] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ImageURL1] [nvarchar](max) NULL,
	[ImageURL2] [nvarchar](max) NULL,
	[ImageURL3] [nvarchar](max) NULL,
	[ImageURL4] [nvarchar](max) NULL,
	[ImageURL5] [nvarchar](max) NULL,
	[ImageURL6] [nvarchar](max) NULL,
	[ImageURL7] [nvarchar](max) NULL,
	[ImageURL8] [nvarchar](max) NULL,
	[ImageURL9] [nvarchar](max) NULL,
	[VideoUrl] [nvarchar](max) NULL,
	[BrandURL] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProductLookDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductLookDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductLookDetails_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ProductLookDetails] CHECK CONSTRAINT [FK_ProductLookDetails_Product]
GO
