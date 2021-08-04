CREATE TABLE EggTendering(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

TendID varchar(50) not null default(''),
TrendDate datetime null,
ItemCode varchar(50) not null default(''),
ItemAutoNo varchar(50) not null default(''),
BNo varchar(50) not null default(''),
BAutoNo varchar(50) not null default(''),
SNo varchar(50) not null default(''),
qty varchar(50) not null default(''),
TendPerc varchar(30) not null default(''),
rmk varchar(200) not null default(''),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);