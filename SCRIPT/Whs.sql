CREATE TABLE Whs(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------

WhsId varchar(150) not null default(''),
WhsName varchar(150) not null default(''),
Sl int not null default(''),
WhsAddress varchar(150) not null default(''),
Capacity varchar(150) not null default(''),
Rmk varchar(150) not null default(''),

--------------------------------------------

PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);