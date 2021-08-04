CREATE TABLE LoginUser(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

UserID varchar(50) not null default(''),
UserName varchar(50) not null default(''),
pwd varchar(50) not null default(''),
EmpId varchar(50) not null default(''),
DisplayName varchar(50) not null default(''),

--------------------------------------------

PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),


);



