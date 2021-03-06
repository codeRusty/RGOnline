USE [RGOnline]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 03-06-2020 22:38:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [bigint] IDENTITY(1000,1) NOT NULL,
	[Building] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NULL,
	[Area] [nvarchar](50) NULL,
	[City] [nvarchar](50) NOT NULL,
	[Pincode] [bigint] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 03-06-2020 22:38:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CustomerId] [bigint] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartItem]    Script Date: 03-06-2020 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CartId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
 CONSTRAINT [PK_CartItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 03-06-2020 22:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](30) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[AddressId] [bigint] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[M_ProductCategory]    Script Date: 03-06-2020 22:38:24 ******/
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
/****** Object:  Table [dbo].[M_ProductSubCategory]    Script Date: 03-06-2020 22:38:24 ******/
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
/****** Object:  Table [dbo].[M_ProductSubCategoryProperty]    Script Date: 03-06-2020 22:38:25 ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 03-06-2020 22:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [bigint] NOT NULL,
	[Reference] [bigint] NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Tax] [decimal](18, 2) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[ShippingAddress] [bigint] NOT NULL,
	[CustomerId] [bigint] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 03-06-2020 22:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SalesFee] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[ProductId] [bigint] NULL,
	[OrderId] [bigint] NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 03-06-2020 22:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [bigint] IDENTITY(100,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[SKU] [varchar](50) NOT NULL,
	[SalesFee] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ProductSubCategoryId] [bigint] NOT NULL,
	[SizeId] [bigint] NOT NULL,
	[SeasonId] [bigint] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 03-06-2020 22:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[Id] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[ProductSubCategoryPropertyId] [int] NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductLookDetails]    Script Date: 03-06-2020 22:38:26 ******/
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
/****** Object:  Table [dbo].[School]    Script Date: 03-06-2020 22:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[School](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[AddressId] [bigint] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_School] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Season]    Script Date: 03-06-2020 22:38:26 ******/
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
/****** Object:  Table [dbo].[Size]    Script Date: 03-06-2020 22:38:27 ******/
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
SET IDENTITY_INSERT [dbo].[M_ProductCategory] ON 

INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (1, N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2), N'This category is for School Uniforms', 1, N'School Uniforms', N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2))
INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (2, N'Admin', CAST(N'2018-04-01T17:12:00.0000000' AS DateTime2), N'This category is for Men', 1, N'Men', N'Admin', CAST(N'2018-04-01T17:13:00.0000000' AS DateTime2))
INSERT [dbo].[M_ProductCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductCategory], [UpdatedBy], [UpdatedOn]) VALUES (3, N'Admin', CAST(N'2018-04-01T17:13:00.0000000' AS DateTime2), N'This category is for Women', 1, N'Women', N'Admin', CAST(N'2018-04-01T17:14:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[M_ProductCategory] OFF
SET IDENTITY_INSERT [dbo].[M_ProductSubCategory] ON 

INSERT [dbo].[M_ProductSubCategory] ([Id], [CreatedBy], [CreatedOn], [Description], [IsActive], [ProductSubCategory], [UpdatedBy], [UpdatedOn], [ProductCategoryID]) VALUES (1, N'Admin', CAST(N'2018-04-01T17:15:00.0000000' AS DateTime2), N'This category is for DPS Summer T-Shirts', 1, N' DPS Summer T-Shirts', N'Admin', CAST(N'2018-04-01T17:15:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[M_ProductSubCategory] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Description], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [SKU], [SalesFee], [Quantity], [IsActive], [ProductSubCategoryId], [SizeId], [SeasonId]) VALUES (101, N'DPS Tshirt', N'White DPS Tshirt', CAST(N'2018-04-07T10:38:00.000' AS DateTime), N'Admin', CAST(N'2018-04-06T10:38:00.000' AS DateTime), N'Admin', N'WHITEDPS001', CAST(200 AS Decimal(18, 0)), 200, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
INSERT [dbo].[Season] ([Id], [Name], [Description], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (1, N'Summer', N'http://localhost:62181/Products/Create', CAST(N'2018-05-07T10:36:00.000' AS DateTime), N'Admin', CAST(N'2018-04-07T10:36:00.000' AS DateTime), N'Admin', 1)
INSERT [dbo].[Size] ([Id], [Name], [Description], [Length], [Breath], [Weight], [Number], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (1, N'32', N'Size 32', CAST(22 AS Decimal(18, 0)), CAST(22 AS Decimal(18, 0)), CAST(22 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), CAST(N'2018-04-07T10:34:00.000' AS DateTime), N'Admin', CAST(N'2018-08-07T10:34:00.000' AS DateTime), N'Admin', 1)
INSERT [dbo].[Size] ([Id], [Name], [Description], [Length], [Breath], [Weight], [Number], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [IsActive]) VALUES (2, N'34', N'Size 34', CAST(24 AS Decimal(18, 0)), CAST(24 AS Decimal(18, 0)), CAST(220 AS Decimal(18, 0)), CAST(11 AS Decimal(18, 0)), CAST(N'2018-04-07T10:35:00.000' AS DateTime), N'Admin', CAST(N'2018-04-07T10:35:00.000' AS DateTime), N'Admin', 1)
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Customer]
GO
ALTER TABLE [dbo].[CartItem]  WITH CHECK ADD  CONSTRAINT [FK_Cart_CartItem] FOREIGN KEY([CartId])
REFERENCES [dbo].[Cart] ([Id])
GO
ALTER TABLE [dbo].[CartItem] CHECK CONSTRAINT [FK_Cart_CartItem]
GO
ALTER TABLE [dbo].[CartItem]  WITH CHECK ADD  CONSTRAINT [FK_CartItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[CartItem] CHECK CONSTRAINT [FK_CartItem_Product]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Address_1] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Address_1]
GO
ALTER TABLE [dbo].[M_ProductSubCategory]  WITH CHECK ADD  CONSTRAINT [FK_M_ProductSubCategory_M_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[M_ProductCategory] ([Id])
GO
ALTER TABLE [dbo].[M_ProductSubCategory] CHECK CONSTRAINT [FK_M_ProductSubCategory_M_ProductCategory]
GO
ALTER TABLE [dbo].[M_ProductSubCategoryProperty]  WITH CHECK ADD  CONSTRAINT [FK_M_ProductSubCategoryProperty_M_ProductSubCategory] FOREIGN KEY([ProductSubCategoryID])
REFERENCES [dbo].[M_ProductSubCategory] ([Id])
GO
ALTER TABLE [dbo].[M_ProductSubCategoryProperty] CHECK CONSTRAINT [FK_M_ProductSubCategoryProperty_M_ProductSubCategory]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Address] FOREIGN KEY([ShippingAddress])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Address]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_OrderId]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Season] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Season]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Size] FOREIGN KEY([SizeId])
REFERENCES [dbo].[Size] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Size]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_SubCategory] FOREIGN KEY([ProductSubCategoryId])
REFERENCES [dbo].[M_ProductSubCategory] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_SubCategory]
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ProductDetails] CHECK CONSTRAINT [FK_ProductDetails_Product]
GO
ALTER TABLE [dbo].[ProductLookDetails]  WITH CHECK ADD  CONSTRAINT [FK_ProductLookDetails_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ProductLookDetails] CHECK CONSTRAINT [FK_ProductLookDetails_Product]
GO
ALTER TABLE [dbo].[School]  WITH CHECK ADD  CONSTRAINT [FK_School_Address_1] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[School] CHECK CONSTRAINT [FK_School_Address_1]
GO
