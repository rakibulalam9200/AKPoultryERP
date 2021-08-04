CREATE TABLE Sale(

[ComId] [varchar](20) NOT NULL default(''),
[AutoNo] [int] IDENTITY(1,1) NOT NULL,
[AutoNoFormMstrTbl] [int] NOT NULL default(''),
[SID] [varchar](50) NOT NULL default(''),
[PartyCode] [varchar](50) NOT NULL default(''),
[PartyAutoNo] [int] NOT NULL default(''),
[LocID] [varchar](20) NOT NULL default(''),
[LocAutoNo] [int] NOT NULL default(''),
[SlNo] [int] NOT NULL default(''),
[ItemCode] [varchar](50) NOT NULL default(''),
[ItemAutoNo] [int] NOT NULL default(0),
[Qty] [money] NOT NULL default(0),
[Unit] [money] NOT NULL default(0),
[Total] [money] NOT NULL default(0),
[UPrice] [money] NOT NULL default(0),
[Rmk] [varchar](250) NOT NULL default(''),
[ComName] [varchar](150) NOT NULL default(''),
[PcName] [varchar](50) NOT NULL default(''),
[UserCode] [varchar](50) NOT NULL default(''),
[EntryTime] [datetime] NOT NULL default(GETDATE()),
[UserIP] [varchar](100) NOT NULL default('')

);