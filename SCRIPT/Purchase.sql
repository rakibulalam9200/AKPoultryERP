CREATE TABLE Purchase(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
AutoNoFormMstrTbl int not null default(''),
--------------------------------------------
PurchaseCode varchar(50) NOT NULL default(''),
PartyCode varchar(50) NOT NULL default(''),
PartyAutoNo int NOT NULL default(''),

--Loaction Info
LocID varchar(20) not null default(''),
LocAutoNo int not null default(''),

SlNo int NOT NULL default(''),
ItemCode varchar(50) not null default(''),
ItemAutoNo int not null default(''),
Qty money NOT NULL default(0),
UnitPrice money NOT NULL default(0),
TotalPrice money NOT NULL default(0),
Rmk varchar(250) NOT NULL default(0),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

) 