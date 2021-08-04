CREATE TABLE Challan(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
CNo varchar(20) not null default(''),

--Loaction Info
LocID varchar(20) not null default(''),
LocAutoNo int not null default(''),

SL int not null default(''),
ItemCode varchar(100) not null default(''),
ItemAutoNo int not null default(''),
Qty money not null default(0),
UPrice money not null default(0),
Total money not null default(0),
rmk varchar(150) not null default(''),

--------------------------------------------
AutoNoFormMstrTbl int not null default(''),
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);

