CREATE TABLE Commission(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
PartyCode varchar(50) not null default(''),
ItemCode varchar(50) not null default(''),
ItemAutoNo int not null default(''),
Perc money not null default(0),
Conv money not null default(0),
Transport money not null default(0),
BaseCom money not null default(0),
MonCom money not null default(0),
YearlyCom money not null default(0),
Rmk varchar(200) not null default(''),
--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

);