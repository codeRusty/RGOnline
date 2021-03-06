USE [RGOnline]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 03-06-2020 22:36:54 ******/
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
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Address_1] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Address_1]
GO
