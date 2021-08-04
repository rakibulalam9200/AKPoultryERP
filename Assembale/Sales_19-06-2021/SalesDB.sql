USE [AKPOULTRY_ERP]
GO

/****** Object:  Table [dbo].[Sale]    Script Date: 19/06/2021 11:38:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sale](
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[AutoNoFormMstrTbl] [int] NOT NULL,
	[SID] [varchar](50) NOT NULL,
	[PartyCode] [varchar](50) NOT NULL,
	[PartyAutoNo] [int] NOT NULL,
	[LocID] [varchar](20) NOT NULL,
	[LocAutoNo] [int] NOT NULL,
	[SlNo] [int] NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[ItemAutoNo] [numeric](18, 0) NOT NULL,
	[Qty] [money] NOT NULL,
	[Unit] [money] NOT NULL,
	[Total] [money] NOT NULL,
	[UPrice] [money] NOT NULL,
	[Rmk] [varchar](250) NOT NULL,
	[ComName] [varchar](150) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserIP] [varchar](100) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [ComId]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [AutoNoFormMstrTbl]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [SID]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [PartyCode]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [PartyAutoNo]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [LocID]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [LocAutoNo]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [SlNo]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [ItemCode]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [ItemAutoNo]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [Qty]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [Unit]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [Total]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ((0)) FOR [UPrice]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [ComName]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [PcName]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [UserCode]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT (getdate()) FOR [EntryTime]
GO

ALTER TABLE [dbo].[Sale] ADD  DEFAULT ('') FOR [UserIP]
GO


