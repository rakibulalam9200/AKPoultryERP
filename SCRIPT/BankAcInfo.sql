CREATE TABLE BankAcInfo(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
BankID varchar(20) not null default(''),
HeadID varchar(50) not null default(''),
AcName varchar(150) not null default(''),
AcNo varchar(150) not null default(''),
AcPerson varchar(150) not null default(''),
BankName varchar(150) not null default(''),
Branch varchar(100) not null default(''),
BCode varchar(50) not null default(''),
BRoutNo varchar(50) not null default(''),
BAddress varchar(200) not null default(''),
BPhone varchar(50) not null default(''),
BEmail varchar(50) not null default(''),
--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);