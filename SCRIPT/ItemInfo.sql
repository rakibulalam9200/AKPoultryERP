
CREATE TABLE ItemInfo(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

ItemCode varchar(50) not null default(''),
ItemName varchar(100) not null default(''),
ShortName varchar(100) not null default(''),
IGroup varchar(50) not null default(''),
IType varchar(100) not null default(''),
ISize varchar(100) not null default(''),
Unit varchar(20) not null default(''),
BagSize money not null default(0),
UnitPrice money not null default(0),
VendorID varchar(50) not null default(''),
StockMaintain int not null default(0),
Rmk varchar(255) not null default(''),
---
VName varchar(255) not null default(''),
TdAcct int not null default(0),
AvgPurchase int not null default(0),
TdTotal int not null default(0),
DRaw int not null default(0),
DBag int not null default(0),
PC varchar(200) not null default(''),
UN varchar(200) not null default(''),
ET datetime null default(''),

--Loaction Info
LocID varchar(20) not null default(''),
LocAutoNo int not null default(''),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),
)
