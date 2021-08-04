CREATE TABLE CreditInfo(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
PartyCode varchar(50) not null default(''),
CreditLimit money not null default(0),
--------------------------------------------
SlNo varchar(50) not null default(''),
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);
