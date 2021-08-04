Create table BatchInfo(
	
ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

ChicksType varchar(100) not null default(''),
BatchId varchar(50) not null default(''),
TotalChks money not null default(0),
BType varchar(150) not null default(''),
BreedName varchar(150) not null default(''),
BLoc varchar(150) not null default(''),
rmk varchar(200) not null default(''),
Sl int not null default(''),

--------------------------------------------

PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);