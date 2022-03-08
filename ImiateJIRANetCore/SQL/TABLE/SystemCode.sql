USE [ImitateJIRA]
GO

/****** Object:  Table [dbo].[SystemCode]    Script Date: 2022/3/5 ¤W¤È 10:59:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemCode]') AND type in (N'U'))
DROP TABLE [dbo].[SystemCode]
GO

/****** Object:  Table [dbo].[SystemCode]    Script Date: 2022/3/5 ¤W¤È 10:59:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SystemCode](
	[CodeType] [varchar](20) NOT NULL,
	[Systemcode] [varchar](20) NOT NULL,
	[CodeName] [nvarchar](100) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Content1] [nvarchar](100) NULL,
	[Content2] [nvarchar](100) NULL,
	[Content3] [nvarchar](100) NULL,
	[CreatedUser] [varchar](20) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdateUser] [varchar](20) NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_SystemCode] PRIMARY KEY CLUSTERED 
(
	[CodeType] ASC,
	[Systemcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


