CREATE TABLE Designation(

AutoNo int IDENTITY(1,1),
--------------------------------------------

DID varchar(50) NOT NULL default(''),
Name varchar(100) NOT NULL default(''),
Bname varchar(100) NOT NULL default(''),
Rmk varchar(100) NOT NULL default(''),
SlNo varchar(50) not null default(''),

--------------------------------------------
ComId varchar(20) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

) 