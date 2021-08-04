CREATE TABLE PartyInfo(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
PartyCode varchar(50) not null default(''),
PartyName varchar(100) not null default(''),
ProName varchar(100) not null default(''),
Address varchar(150) not null default(''),
ContactPerson varchar(150) not null default(''),
Class varchar(50) not null default(''),
Division varchar(50) not null default(''),
Zila varchar(50) not null default(''),
Upazila varchar(50) not null default(''),
Uneon varchar(50) not null default(''),
PGroup varchar(150) not null default(''),
Phone varchar(50) not null default(''),
Email varchar(50) not null default(''),
Region varchar(50) not null default(''),
Zone varchar(50) not null default(''),
Area varchar(50) not null default(''),
DeedNo varchar(50) not null default(''),
TradeLicence varchar(50) not null default(''),
NIDNo varchar(50) not null default(''),
ChequeAmt varchar(50) not null default(''),
SMS varchar(10) not null default(0),
SMSPhone varchar(50) not null default(''),
ResId varchar(150) not null default(''),
ResMob varchar(30) not null default(''),
SubResId varchar(150) not null default(''),
MainResID varchar(150) not null default(''),
HeadID varchar(50) not null default(''),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),


);