Create Table Company (

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

BranchCode varchar(150) not null default(''),
Prefix varchar(50) not null default(''),
ComName varchar(150) not null default(''),
ComAddress varchar(150) not null default(''),
ComPhone varchar(200) not null default(''),
email varchar(150) not null default(''),
RptHead varchar(150) not null default(''),

--------------------------------------------

PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);