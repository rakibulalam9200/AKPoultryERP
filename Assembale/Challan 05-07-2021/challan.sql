USE [AKPOULTRY_ERP]
GO

/****** Object:  Table [dbo].[Challan]    Script Date: 05/07/2021 9:23:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Challan](
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[CNo] [varchar](20) NOT NULL,
	[LocID] [varchar](20) NOT NULL,
	[LocAutoNo] [int] NOT NULL,
	[SL] [int] NOT NULL,
	[ItemCode] [varchar](100) NOT NULL,
	[ItemAutoNo] [int] NOT NULL,
	[Qty] [money] NOT NULL,
	[UPrice] [money] NOT NULL,
	[Total] [money] NOT NULL,
	[rmk] [varchar](150) NOT NULL,
	[AutoNoFormMstrTbl] [int] NOT NULL,
	[ComName] [varchar](150) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserIP] [varchar](100) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [ComId]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [CNo]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [LocID]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [LocAutoNo]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [SL]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [ItemCode]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [ItemAutoNo]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ((0)) FOR [Qty]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ((0)) FOR [UPrice]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ((0)) FOR [Total]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [rmk]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [AutoNoFormMstrTbl]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [ComName]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [PcName]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [UserCode]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT (getdate()) FOR [EntryTime]
GO

ALTER TABLE [dbo].[Challan] ADD  DEFAULT ('') FOR [UserIP]
GO


