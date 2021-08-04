CREATE TABLE VehicleInfo(

AutoNo int IDENTITY(1,1),
--------------------------------------------
VID varchar(50) not null default(''),
VNo varchar(50) not null default(''),
Vtype varchar(50) not null default(''),
RegDate datetime null,
LicExpDate datetime null,
VIN varchar(50) not null default(''),
VPN varchar(50) not null default(''),
VRmk varchar(200) not null default(''),

--Driver and Helper Info
DrvEmpID varchar(50) not null default(''),
DRmk varchar(255) not null default(''),
HlprEmpID varchar(50) not null default(''),
HRmk varchar(50) not null default(''),
--------------------------------------------
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),
ComId varchar(20) not null default(''),

);