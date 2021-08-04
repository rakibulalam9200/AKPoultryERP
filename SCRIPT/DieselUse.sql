
Create table DieselUse
(

[ComId] [varchar](20) NOT NULL,
[AutoNo] [int] IDENTITY(1,1) NOT NULL,
SlNo int NOT NULL default(''),
TheDate datetime null,
ItemName varchar(100) not null,
ItemGroup varchar(100) not null,
qty int default 0,
GenOnTime datetime default null,
GenOffTime datetime default null,
rmk varchar(150)default '',

[ComName] [varchar](150) NOT NULL,
[PcName] [varchar](50) NOT NULL,
[UserCode] [varchar](50) NOT NULL,
[EntryTime] [datetime] not null default(GETDATE()),
[UserIP] [varchar](100) NOT NULL

)

