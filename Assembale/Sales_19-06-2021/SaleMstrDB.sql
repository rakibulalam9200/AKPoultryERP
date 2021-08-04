USE [AKPOULTRY_ERP]
GO

/****** Object:  Table [dbo].[SaleMstr]    Script Date: 19/06/2021 11:39:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SaleMstr](
	[ComId] [varchar](20) NOT NULL,
	[AutoNo] [int] IDENTITY(1,1) NOT NULL,
	[SID] [varchar](50) NOT NULL,
	[SDate] [datetime] NULL,
	[PartyCode] [varchar](50) NOT NULL,
	[PartyAutoNo] [int] NOT NULL,
	[TotalAmt] [money] NOT NULL,
	[Discount] [money] NOT NULL,
	[Payable] [money] NOT NULL,
	[Paid] [money] NOT NULL,
	[rmk] [varchar](150) NOT NULL,
	[ISBN] [int] NULL,
	[ESBN] [int] NULL,
	[VID] [varchar](50) NOT NULL,
	[VNo] [varchar](50) NOT NULL,
	[VAutoNo] [int] NOT NULL,
	[VType] [varchar](50) NOT NULL,
	[DriverName] [varchar](50) NOT NULL,
	[VDM] [varchar](50) NOT NULL,
	[AcPost] [varchar](50) NOT NULL,
	[AutoRmk] [varchar](50) NOT NULL,
	[Cur] [varchar](50) NOT NULL,
	[ComName] [varchar](150) NOT NULL,
	[PcName] [varchar](50) NOT NULL,
	[UserCode] [varchar](50) NOT NULL,
	[EntryTime] [datetime] NOT NULL,
	[UserIP] [varchar](100) NOT NULL,
	[ISBAutoNo] [int] NOT NULL,
	[ESBAutoNo] [int] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [ComId]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [SID]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [PartyCode]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [PartyAutoNo]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [TotalAmt]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [Discount]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [Payable]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [Paid]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [rmk]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [ISBN]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [ESBN]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [VID]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [VNo]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [VAutoNo]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [VType]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [DriverName]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [VDM]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [AcPost]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [AutoRmk]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [Cur]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [ComName]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [PcName]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [UserCode]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT (getdate()) FOR [EntryTime]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ('') FOR [UserIP]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [ISBAutoNo]
GO

ALTER TABLE [dbo].[SaleMstr] ADD  DEFAULT ((0)) FOR [ESBAutoNo]
GO


