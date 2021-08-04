CREATE TABLE ResInfo(
	
AutoNo int IDENTITY(1,1),
--------------------------------------------

ResId varchar(50) not null default(''),
ResName varchar(150) not null default(''),
ResType varchar(50) not null default(''),
EmpId varchar(50) not null default(''),
ResPerson varchar(100) not null default(''),
Phone varchar(50) not null default(''),
Division varchar(50) not null default(''),
Zila varchar(50) not null default(''),
Upazila varchar(50) not null default(''),
Uneon varchar(50) not null default(''),

--------------------------------------------
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);