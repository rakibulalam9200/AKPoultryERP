CREATE TABLE ChallanMstr(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
CNo varchar(20) not null default(''),
CDate datetime null,
PartyCode varchar(50) not null default(''),
PartyAutoNo int not null default(''),

TotalAmt money not null default(0),
Discount money not null default(0),
Payable money not null default(0),
Paid money not null default(0),
rmk varchar(150) not null default(''),

--Vehicle Info
VID varchar(50) not null default(''),
VNo varchar(50) not null default(''),
VAutoNo int not null default(''),
VType varchar(50) not null default(''),
DriverName varchar(50) not null default(''),
VDM varchar(50) not null default(''),
--------------------------------------------
AcPost varchar(50) not null default(''),
AutoRmk varchar(50) not null default(''),
Cur varchar(50) not null default(''),
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);

