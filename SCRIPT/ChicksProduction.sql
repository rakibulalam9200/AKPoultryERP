CREATE TABLE ChicksProduction(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

PID varchar(50) not null default(''),
PDate datetime null,
LocID varchar(20) not null default(''),
ItemCode varchar(50) not null default(''),
ItemAutoNo varchar(50) not null default(''),
BNo varchar(50) not null default(''),
BAutoNo varchar(50) not null default(''),
SNo varchar(50) not null default(''),
MNo varchar(50) not null default(''),
qty money not null default(''),
weigt money not null default(''),
rmk varchar(200) not null default(''),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);