USE [RGOnline]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 03-06-2020 22:36:51 ******/
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
