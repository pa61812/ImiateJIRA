USE [ImitateJIRA]
GO

/****** Object:  Table [dbo].[JiraOrder]    Script Date: 2022/3/5 ¤W¤È 10:59:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JiraOrder]') AND type in (N'U'))
DROP TABLE [dbo].[JiraOrder]
GO

/****** Object:  Table [dbo].[JiraOrder]    Script Date: 2022/3/5 ¤W¤È 10:59:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JiraOrder](
	[ID] int NOT NULL Identity(1,1),
	[JiraID] [varchar](20) NOT NULL,	
	[JiraTitle] [varchar](20) NOT NULL,
	[JiraStatus] [varchar](20) NOT NULL,
	[Jiradescription] [varchar](Max) NOT NULL,
	[CreatedUser] [varchar](20) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdateUser] [varchar](20) NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_JiraOrder] PRIMARY KEY CLUSTERED 
(
	[JiraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


